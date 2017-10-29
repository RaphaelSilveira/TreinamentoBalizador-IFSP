using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Communication;

namespace TreinamentoBalizador_IFSP.Data
{
    class Movements
    {
        private static Movements instance;
        private MovementConfigCommunication communication = new MovementConfigCommunication();
        public List<ActiveMovement> activeMovements;

        private Movements() {
            LoadMovements();
        }

        public static Movements Instance {
            get {
                if (instance == null)
                {
                    instance = new Movements();
                }
                return instance;
            }
        }

        private void LoadMovements()
        {
            activeMovements = communication.GetActiveMovementsList();
        }
    }
}
