using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TreinamentoBalizador_IFSP.Models;

namespace TreinamentoBalizador_IFSP.Services
{
    class SaveCoordinatesService
    {
        public void Save(string path, String delimitator, Coordinates coordinate)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            String line = String.Concat(
                Convert.ToString(coordinate.X),
                delimitator,
                Convert.ToString(coordinate.Y),
                delimitator,
                Convert.ToString(coordinate.Z),
                delimitator
            );

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine(line);
            }
        }
    }
}
