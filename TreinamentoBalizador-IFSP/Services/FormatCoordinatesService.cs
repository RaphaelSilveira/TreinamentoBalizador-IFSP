using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Communication;

namespace TreinamentoBalizador_IFSP.Services
{
    class FormatCoordinatesService
    {
        private const String FAILED_MOVEMENT = "Movimento não detectado, tente novamente";

        public FormatedCoordinatesModel Format(Dictionary<string, List<KinectJoint>> jointsInMoment, String movement)
        {
            FormatedCoordinatesModel formated = new FormatedCoordinatesModel();

            List<String> movements = new List<string>();
            formated.Coordinates = movements;

            Console.WriteLine("Count on format" + jointsInMoment.Count);

            try
            {
                int first = int.Parse(jointsInMoment.First().Key);
                int last = int.Parse(jointsInMoment.Last().Key);

                formated.Movement = movement;

                for (int i = first, j = 0; i < last; i++)
                {
                    List<KinectJoint> kinectJoints = jointsInMoment[i.ToString()];
                    foreach (KinectJoint kinectJoint in kinectJoints)
                    {

                        formated.Coordinates.Add(kinectJoint.X.ToString());
                        formated.Coordinates.Add(kinectJoint.Y.ToString());
                        formated.Coordinates.Add(kinectJoint.Z.ToString());
                    }
                    j++;
                    if (j == 210)
                    {
                        break;
                    }
                }

                return formated;
            }
            catch (Exception e)
            {
                MessageBox.Show(FAILED_MOVEMENT, "Ops!",
                            System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
