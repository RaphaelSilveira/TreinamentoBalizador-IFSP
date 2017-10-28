using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Services
{
    class ExamService
    {
        public List<int> RandomMovementListGenerate(int totalMovement, int examMovementNumber)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < totalMovement; i++)
            {
                int index = rnd.Next(1, totalMovement);

                if (list.Contains(index))
                {
                    index = rnd.Next(1, totalMovement);
                }
                else
                {
                    list.Add(index);
                }

                if (list.Count == examMovementNumber)
                {
                    break;
                }
            }

            foreach (int number in list)
            {
                Console.Write("Os números gerados foram: {0}", number);
            }
            return list;
        }
    }
}
