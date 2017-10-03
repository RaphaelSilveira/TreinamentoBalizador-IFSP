using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Communication;

namespace TreinamentoBalizador_IFSP.Services
{
    class FormatCoordinatesService
    {
        public Boolean Format(Dictionary<string, List<KinectJoint>> jointsInMoment, String movement)
        {
            FormatedCoordinatesModel formated = new FormatedCoordinatesModel();
            MovementServerCommunication communication = new MovementServerCommunication();

            List<String> movements = new List<string>();
            formated.Coordinates = movements;

            int first = int.Parse(jointsInMoment.First().Key);
            int last = int.Parse(jointsInMoment.Last().Key);

            formated.Movement = movement;

            for (int i = first, j = 0; i < last; i++)
            {
                List<KinectJoint> kinectJoints = jointsInMoment[i.ToString()];
                Console.WriteLine(jointsInMoment.Count);
                Console.WriteLine("format" + kinectJoints.Count());
                foreach (KinectJoint kinectJoint in kinectJoints)
                {

                    formated.Coordinates.Add(kinectJoint.X.ToString());
                    j++;
                    formated.Coordinates.Add(kinectJoint.Y.ToString());
                    j++;
                    formated.Coordinates.Add(kinectJoint.Z.ToString());
                    j++;
                }
                if (j == 210)
                {
                    break;
                }
            }


            return communication.VerifyMovement(formated);
        }
    }
}
