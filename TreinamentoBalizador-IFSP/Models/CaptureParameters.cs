using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Models
{
    class CaptureParameters
    {
        private int framesPerSecond;
        private Double captureDuration;
        private String filePath;
        private String delimitator;

        public int FramesPerSecond { get; set; }
        public Double CaptureDuration { get; set; }
        public String FilePath { get; set; }
        public String Delimitator { get; set; }
    }
}
