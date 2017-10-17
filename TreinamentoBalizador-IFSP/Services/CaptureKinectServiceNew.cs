using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using System.Threading;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.View;
using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Communication;

namespace TreinamentoBalizador_IFSP.Services
{
    class CaptureKinectServiceNew
    {
        private const String HAND_LEFT = "HandLeft";
        private const String HAND_RIGHT = "HandRight";
        private const String SUCCESS_MOVEMENT = "Movimento executado com sucesso";
        private const String FAILED_MOVEMENT = "O movimento não foi executado corretamente";
        private const String SUCCESS_SAVED = "Movimento salvo com sucesso";
        private const String FAILED_SAVED = "Não foi possível salvar movimento";

        private KinectSensor kinectSensor;
        private Skeleton[] skeleton = new Skeleton[6];
        private FormatCoordinatesService formatService;
        MovementServerCommunication communication = new MovementServerCommunication();
        private TemporalService temporalService;
        private Thread temporal;
        private List<KinectJoint> kinectJoints;
        private int moment;
        private int jointCount = 0;
        private bool saveCoordinates = false;
        private TrainingFormView trainigForm;
        private Thread keepAlive;
        private String movement;
        private bool trainingFile;
        private Dictionary<string, List<KinectJoint>> jointsInMoment =
            new Dictionary<string, List<KinectJoint>>();

        public CaptureKinectServiceNew(TrainingFormView trainigForm, String movementKey, bool trainingFile)
        {
            this.trainigForm = trainigForm;
            this.trainingFile = trainingFile;

            StartKinectSensor();
            movement = movementKey;
            moment = 1;
        }

        public void StartKinectSensor()
        {
            kinectSensor = KinectSensor.KinectSensors.Where(s => s.Status == KinectStatus.Connected).FirstOrDefault();
            kinectSensor.SkeletonStream.Enable();
            kinectSensor.Start();
            kinectSensor.AllFramesReady += Sensor_AllFramesReady;
        }

        public void StartSaveCoordinates()
        {
            temporalService = new TemporalService(8000);
            temporal = new Thread(temporalService.Execute);
            keepAlive = new Thread(KeepCapturing);
 
            saveCoordinates = true;
            temporal.Start();
            keepAlive.Start();
        }

        public void StopSaveCoordinates()
        {
            temporal.Abort();
            saveCoordinates = false;
        }

        public void StopAll()
        {
            kinectSensor.Stop();
            temporal.Abort();
            StopSaveCoordinates();

        }

        private void KeepCapturing()
        {
            while (temporal.IsAlive);

            if (kinectSensor != null)
            {
                kinectSensor.Stop();
                formatService = new FormatCoordinatesService();
                StopSaveCoordinates();
                trainigForm.BodyUndetected();

                FormatedCoordinatesModel formatedCoordinates = formatService.Format(jointsInMoment, movement);

                Communicate(formatedCoordinates);
            }
        }

        private void Communicate(FormatedCoordinatesModel formatedCoordinates)
        {

            if (trainingFile)
            {
                bool saveSuccess =  communication.SaveMovement(formatedCoordinates);

                if (saveSuccess)
                {
                    MessageBox.Show(SUCCESS_SAVED, "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(FAILED_SAVED, "Ops!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool verifySuccess = communication.VerifyMovement(formatedCoordinates);

                if (verifySuccess)
                {
                    MessageBox.Show(SUCCESS_MOVEMENT, "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(FAILED_MOVEMENT, "Ops!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Sensor_AllFramesReady(object sender, AllFramesReadyEventArgs e)
        {
            using (var frame = e.OpenSkeletonFrame())
            {
                if (frame != null)
                {
                    frame.CopySkeletonDataTo(skeleton);
                    kinectJoints = new List<KinectJoint>();

                    foreach (var body in skeleton)
                    {
                        if (body.TrackingState == SkeletonTrackingState.Tracked)
                        {
                            trainigForm.BodyDetected();
                        }
                        if(body.TrackingState == SkeletonTrackingState.Tracked && saveCoordinates)
                        {
                            foreach (Joint joint in body.Joints)
                            {
                                SkeletonPoint skeletonPoint = joint.Position;

                                KinectJoint kinectJoint = new KinectJoint();

                                if (joint.JointType.ToString().Equals(HAND_LEFT) || joint.JointType.ToString().Equals(HAND_RIGHT))
                                {
                                    kinectJoint.Type = joint.JointType.ToString();
                                    kinectJoint.Moment = moment;
                                    kinectJoint.X = skeletonPoint.X;
                                    kinectJoint.Y = skeletonPoint.Y;
                                    kinectJoint.Z = skeletonPoint.Z;
                                    kinectJoints.Add(kinectJoint);
                                    jointCount++;
                                }
                            }
                            jointsInMoment.Add(moment.ToString(), kinectJoints);
                            moment++;
                        }
                    }
                }
            }
        }
    }
}
