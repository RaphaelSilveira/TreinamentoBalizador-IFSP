using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class TrainingFormView : Form
    {
        private Dictionary<String, String> movments = new Dictionary<string, string>();
 
        public TrainingFormView()
        {
            InitializeComponent();
            PopulateCombobox();
        }

        private void cbxSelectMovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cbxSelectMovement.SelectedValue);
            wmpMovement.URL = @"videos\\sinaleiro.mp4";
            wmpMovement.Ctlcontrols.play();
        }

        private void PopulateCombobox()
        {
            ReadFile();
            foreach (KeyValuePair<string, string> pair in movments)
            {
                Console.WriteLine(pair.Value);
                cbxSelectMovement.Items.Add(Text = pair.Value.Replace(',', ' '));
            }
        }

        private void ReadFile()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"current_movement.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] lineSplited = line.Split(';');
                movments.Add(lineSplited[0], lineSplited[1]);
            }

            file.Close();
        }
    }
}
