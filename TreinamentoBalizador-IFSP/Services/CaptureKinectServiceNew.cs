using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using System.Threading;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.Models;
using System.Media;

namespace TreinamentoBalizador_IFSP.Services
{
    class CaptureKinectServiceNew
    {
        private const String HAND_LEFT = "HandLeft";
        private const String HAND_RIGHT = "HandRight";
        private const String KINECT_NOT_AVAILABLE = "É necessário conectar o Kinect antes de iniciar";

        private KinectSensor kinectSensor;
        private Skeleton[] skeleton = new Skeleton[6];
        private FormatCoordinatesService formatService;
        private TemporalService temporalService;
        private Thread temporal;
        private List<KinectJoint> kinectJoints;
        private int moment;
        private int jointCount = 0;
        private bool saveCoordinates = false;
        private FormInterface form;
        private Thread keepAlive;
        private String movement;
        private bool trainingFile;
        public FormatedCoordinatesModel formatedCoordinates { get; set; }
        private Dictionary<string, List<KinectJoint>> jointsInMoment =
            new Dictionary<string, List<KinectJoint>>();




        public CaptureKinectServiceNew(FormInterface form, String movementKey, bool trainingFile)
        {
            this.form = form;

            this.trainingFile = trainingFile;
            
            movement = movementKey;
            moment = 1;
        }

        public void StartKinectSensor()
        {
            try
            {
                StartKineck();
            }
            catch (Exception e)
            {
                MessageBox.Show(KINECT_NOT_AVAILABLE, "Ops!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StartSaveCoordinates()
        {
            temporalService = new TemporalService(8000);
            temporal = new Thread(temporalService.Execute);
            keepAlive = new Thread(KeepCapturing);
 
            saveCoordinates = true;
            temporal.Start();
            keepAlive.Start();
            SystemSounds.Hand.Play();
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

        private void StartKineck()
        {
            kinectSensor = KinectSensor.KinectSensors.Where(s => s.Status == KinectStatus.Connected).FirstOrDefault();
            kinectSensor.SkeletonStream.Enable();
            kinectSensor.Start();
            kinectSensor.AllFramesReady += Sensor_AllFramesReady;
            form.SetMovementLabel();
        }

        private void KeepCapturing()
        {
            while (temporal.IsAlive);
            Console.WriteLine("passou no finish aqui deoi");
            Console.WriteLine(kinectSensor.IsRunning);
            if (kinectSensor != null)
            {
                SystemSounds.Hand.Play();

                StopSaveCoordinates();
                Console.WriteLine("passou no finish aqui antes fromat");
                formatService = new FormatCoordinatesService();
                formatedCoordinates = formatService.Format(jointsInMoment, movement);
                Console.WriteLine("passou no finish aqui depois fromat");
                form.FinishCapture();
                kinectSensor.Stop();
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
                            form.BodyDetected();
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
