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

            for (int i = first; i < last; i = i + 10)
            {
                List<KinectJoint> kinectJoints = jointsInMoment[i.ToString()];

                foreach(KinectJoint kinectJoint in kinectJoints)
                {
                    WriteLine(kinectJoint);
                }
            }

            SaveInFile(captureParameters.Movement, jointCount);

            MessageBox.Show("Movimentos capturados com sucesso!", "Fim da captura",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveInFile(String movement, int jointCount)
        {
            String filePath = saveHeaderService.Create(jointCount);

            Console.WriteLine(filePath);
            Console.WriteLine(movementLine);

            using (StreamWriter streamWriter = File.AppendText(filePath))
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
