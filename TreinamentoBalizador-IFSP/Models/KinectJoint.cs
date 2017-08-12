using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Models
{
    class KinectJoint
    {
        private int moment;
        private String type;
        private Double x;
        private Double y;
        private Double z;

        public int Moment { get; set; }

        public String Type { get; set; }

        public Double X { get; set; }

        public Double Y { get; set; }

        public Double Z { get; set; }
    }
}
