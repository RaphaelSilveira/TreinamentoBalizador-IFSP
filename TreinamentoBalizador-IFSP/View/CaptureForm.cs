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

using TreinamentoBalizador_IFSP.Services;
using TreinamentoBalizador_IFSP.Models;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class CaptureForm : Form
    {

        private String movement;
        private bool trainingFile;
        CaptureKinectServiceNew captureService;

        public CaptureForm()
        {
            InitializeComponent();
        }

        public CaptureForm(string movementText, string movementKey, bool trainingFile)
        {
            InitializeComponent();
            this.trainingFile = trainingFile;
            // captureService = new CaptureKinectServiceNew(this, movementKey, this.trainingFile);

            this.Text = movementText;
            lblMovementName.Text = movementText;
            this.movement = movementKey;

            captureService.StartKinectSensor();
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            //desabilita os botões enquanto a tarefa é executada
            btnStartCapture.Enabled = false;
            btnStopCapture.Enabled = true;

            //define o stilo padrao do progressbar
            pbCapturing.Style = ProgressBarStyle.Blocks;
            pbCapturing.Value = 0;

            captureService.StartSaveCoordinates();
        }

        public void BodyUndetected()
        {

        }

        public void BodyDetected()
        {
            btnStartCapture.Enabled = true;
            lblSensorReady.Text = "Reconhecimento concluido";
        }

        private void TarefaLonga(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                // faz a thread dormir por "p" milissegundos a cada passagem do loop
                Thread.Sleep(p);
            }
        }

        private void bwCapturing_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 7; i++)//representa uma tarefa com 100 processos.
            {
                //Executa o método longo 100 vezes.
                //TarefaLonga(20);
                //incrementa o progresso do backgroundWorker 
                //a cada passagem do loop.
                this.bwCapturing.ReportProgress(i);

                //Verifica se houve uma requisição para cancelar a operação.
                if (bwCapturing.CancellationPending)
                {
                    //se sim, define a propriedade Cancel para true
                    //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                    e.Cancel = true;

                    //zera o percentual de progresso do backgroundWorker1.
                    bwCapturing.ReportProgress(0);
                    return;
                }
            }
            //Finalmente, caso tudo esteja ok, finaliza
            //o progresso em 100%.
            bwCapturing.ReportProgress(100);
        }

        private void bwCapturing_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.
            pbCapturing.Value = e.ProgressPercentage;
            
        }

        private void bwCapturing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //caso a operação seja cancelada, informa ao usuario.
                //label2.Text = "Operação Cancelada pelo Usuário!";

                //habilita o Botao cancelar
                // btnCancelar.Enabled = true;
                //limpa a label
                //label1.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                //label2.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                //label2.Text = "Tarefa Concluida com sucesso!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            captureService.StopSaveCoordinates();
            btnStopCapture.Enabled = false;

            //Cancelamento da tarefa com fim determinado [backgroundWorker1]
            if (bwCapturing.IsBusy)//se o backgroundWorker1 estiver ocupado
            {
                // notifica a thread que o cancelamento foi solicitado.
                // Cancela a tarefa DoWork 
                bwCapturing.CancelAsync();
            }
            //desabilita o botão cancelar.
            // label1.Text = "Cancelando...";
        }

        public void TrainingFile()
        {
            trainingFile = !trainingFile;
            Console.WriteLine(trainingFile);
        }

        private void CaptureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            captureService.StopAll();
        }
    }
}
