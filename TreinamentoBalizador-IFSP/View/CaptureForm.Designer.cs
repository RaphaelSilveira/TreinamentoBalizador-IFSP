namespace TreinamentoBalizador_IFSP.View
{
    partial class CaptureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.lblMovementName = new System.Windows.Forms.Label();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.lblSensorReady = new System.Windows.Forms.Label();
            this.pbCapturing = new System.Windows.Forms.ProgressBar();
            this.bwCapturing = new System.ComponentModel.BackgroundWorker();
            this.gbxCapture = new System.Windows.Forms.GroupBox();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.gbxCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovementName
            // 
            this.lblMovementName.AutoSize = true;
            this.lblMovementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovementName.Location = new System.Drawing.Point(25, 22);
            this.lblMovementName.Name = "lblMovementName";
            this.lblMovementName.Size = new System.Drawing.Size(0, 16);
            this.lblMovementName.TabIndex = 0;
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Enabled = false;
            this.btnStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCapture.Location = new System.Drawing.Point(6, 73);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(106, 27);
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
            this.lblSensorReady.Location = new System.Drawing.Point(17, 35);
            this.lblSensorReady.Name = "lblSensorReady";
            this.lblSensorReady.Size = new System.Drawing.Size(0, 18);
            this.lblSensorReady.TabIndex = 3;
            // 
            // pbCapturing
            // 
            this.pbCapturing.Location = new System.Drawing.Point(6, 122);
            this.pbCapturing.Name = "pbCapturing";
            this.pbCapturing.Size = new System.Drawing.Size(679, 23);
            this.pbCapturing.TabIndex = 4;
            // 
            // bwCapturing
            // 
            this.bwCapturing.WorkerReportsProgress = true;
            this.bwCapturing.WorkerSupportsCancellation = true;
            this.bwCapturing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCapturing_DoWork);
            this.bwCapturing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwCapturing_ProgressChanged);
            this.bwCapturing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCapturing_RunWorkerCompleted);
            // 
            // gbxCapture
            // 
            this.gbxCapture.Controls.Add(this.btnStopCapture);
            this.gbxCapture.Controls.Add(this.btnStartCapture);
            this.gbxCapture.Controls.Add(this.lblSensorReady);
            this.gbxCapture.Controls.Add(this.pbCapturing);
            this.gbxCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCapture.Location = new System.Drawing.Point(28, 22);
            this.gbxCapture.Name = "gbxCapture";
            this.gbxCapture.Size = new System.Drawing.Size(691, 217);
            this.gbxCapture.TabIndex = 6;
            this.gbxCapture.TabStop = false;
            this.gbxCapture.Text = "Leitura";
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Enabled = false;
            this.btnStopCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopCapture.Location = new System.Drawing.Point(566, 73);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(119, 27);
            this.btnStopCapture.TabIndex = 5;
            this.btnStopCapture.Text = "Para leitura";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            this.btnStopCapture.Click += new System.EventHandler(this.button1_Click);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 571);
            this.Controls.Add(this.gbxCapture);
            this.Controls.Add(this.lblMovementName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureForm";
            this.Text = "Capturar movimentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaptureForm_FormClosing);
            this.gbxCapture.ResumeLayout(false);
            this.gbxCapture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovementName;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.Label lblSensorReady;
        private System.Windows.Forms.ProgressBar pbCapturing;
        private System.ComponentModel.BackgroundWorker bwCapturing;
        private System.Windows.Forms.GroupBox gbxCapture;
        private System.Windows.Forms.Button btnStopCapture;
    }
}