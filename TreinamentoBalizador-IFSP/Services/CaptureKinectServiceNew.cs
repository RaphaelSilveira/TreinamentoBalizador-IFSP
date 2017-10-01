using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

using TreinamentoBalizador_IFSP.Models;
using System.Threading;

namespace TreinamentoBalizador_IFSP.Services
{
    class CaptureKinectServiceNew
    {
        private KinectSensor kinectSensor;
        private Skeleton[] skeleton = new Skeleton[6];
        private CaptureParameters captureParameters;
        private TemporalService temporalService;
        private Thread temporal;
        private List<KinectJoint> kinectJoints;
        private int moment;
        private int jointCount = 0;
        private Dictionary<string, List<KinectJoint>> jointsInMoment =
            new Dictionary<string, List<KinectJoint>>();

        public CaptureKinectServiceNew()
        {

            temporalService = new TemporalService(7000);
            temporal = new Thread(temporalService.Execute);

            moment = 1;
        }

        public void StartKinectSensor()
        {
            kinectSensor = KinectSensor.KinectSensors.Where(s => s.Status == KinectStatus.Connected).FirstOrDefault();

            if (kinectSensor != null)
            {
                Thread keepAlive = new Thread(KeepCapturing);
                // kinectSensor.SkeletonStream.Enable();
                // kinectSensor.Start();
                Console.WriteLine("startou kinect");
                if (kinectSensor.IsRunning)
                {
                    temporal.Start();
                    keepAlive.Start();
                }
            }

            // kinectSensor.AllFramesReady += Sensor_AllFramesReady;
        }

        private void KeepCapturing()
        {
            while (temporal.IsAlive);

            Console.WriteLine("thread rodando");

            if (kinectSensor != null)
            {
                kinectSensor.Stop();
                // Save();
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
                            foreach (Joint joint in body.Joints)
                            {
                                SkeletonPoint skeletonPoint = joint.Position;

                                KinectJoint kinectJoint = new KinectJoint();

                                if (captureParameters.GetSelectedJoints().Contains(joint.JointType.ToString()))
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
