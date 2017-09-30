using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.Data;
using TreinamentoBalizador_IFSP.Models;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class TrainingFormView : Form
    {
        private Dictionary<String, String> movements = new Dictionary<string, string>();
        Movements movementData = Movements.Instance;

 
        public TrainingFormView()
        {
            InitializeComponent();
            movements = movementData.movments;
            PopulateCombobox();
        }

        private void cbxSelectMovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cbxSelectMovement.SelectedValue);
            wmpMovement.URL = @"videos\\"+ cbxSelectMovement.SelectedValue + ".mp4";
            wmpMovement.Ctlcontrols.play();
        }

        private void PopulateCombobox()
        {

            var dataSource = new List<MovementItem>();
            
            //Setup data binding
            

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
            CaptureForm captureForm = new CaptureForm(cbxSelectMovement.Text, cbxSelectMovement.SelectedValue.ToString());
            captureForm.Show();
        }
    }
}
