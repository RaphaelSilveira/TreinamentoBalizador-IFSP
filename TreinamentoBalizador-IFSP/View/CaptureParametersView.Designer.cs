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
            this.lblJoints = new System.Windows.Forms.Label();
            this.jointsCBxL = new System.Windows.Forms.CheckedListBox();
            this.mtbCaptureTime = new System.Windows.Forms.MaskedTextBox();
            this.lblMinutesSeconds = new System.Windows.Forms.Label();
            this.lblCaptureTime = new System.Windows.Forms.Label();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.fbdFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.lblMovements = new System.Windows.Forms.Label();
            this.cbxMovement = new System.Windows.Forms.ComboBox();
            this.gbxParameterCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxParameterCapture
            // 
            this.gbxParameterCapture.Controls.Add(this.cbxMovement);
            this.gbxParameterCapture.Controls.Add(this.lblMovements);
            this.gbxParameterCapture.Controls.Add(this.lblJoints);
            this.gbxParameterCapture.Controls.Add(this.jointsCBxL);
            this.gbxParameterCapture.Controls.Add(this.mtbCaptureTime);
            this.gbxParameterCapture.Controls.Add(this.lblMinutesSeconds);
            this.gbxParameterCapture.Controls.Add(this.lblCaptureTime);
            this.gbxParameterCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParameterCapture.Location = new System.Drawing.Point(13, 9);
            this.gbxParameterCapture.Name = "gbxParameterCapture";
            this.gbxParameterCapture.Size = new System.Drawing.Size(747, 493);
            this.gbxParameterCapture.TabIndex = 0;
            this.gbxParameterCapture.TabStop = false;
            this.gbxParameterCapture.Text = "Parâmetros de captura";
            // 
            // lblJoints
            // 
            this.lblJoints.AutoSize = true;
            this.lblJoints.Location = new System.Drawing.Point(24, 140);
            this.lblJoints.Name = "lblJoints";
            this.lblJoints.Size = new System.Drawing.Size(107, 16);
            this.lblJoints.TabIndex = 10;
            this.lblJoints.Text = "Selecionar joints";
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
            this.jointsCBxL.Location = new System.Drawing.Point(27, 159);
            this.jointsCBxL.Name = "jointsCBxL";
            this.jointsCBxL.Size = new System.Drawing.Size(703, 293);
            this.jointsCBxL.TabIndex = 0;
            // 
            // mtbCaptureTime
            // 
            this.mtbCaptureTime.Location = new System.Drawing.Point(164, 28);
            this.mtbCaptureTime.Mask = "90:00";
            this.mtbCaptureTime.Name = "mtbCaptureTime";
            this.mtbCaptureTime.Size = new System.Drawing.Size(40, 22);
            this.mtbCaptureTime.TabIndex = 6;
            this.mtbCaptureTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblMinutesSeconds
            // 
            this.lblMinutesSeconds.AutoSize = true;
            this.lblMinutesSeconds.Location = new System.Drawing.Point(221, 34);
            this.lblMinutesSeconds.Name = "lblMinutesSeconds";
            this.lblMinutesSeconds.Size = new System.Drawing.Size(47, 16);
            this.lblMinutesSeconds.TabIndex = 4;
            this.lblMinutesSeconds.Text = "mm:ss";
            // 
            // lblCaptureTime
            // 
            this.lblCaptureTime.AutoSize = true;
            this.lblCaptureTime.Location = new System.Drawing.Point(24, 34);
            this.lblCaptureTime.Name = "lblCaptureTime";
            this.lblCaptureTime.Size = new System.Drawing.Size(119, 16);
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
            // lblMovements
            // 
            this.lblMovements.AutoSize = true;
            this.lblMovements.Location = new System.Drawing.Point(24, 73);
            this.lblMovements.Name = "lblMovements";
            this.lblMovements.Size = new System.Drawing.Size(74, 16);
            this.lblMovements.TabIndex = 11;
            this.lblMovements.Text = "Movimento";
            // 
            // cbxMovement
            // 
            this.cbxMovement.DropDownHeight = 80;
            this.cbxMovement.FormattingEnabled = true;
            this.cbxMovement.IntegralHeight = false;
            this.cbxMovement.ItemHeight = 16;
            this.cbxMovement.Items.AddRange(new object[] {
            "Sinaleiro ",
            "IdentificacaoRampa ",
            "ProsseguirParaProximoSinaleiroComoOrientadoPelaTorreControle ",
            "ProsseguirFrente ",
            "GirarParaEsquerda ",
            "GirarParaDireita ",
            "ParadaNormal ",
            "ParadaEmergencia ",
            "AcionarFreios ",
            "SoltarFreios ",
            "CalcosColocados ",
            "CalcosRetirados ",
            "AcionamentoMotores ",
            "CortarMotores ",
            "ReduzirVelocidade ",
            "ReduzirVelocidadeMotorDireita ",
            "ReduzirVelocidadeMotorEsquerda ",
            "Recuar ",
            "VirarEnquantoRecuandoDireita ",
            "VirarEnquantoRecuandoEsquerda ",
            "Afirmativo ",
            "VooPairado ",
            "Subida ",
            "Descida ",
            "DeslocamentoHorizontalParaDireita ",
            "DeslocamentoHorizontalParaEsquerda ",
            "Pouso ",
            "Fogo ",
            "ManterPosicao ",
            "DespachoAeronave ",
            "NaoToqueComandos ",
            "ConectarAlimentacaoEletricaSolo ",
            "DesconectarAlimentacaoEletrica ",
            "Negativo ",
            "EstabelecerComunicacaoInterfone ",
            "AbrirFecharEscadas"});
            this.cbxMovement.Location = new System.Drawing.Point(164, 65);
            this.cbxMovement.MaxDropDownItems = 5;
            this.cbxMovement.Name = "cbxMovement";
            this.cbxMovement.Size = new System.Drawing.Size(286, 24);
            this.cbxMovement.TabIndex = 13;
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
        private System.Windows.Forms.Label lblCaptureTime;
        private System.Windows.Forms.MaskedTextBox mtbCaptureTime;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.FolderBrowserDialog fbdFilePath;
        private System.Windows.Forms.CheckedListBox jointsCBxL;
        private System.Windows.Forms.Label lblJoints;
        private System.Windows.Forms.Label lblMovements;
        private System.Windows.Forms.ComboBox cbxMovement;
    }
}

