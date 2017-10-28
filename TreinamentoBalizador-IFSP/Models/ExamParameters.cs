using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Models
{
    class ExamParameters
    {
        public String StudentName { get; set; }
        public int MovementNumber { get; set; }
        public String Date { get; set; }

        public ExamParameters(String studentName, int movementNumber, String date) {
            this.StudentName = studentName;
            this.MovementNumber = movementNumber;
            this.Date = date;
        }
    }
}
