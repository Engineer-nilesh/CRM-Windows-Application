namespace GSTEducationalCRMSoft
{
    partial class frmCertification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.cmbbxCourseName = new System.Windows.Forms.ComboBox();
            this.cmbbxStudentName = new System.Windows.Forms.ComboBox();
            this.grdCertificationView = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictbxExcel = new System.Windows.Forms.PictureBox();
            this.pictbxPDF = new System.Windows.Forms.PictureBox();
            this.pictbxPlus = new System.Windows.Forms.PictureBox();
            this.picbxFilters = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.picbxSearch = new System.Windows.Forms.PictureBox();
            this.btnNewTestimonial = new System.Windows.Forms.Button();
            this.picbxDelete = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSMS = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdCertificationView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(78, 206);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(173, 27);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(83, 282);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 27);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(501, 208);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(181, 27);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Name :";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(164, 282);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(376, 30);
            this.dateTimePickerDate.TabIndex = 3;
            // 
            // cmbbxCourseName
            // 
            this.cmbbxCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCourseName.FormattingEnabled = true;
            this.cmbbxCourseName.Location = new System.Drawing.Point(268, 206);
            this.cmbbxCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxCourseName.Name = "cmbbxCourseName";
            this.cmbbxCourseName.Size = new System.Drawing.Size(180, 31);
            this.cmbbxCourseName.TabIndex = 4;
            this.cmbbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourseName_SelectedIndexChanged);
            // 
            // cmbbxStudentName
            // 
            this.cmbbxStudentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxStudentName.FormattingEnabled = true;
            this.cmbbxStudentName.Location = new System.Drawing.Point(701, 208);
            this.cmbbxStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxStudentName.Name = "cmbbxStudentName";
            this.cmbbxStudentName.Size = new System.Drawing.Size(168, 31);
            this.cmbbxStudentName.TabIndex = 5;
            this.cmbbxStudentName.SelectedIndexChanged += new System.EventHandler(this.cmbbxStudentName_SelectedIndexChanged);
            // 
            // grdCertificationView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCertificationView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCertificationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCertificationView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox});
            this.grdCertificationView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdCertificationView.Location = new System.Drawing.Point(188, 353);
            this.grdCertificationView.Margin = new System.Windows.Forms.Padding(2);
            this.grdCertificationView.Name = "grdCertificationView";
            this.grdCertificationView.RowHeadersVisible = false;
            this.grdCertificationView.RowHeadersWidth = 82;
            this.grdCertificationView.RowTemplate.Height = 33;
            this.grdCertificationView.Size = new System.Drawing.Size(741, 395);
            this.grdCertificationView.TabIndex = 6;
            this.grdCertificationView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCertificationView_CellContentClick);
            // 
            // checkbox
            // 
            this.checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkbox.HeaderText = "";
            this.checkbox.MinimumWidth = 8;
            this.checkbox.Name = "checkbox";
            // 
            // pictbxExcel
            // 
            this.pictbxExcel.BackColor = System.Drawing.Color.Transparent;
            this.pictbxExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxExcel.Image = global::GSTEducationalCRMSoft.Properties.Resources.ms_excel;
            this.pictbxExcel.Location = new System.Drawing.Point(686, 124);
            this.pictbxExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictbxExcel.Name = "pictbxExcel";
            this.pictbxExcel.Size = new System.Drawing.Size(44, 39);
            this.pictbxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxExcel.TabIndex = 31;
            this.pictbxExcel.TabStop = false;
            this.toolTip1.SetToolTip(this.pictbxExcel, "Excel Button");
            this.pictbxExcel.Click += new System.EventHandler(this.pictbxExcel_Click);
            // 
            // pictbxPDF
            // 
            this.pictbxPDF.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPDF.Image = global::GSTEducationalCRMSoft.Properties.Resources.pdf;
            this.pictbxPDF.Location = new System.Drawing.Point(638, 124);
            this.pictbxPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictbxPDF.Name = "pictbxPDF";
            this.pictbxPDF.Size = new System.Drawing.Size(43, 39);
            this.pictbxPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPDF.TabIndex = 30;
            this.pictbxPDF.TabStop = false;
            this.toolTip1.SetToolTip(this.pictbxPDF, "PDF Button");
            this.pictbxPDF.Click += new System.EventHandler(this.pictbxPDF_Click);
            // 
            // pictbxPlus
            // 
            this.pictbxPlus.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPlus.Image = global::GSTEducationalCRMSoft.Properties.Resources.plus1;
            this.pictbxPlus.Location = new System.Drawing.Point(381, 132);
            this.pictbxPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictbxPlus.Name = "pictbxPlus";
            this.pictbxPlus.Size = new System.Drawing.Size(35, 25);
            this.pictbxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPlus.TabIndex = 29;
            this.pictbxPlus.TabStop = false;
            // 
            // picbxFilters
            // 
            this.picbxFilters.BackColor = System.Drawing.Color.Transparent;
            this.picbxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxFilters.Image = global::GSTEducationalCRMSoft.Properties.Resources.filter3;
            this.picbxFilters.Location = new System.Drawing.Point(1044, 132);
            this.picbxFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbxFilters.Name = "picbxFilters";
            this.picbxFilters.Size = new System.Drawing.Size(35, 25);
            this.picbxFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxFilters.TabIndex = 28;
            this.picbxFilters.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(116, 124);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 40);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(1031, 124);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(141, 39);
            this.btnFilters.TabIndex = 27;
            this.btnFilters.Text = "Filters";
            this.btnFilters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilters.UseVisualStyleBackColor = false;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // picbxSearch
            // 
            this.picbxSearch.BackColor = System.Drawing.Color.Transparent;
            this.picbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxSearch.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.picbxSearch.Location = new System.Drawing.Point(610, 282);
            this.picbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbxSearch.Name = "picbxSearch";
            this.picbxSearch.Size = new System.Drawing.Size(35, 30);
            this.picbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxSearch.TabIndex = 23;
            this.picbxSearch.TabStop = false;
            this.picbxSearch.Click += new System.EventHandler(this.picbxSearch_Click);
            // 
            // btnNewTestimonial
            // 
            this.btnNewTestimonial.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTestimonial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewTestimonial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTestimonial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTestimonial.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTestimonial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewTestimonial.Location = new System.Drawing.Point(365, 124);
            this.btnNewTestimonial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewTestimonial.Name = "btnNewTestimonial";
            this.btnNewTestimonial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNewTestimonial.Size = new System.Drawing.Size(249, 39);
            this.btnNewTestimonial.TabIndex = 24;
            this.btnNewTestimonial.Text = "Add Certificate ";
            this.btnNewTestimonial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewTestimonial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTestimonial.UseVisualStyleBackColor = false;
            this.btnNewTestimonial.Click += new System.EventHandler(this.btnNewTestimonial_Click);
            // 
            // picbxDelete
            // 
            this.picbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.picbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxDelete.Image = global::GSTEducationalCRMSoft.Properties.Resources.delete4;
            this.picbxDelete.Location = new System.Drawing.Point(756, 132);
            this.picbxDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbxDelete.Name = "picbxDelete";
            this.picbxDelete.Size = new System.Drawing.Size(35, 25);
            this.picbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxDelete.TabIndex = 26;
            this.picbxDelete.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(745, 124);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 39);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 49);
            this.label1.TabIndex = 32;
            this.label1.Text = "Certification";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GSTEducationalCRMSoft.Properties.Resources.SMS;
            this.pictureBox1.Location = new System.Drawing.Point(908, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnSMS
            // 
            this.btnSMS.BackColor = System.Drawing.Color.Transparent;
            this.btnSMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMS.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMS.Location = new System.Drawing.Point(894, 124);
            this.btnSMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(121, 39);
            this.btnSMS.TabIndex = 33;
            this.btnSMS.Text = "SMS";
            this.btnSMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSMS.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GSTEducationalCRMSoft.Properties.Resources.calendar2;
            this.pictureBox2.Location = new System.Drawing.Point(556, 282);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "PDF Button");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(70, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 66;
            this.pictureBox3.TabStop = false;
            // 
            // frmCertification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 781);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSMS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictbxExcel);
            this.Controls.Add(this.pictbxPDF);
            this.Controls.Add(this.pictbxPlus);
            this.Controls.Add(this.picbxFilters);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.picbxSearch);
            this.Controls.Add(this.btnNewTestimonial);
            this.Controls.Add(this.picbxDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdCertificationView);
            this.Controls.Add(this.cmbbxStudentName);
            this.Controls.Add(this.cmbbxCourseName);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCourseName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCertification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCertification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCertificationView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox cmbbxCourseName;
        private System.Windows.Forms.ComboBox cmbbxStudentName;
        private System.Windows.Forms.DataGridView grdCertificationView;
        private System.Windows.Forms.PictureBox pictbxExcel;
        private System.Windows.Forms.PictureBox pictbxPDF;
        private System.Windows.Forms.PictureBox pictbxPlus;
        private System.Windows.Forms.PictureBox picbxFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.PictureBox picbxSearch;
        private System.Windows.Forms.Button btnNewTestimonial;
        private System.Windows.Forms.PictureBox picbxDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSMS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}