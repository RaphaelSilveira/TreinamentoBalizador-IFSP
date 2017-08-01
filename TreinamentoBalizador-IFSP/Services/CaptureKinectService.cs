using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using TreinamentoBalizador_IFSP.Utils;
using System.Threading;
using TreinamentoBalizador_IFSP.Models;

namespace TreinamentoBalizador_IFSP.Services
{
    class CaptureKinectService
    {
        private KinectSensor kinectSensor;
        private Skeleton[] skeleton = new Skeleton[6];
        private CaptureParameters captureParameters;
        private TemporalService temporalService;
        private Thread temporal;

        /**
         * Construtor 
         */
        public CaptureKinectService(CaptureParameters captureParameters)
        {
            this.captureParameters = captureParameters;

            Double time = DateUtils.ConvertToUnixTimestamp(this.captureParameters.CaptureDuration);
            temporalService = new TemporalService(time);
            temporal = new Thread(temporalService.Execute);
        }

        /**
         * Inicia a captura de movimentos do kinect
         */
        public void InitCapture()
        {
            kinectSensor = KinectSensor.KinectSensors.Where(s => s.Status == KinectStatus.Connected).FirstOrDefault();

            if (kinectSensor != null)
            {
                Thread keepAlive = new Thread(KeepCapturing);

                kinectSensor.SkeletonStream.Enable();

                temporal.Start();
                keepAlive.Start();

                kinectSensor.AllFramesReady += Sensor_AllFramesReady;
            }

        }

        /**
         * Mantém a captura de movimentos ativa durante o tempo estipulado 
         */
        private void KeepCapturing()
        {
            while (temporal.IsAlive) ;

            if (kinectSensor != null)
            {
                kinectSensor.Stop();
            }
        }

        /**
         * Realiza a comunicação com o Kinect Sensor e faz a chamada 
         * para salvar os dados no arquivo
         */
        private void Sensor_AllFramesReady(object sender, AllFramesReadyEventArgs e)
        {
            using (var frame = e.OpenSkeletonFrame())
            {
                if (frame != null)
                {
                    frame.CopySkeletonDataTo(skeleton);

                    foreach (var body in skeleton)
                    {
                        if (body.TrackingState == SkeletonTrackingState.Tracked)
                        {
                            foreach (Joint joint in body.Joints)
                            {
                                SkeletonPoint skeletonPoint = joint.Position;
                                Save(skeletonPoint);
                            }
                        }
                    }
                }
            }
        }

        /**
         * Organiza as informações antes de elas serem efetivamente salvas
         */
        private void Save(SkeletonPoint skeletonPoint)
        {
            Coordinates coordinate = new Coordinates();
            SaveCoordinatesService saveCoordinatesService = new SaveCoordinatesService();

            coordinate.X = skeletonPoint.X;
            coordinate.Y = skeletonPoint.Y;
            coordinate.Z = skeletonPoint.Z;

            saveCoordinatesService.Save(
                captureParameters.FilePath + "coordinates.txt",
                captureParameters.Delimitator,
                coordinate
            );
        }
    }
}
