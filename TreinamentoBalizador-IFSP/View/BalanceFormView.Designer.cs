namespace TreinamentoBalizador_IFSP.View
{
    partial class BalanceFormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceFormView));
            this.gpbBalance = new System.Windows.Forms.GroupBox();
            this.dgvBalance = new System.Windows.Forms.DataGridView();
            this.gpbBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBalance
            // 
            this.gpbBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbBalance.Controls.Add(this.dgvBalance);
            this.gpbBalance.Location = new System.Drawing.Point(12, 12);
            this.gpbBalance.Name = "gpbBalance";
            this.gpbBalance.Size = new System.Drawing.Size(1037, 571);
            this.gpbBalance.TabIndex = 0;
            this.gpbBalance.TabStop = false;
            this.gpbBalance.Text = "Tabela de balanceamento";
            // 
            // dgvBalance
            // 
            this.dgvBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalance.Location = new System.Drawing.Point(6, 19);
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.Size = new System.Drawing.Size(1025, 546);
            this.dgvBalance.TabIndex = 0;
            // 
            // BalanceFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 595);
            this.Controls.Add(this.gpbBalance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BalanceFormView";
            this.Text = "Balanceamento de movimentos";
            this.Load += new System.EventHandler(this.BalanceFormView_Load);
            this.gpbBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBalance;
        private System.Windows.Forms.DataGridView dgvBalance;
    }
}