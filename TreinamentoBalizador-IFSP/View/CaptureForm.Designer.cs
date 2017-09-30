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
            this.btnStartSensor = new System.Windows.Forms.Button();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.lnlSensorReady = new System.Windows.Forms.Label();
            this.pbCapturing = new System.Windows.Forms.ProgressBar();
            this.bwCapturing = new System.ComponentModel.BackgroundWorker();
            this.gbxSensor = new System.Windows.Forms.GroupBox();
            this.btnSensorOff = new System.Windows.Forms.Button();
            this.gbxCapture = new System.Windows.Forms.GroupBox();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.gbxSensor.SuspendLayout();
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
            // btnStartSensor
            // 
            this.btnStartSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSensor.Location = new System.Drawing.Point(6, 42);
            this.btnStartSensor.Name = "btnStartSensor";
            this.btnStartSensor.Size = new System.Drawing.Size(106, 27);
            this.btnStartSensor.TabIndex = 1;
            this.btnStartSensor.Text = "Ligar sensor";
            this.btnStartSensor.UseVisualStyleBackColor = true;
            this.btnStartSensor.Click += new System.EventHandler(this.btnStartSensor_Click);
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Enabled = false;
            this.btnStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCapture.Location = new System.Drawing.Point(6, 72);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(106, 27);
            this.btnStartCapture.TabIndex = 2;
            this.btnStartCapture.Text = "Iniciar leitura";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // lnlSensorReady
            // 
            this.lnlSensorReady.AutoSize = true;
            this.lnlSensorReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlSensorReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lnlSensorReady.Location = new System.Drawing.Point(17, 35);
            this.lnlSensorReady.Name = "lnlSensorReady";
            this.lnlSensorReady.Size = new System.Drawing.Size(0, 18);
            this.lnlSensorReady.TabIndex = 3;
            // 
            // pbCapturing
            // 
            this.pbCapturing.Location = new System.Drawing.Point(6, 122);
            this.pbCapturing.Name = "pbCapturing";
            this.pbCapturing.Size = new System.Drawing.Size(320, 23);
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
            // gbxSensor
            // 
            this.gbxSensor.Controls.Add(this.btnSensorOff);
            this.gbxSensor.Controls.Add(this.btnStartSensor);
            this.gbxSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSensor.Location = new System.Drawing.Point(28, 70);
            this.gbxSensor.Name = "gbxSensor";
            this.gbxSensor.Size = new System.Drawing.Size(332, 100);
            this.gbxSensor.TabIndex = 5;
            this.gbxSensor.TabStop = false;
            this.gbxSensor.Text = "Sensor";
            // 
            // btnSensorOff
            // 
            this.btnSensorOff.Enabled = false;
            this.btnSensorOff.Location = new System.Drawing.Point(207, 42);
            this.btnSensorOff.Name = "btnSensorOff";
            this.btnSensorOff.Size = new System.Drawing.Size(119, 27);
            this.btnSensorOff.TabIndex = 2;
            this.btnSensorOff.Text = "Desligar sensor";
            this.btnSensorOff.UseVisualStyleBackColor = true;
            // 
            // gbxCapture
            // 
            this.gbxCapture.Controls.Add(this.btnStopCapture);
            this.gbxCapture.Controls.Add(this.btnStartCapture);
            this.gbxCapture.Controls.Add(this.lnlSensorReady);
            this.gbxCapture.Controls.Add(this.pbCapturing);
            this.gbxCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCapture.Location = new System.Drawing.Point(28, 208);
            this.gbxCapture.Name = "gbxCapture";
            this.gbxCapture.Size = new System.Drawing.Size(332, 217);
            this.gbxCapture.TabIndex = 6;
            this.gbxCapture.TabStop = false;
            this.gbxCapture.Text = "Leitura";
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Enabled = false;
            this.btnStopCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopCapture.Location = new System.Drawing.Point(207, 72);
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
            this.Controls.Add(this.gbxSensor);
            this.Controls.Add(this.lblMovementName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureForm";
            this.Text = "Capturar movimentos";
            this.gbxSensor.ResumeLayout(false);
            this.gbxCapture.ResumeLayout(false);
            this.gbxCapture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovementName;
        private System.Windows.Forms.Button btnStartSensor;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.Label lnlSensorReady;
        private System.Windows.Forms.ProgressBar pbCapturing;
        private System.ComponentModel.BackgroundWorker bwCapturing;
        private System.Windows.Forms.GroupBox gbxSensor;
        private System.Windows.Forms.Button btnSensorOff;
        private System.Windows.Forms.GroupBox gbxCapture;
        private System.Windows.Forms.Button btnStopCapture;
    }
}