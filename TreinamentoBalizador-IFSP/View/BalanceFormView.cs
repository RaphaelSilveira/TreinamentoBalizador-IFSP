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
    public partial class BalanceFormView : Form
    {
        public BalanceFormView()
        {
            InitializeComponent();
        }

        private void BalanceFormView_Load(object sender, EventArgs e)
        {
            Movements movements = Movements.Instance;

            var balance = movements.activeMovements.Select(movement => new
            {
                Movimento = movement.Name,
                Quatidade = movement.InsertsInArff
            }).ToList();
            
            dgvBalance.DataSource = balance;
            dgvBalance.Refresh();
        }
    }
}
