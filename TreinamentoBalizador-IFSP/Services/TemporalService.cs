using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TreinamentoBalizador_IFSP.Services
{
    class TemporalService
    {
        private Double time;

        public TemporalService(Double time)
        {
            this.time = time;
        }

        public void Execute()
        {
            Thread.Sleep((int) time);
        }
    }
}
