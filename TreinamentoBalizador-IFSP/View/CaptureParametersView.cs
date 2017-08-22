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

namespace TreinamentoBalizador_IFSP
{
    public partial class CaptureParametersView : Form
    {

        CaptureParameters captureParameters = new CaptureParameters();

        public CaptureParametersView()
        {
            InitializeComponent();
        }

        private void CaptureParametersView_Load(object sender, EventArgs e)
        {

        }

        private String FormValidation()
        {  
            if (jointsCBxL.CheckedItems.Count == 0)
            {
                return "Selecione no mínimo um joint.";
            }
            //if (mtbCaptureTime.Text.Replace(" ", string.Empty) == ":")
            //{
            //    return "Insira um valor para Tempo de captura.";
            //}
            if (cbxMovement.Text == "")
            {
                return "Declare o nome do movimento";
            }

            return "";
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            String error = FormValidation();

            if (error != "")
            {
                MessageBox.Show(error, "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Console.WriteLine(jointsCBxL.SelectedItems.Count);
                // DateTime duration = DateTime.ParseExact(mtbCaptureTime.Text, "mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                List<string> jointList = new List<string>();

                foreach (String item in jointsCBxL.CheckedItems)
                {
                    jointList.Add(item);
                }

                // Double minutes = duration.Minute;
                // Double seconds = duration.Second;
                Double totalMileseconds = (12) * 1000;

                captureParameters.CaptureDuration = totalMileseconds;
                captureParameters.Movement = cbxMovement.Text;
                captureParameters.SetSelectedJoints(jointList);

                CaptureKinectService captureKinectService = new CaptureKinectService(captureParameters);
                captureKinectService.InitCapture();

            }
        }
    }
}
