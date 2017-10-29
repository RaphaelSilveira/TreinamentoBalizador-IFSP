using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBalizador_IFSP.Data;
using TreinamentoBalizador_IFSP.Models;

namespace TreinamentoBalizador_IFSP.Services
{
    class TestControlService
    {
        private Dictionary<String, String> movements = new Dictionary<string, string>();
        private List<MoveListTest> result;

        Random random;

        private int correct;
        private int wrong;
        private int index;

        private static readonly int QUESTIONS_IN_TEST = 10;

        public TestControlService()
        {
            Movements data = Movements.Instance;
            // movements = data.activeMovements;

            index = 0;

            correct = 0;
            wrong = 0;

            random = new Random();
            result = new List<MoveListTest>();
        }

        public int Correct { get => correct; set => correct = value; }

        public int Wrong { get => wrong; set => wrong = value; }
        internal List<MoveListTest> Result { get => result; }

        public void GenerateListMovement()
        {
            HashSet<int> generated = new HashSet<int>();

            int index = 0;

            foreach (KeyValuePair<String, String> top in this.movements)
            {
                int value = random.Next(0, QUESTIONS_IN_TEST);
                int count = 0;

                while (generated.Contains(value))
                {
                    value = random.Next(0, 9);
                }

                foreach (KeyValuePair<String, String> item in this.movements)
                {
                    if (value == count)
                    {
                        MoveListTest move = new MoveListTest();
                        
                        move.Key = item.Key;
                        move.Value = item.Value;
                        move.Correct = false;

                        Result.Add(move);
                        
                        count++;
                        index++;

                        generated.Add(value);
                    }
                }

                if (index == QUESTIONS_IN_TEST) break; 
            }
        }

        public MoveListTest getCurrentMovement()
        {
            return Result.ElementAt(index);
        }

        public Double HitPercentage()
        {
            Double result = 0d;

            try
            {
                 result = (correct / (correct + wrong)) * 100;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e);
            }


            return result;
        }

        public void AddCorrectMove()
        {
            this.correct++;
            Result.ElementAt(index).Correct = true;
            index++;
        }

        public void AddWrongMove()
        {
            this.wrong++;
            Result.ElementAt(index).Correct = false;
            index++;
        }
    }
}
