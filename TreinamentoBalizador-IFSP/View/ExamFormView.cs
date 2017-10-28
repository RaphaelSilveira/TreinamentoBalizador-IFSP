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

namespace TreinamentoBalizador_IFSP.View
{
    public partial class ExamFormView : Form
    {

        private ExamParameters examParameters;
        private List<ExamResult> examResults;
        private Dictionary<int, string> dbMovements = new Dictionary<int, string>();
        private ExamService examService = new ExamService();
        private List<int> movementsIndexRandomList;
        private CaptureKinectServiceNew captureService;

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
                    DateTime.Now.ToString("MM/dd/yyyy h:mm tt")
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
    }
}
