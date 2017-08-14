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

        private void ChooseFolder()
        {
            if (fbdFilePath.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fbdFilePath.SelectedPath);
                tbxPathFile.Text = fbdFilePath.SelectedPath;
                Console.WriteLine(captureParameters.FilePath);
            }
        }

        private void btnPathFile_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private String FormValidation()
        {  
            if (jointsCBxL.CheckedItems.Count == 0)
            {
                return "Selecione no mínimo um joint.";
            }
            if (mtbCaptureTime.Text.Replace(" ", string.Empty) == ":")
            {
                return "Insira um valor para Tempo de captura.";
            }
            if (tbxDelimitator.Text == "")
            {
                return "Insira um valor para Delimitador.";
            }
            if (tbxPathFile.Text == "")
            {
                return "Selecione um local para o arquivo.";
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
                DateTime duration = DateTime.ParseExact(mtbCaptureTime.Text, "mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                List<string> jointList = new List<string>();

                foreach (String item in jointsCBxL.CheckedItems)
                {
                    jointList.Add(item);
                }

                Double minutes = duration.Minute;
                Double seconds = duration.Second;
                Double totalMileseconds = ((minutes * 60) + seconds) * 1000;

                captureParameters.CaptureDuration = totalMileseconds;
                captureParameters.Delimitator = tbxDelimitator.Text;
                captureParameters.FilePath = tbxPathFile.Text;
                captureParameters.SetSelectedJoints(jointList);

                CaptureKinectService captureKinectService = new CaptureKinectService(captureParameters);
                captureKinectService.InitCapture();

            }
        }
    }
}
