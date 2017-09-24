using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class MovementList : Form
    {
 
        public MovementList()
        {
            InitializeComponent();
        }

        private void cbxSelectMovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmpMovement.URL = @"videos\\sinaleiro.mp4";
            wmpMovement.Ctlcontrols.play();
        }
    }
}
