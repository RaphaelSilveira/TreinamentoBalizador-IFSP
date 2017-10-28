using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Services;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class ExamFormView : AbstractFormService
    {

        private ExamParameters examParameters;
        private List<ExamResult> examResults;
        private Dictionary<int, string> dbMovements = new Dictionary<int, string>();
        private ExamService examService = new ExamService();
        private List<int> movementsIndexRandomList;
        private CaptureKinectServiceNew captureService;
        private String currentMovement;


        public ExamFormView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String error = ExamParametersValidation();

            if (error != "")
            {
                MessageBox.Show(error, "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int movementNumber = Convert.ToInt32(numUpDownMovementNumber.Value);
                examParameters = new ExamParameters(
                    txtBoxStudentName.Text,
                    movementNumber,
                    DateTime.Now.ToString("dd/MM/yyyy hh:mm ")
                );

                examResults = new List<ExamResult>();
                btnExamCancel.Enabled = true;
                btnStartKinect.Enabled = true;

                movementsIndexRandomList = examService.RandomMovementListGenerate(
                    dbMovements.Count,
                    movementNumber
                );
            }
        }
        
        private String ExamParametersValidation()
        {
            String error = "";

            if (txtBoxStudentName.Text == "")
            {
                error = "Insira o nome do aluno";
            }
            else if (Convert.ToInt32(numUpDownMovementNumber.Value) <= 0)
            {
                error = "Insira a quantidade de movimentos";
            }

            return error;
        }

        private void btnInitCapture_Click(object sender, EventArgs e)
        {
            pbCapturing.Style = ProgressBarStyle.Blocks;
            pbCapturing.Value = 0;

            bgdProgressStatus.RunWorkerAsync();
        }
  
        private void btnStartKinect_Click(object sender, EventArgs e)
        {
            String currentMovementKey = "";
            captureService = new CaptureKinectServiceNew(this, currentMovementKey, false);

            captureService.StartKinectSensor();
        }

        private void bgdProgressStatus_DoWork_1(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 16; i++)
            {
                Thread.Sleep(500);
                bgdProgressStatus.ReportProgress((100 / 16) * i);
            }

            bgdProgressStatus.ReportProgress(100);
        }

        private void bgdProgressStatus_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            pbCapturing.Value = e.ProgressPercentage;
        }

        public override void SetMovementLabel()
        {
            lblMovement.Text = currentMovement;
        }

        public override void BodyDetected()
        {

        }

        public override void BodyUndetected()
        {

        }

    }
}
