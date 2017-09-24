namespace TreinamentoBalizador_IFSP.View
{
    partial class MovementList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovementList));
            this.pnlMovementsList = new System.Windows.Forms.Panel();
            this.gbxSelectMovement = new System.Windows.Forms.GroupBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxSelectMovement = new System.Windows.Forms.ComboBox();
            this.wbMovement = new System.Windows.Forms.WebBrowser();
            this.pnlMovementsList.SuspendLayout();
            this.gbxSelectMovement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMovementsList
            // 
            this.pnlMovementsList.Controls.Add(this.gbxSelectMovement);
            this.pnlMovementsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMovementsList.Location = new System.Drawing.Point(0, 0);
            this.pnlMovementsList.Name = "pnlMovementsList";
            this.pnlMovementsList.Size = new System.Drawing.Size(777, 571);
            this.pnlMovementsList.TabIndex = 0;
            // 
            // gbxSelectMovement
            // 
            this.gbxSelectMovement.Controls.Add(this.wbMovement);
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
            this.cbxSelectMovement.Items.AddRange(new object[] {
            "Sinaleiro ",
            "IdentificacaoRampa ",
            "ProsseguirParaProximoSinaleiroComoOrientadoPelaTorreControleDireita",
            "ProsseguirParaProximoSinaleiroComoOrientadoPelaTorreControleEsquerda",
            "ProsseguirFrente ",
            "GirarParaEsquerda ",
            "GirarParaDireita ",
            "ParadaNormal ",
            "ParadaEmergencia ",
            "AcionarOuSoltarFreios",
            "CalcosColocadosOuRetirados",
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
            this.cbxSelectMovement.Location = new System.Drawing.Point(114, 34);
            this.cbxSelectMovement.Name = "cbxSelectMovement";
            this.cbxSelectMovement.Size = new System.Drawing.Size(608, 24);
            this.cbxSelectMovement.TabIndex = 0;
            this.cbxSelectMovement.SelectedIndexChanged += new System.EventHandler(this.cbxSelectMovement_SelectedIndexChanged);
            // 
            // wbMovement
            // 
            this.wbMovement.Location = new System.Drawing.Point(19, 98);
            this.wbMovement.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMovement.Name = "wbMovement";
            this.wbMovement.Size = new System.Drawing.Size(702, 307);
            this.wbMovement.TabIndex = 2;
            // 
            // MovementList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 571);
            this.Controls.Add(this.pnlMovementsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovementList";
            this.Text = "Lista de sinais";
            this.pnlMovementsList.ResumeLayout(false);
            this.gbxSelectMovement.ResumeLayout(false);
            this.gbxSelectMovement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMovementsList;
        private System.Windows.Forms.GroupBox gbxSelectMovement;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbxSelectMovement;
        private System.Windows.Forms.WebBrowser wbMovement;
    }
}