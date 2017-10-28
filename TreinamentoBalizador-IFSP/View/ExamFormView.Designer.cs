﻿namespace TreinamentoBalizador_IFSP.View
{
    partial class ExamFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamFormView));
            this.pnlExam = new System.Windows.Forms.Panel();
            this.gbxExamConfig = new System.Windows.Forms.GroupBox();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtBoxStudentName = new System.Windows.Forms.TextBox();
            this.lblMovementNumber = new System.Windows.Forms.Label();
            this.numUpDownMovementNumber = new System.Windows.Forms.NumericUpDown();
            this.btnExamInit = new System.Windows.Forms.Button();
            this.gbxExamStatus = new System.Windows.Forms.GroupBox();
            this.lblMovement = new System.Windows.Forms.Label();
            this.lblCurrentMovement = new System.Windows.Forms.Label();
            this.btnInitCapture = new System.Windows.Forms.Button();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.pbCapturing = new System.Windows.Forms.ProgressBar();
            this.btnExamCancel = new System.Windows.Forms.Button();
            this.gbxExamResult = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnStartKinect = new System.Windows.Forms.Button();
            this.lblSensorReady = new System.Windows.Forms.Label();
            this.bgdProgressStatus = new System.ComponentModel.BackgroundWorker();
            this.clmStudantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlExam.SuspendLayout();
            this.gbxExamConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMovementNumber)).BeginInit();
            this.gbxExamStatus.SuspendLayout();
            this.gbxExamResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExam
            // 
            this.pnlExam.Controls.Add(this.gbxExamResult);
            this.pnlExam.Controls.Add(this.gbxExamStatus);
            this.pnlExam.Controls.Add(this.lblFormName);
            this.pnlExam.Controls.Add(this.gbxExamConfig);
            this.pnlExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExam.Location = new System.Drawing.Point(0, 0);
            this.pnlExam.Name = "pnlExam";
            this.pnlExam.Size = new System.Drawing.Size(1159, 741);
            this.pnlExam.TabIndex = 0;
            // 
            // gbxExamConfig
            // 
            this.gbxExamConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxExamConfig.Controls.Add(this.btnExamCancel);
            this.gbxExamConfig.Controls.Add(this.btnExamInit);
            this.gbxExamConfig.Controls.Add(this.numUpDownMovementNumber);
            this.gbxExamConfig.Controls.Add(this.lblMovementNumber);
            this.gbxExamConfig.Controls.Add(this.txtBoxStudentName);
            this.gbxExamConfig.Controls.Add(this.lblStudentName);
            this.gbxExamConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExamConfig.Location = new System.Drawing.Point(12, 51);
            this.gbxExamConfig.Name = "gbxExamConfig";
            this.gbxExamConfig.Size = new System.Drawing.Size(1135, 113);
            this.gbxExamConfig.TabIndex = 0;
            this.gbxExamConfig.TabStop = false;
            this.gbxExamConfig.Text = "Configurar prova";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(12, 22);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(172, 18);
            this.lblFormName.TabIndex = 1;
            this.lblFormName.Text = "Prova de movimentos";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(15, 37);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(100, 16);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Nome do aluno";
            // 
            // txtBoxStudentName
            // 
            this.txtBoxStudentName.Location = new System.Drawing.Point(18, 66);
            this.txtBoxStudentName.Name = "txtBoxStudentName";
            this.txtBoxStudentName.Size = new System.Drawing.Size(394, 22);
            this.txtBoxStudentName.TabIndex = 1;
            // 
            // lblMovementNumber
            // 
            this.lblMovementNumber.AutoSize = true;
            this.lblMovementNumber.Location = new System.Drawing.Point(481, 37);
            this.lblMovementNumber.Name = "lblMovementNumber";
            this.lblMovementNumber.Size = new System.Drawing.Size(173, 16);
            this.lblMovementNumber.TabIndex = 2;
            this.lblMovementNumber.Text = "Quantidade de movimentos";
            // 
            // numUpDownMovementNumber
            // 
            this.numUpDownMovementNumber.Location = new System.Drawing.Point(484, 67);
            this.numUpDownMovementNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownMovementNumber.Name = "numUpDownMovementNumber";
            this.numUpDownMovementNumber.ReadOnly = true;
            this.numUpDownMovementNumber.Size = new System.Drawing.Size(170, 22);
            this.numUpDownMovementNumber.TabIndex = 3;
            this.numUpDownMovementNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExamInit
            // 
            this.btnExamInit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExamInit.Location = new System.Drawing.Point(984, 21);
            this.btnExamInit.Name = "btnExamInit";
            this.btnExamInit.Size = new System.Drawing.Size(145, 30);
            this.btnExamInit.TabIndex = 4;
            this.btnExamInit.Text = "Iniciar prova";
            this.btnExamInit.UseVisualStyleBackColor = true;
            this.btnExamInit.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxExamStatus
            // 
            this.gbxExamStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxExamStatus.Controls.Add(this.lblSensorReady);
            this.gbxExamStatus.Controls.Add(this.btnStartKinect);
            this.gbxExamStatus.Controls.Add(this.pbCapturing);
            this.gbxExamStatus.Controls.Add(this.btnStopCapture);
            this.gbxExamStatus.Controls.Add(this.btnInitCapture);
            this.gbxExamStatus.Controls.Add(this.lblCurrentMovement);
            this.gbxExamStatus.Controls.Add(this.lblMovement);
            this.gbxExamStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExamStatus.Location = new System.Drawing.Point(15, 194);
            this.gbxExamStatus.Name = "gbxExamStatus";
            this.gbxExamStatus.Size = new System.Drawing.Size(1135, 189);
            this.gbxExamStatus.TabIndex = 2;
            this.gbxExamStatus.TabStop = false;
            this.gbxExamStatus.Text = "Execução da prova";
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Location = new System.Drawing.Point(12, 38);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(74, 16);
            this.lblMovement.TabIndex = 1;
            this.lblMovement.Text = "Movimento";
            // 
            // lblCurrentMovement
            // 
            this.lblCurrentMovement.AutoSize = true;
            this.lblCurrentMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMovement.Location = new System.Drawing.Point(12, 69);
            this.lblCurrentMovement.Name = "lblCurrentMovement";
            this.lblCurrentMovement.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentMovement.TabIndex = 2;
            // 
            // btnInitCapture
            // 
            this.btnInitCapture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInitCapture.Enabled = false;
            this.btnInitCapture.Location = new System.Drawing.Point(981, 64);
            this.btnInitCapture.Name = "btnInitCapture";
            this.btnInitCapture.Size = new System.Drawing.Size(145, 30);
            this.btnInitCapture.TabIndex = 5;
            this.btnInitCapture.Text = "Executar movimento";
            this.btnInitCapture.UseVisualStyleBackColor = true;
            this.btnInitCapture.Click += new System.EventHandler(this.btnInitCapture_Click);
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopCapture.Enabled = false;
            this.btnStopCapture.Location = new System.Drawing.Point(981, 104);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(145, 30);
            this.btnStopCapture.TabIndex = 6;
            this.btnStopCapture.Text = "Parar execução";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            // 
            // pbCapturing
            // 
            this.pbCapturing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCapturing.Location = new System.Drawing.Point(6, 150);
            this.pbCapturing.Name = "pbCapturing";
            this.pbCapturing.Size = new System.Drawing.Size(1120, 23);
            this.pbCapturing.TabIndex = 7;
            // 
            // btnExamCancel
            // 
            this.btnExamCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExamCancel.Enabled = false;
            this.btnExamCancel.Location = new System.Drawing.Point(984, 67);
            this.btnExamCancel.Name = "btnExamCancel";
            this.btnExamCancel.Size = new System.Drawing.Size(145, 30);
            this.btnExamCancel.TabIndex = 5;
            this.btnExamCancel.Text = "Cancelar prova";
            this.btnExamCancel.UseVisualStyleBackColor = true;
            // 
            // gbxExamResult
            // 
            this.gbxExamResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxExamResult.Controls.Add(this.dgvResults);
            this.gbxExamResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExamResult.Location = new System.Drawing.Point(15, 413);
            this.gbxExamResult.Name = "gbxExamResult";
            this.gbxExamResult.Size = new System.Drawing.Size(1135, 251);
            this.gbxExamResult.TabIndex = 3;
            this.gbxExamResult.TabStop = false;
            this.gbxExamResult.Text = "Resultados";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStudantName,
            this.clmDate,
            this.clmMovement,
            this.clmResult});
            this.dgvResults.Location = new System.Drawing.Point(15, 37);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(1102, 190);
            this.dgvResults.TabIndex = 0;
            // 
            // btnStartKinect
            // 
            this.btnStartKinect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartKinect.Enabled = false;
            this.btnStartKinect.Location = new System.Drawing.Point(981, 21);
            this.btnStartKinect.Name = "btnStartKinect";
            this.btnStartKinect.Size = new System.Drawing.Size(145, 30);
            this.btnStartKinect.TabIndex = 8;
            this.btnStartKinect.Text = "Preparar para execução";
            this.btnStartKinect.UseVisualStyleBackColor = true;
            this.btnStartKinect.Click += new System.EventHandler(this.btnStartKinect_Click);
            // 
            // lblSensorReady
            // 
            this.lblSensorReady.AutoSize = true;
            this.lblSensorReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSensorReady.Location = new System.Drawing.Point(823, 33);
            this.lblSensorReady.Name = "lblSensorReady";
            this.lblSensorReady.Size = new System.Drawing.Size(0, 18);
            this.lblSensorReady.TabIndex = 9;
            // 
            // clmStudantName
            // 
            this.clmStudantName.HeaderText = "Nome do aluno";
            this.clmStudantName.Name = "clmStudantName";
            this.clmStudantName.Width = 400;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Data da prova";
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 200;
            // 
            // clmMovement
            // 
            this.clmMovement.HeaderText = "Movimento";
            this.clmMovement.Name = "clmMovement";
            this.clmMovement.Width = 560;
            // 
            // clmResult
            // 
            this.clmResult.HeaderText = "Resultado";
            this.clmResult.Name = "clmResult";
            // 
            // ExamFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 741);
            this.Controls.Add(this.pnlExam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExamFormView";
            this.Text = "Prova de movimentos";
            this.pnlExam.ResumeLayout(false);
            this.pnlExam.PerformLayout();
            this.gbxExamConfig.ResumeLayout(false);
            this.gbxExamConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMovementNumber)).EndInit();
            this.gbxExamStatus.ResumeLayout(false);
            this.gbxExamStatus.PerformLayout();
            this.gbxExamResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExam;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.GroupBox gbxExamConfig;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtBoxStudentName;
        private System.Windows.Forms.NumericUpDown numUpDownMovementNumber;
        private System.Windows.Forms.Label lblMovementNumber;
        private System.Windows.Forms.Button btnExamInit;
        private System.Windows.Forms.GroupBox gbxExamStatus;
        private System.Windows.Forms.Button btnStopCapture;
        private System.Windows.Forms.Button btnInitCapture;
        private System.Windows.Forms.Label lblCurrentMovement;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.ProgressBar pbCapturing;
        private System.Windows.Forms.Button btnExamCancel;
        private System.Windows.Forms.GroupBox gbxExamResult;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnStartKinect;
        private System.Windows.Forms.Label lblSensorReady;
        private System.ComponentModel.BackgroundWorker bgdProgressStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResult;
    }
}