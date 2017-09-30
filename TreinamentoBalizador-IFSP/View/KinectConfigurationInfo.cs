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
    public partial class KinectConfigurationInfo : Form
    {

        private String flow;
        private Form _objForm;

        private const String ADD_MOVEMENT = "addMovement";
        private const String TEST = "test";
        private const String TRAINIG = "training";

        public KinectConfigurationInfo(String flow)
        {
            InitializeComponent();
            this.flow = flow;
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            Form form;
            switch (flow)
            {
                case ADD_MOVEMENT:
                    form = new CaptureParametersView()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };
                    RenderForm(form);
                    break;
                case TEST:
                    form = new CaptureParametersView()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };
                    RenderForm(form);
                    break;
                case TRAINIG:
                    form = new TrainingFormView()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };
                    RenderForm(form);
                    break;
            }
        }

        public void RenderForm(Form form)
        {
            _objForm?.Close();

            _objForm = form;
            
            pnlKinectConfigInfo.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
