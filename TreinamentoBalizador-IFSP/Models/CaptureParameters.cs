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
        private DateTime captureDuration;
        private String filePath;
        private String delimitator;

        public int FramesPerSecond { get; set; }
        public DateTime CaptureDuration { get; set; }
        public String FilePath { get; set; }
        public String Delimitator { get; set; }
    }
}
