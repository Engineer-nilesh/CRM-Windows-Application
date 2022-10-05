namespace GSTEducationalCRMSoft
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.pnlSplash = new System.Windows.Forms.Panel();
            this.PrgsbrLoding = new System.Windows.Forms.ProgressBar();
            this.timerCRM = new System.Windows.Forms.Timer(this.components);
            this.pnlSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSplash
            // 
            this.pnlSplash.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.CRM_Image1;
            this.pnlSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSplash.Controls.Add(this.PrgsbrLoding);
            this.pnlSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplash.Location = new System.Drawing.Point(0, 0);
            this.pnlSplash.Name = "pnlSplash";
            this.pnlSplash.Size = new System.Drawing.Size(921, 448);
            this.pnlSplash.TabIndex = 0;
            // 
            // PrgsbrLoding
            // 
            this.PrgsbrLoding.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrgsbrLoding.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.PrgsbrLoding.Location = new System.Drawing.Point(38, 308);
            this.PrgsbrLoding.Name = "PrgsbrLoding";
            this.PrgsbrLoding.Size = new System.Drawing.Size(850, 32);
            this.PrgsbrLoding.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PrgsbrLoding.TabIndex = 7;
            this.PrgsbrLoding.Click += new System.EventHandler(this.PrgsbrLoding_Click);
            // 
            // timerCRM
            // 
            this.timerCRM.Enabled = true;
            this.timerCRM.Tick += new System.EventHandler(this.timerCRM_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 448);
            this.Controls.Add(this.pnlSplash);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.pnlSplash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSplash;
        internal System.Windows.Forms.ProgressBar PrgsbrLoding;
        private System.Windows.Forms.Timer timerCRM;
    }
}