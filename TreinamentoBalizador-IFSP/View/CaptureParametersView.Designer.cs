namespace TreinamentoBalizador_IFSP
{
    partial class CaptureParametersView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureParametersView));
            this.gbxParameterCapture = new System.Windows.Forms.GroupBox();
            this.jointsCBxL = new System.Windows.Forms.CheckedListBox();
            this.tbxPathFile = new System.Windows.Forms.TextBox();
            this.btnPathFile = new System.Windows.Forms.Button();
            this.tbxDelimitator = new System.Windows.Forms.TextBox();
            this.mtbCaptureTime = new System.Windows.Forms.MaskedTextBox();
            this.lblMinutesSeconds = new System.Windows.Forms.Label();
            this.lblDelimitator = new System.Windows.Forms.Label();
            this.lblCaptureTime = new System.Windows.Forms.Label();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.fbdFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxParameterCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxParameterCapture
            // 
            this.gbxParameterCapture.Controls.Add(this.label1);
            this.gbxParameterCapture.Controls.Add(this.jointsCBxL);
            this.gbxParameterCapture.Controls.Add(this.tbxPathFile);
            this.gbxParameterCapture.Controls.Add(this.btnPathFile);
            this.gbxParameterCapture.Controls.Add(this.tbxDelimitator);
            this.gbxParameterCapture.Controls.Add(this.mtbCaptureTime);
            this.gbxParameterCapture.Controls.Add(this.lblMinutesSeconds);
            this.gbxParameterCapture.Controls.Add(this.lblDelimitator);
            this.gbxParameterCapture.Controls.Add(this.lblCaptureTime);
            this.gbxParameterCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParameterCapture.Location = new System.Drawing.Point(13, 9);
            this.gbxParameterCapture.Name = "gbxParameterCapture";
            this.gbxParameterCapture.Size = new System.Drawing.Size(747, 493);
            this.gbxParameterCapture.TabIndex = 0;
            this.gbxParameterCapture.TabStop = false;
            this.gbxParameterCapture.Text = "Parâmetros de captura";
            // 
            // jointsCBxL
            // 
            this.jointsCBxL.FormattingEnabled = true;
            this.jointsCBxL.Items.AddRange(new object[] {
            "HipCenter",
            "Spine",
            "ShoulderCenter",
            "Head",
            "ShoulderLeft",
            "ElbowLeft",
            "WristLeft",
            "HandLeft",
            "ShoulderRight",
            "ElbowRight",
            "WristRight",
            "HandRight",
            "HipLeft",
            "KneeLeft",
            "AnkleLeft",
            "FootLeft",
            "HipRight",
            "KneeRight",
            "AnkleRight",
            "FootRight"});
            this.jointsCBxL.Location = new System.Drawing.Point(27, 132);
            this.jointsCBxL.Name = "jointsCBxL";
            this.jointsCBxL.Size = new System.Drawing.Size(703, 298);
            this.jointsCBxL.TabIndex = 0;
            // 
            // tbxPathFile
            // 
            this.tbxPathFile.Location = new System.Drawing.Point(270, 458);
            this.tbxPathFile.Name = "tbxPathFile";
            this.tbxPathFile.Size = new System.Drawing.Size(460, 26);
            this.tbxPathFile.TabIndex = 9;
            // 
            // btnPathFile
            // 
            this.btnPathFile.Location = new System.Drawing.Point(27, 458);
            this.btnPathFile.Name = "btnPathFile";
            this.btnPathFile.Size = new System.Drawing.Size(221, 29);
            this.btnPathFile.TabIndex = 8;
            this.btnPathFile.Text = "Salvar arquivo onde";
            this.btnPathFile.UseVisualStyleBackColor = true;
            this.btnPathFile.Click += new System.EventHandler(this.btnPathFile_Click);
            // 
            // tbxDelimitator
            // 
            this.tbxDelimitator.Location = new System.Drawing.Point(186, 71);
            this.tbxDelimitator.Name = "tbxDelimitator";
            this.tbxDelimitator.Size = new System.Drawing.Size(64, 26);
            this.tbxDelimitator.TabIndex = 7;
            // 
            // mtbCaptureTime
            // 
            this.mtbCaptureTime.Location = new System.Drawing.Point(186, 34);
            this.mtbCaptureTime.Mask = "90:00";
            this.mtbCaptureTime.Name = "mtbCaptureTime";
            this.mtbCaptureTime.Size = new System.Drawing.Size(46, 26);
            this.mtbCaptureTime.TabIndex = 6;
            this.mtbCaptureTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblMinutesSeconds
            // 
            this.lblMinutesSeconds.AutoSize = true;
            this.lblMinutesSeconds.Location = new System.Drawing.Point(248, 37);
            this.lblMinutesSeconds.Name = "lblMinutesSeconds";
            this.lblMinutesSeconds.Size = new System.Drawing.Size(55, 20);
            this.lblMinutesSeconds.TabIndex = 4;
            this.lblMinutesSeconds.Text = "mm:ss";
            // 
            // lblDelimitator
            // 
            this.lblDelimitator.AutoSize = true;
            this.lblDelimitator.Location = new System.Drawing.Point(23, 77);
            this.lblDelimitator.Name = "lblDelimitator";
            this.lblDelimitator.Size = new System.Drawing.Size(89, 20);
            this.lblDelimitator.TabIndex = 3;
            this.lblDelimitator.Text = "Delimitador";
            // 
            // lblCaptureTime
            // 
            this.lblCaptureTime.AutoSize = true;
            this.lblCaptureTime.Location = new System.Drawing.Point(23, 40);
            this.lblCaptureTime.Name = "lblCaptureTime";
            this.lblCaptureTime.Size = new System.Drawing.Size(138, 20);
            this.lblCaptureTime.TabIndex = 2;
            this.lblCaptureTime.Text = "Tempo de captura";
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCapture.Location = new System.Drawing.Point(13, 521);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(747, 38);
            this.btnStartCapture.TabIndex = 1;
            this.btnStartCapture.Text = "Iniciar captura";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecionar joints";
            // 
            // CaptureParametersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 571);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.gbxParameterCapture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureParametersView";
            this.Text = "Captura de Parâmetros";
            this.Load += new System.EventHandler(this.CaptureParametersView_Load);
            this.gbxParameterCapture.ResumeLayout(false);
            this.gbxParameterCapture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxParameterCapture;
        private System.Windows.Forms.Label lblMinutesSeconds;
        private System.Windows.Forms.Label lblDelimitator;
        private System.Windows.Forms.Label lblCaptureTime;
        private System.Windows.Forms.TextBox tbxPathFile;
        private System.Windows.Forms.Button btnPathFile;
        private System.Windows.Forms.TextBox tbxDelimitator;
        private System.Windows.Forms.MaskedTextBox mtbCaptureTime;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.FolderBrowserDialog fbdFilePath;
        private System.Windows.Forms.CheckedListBox jointsCBxL;
        private System.Windows.Forms.Label label1;
    }
}

