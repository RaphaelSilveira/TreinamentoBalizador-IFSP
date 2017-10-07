using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using System.Threading;

using TreinamentoBalizador_IFSP.View;
using TreinamentoBalizador_IFSP.Models;

namespace TreinamentoBalizador_IFSP.Services
{
    class CaptureKinectServiceNew
    {
        private const String HAND_LEFT = "HandLeft";
        private const String HAND_RIGHT = "HandRight";
        private KinectSensor kinectSensor;
        private Skeleton[] skeleton = new Skeleton[6];
        private FormatCoordinatesService captureService;
        private TemporalService temporalService;
        private Thread temporal;
        private List<KinectJoint> kinectJoints;
        private int moment;
        private int jointCount = 0;
        private bool saveCoordinates = false;
        private CaptureForm captureForm;
        private Thread keepAlive;
        private String movement;
        private Dictionary<string, List<KinectJoint>> jointsInMoment =
            new Dictionary<string, List<KinectJoint>>();

        public CaptureKinectServiceNew(CaptureForm captureForm, String movementKey)
        {
            this.captureForm = captureForm;

            temporalService = new TemporalService(8000);
            temporal = new Thread(temporalService.Execute);
            keepAlive = new Thread(KeepCapturing);

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
            saveCoordinates = true;
            temporal.Start();
            keepAlive.Start();
            Console.WriteLine("startou");
        }

        public void StopSaveCoordinates()
        {
            saveCoordinates = false;
        }

        private void KeepCapturing()
        {
            while (temporal.IsAlive);
            Console.WriteLine("temporal");

            if (kinectSensor != null)
            {
                Console.WriteLine("parou");
                kinectSensor.Stop();
                StopSaveCoordinates();
                captureService = new FormatCoordinatesService();

                captureService.Format(jointsInMoment, movement);
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
                            captureForm.BodyDetected();
                            Console.WriteLine("ready");
                        }
                        if(body.TrackingState == SkeletonTrackingState.Tracked && saveCoordinates)
                        {
                            foreach (Joint joint in body.Joints)
                            {
                                SkeletonPoint skeletonPoint = joint.Position;

                                KinectJoint kinectJoint = new KinectJoint();

                                if (joint.JointType.ToString().Equals(HAND_LEFT) || joint.JointType.ToString().Equals(HAND_RIGHT))
                                {
                                    Console.WriteLine(joint.JointType.ToString());
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
                else
                {
                    captureForm.BodyUnDetected();
                    Console.WriteLine("ready");
                }
            }
        }
    }
}
