namespace TreinamentoBalizador_IFSP.View
{
    partial class TrainingFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingFormView));
            this.pnlMovementsList = new System.Windows.Forms.Panel();
            this.btnTraining = new System.Windows.Forms.Button();
            this.gbxSelectMovement = new System.Windows.Forms.GroupBox();
            this.wmpMovement = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxSelectMovement = new System.Windows.Forms.ComboBox();
            this.pnlMovementsList.SuspendLayout();
            this.gbxSelectMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMovementsList
            // 
            this.pnlMovementsList.Controls.Add(this.btnTraining);
            this.pnlMovementsList.Controls.Add(this.gbxSelectMovement);
            this.pnlMovementsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMovementsList.Location = new System.Drawing.Point(0, 0);
            this.pnlMovementsList.Name = "pnlMovementsList";
            this.pnlMovementsList.Size = new System.Drawing.Size(777, 571);
            this.pnlMovementsList.TabIndex = 0;
            // 
            // btnTraining
            // 
            this.btnTraining.Location = new System.Drawing.Point(627, 529);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(138, 30);
            this.btnTraining.TabIndex = 3;
            this.btnTraining.Text = "Treinar movimento";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // gbxSelectMovement
            // 
            this.gbxSelectMovement.Controls.Add(this.wmpMovement);
            this.gbxSelectMovement.Controls.Add(this.lblSelect);
            this.gbxSelectMovement.Controls.Add(this.cbxSelectMovement);
            this.gbxSelectMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelectMovement.Location = new System.Drawing.Point(12, 23);
            this.gbxSelectMovement.Name = "gbxSelectMovement";
            this.gbxSelectMovement.Size = new System.Drawing.Size(753, 476);
            this.gbxSelectMovement.TabIndex = 0;
            this.gbxSelectMovement.TabStop = false;
            this.gbxSelectMovement.Text = "Selecionar movimento";
            // 
            // wmpMovement
            // 
            this.wmpMovement.Enabled = true;
            this.wmpMovement.Location = new System.Drawing.Point(21, 75);
            this.wmpMovement.Name = "wmpMovement";
            this.wmpMovement.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMovement.OcxState")));
            this.wmpMovement.Size = new System.Drawing.Size(701, 324);
            this.wmpMovement.TabIndex = 2;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(22, 37);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(74, 16);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Movimento";
            // 
            // cbxSelectMovement
            // 
            this.cbxSelectMovement.FormattingEnabled = true;
            this.cbxSelectMovement.Location = new System.Drawing.Point(114, 34);
            this.cbxSelectMovement.Name = "cbxSelectMovement";
            this.cbxSelectMovement.Size = new System.Drawing.Size(608, 24);
            this.cbxSelectMovement.TabIndex = 0;
            this.cbxSelectMovement.SelectedIndexChanged += new System.EventHandler(this.cbxSelectMovement_SelectedIndexChanged);
            // 
            // TrainingFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 571);
            this.Controls.Add(this.pnlMovementsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainingFormView";
            this.Text = "Lista de sinais";
            this.pnlMovementsList.ResumeLayout(false);
            this.gbxSelectMovement.ResumeLayout(false);
            this.gbxSelectMovement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMovement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMovementsList;
        private System.Windows.Forms.GroupBox gbxSelectMovement;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbxSelectMovement;
        private AxWMPLib.AxWindowsMediaPlayer wmpMovement;
        private System.Windows.Forms.Button btnTraining;
    }
}