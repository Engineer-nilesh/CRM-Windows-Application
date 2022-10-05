namespace GSTEducationalCRMSoft
{
    partial class frmAddNewEnquirySource
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEnquirySource = new System.Windows.Forms.Label();
            this.txtEnquirySourceName = new System.Windows.Forms.TextBox();
            this.erpNewSource = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpNewSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(123, 208);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(311, 208);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEnquirySource
            // 
            this.lblEnquirySource.AutoSize = true;
            this.lblEnquirySource.BackColor = System.Drawing.Color.Transparent;
            this.lblEnquirySource.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnquirySource.Location = new System.Drawing.Point(88, 95);
            this.lblEnquirySource.Name = "lblEnquirySource";
            this.lblEnquirySource.Size = new System.Drawing.Size(228, 24);
            this.lblEnquirySource.TabIndex = 2;
            this.lblEnquirySource.Text = "Enquiry Source Name :";
            // 
            // txtEnquirySourceName
            // 
            this.txtEnquirySourceName.Location = new System.Drawing.Point(385, 95);
            this.txtEnquirySourceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnquirySourceName.Name = "txtEnquirySourceName";
            this.txtEnquirySourceName.Size = new System.Drawing.Size(143, 22);
            this.txtEnquirySourceName.TabIndex = 3;
            this.txtEnquirySourceName.TextChanged += new System.EventHandler(this.txtEnquirySource_TextChanged);
            this.txtEnquirySourceName.Leave += new System.EventHandler(this.txtEnquirySourceName_Leave);
            // 
            // erpNewSource
            // 
            this.erpNewSource.ContainerControl = this;
            // 
            // frmAddNewEnquirySource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 310);
            this.Controls.Add(this.txtEnquirySourceName);
            this.Controls.Add(this.lblEnquirySource);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddNewEnquirySource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Enquiry Source";
            this.Load += new System.EventHandler(this.frmAddNewEnquirySource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpNewSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEnquirySource;
        private System.Windows.Forms.TextBox txtEnquirySourceName;
        private System.Windows.Forms.ErrorProvider erpNewSource;
    }
}