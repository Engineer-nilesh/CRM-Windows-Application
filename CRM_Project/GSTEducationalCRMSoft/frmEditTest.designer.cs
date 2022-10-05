namespace GSTEducationalCRMSoft
{
    partial class frmEditTest
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
            this.dateTimePicker1TestDate = new System.Windows.Forms.DateTimePicker();
            this.cmbbxTestStatus = new System.Windows.Forms.ComboBox();
            this.cmbbxTestLab = new System.Windows.Forms.ComboBox();
            this.cmbbxTestTrainer = new System.Windows.Forms.ComboBox();
            this.txtMaximumMarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.cmbbxTestName = new System.Windows.Forms.ComboBox();
            this.cmbbxTestBatchName = new System.Windows.Forms.ComboBox();
            this.cmbbxTestCourseName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbxTestDuration = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.txtTestSelectFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbbxSTime = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProviderEditStime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDuration = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMarks = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSelectFile = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1Date = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditStime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSelectFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Date)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1TestDate
            // 
            this.dateTimePicker1TestDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1TestDate.Location = new System.Drawing.Point(426, 232);
            this.dateTimePicker1TestDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1TestDate.Name = "dateTimePicker1TestDate";
            this.dateTimePicker1TestDate.Size = new System.Drawing.Size(226, 35);
            this.dateTimePicker1TestDate.TabIndex = 66;
            this.dateTimePicker1TestDate.ValueChanged += new System.EventHandler(this.dateTimePicker1TestDate_ValueChanged);
            // 
            // cmbbxTestStatus
            // 
            this.cmbbxTestStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestStatus.FormattingEnabled = true;
            this.cmbbxTestStatus.Location = new System.Drawing.Point(1053, 420);
            this.cmbbxTestStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestStatus.Name = "cmbbxTestStatus";
            this.cmbbxTestStatus.Size = new System.Drawing.Size(126, 35);
            this.cmbbxTestStatus.TabIndex = 64;
            // 
            // cmbbxTestLab
            // 
            this.cmbbxTestLab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestLab.FormattingEnabled = true;
            this.cmbbxTestLab.Location = new System.Drawing.Point(1053, 355);
            this.cmbbxTestLab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestLab.Name = "cmbbxTestLab";
            this.cmbbxTestLab.Size = new System.Drawing.Size(126, 35);
            this.cmbbxTestLab.TabIndex = 63;
            // 
            // cmbbxTestTrainer
            // 
            this.cmbbxTestTrainer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestTrainer.FormattingEnabled = true;
            this.cmbbxTestTrainer.Location = new System.Drawing.Point(1053, 169);
            this.cmbbxTestTrainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestTrainer.Name = "cmbbxTestTrainer";
            this.cmbbxTestTrainer.Size = new System.Drawing.Size(192, 35);
            this.cmbbxTestTrainer.TabIndex = 62;
            // 
            // txtMaximumMarks
            // 
            this.txtMaximumMarks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximumMarks.Location = new System.Drawing.Point(1053, 229);
            this.txtMaximumMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaximumMarks.Name = "txtMaximumMarks";
            this.txtMaximumMarks.Size = new System.Drawing.Size(192, 35);
            this.txtMaximumMarks.TabIndex = 59;
            this.txtMaximumMarks.Leave += new System.EventHandler(this.txtMaximumMarks_Leave);
            this.txtMaximumMarks.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaximumMarks_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(807, 420);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 33);
            this.label11.TabIndex = 56;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(807, 360);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 33);
            this.label10.TabIndex = 55;
            this.label10.Text = "Lab";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(807, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 33);
            this.label7.TabIndex = 52;
            this.label7.Text = "Maximum Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(807, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 33);
            this.label6.TabIndex = 51;
            this.label6.Text = "Trainer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 48;
            this.label3.Text = " Test Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 33);
            this.label2.TabIndex = 47;
            this.label2.Text = "Test Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(678, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 47);
            this.label1.TabIndex = 46;
            this.label1.Text = "Edit Test";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(754, 592);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(202, 51);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTest.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.Location = new System.Drawing.Point(516, 592);
            this.btnAddTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(202, 51);
            this.btnAddTest.TabIndex = 72;
            this.btnAddTest.Text = "Edit Test";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // cmbbxTestName
            // 
            this.cmbbxTestName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestName.FormattingEnabled = true;
            this.cmbbxTestName.Location = new System.Drawing.Point(424, 166);
            this.cmbbxTestName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestName.Name = "cmbbxTestName";
            this.cmbbxTestName.Size = new System.Drawing.Size(192, 35);
            this.cmbbxTestName.TabIndex = 74;
            this.cmbbxTestName.SelectedIndexChanged += new System.EventHandler(this.cmbbxTestName_SelectedIndexChanged);
            // 
            // cmbbxTestBatchName
            // 
            this.cmbbxTestBatchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestBatchName.FormattingEnabled = true;
            this.cmbbxTestBatchName.Location = new System.Drawing.Point(424, 352);
            this.cmbbxTestBatchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestBatchName.Name = "cmbbxTestBatchName";
            this.cmbbxTestBatchName.Size = new System.Drawing.Size(192, 35);
            this.cmbbxTestBatchName.TabIndex = 78;
            // 
            // cmbbxTestCourseName
            // 
            this.cmbbxTestCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestCourseName.FormattingEnabled = true;
            this.cmbbxTestCourseName.Location = new System.Drawing.Point(424, 291);
            this.cmbbxTestCourseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestCourseName.Name = "cmbbxTestCourseName";
            this.cmbbxTestCourseName.Size = new System.Drawing.Size(192, 35);
            this.cmbbxTestCourseName.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 33);
            this.label5.TabIndex = 76;
            this.label5.Text = "Batch Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 33);
            this.label4.TabIndex = 75;
            this.label4.Text = "Course Name";
            // 
            // cmbbxTestDuration
            // 
            this.cmbbxTestDuration.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestDuration.FormattingEnabled = true;
            this.cmbbxTestDuration.Items.AddRange(new object[] {
            "01:00 hr",
            "02:00 hr",
            "03:00 hr",
            "01:30 hr",
            "02:30 hr",
            "03:00 hr"});
            this.cmbbxTestDuration.Location = new System.Drawing.Point(426, 480);
            this.cmbbxTestDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestDuration.Name = "cmbbxTestDuration";
            this.cmbbxTestDuration.Size = new System.Drawing.Size(102, 35);
            this.cmbbxTestDuration.TabIndex = 81;
            this.cmbbxTestDuration.SelectedIndexChanged += new System.EventHandler(this.cmbbxTestDuration_SelectedIndexChanged);
            this.cmbbxTestDuration.Leave += new System.EventHandler(this.cmbbxTestDuration_Leave);
            this.cmbbxTestDuration.Validating += new System.ComponentModel.CancelEventHandler(this.cmbbxTestDuration_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 475);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 33);
            this.label9.TabIndex = 80;
            this.label9.Text = "Duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 33);
            this.label8.TabIndex = 79;
            this.label8.Text = "Start Time";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadFile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.Location = new System.Drawing.Point(1190, 298);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(188, 49);
            this.btnUploadFile.TabIndex = 85;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // txtTestSelectFile
            // 
            this.txtTestSelectFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestSelectFile.Location = new System.Drawing.Point(1053, 298);
            this.txtTestSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTestSelectFile.Name = "txtTestSelectFile";
            this.txtTestSelectFile.Size = new System.Drawing.Size(126, 35);
            this.txtTestSelectFile.TabIndex = 84;
            this.txtTestSelectFile.Leave += new System.EventHandler(this.txtTestSelectFile_Leave);
            this.txtTestSelectFile.Validating += new System.ComponentModel.CancelEventHandler(this.txtTestSelectFile_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(807, 302);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 33);
            this.label12.TabIndex = 83;
            this.label12.Text = "Select File";
            // 
            // cmbbxSTime
            // 
            this.cmbbxSTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSTime.FormattingEnabled = true;
            this.cmbbxSTime.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "01:00",
            "02:00",
            "03:00"});
            this.cmbbxSTime.Location = new System.Drawing.Point(426, 418);
            this.cmbbxSTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxSTime.Name = "cmbbxSTime";
            this.cmbbxSTime.Size = new System.Drawing.Size(102, 35);
            this.cmbbxSTime.TabIndex = 86;
            this.cmbbxSTime.Leave += new System.EventHandler(this.cmbbxSTime_Leave);
            this.cmbbxSTime.Validating += new System.ComponentModel.CancelEventHandler(this.cmbbxSTime_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(855, 603);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 87;
            this.label14.Text = "label14";
            // 
            // errorProviderEditStime
            // 
            this.errorProviderEditStime.ContainerControl = this;
            // 
            // errorProviderDuration
            // 
            this.errorProviderDuration.ContainerControl = this;
            // 
            // errorProviderMarks
            // 
            this.errorProviderMarks.ContainerControl = this;
            // 
            // errorProviderSelectFile
            // 
            this.errorProviderSelectFile.ContainerControl = this;
            // 
            // errorProvider1Date
            // 
            this.errorProvider1Date.ContainerControl = this;
            // 
            // frmEditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1534, 734);
            this.Controls.Add(this.cmbbxSTime);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.txtTestSelectFile);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbbxTestDuration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbbxTestBatchName);
            this.Controls.Add(this.cmbbxTestCourseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbbxTestName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.dateTimePicker1TestDate);
            this.Controls.Add(this.cmbbxTestStatus);
            this.Controls.Add(this.cmbbxTestLab);
            this.Controls.Add(this.cmbbxTestTrainer);
            this.Controls.Add(this.txtMaximumMarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Test";
            this.Load += new System.EventHandler(this.frmEditTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditStime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSelectFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1TestDate;
        private System.Windows.Forms.ComboBox cmbbxTestStatus;
        private System.Windows.Forms.ComboBox cmbbxTestLab;
        private System.Windows.Forms.ComboBox cmbbxTestTrainer;
        private System.Windows.Forms.TextBox txtMaximumMarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.ComboBox cmbbxTestName;
        private System.Windows.Forms.ComboBox cmbbxTestBatchName;
        private System.Windows.Forms.ComboBox cmbbxTestCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbxTestDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.TextBox txtTestSelectFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbbxSTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProviderEditStime;
        private System.Windows.Forms.ErrorProvider errorProviderDuration;
        private System.Windows.Forms.ErrorProvider errorProviderMarks;
        private System.Windows.Forms.ErrorProvider errorProviderSelectFile;
        private System.Windows.Forms.ErrorProvider errorProvider1Date;
    }
}