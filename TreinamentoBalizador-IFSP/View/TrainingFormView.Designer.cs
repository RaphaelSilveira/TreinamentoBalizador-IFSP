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
            this.gbxCapture = new System.Windows.Forms.GroupBox();
            this.lblMovement = new System.Windows.Forms.Label();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.lblSensorReady = new System.Windows.Forms.Label();
            this.pbCapturing = new System.Windows.Forms.ProgressBar();
            this.gbxSelectMovement = new System.Windows.Forms.GroupBox();
            this.wmpMovement = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxSelectMovement = new System.Windows.Forms.ComboBox();
            this.btnTrainingMove = new System.Windows.Forms.Button();
            this.bgdProgressStatus = new System.ComponentModel.BackgroundWorker();
            this.pnlMovementsList.SuspendLayout();
            this.gbxCapture.SuspendLayout();
            this.gbxSelectMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMovementsList
            // 
            this.pnlMovementsList.Controls.Add(this.gbxCapture);
            this.pnlMovementsList.Controls.Add(this.gbxSelectMovement);
            this.pnlMovementsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMovementsList.Location = new System.Drawing.Point(0, 0);
            this.pnlMovementsList.Name = "pnlMovementsList";
            this.pnlMovementsList.Size = new System.Drawing.Size(1159, 741);
            this.pnlMovementsList.TabIndex = 0;
            // 
            // gbxCapture
            // 
            this.gbxCapture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCapture.Controls.Add(this.lblMovement);
            this.gbxCapture.Controls.Add(this.btnStopCapture);
            this.gbxCapture.Controls.Add(this.btnStartCapture);
            this.gbxCapture.Controls.Add(this.lblSensorReady);
            this.gbxCapture.Controls.Add(this.pbCapturing);
            this.gbxCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCapture.Location = new System.Drawing.Point(12, 509);
            this.gbxCapture.Name = "gbxCapture";
            this.gbxCapture.Size = new System.Drawing.Size(1135, 126);
            this.gbxCapture.TabIndex = 7;
            this.gbxCapture.TabStop = false;
            this.gbxCapture.Text = "Leitura";
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Location = new System.Drawing.Point(176, 51);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(0, 18);
            this.lblMovement.TabIndex = 6;
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStopCapture.Enabled = false;
            this.btnStopCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopCapture.Location = new System.Drawing.Point(6, 59);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(130, 30);
            this.btnStopCapture.TabIndex = 5;
            this.btnStopCapture.Text = "Para leitura";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            this.btnStopCapture.Click += new System.EventHandler(this.btnStopCapture_Click);
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStartCapture.Enabled = false;
            this.btnStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCapture.Location = new System.Drawing.Point(6, 23);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(130, 30);
            this.btnStartCapture.TabIndex = 2;
            this.btnStartCapture.Text = "Iniciar leitura";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // lblSensorReady
            // 
            this.lblSensorReady.AutoSize = true;
            this.lblSensorReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSensorReady.Location = new System.Drawing.Point(176, 101);
            this.lblSensorReady.Name = "lblSensorReady";
            this.lblSensorReady.Size = new System.Drawing.Size(0, 18);
            this.lblSensorReady.TabIndex = 3;
            // 
            // pbCapturing
            // 
            this.pbCapturing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCapturing.Location = new System.Drawing.Point(6, 95);
            this.pbCapturing.Name = "pbCapturing";
            this.pbCapturing.Size = new System.Drawing.Size(1123, 23);
            this.pbCapturing.TabIndex = 4;
            // 
            // gbxSelectMovement
            // 
            this.gbxSelectMovement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSelectMovement.Controls.Add(this.btnTrainingMove);
            this.gbxSelectMovement.Controls.Add(this.wmpMovement);
            this.gbxSelectMovement.Controls.Add(this.lblSelect);
            this.gbxSelectMovement.Controls.Add(this.cbxSelectMovement);
            this.gbxSelectMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelectMovement.Location = new System.Drawing.Point(12, 12);
            this.gbxSelectMovement.Name = "gbxSelectMovement";
            this.gbxSelectMovement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxSelectMovement.Size = new System.Drawing.Size(1135, 491);
            this.gbxSelectMovement.TabIndex = 0;
            this.gbxSelectMovement.TabStop = false;
            this.gbxSelectMovement.Text = "Selecionar movimento";
            // 
            // wmpMovement
            // 
            this.wmpMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.wmpMovement.Enabled = true;
            this.wmpMovement.Location = new System.Drawing.Point(320, 59);
            this.wmpMovement.Name = "wmpMovement";
            this.wmpMovement.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMovement.OcxState")));
            this.wmpMovement.Size = new System.Drawing.Size(502, 390);
            this.wmpMovement.TabIndex = 2;
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(317, 32);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(74, 16);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Movimento";
            // 
            // cbxSelectMovement
            // 
            this.cbxSelectMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbxSelectMovement.FormattingEnabled = true;
            this.cbxSelectMovement.Location = new System.Drawing.Point(397, 29);
            this.cbxSelectMovement.Name = "cbxSelectMovement";
            this.cbxSelectMovement.Size = new System.Drawing.Size(425, 24);
            this.cbxSelectMovement.TabIndex = 0;
            this.cbxSelectMovement.SelectedIndexChanged += new System.EventHandler(this.cbxSelectMovement_SelectedIndexChanged);
            // 
            // btnTrainingMove
            // 
            this.btnTrainingMove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTrainingMove.Location = new System.Drawing.Point(489, 455);
            this.btnTrainingMove.Name = "btnTrainingMove";
            this.btnTrainingMove.Size = new System.Drawing.Size(145, 30);
            this.btnTrainingMove.TabIndex = 3;
            this.btnTrainingMove.Text = "Treinar movimento";
            this.btnTrainingMove.UseVisualStyleBackColor = true;
            this.btnTrainingMove.Click += new System.EventHandler(this.btnTrainingMove_Click);
            // 
            // TrainingFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 741);
            this.Controls.Add(this.pnlMovementsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TrainingFormView";
            this.Text = "Lista de sinais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMovementsList.ResumeLayout(false);
            this.gbxCapture.ResumeLayout(false);
            this.gbxCapture.PerformLayout();
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
        protected System.Windows.Forms.GroupBox gbxCapture;
        private System.Windows.Forms.Button btnStopCapture;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.Label lblSensorReady;
        private System.Windows.Forms.ProgressBar pbCapturing;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.Button btnTrainingMove;
        private System.ComponentModel.BackgroundWorker bgdProgressStatus;
    }
}