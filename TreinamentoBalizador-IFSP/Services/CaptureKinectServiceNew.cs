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
        private KinectSensor kinectSensor;
        private Skeleton[] skeleton = new Skeleton[6];
        private CaptureParameters captureParameters;
        private TemporalService temporalService;
        private Thread temporal;
        private List<KinectJoint> kinectJoints;
        private int moment;
        private int jointCount = 0;
        private bool saveCoordinates = false;
        private CaptureForm captureForm;
        private Dictionary<string, List<KinectJoint>> jointsInMoment =
            new Dictionary<string, List<KinectJoint>>();

        public CaptureKinectServiceNew(CaptureForm captureForm)
        {
            this.captureForm = captureForm;
            temporalService = new TemporalService(7000);
            temporal = new Thread(temporalService.Execute);

            moment = 1;
        }

        public void StartKinectSensor()
        {
            // kinectSensor = KinectSensor.KinectSensors.Where(s => s.Status == KinectStatus.Connected).FirstOrDefault();

            //if (kinectSensor != null)
            if(true)
            {
                Thread keepAlive = new Thread(KeepCapturing);
                // kinectSensor.SkeletonStream.Enable();
                // kinectSensor.Start();
                Console.WriteLine("startou kinect");
                // if (kinectSensor.IsRunning)
                if(true)
                {
                    Console.WriteLine("startou thread");
                    temporal.Start();
                    keepAlive.Start();
                }
            }

            // kinectSensor.AllFramesReady += Sensor_AllFramesReady;
        }

        public void StartSaveCoordinates()
        {
            saveCoordinates = true;
        }

        public void StopSaveCoordinates()
        {
            saveCoordinates = false;
        }

        private void KeepCapturing()
        {
            while (temporal.IsAlive);

            Console.WriteLine("thread rodando");

            // if (kinectSensor != null)
            if(true)
            {
                Console.WriteLine("thread parou");
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
                            captureForm.KinectReady();
                        }
                        if(saveCoordinates)
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
