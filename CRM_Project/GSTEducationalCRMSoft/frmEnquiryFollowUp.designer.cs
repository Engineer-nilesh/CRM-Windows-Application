namespace GSTEducationalCRMSoft
{
    partial class frmEnquiryFollowUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictbxExel = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMoveToAdmission = new System.Windows.Forms.Button();
            this.pictbxCalender2 = new System.Windows.Forms.PictureBox();
            this.pictbxCalender1 = new System.Windows.Forms.PictureBox();
            this.grdEnquiryFollowUp = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddFollowUp = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictbxFilters = new System.Windows.Forms.PictureBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.pictMail = new System.Windows.Forms.PictureBox();
            this.btnMail = new System.Windows.Forms.Button();
            this.pictbxDelete = new System.Windows.Forms.PictureBox();
            this.btnDelet = new System.Windows.Forms.Button();
            this.pictbxRefresh2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictbxSearch2 = new System.Windows.Forms.PictureBox();
            this.cmbbxEnquiryStatus = new System.Windows.Forms.ComboBox();
            this.lblEnquiryStatus = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblEnquiryFollowUp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEnquiryFollowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxRefresh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSearch2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GSTEducationalCRMSoft.Properties.Resources.pdf;
            this.pictureBox1.Location = new System.Drawing.Point(408, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "PDF Buttton");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictbxExel
            // 
            this.pictbxExel.BackColor = System.Drawing.Color.Transparent;
            this.pictbxExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxExel.Image = global::GSTEducationalCRMSoft.Properties.Resources.ms_excel;
            this.pictbxExel.Location = new System.Drawing.Point(463, 122);
            this.pictbxExel.Name = "pictbxExel";
            this.pictbxExel.Size = new System.Drawing.Size(48, 42);
            this.pictbxExel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxExel.TabIndex = 13;
            this.pictbxExel.TabStop = false;
            this.toolTip1.SetToolTip(this.pictbxExel, "Excel Button");
            this.pictbxExel.Click += new System.EventHandler(this.pictbxExel_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnMoveToAdmission);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictbxCalender2);
            this.panel1.Controls.Add(this.pictbxCalender1);
            this.panel1.Controls.Add(this.grdEnquiryFollowUp);
            this.panel1.Controls.Add(this.pictbxFilters);
            this.panel1.Controls.Add(this.btnFilters);
            this.panel1.Controls.Add(this.pictMail);
            this.panel1.Controls.Add(this.btnMail);
            this.panel1.Controls.Add(this.pictbxDelete);
            this.panel1.Controls.Add(this.pictbxExel);
            this.panel1.Controls.Add(this.btnDelet);
            this.panel1.Controls.Add(this.pictbxRefresh2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictbxSearch2);
            this.panel1.Controls.Add(this.cmbbxEnquiryStatus);
            this.panel1.Controls.Add(this.lblEnquiryStatus);
            this.panel1.Controls.Add(this.lblToDate);
            this.panel1.Controls.Add(this.lblFromDate);
            this.panel1.Controls.Add(this.lblEnquiryFollowUp);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 950);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(68, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // btnMoveToAdmission
            // 
            this.btnMoveToAdmission.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveToAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveToAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveToAdmission.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToAdmission.ForeColor = System.Drawing.Color.Black;
            this.btnMoveToAdmission.Location = new System.Drawing.Point(961, 122);
            this.btnMoveToAdmission.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveToAdmission.Name = "btnMoveToAdmission";
            this.btnMoveToAdmission.Size = new System.Drawing.Size(264, 41);
            this.btnMoveToAdmission.TabIndex = 54;
            this.btnMoveToAdmission.Text = "Move To Admission";
            this.btnMoveToAdmission.UseVisualStyleBackColor = false;
            this.btnMoveToAdmission.Click += new System.EventHandler(this.btnMoveToAdmission_Click);
            // 
            // pictbxCalender2
            // 
            this.pictbxCalender2.Image = global::GSTEducationalCRMSoft.Properties.Resources.calendar1;
            this.pictbxCalender2.Location = new System.Drawing.Point(640, 240);
            this.pictbxCalender2.Name = "pictbxCalender2";
            this.pictbxCalender2.Size = new System.Drawing.Size(30, 28);
            this.pictbxCalender2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxCalender2.TabIndex = 25;
            this.pictbxCalender2.TabStop = false;
            // 
            // pictbxCalender1
            // 
            this.pictbxCalender1.Image = global::GSTEducationalCRMSoft.Properties.Resources.calendar1;
            this.pictbxCalender1.Location = new System.Drawing.Point(324, 240);
            this.pictbxCalender1.Name = "pictbxCalender1";
            this.pictbxCalender1.Size = new System.Drawing.Size(30, 28);
            this.pictbxCalender1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxCalender1.TabIndex = 24;
            this.pictbxCalender1.TabStop = false;
            // 
            // grdEnquiryFollowUp
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEnquiryFollowUp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEnquiryFollowUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEnquiryFollowUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.AddFollowUp});
            this.grdEnquiryFollowUp.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEnquiryFollowUp.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdEnquiryFollowUp.Location = new System.Drawing.Point(51, 383);
            this.grdEnquiryFollowUp.Name = "grdEnquiryFollowUp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEnquiryFollowUp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdEnquiryFollowUp.RowHeadersVisible = false;
            this.grdEnquiryFollowUp.RowHeadersWidth = 62;
            this.grdEnquiryFollowUp.Size = new System.Drawing.Size(1554, 534);
            this.grdEnquiryFollowUp.TabIndex = 3;
            this.grdEnquiryFollowUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CheckBox
            // 
            this.CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBox.Frozen = true;
            this.CheckBox.HeaderText = "";
            this.CheckBox.MinimumWidth = 6;
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 40;
            // 
            // AddFollowUp
            // 
            this.AddFollowUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AddFollowUp.HeaderText = "AddFollowUp";
            this.AddFollowUp.Image = global::GSTEducationalCRMSoft.Properties.Resources.AddFollowUp;
            this.AddFollowUp.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AddFollowUp.MinimumWidth = 8;
            this.AddFollowUp.Name = "AddFollowUp";
            this.AddFollowUp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddFollowUp.Width = 119;
            // 
            // pictbxFilters
            // 
            this.pictbxFilters.Image = global::GSTEducationalCRMSoft.Properties.Resources.filter3;
            this.pictbxFilters.Location = new System.Drawing.Point(812, 128);
            this.pictbxFilters.Name = "pictbxFilters";
            this.pictbxFilters.Size = new System.Drawing.Size(30, 27);
            this.pictbxFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxFilters.TabIndex = 23;
            this.pictbxFilters.TabStop = false;
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilters.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(796, 122);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(152, 42);
            this.btnFilters.TabIndex = 22;
            this.btnFilters.Text = "Filters";
            this.btnFilters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilters.UseVisualStyleBackColor = false;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // pictMail
            // 
            this.pictMail.Image = global::GSTEducationalCRMSoft.Properties.Resources.email;
            this.pictMail.Location = new System.Drawing.Point(686, 130);
            this.pictMail.Name = "pictMail";
            this.pictMail.Size = new System.Drawing.Size(30, 27);
            this.pictMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictMail.TabIndex = 21;
            this.pictMail.TabStop = false;
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMail.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.Location = new System.Drawing.Point(675, 122);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(112, 42);
            this.btnMail.TabIndex = 20;
            this.btnMail.Text = "Mail";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMail.UseVisualStyleBackColor = false;
            // 
            // pictbxDelete
            // 
            this.pictbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pictbxDelete.Image = global::GSTEducationalCRMSoft.Properties.Resources.delete4;
            this.pictbxDelete.Location = new System.Drawing.Point(533, 128);
            this.pictbxDelete.Name = "pictbxDelete";
            this.pictbxDelete.Size = new System.Drawing.Size(30, 28);
            this.pictbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxDelete.TabIndex = 16;
            this.pictbxDelete.TabStop = false;
            this.pictbxDelete.Click += new System.EventHandler(this.pictbxDelete_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.Transparent;
            this.btnDelet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelet.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelet.Location = new System.Drawing.Point(518, 122);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(147, 43);
            this.btnDelet.TabIndex = 15;
            this.btnDelet.Text = "Delete";
            this.btnDelet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // pictbxRefresh2
            // 
            this.pictbxRefresh2.BackColor = System.Drawing.Color.Transparent;
            this.pictbxRefresh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxRefresh2.Image = global::GSTEducationalCRMSoft.Properties.Resources.refresh2;
            this.pictbxRefresh2.Location = new System.Drawing.Point(333, 122);
            this.pictbxRefresh2.Name = "pictbxRefresh2";
            this.pictbxRefresh2.Size = new System.Drawing.Size(53, 42);
            this.pictbxRefresh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxRefresh2.TabIndex = 11;
            this.pictbxRefresh2.TabStop = false;
            this.pictbxRefresh2.Click += new System.EventHandler(this.pictbxRefresh2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(115, 123);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 41);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictbxSearch2
            // 
            this.pictbxSearch2.BackColor = System.Drawing.Color.Transparent;
            this.pictbxSearch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxSearch2.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.pictbxSearch2.Location = new System.Drawing.Point(694, 238);
            this.pictbxSearch2.Name = "pictbxSearch2";
            this.pictbxSearch2.Size = new System.Drawing.Size(37, 31);
            this.pictbxSearch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxSearch2.TabIndex = 9;
            this.pictbxSearch2.TabStop = false;
            this.pictbxSearch2.Click += new System.EventHandler(this.pictbxSearch2_Click);
            // 
            // cmbbxEnquiryStatus
            // 
            this.cmbbxEnquiryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxEnquiryStatus.FormattingEnabled = true;
            this.cmbbxEnquiryStatus.Location = new System.Drawing.Point(69, 330);
            this.cmbbxEnquiryStatus.Name = "cmbbxEnquiryStatus";
            this.cmbbxEnquiryStatus.Size = new System.Drawing.Size(239, 33);
            this.cmbbxEnquiryStatus.TabIndex = 6;
            this.cmbbxEnquiryStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEnquiryStatus
            // 
            this.lblEnquiryStatus.AutoSize = true;
            this.lblEnquiryStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblEnquiryStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnquiryStatus.Location = new System.Drawing.Point(74, 289);
            this.lblEnquiryStatus.Name = "lblEnquiryStatus";
            this.lblEnquiryStatus.Size = new System.Drawing.Size(171, 27);
            this.lblEnquiryStatus.TabIndex = 5;
            this.lblEnquiryStatus.Text = "Enquiry Status";
            this.lblEnquiryStatus.Click += new System.EventHandler(this.lblEnquiryStatus_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblToDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(388, 200);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(86, 27);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "ToDate";
            this.lblToDate.Click += new System.EventHandler(this.lblToDate_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFromDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(74, 200);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(125, 27);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "From Date";
            this.lblFromDate.Click += new System.EventHandler(this.lblFromDate_Click);
            // 
            // lblEnquiryFollowUp
            // 
            this.lblEnquiryFollowUp.AutoSize = true;
            this.lblEnquiryFollowUp.BackColor = System.Drawing.Color.Transparent;
            this.lblEnquiryFollowUp.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnquiryFollowUp.Location = new System.Drawing.Point(70, 35);
            this.lblEnquiryFollowUp.Name = "lblEnquiryFollowUp";
            this.lblEnquiryFollowUp.Size = new System.Drawing.Size(382, 49);
            this.lblEnquiryFollowUp.TabIndex = 2;
            this.lblEnquiryFollowUp.Text = "Enquiry FollowUp";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 30);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(384, 239);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(249, 30);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // frmEnquiryFollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1662, 950);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEnquiryFollowUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enquiry FollowUp Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEnquiryFollowUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEnquiryFollowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxRefresh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSearch2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbbxEnquiryStatus;
        private System.Windows.Forms.Label lblEnquiryStatus;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblEnquiryFollowUp;
        private System.Windows.Forms.DataGridView grdEnquiryFollowUp;
        private System.Windows.Forms.PictureBox pictbxRefresh2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictbxSearch2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictbxExel;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.PictureBox pictbxDelete;
        private System.Windows.Forms.PictureBox pictbxFilters;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.PictureBox pictMail;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.PictureBox pictbxCalender2;
        private System.Windows.Forms.PictureBox pictbxCalender1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMoveToAdmission;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewImageColumn AddFollowUp;
    }
}