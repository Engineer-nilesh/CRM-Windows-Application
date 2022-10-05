namespace GSTEducationalCRMSoft
{
    partial class frmAddNewTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.cmbbxTestCourseName = new System.Windows.Forms.ComboBox();
            this.cmbbxTestBatchName = new System.Windows.Forms.ComboBox();
            this.cmbbxTestTrainer = new System.Windows.Forms.ComboBox();
            this.cmbbxTestLab = new System.Windows.Forms.ComboBox();
            this.cmbbxTestStatus = new System.Windows.Forms.ComboBox();
            this.txtTestSelectFile = new System.Windows.Forms.TextBox();
            this.dateTimePicker1TestDate = new System.Windows.Forms.DateTimePicker();
            this.cmbbxTestDuration = new System.Windows.Forms.ComboBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbbxStartTime = new System.Windows.Forms.ComboBox();
            this.errorProviderTestName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMarks = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSelectFile = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDuration = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtmmarks = new System.Windows.Forms.TextBox();
            this.errorProviderCourseName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTestName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSelectFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCourseName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Test Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = " Test Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Course Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 430);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Batch Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 522);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 33);
            this.label6.TabIndex = 22;
            this.label6.Text = "Trainer :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 621);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 33);
            this.label7.TabIndex = 23;
            this.label7.Text = "Maximum Marks :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1018, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 33);
            this.label8.TabIndex = 24;
            this.label8.Text = "Start Time :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1042, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 33);
            this.label9.TabIndex = 25;
            this.label9.Text = "Duration :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1104, 335);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 33);
            this.label10.TabIndex = 26;
            this.label10.Text = "Lab :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1070, 430);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 33);
            this.label11.TabIndex = 27;
            this.label11.Text = "Status :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1015, 522);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 33);
            this.label12.TabIndex = 28;
            this.label12.Text = "Select File :";
            // 
            // txtTestName
            // 
            this.txtTestName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestName.Location = new System.Drawing.Point(647, 160);
            this.txtTestName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(288, 35);
            this.txtTestName.TabIndex = 29;
            this.txtTestName.TextChanged += new System.EventHandler(this.txtTestName_TextChanged);
            this.txtTestName.Leave += new System.EventHandler(this.txtTestName_Leave);
            this.txtTestName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTestName_Validating);
            // 
            // cmbbxTestCourseName
            // 
            this.cmbbxTestCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestCourseName.FormattingEnabled = true;
            this.cmbbxTestCourseName.Location = new System.Drawing.Point(647, 333);
            this.cmbbxTestCourseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestCourseName.Name = "cmbbxTestCourseName";
            this.cmbbxTestCourseName.Size = new System.Drawing.Size(288, 35);
            this.cmbbxTestCourseName.TabIndex = 31;
            this.cmbbxTestCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxTestCourseName_SelectedIndexChanged);
            this.cmbbxTestCourseName.Leave += new System.EventHandler(this.cmbbxTestCourseName_Leave);
            // 
            // cmbbxTestBatchName
            // 
            this.cmbbxTestBatchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestBatchName.FormattingEnabled = true;
            this.cmbbxTestBatchName.Location = new System.Drawing.Point(647, 428);
            this.cmbbxTestBatchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestBatchName.Name = "cmbbxTestBatchName";
            this.cmbbxTestBatchName.Size = new System.Drawing.Size(288, 35);
            this.cmbbxTestBatchName.TabIndex = 32;
            this.cmbbxTestBatchName.SelectedIndexChanged += new System.EventHandler(this.cmbbxTestBatchName_SelectedIndexChanged);
            // 
            // cmbbxTestTrainer
            // 
            this.cmbbxTestTrainer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestTrainer.FormattingEnabled = true;
            this.cmbbxTestTrainer.Location = new System.Drawing.Point(647, 520);
            this.cmbbxTestTrainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestTrainer.Name = "cmbbxTestTrainer";
            this.cmbbxTestTrainer.Size = new System.Drawing.Size(288, 35);
            this.cmbbxTestTrainer.TabIndex = 33;
            // 
            // cmbbxTestLab
            // 
            this.cmbbxTestLab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestLab.FormattingEnabled = true;
            this.cmbbxTestLab.Location = new System.Drawing.Point(1202, 333);
            this.cmbbxTestLab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestLab.Name = "cmbbxTestLab";
            this.cmbbxTestLab.Size = new System.Drawing.Size(187, 35);
            this.cmbbxTestLab.TabIndex = 34;
            // 
            // cmbbxTestStatus
            // 
            this.cmbbxTestStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestStatus.FormattingEnabled = true;
            this.cmbbxTestStatus.Location = new System.Drawing.Point(1202, 428);
            this.cmbbxTestStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestStatus.Name = "cmbbxTestStatus";
            this.cmbbxTestStatus.Size = new System.Drawing.Size(187, 35);
            this.cmbbxTestStatus.TabIndex = 35;
            // 
            // txtTestSelectFile
            // 
            this.txtTestSelectFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestSelectFile.Location = new System.Drawing.Point(1202, 520);
            this.txtTestSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTestSelectFile.Name = "txtTestSelectFile";
            this.txtTestSelectFile.Size = new System.Drawing.Size(187, 35);
            this.txtTestSelectFile.TabIndex = 36;
            this.txtTestSelectFile.Leave += new System.EventHandler(this.txtTestSelectFile_Leave);
            this.txtTestSelectFile.Validating += new System.ComponentModel.CancelEventHandler(this.txtTestSelectFile_Validating);
            // 
            // dateTimePicker1TestDate
            // 
            this.dateTimePicker1TestDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1TestDate.Location = new System.Drawing.Point(647, 248);
            this.dateTimePicker1TestDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1TestDate.Name = "dateTimePicker1TestDate";
            this.dateTimePicker1TestDate.Size = new System.Drawing.Size(288, 35);
            this.dateTimePicker1TestDate.TabIndex = 37;
            // 
            // cmbbxTestDuration
            // 
            this.cmbbxTestDuration.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestDuration.FormattingEnabled = true;
            this.cmbbxTestDuration.Items.AddRange(new object[] {
            "01:00 hr",
            "01:30 hr",
            "00:30 hr",
            "02:00 hr"});
            this.cmbbxTestDuration.Location = new System.Drawing.Point(1202, 248);
            this.cmbbxTestDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxTestDuration.Name = "cmbbxTestDuration";
            this.cmbbxTestDuration.Size = new System.Drawing.Size(187, 35);
            this.cmbbxTestDuration.TabIndex = 39;
            this.cmbbxTestDuration.Leave += new System.EventHandler(this.cmbbxTestDuration_Leave);
            this.cmbbxTestDuration.Validating += new System.ComponentModel.CancelEventHandler(this.cmbbxTestDuration_Validating);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadFile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.Location = new System.Drawing.Point(1420, 508);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(187, 52);
            this.btnUploadFile.TabIndex = 40;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTest.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.Location = new System.Drawing.Point(807, 704);
            this.btnAddTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(201, 54);
            this.btnAddTest.TabIndex = 41;
            this.btnAddTest.Text = "Add Test";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1048, 704);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 54);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cmbbxStartTime
            // 
            this.cmbbxStartTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxStartTime.FormattingEnabled = true;
            this.cmbbxStartTime.Items.AddRange(new object[] {
            "10:00AM",
            "11:00AM",
            "12:00PM",
            "01:00PM",
            "2:00PM",
            "3:00PM",
            "4:00PM",
            "5:00PM"});
            this.cmbbxStartTime.Location = new System.Drawing.Point(1202, 160);
            this.cmbbxStartTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxStartTime.Name = "cmbbxStartTime";
            this.cmbbxStartTime.Size = new System.Drawing.Size(187, 35);
            this.cmbbxStartTime.TabIndex = 45;
            this.cmbbxStartTime.Leave += new System.EventHandler(this.cmbbxStartTime_Leave);
            this.cmbbxStartTime.Validating += new System.ComponentModel.CancelEventHandler(this.cmbbxStartTime_Validating);
            // 
            // errorProviderTestName
            // 
            this.errorProviderTestName.ContainerControl = this;
            // 
            // errorProviderMarks
            // 
            this.errorProviderMarks.ContainerControl = this;
            // 
            // errorProviderSelectFile
            // 
            this.errorProviderSelectFile.ContainerControl = this;
            // 
            // errorProviderDuration
            // 
            this.errorProviderDuration.ContainerControl = this;
            // 
            // errorProviderSTime
            // 
            this.errorProviderSTime.ContainerControl = this;
            // 
            // txtmmarks
            // 
            this.txtmmarks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmmarks.Location = new System.Drawing.Point(647, 619);
            this.txtmmarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmmarks.Name = "txtmmarks";
            this.txtmmarks.Size = new System.Drawing.Size(124, 35);
            this.txtmmarks.TabIndex = 47;
            this.txtmmarks.Leave += new System.EventHandler(this.txtmmarks_Leave);
            this.txtmmarks.Validating += new System.ComponentModel.CancelEventHandler(this.txtmmarks_Validating);
            // 
            // errorProviderCourseName
            // 
            this.errorProviderCourseName.ContainerControl = this;
            // 
            // frmAddNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 825);
            this.Controls.Add(this.txtmmarks);
            this.Controls.Add(this.cmbbxStartTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.cmbbxTestDuration);
            this.Controls.Add(this.dateTimePicker1TestDate);
            this.Controls.Add(this.txtTestSelectFile);
            this.Controls.Add(this.cmbbxTestStatus);
            this.Controls.Add(this.cmbbxTestLab);
            this.Controls.Add(this.cmbbxTestTrainer);
            this.Controls.Add(this.cmbbxTestBatchName);
            this.Controls.Add(this.cmbbxTestCourseName);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 209);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddNewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddNewTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTestName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSelectFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCourseName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.ComboBox cmbbxTestCourseName;
        private System.Windows.Forms.ComboBox cmbbxTestBatchName;
        private System.Windows.Forms.ComboBox cmbbxTestTrainer;
        private System.Windows.Forms.ComboBox cmbbxTestLab;
        private System.Windows.Forms.ComboBox cmbbxTestStatus;
        private System.Windows.Forms.TextBox txtTestSelectFile;
        private System.Windows.Forms.DateTimePicker dateTimePicker1TestDate;
        private System.Windows.Forms.ComboBox cmbbxTestDuration;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbbxStartTime;
        private System.Windows.Forms.ErrorProvider errorProviderTestName;
        private System.Windows.Forms.ErrorProvider errorProviderMarks;
        private System.Windows.Forms.ErrorProvider errorProviderSelectFile;
        private System.Windows.Forms.ErrorProvider errorProviderDuration;
        private System.Windows.Forms.ErrorProvider errorProviderSTime;
        private System.Windows.Forms.TextBox txtmmarks;
        private System.Windows.Forms.ErrorProvider errorProviderCourseName;
    }
}