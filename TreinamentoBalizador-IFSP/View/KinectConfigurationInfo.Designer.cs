using System.Windows.Forms;

namespace TreinamentoBalizador_IFSP.View
{
    partial class KinectConfigurationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KinectConfigurationInfo));
            this.pnlKinectConfigInfo = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnlKinectConfigInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKinectConfigInfo
            // 
            this.pnlKinectConfigInfo.Controls.Add(this.btnContinue);
            this.pnlKinectConfigInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKinectConfigInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlKinectConfigInfo.Name = "pnlKinectConfigInfo";
            this.pnlKinectConfigInfo.Size = new System.Drawing.Size(777, 571);
            this.pnlKinectConfigInfo.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContinue.AutoSize = true;
            this.btnContinue.Location = new System.Drawing.Point(289, 521);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(136, 38);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continuar";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click_1);
            // 
            // KinectConfigurationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 571);
            this.Controls.Add(this.pnlKinectConfigInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KinectConfigurationInfo";
            this.Text = "KinectConfigurationInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlKinectConfigInfo.ResumeLayout(false);
            this.pnlKinectConfigInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlKinectConfigInfo;
        private Button btnContinue;
    }
}