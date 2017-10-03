using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Models
{
    class FormatedCoordinatesModel
    {
        private List<String> coordinates = new List<String>();
        private String movement;

        public String Movement { get; set; }

        public List<String> Coordinates { get; set; }
    }
}
