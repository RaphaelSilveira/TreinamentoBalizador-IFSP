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

using TreinamentoBalizador_IFSP.Data;
using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Services;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class TrainingFormView : Form
    {
        private Dictionary<String, String> movements = new Dictionary<string, string>();
        Movements movementData = Movements.Instance;
        private bool trainingFile;
        private String movementText = "Sinaleiro";
        private String movementKey;
        CaptureKinectServiceNew captureService;


        public TrainingFormView(bool trainingFile)
        {
            InitializeComponent();
            movements = movementData.movments;
            this.trainingFile = trainingFile;
            Console.WriteLine("Trainig file" + this.trainingFile);
            PopulateCombobox();

            this.trainingFile = trainingFile;
        }

        private void cbxSelectMovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            movementText = cbxSelectMovement.Text;
            movementKey = cbxSelectMovement.SelectedValue.ToString();

            Console.WriteLine("text" + movementText);
            Console.WriteLine("key" + movementKey);
            wmpMovement.URL = @"videos\\"+ cbxSelectMovement.SelectedValue + ".mp4";
            wmpMovement.Ctlcontrols.play();

        }

        private void PopulateCombobox()
        {

            var dataSource = new List<MovementItem>();            

            foreach (KeyValuePair<string, string> pair in movements)
            {
                dataSource.Add(new MovementItem() { Text = pair.Value.Replace(',', ' '), Key = pair.Key });
            }

            this.cbxSelectMovement.DataSource = dataSource;
            this.cbxSelectMovement.DisplayMember = "Text";
            this.cbxSelectMovement.ValueMember = "Key";
        }

        private void ReadFile()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"current_movement.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] lineSplited = line.Split(';');
                movements.Add(lineSplited[0], lineSplited[1]);
            }

            file.Close();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            captureService = new CaptureKinectServiceNew(this, movementKey, this.trainingFile);
            captureService.StartKinectSensor();
            lblMovement.Text = movementText;
        }



        public void BodyUndetected()
        {
            Console.WriteLine("body undet");
            btnStartCapture.Enabled = true;
            btnStopCapture.BeginInvoke(
                new Action(() => { Enabled = false; })
            );

            lblSensorReady.BeginInvoke(
                new Action(() => { Text = ""; })
            );
        }

        public void BodyDetected()
        {
            btnStartCapture.Enabled = true;
            lblSensorReady.Text = "Reconhecimento concluido";
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            pbCapturing.Style = ProgressBarStyle.Blocks;
            pbCapturing.Value = 0;

            bgdProgressStatus.RunWorkerAsync();

            btnStartCapture.Enabled = false;
            btnStopCapture.Enabled = true;

            captureService.StartSaveCoordinates();
        }

        private void btnStopCapture_Click(object sender, EventArgs e)
        {
            captureService.StopSaveCoordinates();
            btnStopCapture.Enabled = false;
        }

        private void btnTrainingMove_Click(object sender, EventArgs e)
        {
            captureService = new CaptureKinectServiceNew(this, movementKey, this.trainingFile);
            captureService.StartKinectSensor();
            lblMovement.Text = movementText;
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
