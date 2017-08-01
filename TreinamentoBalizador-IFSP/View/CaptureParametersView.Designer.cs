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
            this.tbxPathFile = new System.Windows.Forms.TextBox();
            this.btnPathFile = new System.Windows.Forms.Button();
            this.tbxDelimitator = new System.Windows.Forms.TextBox();
            this.mtbCaptureTime = new System.Windows.Forms.MaskedTextBox();
            this.cbxFramesPerSecond = new System.Windows.Forms.ComboBox();
            this.lblMinutesSeconds = new System.Windows.Forms.Label();
            this.lblDelimitator = new System.Windows.Forms.Label();
            this.lblCaptureTime = new System.Windows.Forms.Label();
            this.lblFps = new System.Windows.Forms.Label();
            this.lblFramesPerSecond = new System.Windows.Forms.Label();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.fbdFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxParameterCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxParameterCapture
            // 
            this.gbxParameterCapture.Controls.Add(this.tbxPathFile);
            this.gbxParameterCapture.Controls.Add(this.btnPathFile);
            this.gbxParameterCapture.Controls.Add(this.tbxDelimitator);
            this.gbxParameterCapture.Controls.Add(this.mtbCaptureTime);
            this.gbxParameterCapture.Controls.Add(this.cbxFramesPerSecond);
            this.gbxParameterCapture.Controls.Add(this.lblMinutesSeconds);
            this.gbxParameterCapture.Controls.Add(this.lblDelimitator);
            this.gbxParameterCapture.Controls.Add(this.lblCaptureTime);
            this.gbxParameterCapture.Controls.Add(this.lblFps);
            this.gbxParameterCapture.Controls.Add(this.lblFramesPerSecond);
            this.gbxParameterCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParameterCapture.Location = new System.Drawing.Point(13, 9);
            this.gbxParameterCapture.Name = "gbxParameterCapture";
            this.gbxParameterCapture.Size = new System.Drawing.Size(747, 233);
            this.gbxParameterCapture.TabIndex = 0;
            this.gbxParameterCapture.TabStop = false;
            this.gbxParameterCapture.Text = "Parâmetros de captura";
            // 
            // tbxPathFile
            // 
            this.tbxPathFile.Location = new System.Drawing.Point(270, 188);
            this.tbxPathFile.Name = "tbxPathFile";
            this.tbxPathFile.Size = new System.Drawing.Size(460, 26);
            this.tbxPathFile.TabIndex = 9;
            // 
            // btnPathFile
            // 
            this.btnPathFile.Location = new System.Drawing.Point(25, 188);
            this.btnPathFile.Name = "btnPathFile";
            this.btnPathFile.Size = new System.Drawing.Size(221, 29);
            this.btnPathFile.TabIndex = 8;
            this.btnPathFile.Text = "Salvar arquivo onde";
            this.btnPathFile.UseVisualStyleBackColor = true;
            this.btnPathFile.Click += new System.EventHandler(this.btnPathFile_Click);
            // 
            // tbxDelimitator
            // 
            this.tbxDelimitator.Location = new System.Drawing.Point(200, 133);
            this.tbxDelimitator.Name = "tbxDelimitator";
            this.tbxDelimitator.Size = new System.Drawing.Size(64, 26);
            this.tbxDelimitator.TabIndex = 7;
            // 
            // mtbCaptureTime
            // 
            this.mtbCaptureTime.Location = new System.Drawing.Point(200, 87);
            this.mtbCaptureTime.Mask = "90:00";
            this.mtbCaptureTime.Name = "mtbCaptureTime";
            this.mtbCaptureTime.Size = new System.Drawing.Size(46, 26);
            this.mtbCaptureTime.TabIndex = 6;
            this.mtbCaptureTime.ValidatingType = typeof(System.DateTime);
            // 
            // cbxFramesPerSecond
            // 
            this.cbxFramesPerSecond.FormattingEnabled = true;
            this.cbxFramesPerSecond.ItemHeight = 20;
            this.cbxFramesPerSecond.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cbxFramesPerSecond.Location = new System.Drawing.Point(200, 37);
            this.cbxFramesPerSecond.MaxDropDownItems = 5;
            this.cbxFramesPerSecond.Name = "cbxFramesPerSecond";
            this.cbxFramesPerSecond.Size = new System.Drawing.Size(64, 28);
            this.cbxFramesPerSecond.TabIndex = 5;
            // 
            // lblMinutesSeconds
            // 
            this.lblMinutesSeconds.AutoSize = true;
            this.lblMinutesSeconds.Location = new System.Drawing.Point(286, 96);
            this.lblMinutesSeconds.Name = "lblMinutesSeconds";
            this.lblMinutesSeconds.Size = new System.Drawing.Size(55, 20);
            this.lblMinutesSeconds.TabIndex = 4;
            this.lblMinutesSeconds.Text = "mm:ss";
            // 
            // lblDelimitator
            // 
            this.lblDelimitator.AutoSize = true;
            this.lblDelimitator.Location = new System.Drawing.Point(23, 139);
            this.lblDelimitator.Name = "lblDelimitator";
            this.lblDelimitator.Size = new System.Drawing.Size(89, 20);
            this.lblDelimitator.TabIndex = 3;
            this.lblDelimitator.Text = "Delimitador";
            // 
            // lblCaptureTime
            // 
            this.lblCaptureTime.AutoSize = true;
            this.lblCaptureTime.Location = new System.Drawing.Point(23, 93);
            this.lblCaptureTime.Name = "lblCaptureTime";
            this.lblCaptureTime.Size = new System.Drawing.Size(138, 20);
            this.lblCaptureTime.TabIndex = 2;
            this.lblCaptureTime.Text = "Tempo de captura";
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(286, 45);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(31, 20);
            this.lblFps.TabIndex = 1;
            this.lblFps.Text = "fps";
            // 
            // lblFramesPerSecond
            // 
            this.lblFramesPerSecond.AutoSize = true;
            this.lblFramesPerSecond.Location = new System.Drawing.Point(23, 45);
            this.lblFramesPerSecond.Name = "lblFramesPerSecond";
            this.lblFramesPerSecond.Size = new System.Drawing.Size(156, 20);
            this.lblFramesPerSecond.TabIndex = 0;
            this.lblFramesPerSecond.Text = "Frames por segundo";
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCapture.Location = new System.Drawing.Point(13, 261);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(747, 38);
            this.btnStartCapture.TabIndex = 1;
            this.btnStartCapture.Text = "Iniciar captura";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // CaptureParametersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 387);
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
        private System.Windows.Forms.ComboBox cbxFramesPerSecond;
        private System.Windows.Forms.Label lblMinutesSeconds;
        private System.Windows.Forms.Label lblDelimitator;
        private System.Windows.Forms.Label lblCaptureTime;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.Label lblFramesPerSecond;
        private System.Windows.Forms.TextBox tbxPathFile;
        private System.Windows.Forms.Button btnPathFile;
        private System.Windows.Forms.TextBox tbxDelimitator;
        private System.Windows.Forms.MaskedTextBox mtbCaptureTime;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.FolderBrowserDialog fbdFilePath;
    }
}

