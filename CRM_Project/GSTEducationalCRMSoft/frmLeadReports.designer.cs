namespace GSTEducationalCRMSoft
{
    partial class frmLeadReports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdLeadReport = new System.Windows.Forms.DataGridView();
            this.pictbxSearch1 = new System.Windows.Forms.PictureBox();
            this.pictbxCalender2 = new System.Windows.Forms.PictureBox();
            this.pictbxCalender1 = new System.Windows.Forms.PictureBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.datePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picbxSearch = new System.Windows.Forms.PictureBox();
            this.picbxFilters = new System.Windows.Forms.PictureBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.cmbbxEnquirySource = new System.Windows.Forms.ComboBox();
            this.cmbbxEnquiryStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxInterestedCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbxQualification = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLeadReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSearch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.grdLeadReport);
            this.panel1.Controls.Add(this.pictbxSearch1);
            this.panel1.Controls.Add(this.pictbxCalender2);
            this.panel1.Controls.Add(this.pictbxCalender1);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.datePickerToDate);
            this.panel1.Controls.Add(this.datePickerFromDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.picbxSearch);
            this.panel1.Controls.Add(this.picbxFilters);
            this.panel1.Controls.Add(this.btnFilters);
            this.panel1.Controls.Add(this.cmbbxEnquirySource);
            this.panel1.Controls.Add(this.cmbbxEnquiryStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbbxInterestedCourse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbbxQualification);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1731, 1001);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grdLeadReport
            // 
            this.grdLeadReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLeadReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLeadReport.Location = new System.Drawing.Point(66, 426);
            this.grdLeadReport.Name = "grdLeadReport";
            this.grdLeadReport.RowHeadersVisible = false;
            this.grdLeadReport.RowHeadersWidth = 51;
            this.grdLeadReport.RowTemplate.Height = 24;
            this.grdLeadReport.Size = new System.Drawing.Size(1230, 499);
            this.grdLeadReport.TabIndex = 39;
            // 
            // pictbxSearch1
            // 
            this.pictbxSearch1.BackColor = System.Drawing.Color.Transparent;
            this.pictbxSearch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxSearch1.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.pictbxSearch1.Location = new System.Drawing.Point(778, 357);
            this.pictbxSearch1.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxSearch1.Name = "pictbxSearch1";
            this.pictbxSearch1.Size = new System.Drawing.Size(32, 28);
            this.pictbxSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxSearch1.TabIndex = 38;
            this.pictbxSearch1.TabStop = false;
            this.pictbxSearch1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictbxCalender2
            // 
            this.pictbxCalender2.BackColor = System.Drawing.Color.Transparent;
            this.pictbxCalender2.Image = global::GSTEducationalCRMSoft.Properties.Resources.calendar;
            this.pictbxCalender2.Location = new System.Drawing.Point(729, 355);
            this.pictbxCalender2.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxCalender2.Name = "pictbxCalender2";
            this.pictbxCalender2.Size = new System.Drawing.Size(32, 28);
            this.pictbxCalender2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxCalender2.TabIndex = 37;
            this.pictbxCalender2.TabStop = false;
            // 
            // pictbxCalender1
            // 
            this.pictbxCalender1.BackColor = System.Drawing.Color.Transparent;
            this.pictbxCalender1.Image = global::GSTEducationalCRMSoft.Properties.Resources.calendar;
            this.pictbxCalender1.Location = new System.Drawing.Point(412, 354);
            this.pictbxCalender1.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxCalender1.Name = "pictbxCalender1";
            this.pictbxCalender1.Size = new System.Drawing.Size(32, 28);
            this.pictbxCalender1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxCalender1.TabIndex = 36;
            this.pictbxCalender1.TabStop = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblEndDate.Location = new System.Drawing.Point(457, 355);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(100, 27);
            this.lblEndDate.TabIndex = 35;
            this.lblEndDate.Text = "To Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(89, 360);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(132, 27);
            this.lblStartDate.TabIndex = 34;
            this.lblStartDate.Text = "From Date:";
            // 
            // datePickerToDate
            // 
            this.datePickerToDate.CustomFormat = "yyyy-mm-dd";
            this.datePickerToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerToDate.Location = new System.Drawing.Point(582, 354);
            this.datePickerToDate.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerToDate.Name = "datePickerToDate";
            this.datePickerToDate.Size = new System.Drawing.Size(131, 30);
            this.datePickerToDate.TabIndex = 33;
            this.datePickerToDate.Value = new System.DateTime(2022, 7, 2, 19, 57, 4, 0);
            // 
            // datePickerFromDate
            // 
            this.datePickerFromDate.CustomFormat = "yyyy-mm-dd";
            this.datePickerFromDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFromDate.Location = new System.Drawing.Point(256, 353);
            this.datePickerFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerFromDate.Name = "datePickerFromDate";
            this.datePickerFromDate.Size = new System.Drawing.Size(136, 30);
            this.datePickerFromDate.TabIndex = 32;
            this.datePickerFromDate.Value = new System.DateTime(2022, 7, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lead Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(217, 103);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 42);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // picbxSearch
            // 
            this.picbxSearch.BackColor = System.Drawing.Color.Transparent;
            this.picbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxSearch.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.picbxSearch.Location = new System.Drawing.Point(173, 103);
            this.picbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.picbxSearch.Name = "picbxSearch";
            this.picbxSearch.Size = new System.Drawing.Size(40, 40);
            this.picbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxSearch.TabIndex = 30;
            this.picbxSearch.TabStop = false;
            // 
            // picbxFilters
            // 
            this.picbxFilters.Image = global::GSTEducationalCRMSoft.Properties.Resources.filter3;
            this.picbxFilters.Location = new System.Drawing.Point(564, 111);
            this.picbxFilters.Margin = new System.Windows.Forms.Padding(2);
            this.picbxFilters.Name = "picbxFilters";
            this.picbxFilters.Size = new System.Drawing.Size(32, 25);
            this.picbxFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxFilters.TabIndex = 28;
            this.picbxFilters.TabStop = false;
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(552, 103);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(132, 40);
            this.btnFilters.TabIndex = 27;
            this.btnFilters.Text = "Filters";
            this.btnFilters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilters.UseVisualStyleBackColor = false;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // cmbbxEnquirySource
            // 
            this.cmbbxEnquirySource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxEnquirySource.FormattingEnabled = true;
            this.cmbbxEnquirySource.Location = new System.Drawing.Point(869, 276);
            this.cmbbxEnquirySource.Name = "cmbbxEnquirySource";
            this.cmbbxEnquirySource.Size = new System.Drawing.Size(166, 33);
            this.cmbbxEnquirySource.TabIndex = 23;
            this.cmbbxEnquirySource.SelectedIndexChanged += new System.EventHandler(this.cmbbxEnquirySource_SelectedIndexChanged);
            // 
            // cmbbxEnquiryStatus
            // 
            this.cmbbxEnquiryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxEnquiryStatus.FormattingEnabled = true;
            this.cmbbxEnquiryStatus.Location = new System.Drawing.Point(364, 272);
            this.cmbbxEnquiryStatus.Name = "cmbbxEnquiryStatus";
            this.cmbbxEnquiryStatus.Size = new System.Drawing.Size(193, 33);
            this.cmbbxEnquiryStatus.TabIndex = 24;
            this.cmbbxEnquiryStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxEnquiryStatus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enquiry Source:";
            // 
            // cmbbxInterestedCourse
            // 
            this.cmbbxInterestedCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxInterestedCourse.FormattingEnabled = true;
            this.cmbbxInterestedCourse.Location = new System.Drawing.Point(365, 185);
            this.cmbbxInterestedCourse.Name = "cmbbxInterestedCourse";
            this.cmbbxInterestedCourse.Size = new System.Drawing.Size(192, 33);
            this.cmbbxInterestedCourse.TabIndex = 21;
            this.cmbbxInterestedCourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxInterestedCourse_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Interested Course:";
            // 
            // cmbbxQualification
            // 
            this.cmbbxQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxQualification.FormattingEnabled = true;
            this.cmbbxQualification.Location = new System.Drawing.Point(869, 185);
            this.cmbbxQualification.Name = "cmbbxQualification";
            this.cmbbxQualification.Size = new System.Drawing.Size(166, 33);
            this.cmbbxQualification.TabIndex = 22;
            this.cmbbxQualification.SelectedIndexChanged += new System.EventHandler(this.cmbbxQualification_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enquiry Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Qualification:";
            // 
            // frmLeadReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1731, 1001);
            this.Controls.Add(this.panel1);
            this.Name = "frmLeadReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lead Reports Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLeadReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLeadReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSearch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbbxEnquirySource;
        private System.Windows.Forms.ComboBox cmbbxEnquiryStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxInterestedCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbxQualification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picbxFilters;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picbxSearch;
        private System.Windows.Forms.PictureBox pictbxSearch1;
        private System.Windows.Forms.PictureBox pictbxCalender2;
        private System.Windows.Forms.PictureBox pictbxCalender1;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker datePickerToDate;
        private System.Windows.Forms.DateTimePicker datePickerFromDate;
        private System.Windows.Forms.DataGridView grdLeadReport;
    }
}