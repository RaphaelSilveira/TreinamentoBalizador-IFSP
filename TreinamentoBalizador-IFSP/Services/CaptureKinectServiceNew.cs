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

        public void StartKinectSensor()
        {
            kinectSensor = KinectSensor.KinectSensors.Where(s => s.Status == KinectStatus.Connected).FirstOrDefault();

            if (kinectSensor != null)
            {
                kinectSensor.SkeletonStream.Enable();
                kinectSensor.Start();
                Console.WriteLine("startou kinect");
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
