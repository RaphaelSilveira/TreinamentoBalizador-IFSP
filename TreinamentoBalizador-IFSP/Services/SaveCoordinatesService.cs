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
        private String movementLine;
        private String path = System.AppDomain.CurrentDomain.BaseDirectory;

        public void Save(Dictionary<string, List<KinectJoint>> jointsInMoment,
            CaptureParameters captureParameters)
        {
            int first = int.Parse(jointsInMoment.First().Key);
            int last = int.Parse(jointsInMoment.Last().Key);

            for (int i = first; i < last; i = i + 4)
            {
                List<KinectJoint> kinectJoints = jointsInMoment[i.ToString()];

                foreach(KinectJoint kinectJoint in kinectJoints)
                {
                    WriteLine(kinectJoint);
                }
            }

            SaveInFile(captureParameters.Movement);

            MessageBox.Show("Movimentos capturados com sucesso!", "Fim da captura",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveInFile(String movement)
        {
            path = path + "coordinates\\coordinates.arff";

            Console.WriteLine("path" + path);
            Console.WriteLine(movementLine);

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                movementLine = movementLine + movement;
                streamWriter.Write(movementLine);
                streamWriter.Close();
            }
        }

        private void WriteLine(KinectJoint kinectJoint)
        {
            movementLine = movementLine + String.Concat(
                Convert.ToString(kinectJoint.X),
                ",",
                Convert.ToString(kinectJoint.Y),
                ",",
                Convert.ToString(kinectJoint.Z),
                ","
            );
        }
    }
}
