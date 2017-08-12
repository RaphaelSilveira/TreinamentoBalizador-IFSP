using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TreinamentoBalizador_IFSP.Models;
using System.Collections;
using Microsoft.Kinect;
using System.Windows.Forms;

namespace TreinamentoBalizador_IFSP.Services
{
    class SaveCoordinatesService
    {
        public void Save(List<KinectJoint> kinectJoints, CaptureParameters captureParameters)
        {
            Console.WriteLine("Joints: " + kinectJoints.Count);

            int index = 1;

            List<KinectJoint> kinectJointsToSave;

            foreach (KinectJoint kinectJoint in kinectJoints)
            {
                Console.WriteLine("Save in file called");
                SaveInFile(kinectJoint, captureParameters);

                if (index == 30)
                {
                    index = 0;
                }
                
                index++;
            }


            MessageBox.Show("Movimentos capturados com sucesso!", "Fim da captura",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                kinectJoint.Type,
                captureParameters.Delimitator,
                Convert.ToString(kinectJoint.X),
                captureParameters.Delimitator,
                Convert.ToString(kinectJoint.Y),
                captureParameters.Delimitator,
                Convert.ToString(kinectJoint.Z)
            );

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine(line);
                streamWriter.Close();
            }
        }
    }
}
