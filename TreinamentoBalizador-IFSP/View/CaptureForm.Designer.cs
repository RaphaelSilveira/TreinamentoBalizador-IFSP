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
        private void InitializeComponent(string movement)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.pnlCapture = new System.Windows.Forms.Panel();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblReady = new System.Windows.Forms.Label();
            this.btnStartSensor = new System.Windows.Forms.Button();
            this.pnlCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCapture
            // 
            this.pnlCapture.Controls.Add(this.btnStartSensor);
            this.pnlCapture.Controls.Add(this.lblReady);
            this.pnlCapture.Controls.Add(this.btnInit);
            this.pnlCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCapture.Location = new System.Drawing.Point(0, 0);
            this.pnlCapture.Name = "pnlCapture";
            this.pnlCapture.Size = new System.Drawing.Size(777, 571);
            this.pnlCapture.TabIndex = 0;
            // 
            // btnInit
            // 
            this.btnInit.Enabled = false;
            this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.Location = new System.Drawing.Point(12, 140);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(128, 29);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Iniciar leitura";
            this.btnInit.UseVisualStyleBackColor = true;
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblReady.Location = new System.Drawing.Point(12, 103);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(0, 18);
            this.lblReady.TabIndex = 2;
            // 
            // btnStartSensor
            // 
            this.btnStartSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSensor.Location = new System.Drawing.Point(12, 26);
            this.btnStartSensor.Name = "btnStartSensor";
            this.btnStartSensor.Size = new System.Drawing.Size(128, 27);
            this.btnStartSensor.TabIndex = 3;
            this.btnStartSensor.Text = "Ligar sensor";
            this.btnStartSensor.UseVisualStyleBackColor = true;
            this.btnStartSensor.Click += new System.EventHandler(this.btnStartSensor_Click);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 571);
            this.Controls.Add(this.pnlCapture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureForm";
            this.Text = movement;
            this.pnlCapture.ResumeLayout(false);
            this.pnlCapture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCapture;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnStartSensor;
    }
}