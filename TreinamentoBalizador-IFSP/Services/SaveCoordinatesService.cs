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
        SaveHeaderService saveHeaderService = new SaveHeaderService();

        public void Save(Dictionary<string, List<KinectJoint>> jointsInMoment,
            CaptureParameters captureParameters, int jointCount)
        {
            int first = int.Parse(jointsInMoment.First().Key);
            int last = int.Parse(jointsInMoment.Last().Key);

            int count = 0;

            for (int i = first; i < last; i = i + 10)
            {
                List<KinectJoint> kinectJoints = jointsInMoment[i.ToString()];

                foreach(KinectJoint kinectJoint in kinectJoints)
                {
                    WriteLine(kinectJoint);
                }
                count++;

                if (count == 30) break;
            }

            SaveInFile(captureParameters.Movement, jointCount);

            MessageBox.Show("Movimentos capturados com sucesso!", "Fim da captura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveInFile(String movement, int jointCount)
        {
            String filePath = "coordinates-0.0.1.arff";
            
            using (StreamWriter streamWriter = File.AppendText(filePath))
            {
                movementLine = movementLine + movement;
                streamWriter.WriteLine(movementLine);
                streamWriter.Close();
            }
        }

        private void WriteLine(KinectJoint kinectJoint)
        {
            String x = Convert.ToString(kinectJoint.X).Replace(",", ".");
            String y = Convert.ToString(kinectJoint.Y).Replace(",", ".");
            String z = Convert.ToString(kinectJoint.Z).Replace(",", ".");

            movementLine = movementLine + String.Concat(
                x,
                ",",
                y,
                ",",
                z,
                ","
            );
        }
    }
}
