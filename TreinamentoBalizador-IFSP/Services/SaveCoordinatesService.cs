using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TreinamentoBalizador_IFSP.Models;
using System.Collections;
using Microsoft.Kinect;

namespace TreinamentoBalizador_IFSP.Services
{
    class SaveCoordinatesService
    {
        public void Save(List<KinectJoint> kinectJoints, CaptureParameters captureParameters)
        {
            Console.WriteLine("Frames per second: " + captureParameters.FramesPerSecond);
            Console.WriteLine("Joints: " + kinectJoints.Count);

            int index = 1;

            foreach(KinectJoint kinectJoint in kinectJoints)
            {
                if (captureParameters.FramesPerSecond < index)
                {
                    Console.WriteLine("Save in file called");
                    SaveInFile(kinectJoint, captureParameters); 
                }

                if (index == 30)
                {
                    index = 0;
                }
                
                index++;
            }
        }

        private void SaveInFile(KinectJoint kinectJoint, CaptureParameters captureParameters)
        {
            Console.WriteLine("Saving");
            String path = captureParameters.FilePath + "\\coordinates.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            String line = String.Concat(
                kinectJoint.Moment,
                captureParameters.Delimitator,
                kinectJoint.Position,
                captureParameters.Delimitator,
                Convert.ToString(kinectJoint.X),
                captureParameters.Delimitator,
                Convert.ToString(kinectJoint.X),
                captureParameters.Delimitator,
                Convert.ToString(kinectJoint.X)
            );

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine(line);
            }
        }
    }
}
