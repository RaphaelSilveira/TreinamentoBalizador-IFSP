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

            while (list.Count < examMovementNumber)
            {
                int index = rnd.Next(0, totalMovement);

                if (list.Contains(index))
                {
                    index = rnd.Next(0, totalMovement);
                }
                else
                {
                    list.Add(index);
                }
            }

            return list;
        }
    }
}
