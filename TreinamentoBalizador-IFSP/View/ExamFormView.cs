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
using TreinamentoBalizador_IFSP.Data;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class ExamFormView : Form, FormInterface
    {

        private ExamParameters examParameters;
        private List<ExamResult> examResults;
        private ExamService examService = new ExamService();
        private List<int> movementsIndexRandomList;
        private CaptureKinectServiceNew captureService;
        private FormatedCoordinatesModel formatedCoordinates;
        private CommunicationService communicationService = new CommunicationService();
        private Movements movementData = Movements.Instance;
        private List<ActiveMovement> activeMovements;
        private int movementCount = 0;
        private ActiveMovement currentMovement;


        public ExamFormView()
        {
            InitializeComponent();
            activeMovements = movementData.activeMovements;
            numUpDownMovementNumber.Maximum = activeMovements.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String error = ExamParametersValidation();

            numUpDownMovementNumber.Enabled = false;
            txtBoxStudentName.Enabled = false;

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
                    activeMovements.Count,
                    movementNumber
                );
                SetMovement();
            }
        }

        private void SetMovement()
        {
            currentMovement = activeMovements[movementsIndexRandomList[movementCount]];
            lblCurrentMovement.BeginInvoke(
                new Action(() => { lblCurrentMovement.Text = currentMovement.Name; })
            );
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
            captureService = new CaptureKinectServiceNew(this, currentMovement.Key, false);

            captureService.StartKinectSensor();
        }

        public void SetMovementLabel()
        {
            
        }

        public void BodyDetected()
        {
            btnInitCapture.Enabled = true;
            btnStartKinect.Enabled = false;
            lblSensorReady.Text = "Reconhecimento concluido";
        }

        public void FinishCapture()
        {
            bgdProgressStatus.ReportProgress(0);

            lblSensorReady.BeginInvoke(
                new Action(() => { lblSensorReady.Text = ""; })
            );

            btnStopCapture.BeginInvoke(
                new Action(() => { btnStopCapture.Enabled = false; })
            ); ;

            formatedCoordinates = captureService.formatedCoordinates;

            Console.WriteLine(formatedCoordinates.Movement.Length + "length");

            bool success = communicationService.CommunicateExam(formatedCoordinates);

            ExamResult result = new ExamResult(currentMovement.Name, success);

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
                btnStartKinect.BeginInvoke(
                    new Action(() => { btnStartKinect.Enabled = true; })
                );
                btnInitCapture.BeginInvoke(
                    new Action(() => { btnInitCapture.Enabled = false; })
                );
                lblSensorReady.BeginInvoke(
                    new Action(() => { lblSensorReady.Text = ""; })
                );
                SetMovement();
            }
            else
            {
                MessageBox.Show("Prova Finalizada!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FinishExam();
            }
        }

        private void FinishExam()
        {
            movementCount = 0;
            btnExamCancel.BeginInvoke(
                new Action(() => { btnExamCancel.Enabled = false; })
            );
            btnInitCapture.BeginInvoke(
                new Action(() => { btnInitCapture.Enabled = false; })
            );
            btnStartKinect.BeginInvoke(
                new Action(() => { btnStartKinect.Enabled = false; })
            );
            btnStopCapture.BeginInvoke(
                new Action(() => { btnStopCapture.Enabled = false; })
            );
            btnExamInit.BeginInvoke(
                new Action(() => { btnExamInit.Enabled = true; })
            );
            lblCurrentMovement.BeginInvoke(
                new Action(() => { lblCurrentMovement.Text = ""; })
            );
            lblSensorReady.BeginInvoke(
                new Action(() => { lblSensorReady.Text = ""; })
            );
            numUpDownMovementNumber.BeginInvoke(
                new Action(() => { numUpDownMovementNumber.Enabled = true; })
            );
            txtBoxStudentName.BeginInvoke(
                new Action(() => {
                    txtBoxStudentName.Enabled = true;
                    txtBoxStudentName.Text = "";
                })
            );
        }

        private void UpdateGrid()
        {
            btnStopCapture.BeginInvoke(
                new Action(() => { btnStopCapture.Enabled = false; })
            );
 
            dgvResults.BeginInvoke(
                new Action(() => {
                    dgvResults.Rows.Clear();
                })
            );

            foreach (ExamResult result in examResults) {
                dgvResults.BeginInvoke(
                    new Action(() => {
                        dgvResults.Rows.Add(
                            examParameters.StudentName,
                            examParameters.Date,
                            result.Movement,
                            ResultText(result.Result));
                    })
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

        private void bgdProgressStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 16; i++)
            {
                Thread.Sleep(500);
                bgdProgressStatus.ReportProgress((100 / 16) * i);
            }

            bgdProgressStatus.ReportProgress(100);
        }

        private void bgdProgressStatus_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbCapturing.Value = e.ProgressPercentage;
        }

        private void bgdProgressStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
