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
            moveListTest = testControlService.getCurrentMovement();

            lblMoveToDoContent.Text = moveListTest.Value;
            lblMoveCorrectContent.Text = testControlService.Correct.ToString();
            lblMoveWrongContent.Text = testControlService.Wrong.ToString();
            lblPercentageCorrectMoveContent.Text = testControlService.HitPercentage().ToString();
        }

        private void btnStartMove_Click(object sender, EventArgs e)
        {

        }
    }
}
