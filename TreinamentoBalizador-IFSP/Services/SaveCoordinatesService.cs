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
        public void Save(List<Skeleton> bodys, CaptureParameters captureParameters)
        {
            Console.WriteLine("Lenght of skeletons: " + bodys.Count);

            int index = 1;
            int moment = 1;

            foreach(var body in bodys)
            {
                Console.WriteLine("Capting body");
                if (captureParameters.FramesPerSecond < index)
                {
                    foreach (Joint joint in body.Joints)
                    {
                        SkeletonPoint skeletonPoint = joint.Position;
                        SaveInFile(joint, skeletonPoint, captureParameters, moment);

                        moment++;
                    }  
                }

                if (index == 30)
                {
                    index = 0;
                }
                
                index++;
            }
        }

        private void SaveInFile(Joint joint, SkeletonPoint skeleton, CaptureParameters parameters, int moment)
        {
            Console.WriteLine("Call saves");

            Console.WriteLine(Convert.ToString(skeleton.X));
            Console.WriteLine(Convert.ToString(skeleton.Y));
            Console.WriteLine(Convert.ToString(skeleton.Z));

            String path = parameters.FilePath + "coordinates.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            String line = String.Concat(
                moment,
                parameters.Delimitator,
                joint.JointType,
                parameters.Delimitator,
                joint.TrackingState,
                parameters.Delimitator,
                Convert.ToString(skeleton.X),
                parameters.Delimitator,
                Convert.ToString(skeleton.Y),
                parameters.Delimitator,
                Convert.ToString(skeleton.Z)
            );

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine(line);
            }
        }
    }
}
