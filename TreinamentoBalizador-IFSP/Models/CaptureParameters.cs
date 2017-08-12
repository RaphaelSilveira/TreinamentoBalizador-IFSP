using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Models
{
    class CaptureParameters
    {
        private List<string> selectedJoints;
        private Double captureDuration;
        private String filePath;
        private String delimitator;
        
        public Double CaptureDuration { get; set; }
        public String FilePath { get; set; }
        public String Delimitator { get; set; }

        public List<string> GetSelectedJoints() {
            return this.selectedJoints;
        }

        public void SetSelectedJoints(List<string> selectedJoints)
        {
            this.selectedJoints = selectedJoints;
        }

        public void AddJoint(String joint)
        {
            selectedJoints.Add(joint);
        }
    }
}
