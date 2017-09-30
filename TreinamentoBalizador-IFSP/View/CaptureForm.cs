using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Services;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class CaptureForm : Form
    {
        String movement;

        public CaptureForm(String movement)
        {
            InitializeComponent(movement);
            this.movement = movement;
        }

        private void btnStartSensor_Click(object sender, EventArgs e)
        {

        }
    }
}
