using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Models
{
    class ExamResult
    {

        public String Movement { get; set; }
        public Boolean Result { get; set; }

        public ExamResult(String movement, Boolean result) {
            this.Movement = movement;
            this.Result = result;
        }
    }
}
