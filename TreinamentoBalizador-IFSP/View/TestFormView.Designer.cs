namespace TreinamentoBalizador_IFSP.View
{
    partial class TestFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestFormView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartMove = new System.Windows.Forms.Button();
            this.lblMoveToDoContent = new System.Windows.Forms.Label();
            this.lblMoveToDo = new System.Windows.Forms.Label();
            this.pgbMovement = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPercentageCorrectMoveContent = new System.Windows.Forms.Label();
            this.lblMoveWrongContent = new System.Windows.Forms.Label();
            this.lblMoveCorrectContent = new System.Windows.Forms.Label();
            this.lblPercentageCorrectMove = new System.Windows.Forms.Label();
            this.lblMoveWrong = new System.Windows.Forms.Label();
            this.lblMoveCorrect = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnStartMove);
            this.groupBox1.Controls.Add(this.lblMoveToDoContent);
            this.groupBox1.Controls.Add(this.lblMoveToDo);
            this.groupBox1.Controls.Add(this.pgbMovement);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Ação";
            // 
            // btnStartMove
            // 
            this.btnStartMove.Location = new System.Drawing.Point(311, 41);
            this.btnStartMove.Name = "btnStartMove";
            this.btnStartMove.Size = new System.Drawing.Size(118, 23);
            this.btnStartMove.TabIndex = 3;
            this.btnStartMove.Text = "Iniciar movimento";
            this.btnStartMove.UseVisualStyleBackColor = true;
            this.btnStartMove.Click += new System.EventHandler(this.btnStartMove_Click);
            // 
            // lblMoveToDoContent
            // 
            this.lblMoveToDoContent.AutoSize = true;
            this.lblMoveToDoContent.Location = new System.Drawing.Point(145, 46);
            this.lblMoveToDoContent.Name = "lblMoveToDoContent";
            this.lblMoveToDoContent.Size = new System.Drawing.Size(35, 13);
            this.lblMoveToDoContent.TabIndex = 2;
            this.lblMoveToDoContent.Text = "label2";
            // 
            // lblMoveToDo
            // 
            this.lblMoveToDo.AutoSize = true;
            this.lblMoveToDo.Location = new System.Drawing.Point(6, 46);
            this.lblMoveToDo.Name = "lblMoveToDo";
            this.lblMoveToDo.Size = new System.Drawing.Size(133, 13);
            this.lblMoveToDo.TabIndex = 1;
            this.lblMoveToDo.Text = "Movimento a ser realizado:";
            // 
            // pgbMovement
            // 
            this.pgbMovement.Location = new System.Drawing.Point(6, 92);
            this.pgbMovement.Name = "pgbMovement";
            this.pgbMovement.Size = new System.Drawing.Size(423, 23);
            this.pgbMovement.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Location = new System.Drawing.Point(453, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentos realizados";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.lblPercentageCorrectMoveContent);
            this.groupBox3.Controls.Add(this.lblMoveWrongContent);
            this.groupBox3.Controls.Add(this.lblMoveCorrectContent);
            this.groupBox3.Controls.Add(this.lblPercentageCorrectMove);
            this.groupBox3.Controls.Add(this.lblMoveWrong);
            this.groupBox3.Controls.Add(this.lblMoveCorrect);
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // lblPercentageCorrectMoveContent
            // 
            this.lblPercentageCorrectMoveContent.AutoSize = true;
            this.lblPercentageCorrectMoveContent.Location = new System.Drawing.Point(148, 70);
            this.lblPercentageCorrectMoveContent.Name = "lblPercentageCorrectMoveContent";
            this.lblPercentageCorrectMoveContent.Size = new System.Drawing.Size(35, 13);
            this.lblPercentageCorrectMoveContent.TabIndex = 5;
            this.lblPercentageCorrectMoveContent.Text = "label6";
            // 
            // lblMoveWrongContent
            // 
            this.lblMoveWrongContent.AutoSize = true;
            this.lblMoveWrongContent.Location = new System.Drawing.Point(148, 44);
            this.lblMoveWrongContent.Name = "lblMoveWrongContent";
            this.lblMoveWrongContent.Size = new System.Drawing.Size(35, 13);
            this.lblMoveWrongContent.TabIndex = 4;
            this.lblMoveWrongContent.Text = "label5";
            // 
            // lblMoveCorrectContent
            // 
            this.lblMoveCorrectContent.AutoSize = true;
            this.lblMoveCorrectContent.Location = new System.Drawing.Point(148, 20);
            this.lblMoveCorrectContent.Name = "lblMoveCorrectContent";
            this.lblMoveCorrectContent.Size = new System.Drawing.Size(35, 13);
            this.lblMoveCorrectContent.TabIndex = 3;
            this.lblMoveCorrectContent.Text = "label4";
            // 
            // lblPercentageCorrectMove
            // 
            this.lblPercentageCorrectMove.AutoSize = true;
            this.lblPercentageCorrectMove.Location = new System.Drawing.Point(6, 71);
            this.lblPercentageCorrectMove.Name = "lblPercentageCorrectMove";
            this.lblPercentageCorrectMove.Size = new System.Drawing.Size(121, 13);
            this.lblPercentageCorrectMove.TabIndex = 2;
            this.lblPercentageCorrectMove.Text = "Porcentagem de acerto:";
            // 
            // lblMoveWrong
            // 
            this.lblMoveWrong.AutoSize = true;
            this.lblMoveWrong.Location = new System.Drawing.Point(6, 45);
            this.lblMoveWrong.Name = "lblMoveWrong";
            this.lblMoveWrong.Size = new System.Drawing.Size(105, 13);
            this.lblMoveWrong.TabIndex = 1;
            this.lblMoveWrong.Text = "Movimentos errados:";
            // 
            // lblMoveCorrect
            // 
            this.lblMoveCorrect.AutoSize = true;
            this.lblMoveCorrect.Location = new System.Drawing.Point(7, 20);
            this.lblMoveCorrect.Name = "lblMoveCorrect";
            this.lblMoveCorrect.Size = new System.Drawing.Size(117, 13);
            this.lblMoveCorrect.TabIndex = 0;
            this.lblMoveCorrect.Text = "Movimentos acertados:";
            // 
            // TestFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 635);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestFormView";
            this.Text = "Teste Balizador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestFormView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pgbMovement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMoveToDoContent;
        private System.Windows.Forms.Label lblMoveToDo;
        private System.Windows.Forms.Button btnStartMove;
        private System.Windows.Forms.Label lblPercentageCorrectMove;
        private System.Windows.Forms.Label lblMoveWrong;
        private System.Windows.Forms.Label lblMoveCorrect;
        private System.Windows.Forms.Label lblPercentageCorrectMoveContent;
        private System.Windows.Forms.Label lblMoveWrongContent;
        private System.Windows.Forms.Label lblMoveCorrectContent;
    }
}