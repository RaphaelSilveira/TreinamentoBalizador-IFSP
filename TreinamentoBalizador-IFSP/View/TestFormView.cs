using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinamentoBalizador_IFSP.Services;
using TreinamentoBalizador_IFSP.Models;
using System.Threading;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class TestFormView : Form
    {
        private TestControlService testControlService;
        private MoveListTest moveListTest;
        
        public TestFormView()
        {
            InitializeComponent();

            moveListTest = new MoveListTest();

            testControlService = new TestControlService();
            testControlService.GenerateListMovement();
        }

        private void TestFormView_Load(object sender, EventArgs e)
        {
            LoadInformations();
        }

        private void LoadInformations()
        {
            //moveListTest = testControlService.getCurrentMovement();

            //lblMoveToDoContent.Text = moveListTest.Value;
            //lblMoveCorrectContent.Text = testControlService.Correct.ToString();
            //lblMoveWrongContent.Text = testControlService.Wrong.ToString();
            //lblPercentageCorrectMoveContent.Text = testControlService.HitPercentage().ToString();
        }

        private void btnStartMove_Click(object sender, EventArgs e)
        {
            pgbMovement.Style = ProgressBarStyle.Blocks;
            pgbMovement.Value = 0;

            bgdProgressStatus.RunWorkerAsync();            
        }

        private void bgdProgressStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i <= 16; i++)
            {
                Thread.Sleep(500);
                bgdProgressStatus.ReportProgress((100 / 16) * i);
            }

            bgdProgressStatus.ReportProgress(100);
        }

        private void bgdProgressStatus_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbMovement.Value = e.ProgressPercentage;
        }

        private void bgdProgressStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
