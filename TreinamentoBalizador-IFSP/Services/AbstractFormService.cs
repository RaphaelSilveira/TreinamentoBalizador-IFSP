using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Services
{
    public abstract class AbstractFormService : System.Windows.Forms.Form
    {
        public abstract void SetMovementLabel();
        public abstract void BodyUndetected();
        public abstract void BodyDetected();
    }
}
