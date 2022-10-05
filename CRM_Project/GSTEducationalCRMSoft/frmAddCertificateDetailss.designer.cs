namespace GSTEducationalCRMSoft
{
    partial class frmAddCertificateDetailss
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
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAdmission = new System.Windows.Forms.DateTimePicker();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtCertificateNo = new System.Windows.Forms.TextBox();
            this.cmbbxCourseName = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCertificateDate = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCertificateNo = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.lblStudentCode = new System.Windows.Forms.Label();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.lblAddCertificateDetails = new System.Windows.Forms.Label();
            this.cmbbxStudName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(764, 601);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(282, 30);
            this.dateTimePickerTo.TabIndex = 29;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerAdmission
            // 
            this.dateTimePickerAdmission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdmission.Location = new System.Drawing.Point(764, 534);
            this.dateTimePickerAdmission.Name = "dateTimePickerAdmission";
            this.dateTimePickerAdmission.Size = new System.Drawing.Size(282, 30);
            this.dateTimePickerAdmission.TabIndex = 28;
            this.dateTimePickerAdmission.ValueChanged += new System.EventHandler(this.dateTimePickerAdmission_ValueChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblGrade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(636, 671);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(81, 24);
            this.lblGrade.TabIndex = 27;
            this.lblGrade.Text = "Grade :";
            this.lblGrade.Click += new System.EventHandler(this.lblGrade_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(764, 666);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(265, 30);
            this.txtGrade.TabIndex = 26;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // txtCertificateNo
            // 
            this.txtCertificateNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCertificateNo.Location = new System.Drawing.Point(761, 147);
            this.txtCertificateNo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCertificateNo.Name = "txtCertificateNo";
            this.txtCertificateNo.Size = new System.Drawing.Size(395, 30);
            this.txtCertificateNo.TabIndex = 25;
            this.txtCertificateNo.TextChanged += new System.EventHandler(this.txtCertificateNo_TextChanged);
            // 
            // cmbbxCourseName
            // 
            this.cmbbxCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCourseName.FormattingEnabled = true;
            this.cmbbxCourseName.Location = new System.Drawing.Point(761, 213);
            this.cmbbxCourseName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbbxCourseName.Name = "cmbbxCourseName";
            this.cmbbxCourseName.Size = new System.Drawing.Size(395, 31);
            this.cmbbxCourseName.TabIndex = 23;
            this.cmbbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourseName_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(905, 720);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 42);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(756, 720);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 42);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCertificateDate
            // 
            this.lblCertificateDate.AutoSize = true;
            this.lblCertificateDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCertificateDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificateDate.Location = new System.Drawing.Point(548, 600);
            this.lblCertificateDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCertificateDate.Name = "lblCertificateDate";
            this.lblCertificateDate.Size = new System.Drawing.Size(169, 24);
            this.lblCertificateDate.TabIndex = 20;
            this.lblCertificateDate.Text = "Certificate Date :";
            this.lblCertificateDate.Click += new System.EventHandler(this.lblCertificateDate_Click);
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmissionDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionDate.Location = new System.Drawing.Point(553, 539);
            this.lblAdmissionDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(164, 24);
            this.lblAdmissionDate.TabIndex = 19;
            this.lblAdmissionDate.Text = "Admission Date:";
            this.lblAdmissionDate.Click += new System.EventHandler(this.lblAdmissionDate_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(567, 285);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(150, 24);
            this.lblStudentName.TabIndex = 18;
            this.lblStudentName.Text = "Student Name:";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(567, 217);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(150, 24);
            this.lblCourseName.TabIndex = 17;
            this.lblCourseName.Text = "Course Name :";
            this.lblCourseName.Click += new System.EventHandler(this.lblCourseName_Click);
            // 
            // lblCertificateNo
            // 
            this.lblCertificateNo.AutoSize = true;
            this.lblCertificateNo.BackColor = System.Drawing.Color.Transparent;
            this.lblCertificateNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificateNo.Location = new System.Drawing.Point(565, 149);
            this.lblCertificateNo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCertificateNo.Name = "lblCertificateNo";
            this.lblCertificateNo.Size = new System.Drawing.Size(152, 24);
            this.lblCertificateNo.TabIndex = 16;
            this.lblCertificateNo.Text = "Certificate No :";
            this.lblCertificateNo.Click += new System.EventHandler(this.lblCertificateNo_Click);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(546, 413);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(171, 24);
            this.lblContactNumber.TabIndex = 70;
            this.lblContactNumber.Text = "Contact Number:";
            this.lblContactNumber.Click += new System.EventHandler(this.lblContactNumber_Click);
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailId.Location = new System.Drawing.Point(626, 480);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(91, 24);
            this.lblEmailId.TabIndex = 71;
            this.lblEmailId.Text = "Email Id:";
            this.lblEmailId.Click += new System.EventHandler(this.lblEmailId_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(764, 413);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(392, 27);
            this.txtContactNumber.TabIndex = 72;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // txtEmailId
            // 
            this.txtEmailId.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailId.Location = new System.Drawing.Point(764, 478);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(395, 27);
            this.txtEmailId.TabIndex = 73;
            this.txtEmailId.TextChanged += new System.EventHandler(this.txtEmailId_TextChanged);
            // 
            // lblStudentCode
            // 
            this.lblStudentCode.AutoSize = true;
            this.lblStudentCode.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCode.Location = new System.Drawing.Point(565, 351);
            this.lblStudentCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentCode.Name = "lblStudentCode";
            this.lblStudentCode.Size = new System.Drawing.Size(152, 24);
            this.lblStudentCode.TabIndex = 74;
            this.lblStudentCode.Text = "Student Code :";
            this.lblStudentCode.Click += new System.EventHandler(this.lblStudentCode_Click);
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(761, 346);
            this.txtStudentCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(395, 30);
            this.txtStudentCode.TabIndex = 75;
            this.txtStudentCode.TextChanged += new System.EventHandler(this.txtStudentCode_TextChanged);
            // 
            // lblAddCertificateDetails
            // 
            this.lblAddCertificateDetails.AutoSize = true;
            this.lblAddCertificateDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCertificateDetails.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCertificateDetails.Location = new System.Drawing.Point(711, 58);
            this.lblAddCertificateDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCertificateDetails.Name = "lblAddCertificateDetails";
            this.lblAddCertificateDetails.Size = new System.Drawing.Size(335, 35);
            this.lblAddCertificateDetails.TabIndex = 76;
            this.lblAddCertificateDetails.Text = "Add Certificate Details";
            this.lblAddCertificateDetails.Click += new System.EventHandler(this.lblAddCertificateDetails_Click);
            // 
            // cmbbxStudName
            // 
            this.cmbbxStudName.FormattingEnabled = true;
            this.cmbbxStudName.Location = new System.Drawing.Point(761, 278);
            this.cmbbxStudName.Name = "cmbbxStudName";
            this.cmbbxStudName.Size = new System.Drawing.Size(395, 32);
            this.cmbbxStudName.TabIndex = 77;
            this.cmbbxStudName.SelectedIndexChanged += new System.EventHandler(this.cmbbxStudName_SelectedIndexChanged);
            // 
            // frmAddCertificateDetailss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 868);
            this.Controls.Add(this.cmbbxStudName);
            this.Controls.Add(this.lblAddCertificateDetails);
            this.Controls.Add(this.txtStudentCode);
            this.Controls.Add(this.lblStudentCode);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtEmailId);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerAdmission);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtCertificateNo);
            this.Controls.Add(this.cmbbxCourseName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCertificateDate);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCertificateNo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAddCertificateDetailss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Certificate Detailss";
            this.Load += new System.EventHandler(this.frmAddCertificateDetailss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdmission;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtCertificateNo;
        private System.Windows.Forms.ComboBox cmbbxCourseName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCertificateDate;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCertificateNo;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label lblStudentCode;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Label lblAddCertificateDetails;
        private System.Windows.Forms.ComboBox cmbbxStudName;
    }
}