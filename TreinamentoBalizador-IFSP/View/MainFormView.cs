using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.Data;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class MainFormView : Form
    {
        private Form _objForm;

        public MainFormView()
        {
            InitializeComponent();
            InicializeMovements();
        }

        private void InicializeMovements()
        {
            Movements movementData = Movements.Instance;
        }

        private void msOpenClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void msOpenCaptureParametersForm_Click(object sender, EventArgs e)
        {
            RenderForm("training");
        }

        private void msOpenGroundSignalsListForm_Click(object sender, EventArgs e)
        {
            RenderForm("addMovement");
        }

        private void msOpenTestForm_Click(object sender, EventArgs e)
        {
            RenderForm("test");
        }

        public void RenderForm(String flow)
        {
            _objForm?.Close();

            _objForm = new KinectConfigurationInfo(flow)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
