using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Data
{
    class Movements
    {
        private static Movements instance;
        public Dictionary<String, String> movements = new Dictionary<string, string>();

        private Movements() {
            ReadFile();
        }

        public static Movements Instance {
            get {
                if (instance == null)
                {
                    instance = new Movements();
                }
                return instance;
            }
        }

        private void ReadFile()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"current_movement.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] lineSplited = line.Split(';');
                movments.Add(lineSplited[0], lineSplited[1]);
            }

            file.Close();
        }
    }
}
