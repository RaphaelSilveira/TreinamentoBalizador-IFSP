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
    public partial class ExamFormView : Form, FormInterface
    {

        private ExamParameters examParameters;
        private List<ExamResult> examResults;
        private Dictionary<int, string> dbMovements = new Dictionary<int, string>();
        private ExamService examService = new ExamService();
        private List<int> movementsIndexRandomList;
        private CaptureKinectServiceNew captureService;
        private FormatedCoordinatesModel formatedCoordinates;
        private CommunicationService communicationService = new CommunicationService();
        private int movementCount = 0;
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
                btnExamInit.Enabled = false;

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

            captureService.StartSaveCoordinates();

            btnStopCapture.Enabled = false;
            btnStopCapture.Enabled = true;
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

        public void SetMovementLabel()
        {
            lblMovement.Text = currentMovement;
        }

        public void BodyDetected()
        {
            btnExamInit.Enabled = true;
            btnStartKinect.Enabled = false;
            lblSensorReady.Text = "Reconhecimento concluido";
        }

        public void FinishCapture()
        {
            bgdProgressStatus.ReportProgress(0);
            lblSensorReady.Text = "";
            btnStopCapture.Enabled = false;

            formatedCoordinates = captureService.formatedCoordinates;

            bool success = communicationService.CommunicateExam(formatedCoordinates);

            ExamResult result = new ExamResult(currentMovement, success);

            examResults.Add(result);
            UpdateGrid();
            movementCount++;

            HasNextMovement();
        }

        private void btnExamCancel_Click(object sender, EventArgs e)
        {
            FinishExam();
            dgvResults.Rows.Clear();
        }

        private void HasNextMovement()
        {
            if (movementCount < examParameters.MovementNumber)
            {
                btnStartKinect.Enabled = true;
                lblCurrentMovement.Text = currentMovement;
                lblSensorReady.Text = "";
            }
            else
            {
                MessageBox.Show("Prova Finalizada!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FinishExam();
                lblCurrentMovement.Text = "";
                lblSensorReady.Text = "";
                btnStartKinect.Enabled = true;
            }
        }

        private void FinishExam()
        {
            btnExamCancel.Enabled = false;
            btnInitCapture.Enabled = false;
            btnStartKinect.Enabled = false;
            btnStopCapture.Enabled = false;
            btnExamInit.Enabled = true;
        }

        private void UpdateGrid()
        {
            dgvResults.Rows.Clear();
            foreach (ExamResult result in examResults) {
                dgvResults.Rows.Add(
                    examParameters.StudentName,
                    examParameters.Date,
                    result.Movement,
                    ResultText(result.Result)
               );
            }
        }

        private String ResultText(bool result)
        {
            if (result)
            {
                return "Certo";
            }
            else
            {
                return "Errado";
            }
        }
    }
}
