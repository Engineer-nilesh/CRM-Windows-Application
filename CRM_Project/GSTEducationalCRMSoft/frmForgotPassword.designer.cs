namespace GSTEducationalCRMSoft
{
    partial class frmForgotPassword
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlForgotPassword = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEnterYourEmailAddr = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlForgotPassword
            // 
            this.pnlForgotPassword.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground9;
            this.pnlForgotPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlForgotPassword.Controls.Add(this.btnContinue);
            this.pnlForgotPassword.Controls.Add(this.txtEmail);
            this.pnlForgotPassword.Controls.Add(this.lblEnterYourEmailAddr);
            this.pnlForgotPassword.Controls.Add(this.lblForgotPassword);
            this.pnlForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForgotPassword.Location = new System.Drawing.Point(0, 0);
            this.pnlForgotPassword.Name = "pnlForgotPassword";
            this.pnlForgotPassword.Size = new System.Drawing.Size(679, 331);
            this.pnlForgotPassword.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(158, 249);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(336, 44);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(158, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 35);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEnterYourEmailAddr
            // 
            this.lblEnterYourEmailAddr.AutoSize = true;
            this.lblEnterYourEmailAddr.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterYourEmailAddr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterYourEmailAddr.ForeColor = System.Drawing.Color.Lavender;
            this.lblEnterYourEmailAddr.Location = new System.Drawing.Point(174, 114);
            this.lblEnterYourEmailAddr.Name = "lblEnterYourEmailAddr";
            this.lblEnterYourEmailAddr.Size = new System.Drawing.Size(287, 27);
            this.lblEnterYourEmailAddr.TabIndex = 1;
            this.lblEnterYourEmailAddr.Text = "Enter Your Email Address";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Lavender;
            this.lblForgotPassword.Location = new System.Drawing.Point(150, 38);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(344, 46);
            this.lblForgotPassword.TabIndex = 0;
            this.lblForgotPassword.Text = "Forgot Password";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 331);
            this.Controls.Add(this.pnlForgotPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password Details";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlForgotPassword.ResumeLayout(false);
            this.pnlForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForgotPassword;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEnterYourEmailAddr;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}