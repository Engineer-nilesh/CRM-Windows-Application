namespace GSTEducationalCRMSoft
{
    partial class AddPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLastBalAmo = new System.Windows.Forms.Label();
            this.lblLBA = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ccmbbxPayMode = new System.Windows.Forms.ComboBox();
            this.txtpaidA = new System.Windows.Forms.TextBox();
            this.lblAddPay = new System.Windows.Forms.Label();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBalAmount = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(275, 102);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(130, 27);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblLastBalAmo);
            this.panel1.Controls.Add(this.lblLBA);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.ccmbbxPayMode);
            this.panel1.Controls.Add(this.txtpaidA);
            this.panel1.Controls.Add(this.lblAddPay);
            this.panel1.Controls.Add(this.lblPaymentMode);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblBalAmount);
            this.panel1.Controls.Add(this.lblPaidAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTotalFee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCourseName);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblLastBalAmo
            // 
            this.lblLastBalAmo.AutoSize = true;
            this.lblLastBalAmo.BackColor = System.Drawing.Color.Transparent;
            this.lblLastBalAmo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastBalAmo.Location = new System.Drawing.Point(572, 254);
            this.lblLastBalAmo.Name = "lblLastBalAmo";
            this.lblLastBalAmo.Size = new System.Drawing.Size(125, 23);
            this.lblLastBalAmo.TabIndex = 20;
            this.lblLastBalAmo.Text = "LastPayment";
            // 
            // lblLBA
            // 
            this.lblLBA.AutoSize = true;
            this.lblLBA.BackColor = System.Drawing.Color.Transparent;
            this.lblLBA.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA.Location = new System.Drawing.Point(275, 254);
            this.lblLBA.Name = "lblLBA";
            this.lblLBA.Size = new System.Drawing.Size(240, 27);
            this.lblLBA.TabIndex = 18;
            this.lblLBA.Text = "Last Balance Amount";
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(535, 480);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(169, 38);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(346, 480);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 38);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ccmbbxPayMode
            // 
            this.ccmbbxPayMode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccmbbxPayMode.FormattingEnabled = true;
            this.ccmbbxPayMode.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Online"});
            this.ccmbbxPayMode.Location = new System.Drawing.Point(575, 403);
            this.ccmbbxPayMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ccmbbxPayMode.Name = "ccmbbxPayMode";
            this.ccmbbxPayMode.Size = new System.Drawing.Size(160, 31);
            this.ccmbbxPayMode.TabIndex = 12;
            this.ccmbbxPayMode.SelectedIndexChanged += new System.EventHandler(this.ccmbbxPayMode_SelectedIndexChanged);
            // 
            // txtpaidA
            // 
            this.txtpaidA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidA.Location = new System.Drawing.Point(575, 308);
            this.txtpaidA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpaidA.Name = "txtpaidA";
            this.txtpaidA.Size = new System.Drawing.Size(132, 30);
            this.txtpaidA.TabIndex = 11;
            this.txtpaidA.TextChanged += new System.EventHandler(this.txtpaidA_TextChanged);
            this.txtpaidA.MouseEnter += new System.EventHandler(this.txtpaidA_MouseEnter);
            // 
            // lblAddPay
            // 
            this.lblAddPay.AutoSize = true;
            this.lblAddPay.BackColor = System.Drawing.Color.Transparent;
            this.lblAddPay.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPay.Location = new System.Drawing.Point(357, 23);
            this.lblAddPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddPay.Name = "lblAddPay";
            this.lblAddPay.Size = new System.Drawing.Size(289, 49);
            this.lblAddPay.TabIndex = 10;
            this.lblAddPay.Text = "Add Payment";
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentMode.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMode.Location = new System.Drawing.Point(283, 402);
            this.lblPaymentMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(180, 27);
            this.lblPaymentMode.TabIndex = 9;
            this.lblPaymentMode.Text = "Payment Mode:";
            this.lblPaymentMode.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 359);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // lblBalAmount
            // 
            this.lblBalAmount.AutoSize = true;
            this.lblBalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblBalAmount.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalAmount.Location = new System.Drawing.Point(275, 359);
            this.lblBalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalAmount.Name = "lblBalAmount";
            this.lblBalAmount.Size = new System.Drawing.Size(195, 27);
            this.lblBalAmount.TabIndex = 7;
            this.lblBalAmount.Text = "Balance Amount:";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPaidAmount.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.Location = new System.Drawing.Point(283, 299);
            this.lblPaidAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(156, 27);
            this.lblPaidAmount.TabIndex = 6;
            this.lblPaidAmount.Text = "Paid Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFee.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(275, 202);
            this.lblTotalFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(117, 27);
            this.lblTotalFee.TabIndex = 4;
            this.lblTotalFee.Text = "Total Fee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(275, 148);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(166, 27);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Course Name:";
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Payment Details";
            this.Load += new System.EventHandler(this.frmAddPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ccmbbxPayMode;
        private System.Windows.Forms.TextBox txtpaidA;
        private System.Windows.Forms.Label lblAddPay;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBalAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblLBA;
        private System.Windows.Forms.Label lblLastBalAmo;
    }
}