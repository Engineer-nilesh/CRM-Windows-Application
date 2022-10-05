namespace GSTEducationalCRMSoft
{
    partial class frmPaymentsManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpc = new System.Windows.Forms.Button();
            this.btnpp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSMS = new System.Windows.Forms.Button();
            this.pictbxExcel = new System.Windows.Forms.PictureBox();
            this.pictbxPDF = new System.Windows.Forms.PictureBox();
            this.pictRefresh = new System.Windows.Forms.PictureBox();
            this.picbxFilters = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.picbxSearch = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbbxStatus = new System.Windows.Forms.ComboBox();
            this.grdPaymentManagement = new System.Windows.Forms.DataGridView();
            this.AddPayment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ViewDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cmbbxName = new System.Windows.Forms.ComboBox();
            this.cmbbxCourse = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblPayMan = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPaymentManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnpc);
            this.panel1.Controls.Add(this.btnpp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSMS);
            this.panel1.Controls.Add(this.pictbxExcel);
            this.panel1.Controls.Add(this.pictbxPDF);
            this.panel1.Controls.Add(this.pictRefresh);
            this.panel1.Controls.Add(this.picbxFilters);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnFilters);
            this.panel1.Controls.Add(this.picbxSearch);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.cmbbxStatus);
            this.panel1.Controls.Add(this.grdPaymentManagement);
            this.panel1.Controls.Add(this.cmbbxName);
            this.panel1.Controls.Add(this.cmbbxCourse);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblCourse);
            this.panel1.Controls.Add(this.lblPayMan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 798);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnpc
            // 
            this.btnpc.BackColor = System.Drawing.Color.Transparent;
            this.btnpc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpc.Location = new System.Drawing.Point(1024, 112);
            this.btnpc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnpc.Name = "btnpc";
            this.btnpc.Size = new System.Drawing.Size(197, 42);
            this.btnpc.TabIndex = 39;
            this.btnpc.Text = "Payment Completed";
            this.btnpc.UseVisualStyleBackColor = false;
            this.btnpc.Click += new System.EventHandler(this.btnpc_Click);
            // 
            // btnpp
            // 
            this.btnpp.BackColor = System.Drawing.Color.Transparent;
            this.btnpp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpp.Location = new System.Drawing.Point(779, 110);
            this.btnpp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnpp.Name = "btnpp";
            this.btnpp.Size = new System.Drawing.Size(232, 46);
            this.btnpp.TabIndex = 38;
            this.btnpp.Text = "Outstanding Payments";
            this.btnpp.UseVisualStyleBackColor = false;
            this.btnpp.Click += new System.EventHandler(this.btnpp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GSTEducationalCRMSoft.Properties.Resources.SMS;
            this.pictureBox1.Location = new System.Drawing.Point(520, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btnSMS
            // 
            this.btnSMS.BackColor = System.Drawing.Color.Transparent;
            this.btnSMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMS.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMS.Location = new System.Drawing.Point(508, 113);
            this.btnSMS.Margin = new System.Windows.Forms.Padding(2);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(114, 42);
            this.btnSMS.TabIndex = 36;
            this.btnSMS.Text = "SMS";
            this.btnSMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSMS.UseVisualStyleBackColor = false;
            // 
            // pictbxExcel
            // 
            this.pictbxExcel.BackColor = System.Drawing.Color.Transparent;
            this.pictbxExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxExcel.Image = global::GSTEducationalCRMSoft.Properties.Resources.ms_excel;
            this.pictbxExcel.Location = new System.Drawing.Point(453, 113);
            this.pictbxExcel.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxExcel.Name = "pictbxExcel";
            this.pictbxExcel.Size = new System.Drawing.Size(48, 42);
            this.pictbxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxExcel.TabIndex = 28;
            this.pictbxExcel.TabStop = false;
            this.pictbxExcel.Click += new System.EventHandler(this.pictbxExcel_Click);
            // 
            // pictbxPDF
            // 
            this.pictbxPDF.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPDF.Image = global::GSTEducationalCRMSoft.Properties.Resources.pdf;
            this.pictbxPDF.Location = new System.Drawing.Point(402, 113);
            this.pictbxPDF.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxPDF.Name = "pictbxPDF";
            this.pictbxPDF.Size = new System.Drawing.Size(48, 42);
            this.pictbxPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPDF.TabIndex = 27;
            this.pictbxPDF.TabStop = false;
            this.pictbxPDF.Click += new System.EventHandler(this.pictbxPDF_Click);
            // 
            // pictRefresh
            // 
            this.pictRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRefresh.Image = global::GSTEducationalCRMSoft.Properties.Resources.refresh2;
            this.pictRefresh.Location = new System.Drawing.Point(348, 113);
            this.pictRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.pictRefresh.Name = "pictRefresh";
            this.pictRefresh.Size = new System.Drawing.Size(42, 41);
            this.pictRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictRefresh.TabIndex = 26;
            this.pictRefresh.TabStop = false;
            this.pictRefresh.Click += new System.EventHandler(this.pictRefresh_Click);
            // 
            // picbxFilters
            // 
            this.picbxFilters.BackColor = System.Drawing.Color.Transparent;
            this.picbxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxFilters.Image = global::GSTEducationalCRMSoft.Properties.Resources.filter3;
            this.picbxFilters.Location = new System.Drawing.Point(639, 121);
            this.picbxFilters.Margin = new System.Windows.Forms.Padding(2);
            this.picbxFilters.Name = "picbxFilters";
            this.picbxFilters.Size = new System.Drawing.Size(32, 26);
            this.picbxFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxFilters.TabIndex = 25;
            this.picbxFilters.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(108, 115);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 40);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(628, 113);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(132, 41);
            this.btnFilters.TabIndex = 24;
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
            this.picbxSearch.Location = new System.Drawing.Point(68, 115);
            this.picbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.picbxSearch.Name = "picbxSearch";
            this.picbxSearch.Size = new System.Drawing.Size(43, 40);
            this.picbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxSearch.TabIndex = 23;
            this.picbxSearch.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(637, 199);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 27);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status :";
            // 
            // cmbbxStatus
            // 
            this.cmbbxStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxStatus.FormattingEnabled = true;
            this.cmbbxStatus.Location = new System.Drawing.Point(729, 199);
            this.cmbbxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxStatus.Name = "cmbbxStatus";
            this.cmbbxStatus.Size = new System.Drawing.Size(168, 31);
            this.cmbbxStatus.TabIndex = 12;
            this.cmbbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxStatus_SelectedIndexChanged);
            // 
            // grdPaymentManagement
            // 
            this.grdPaymentManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPaymentManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPaymentManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPaymentManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddPayment,
            this.ViewDetails});
            this.grdPaymentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdPaymentManagement.Location = new System.Drawing.Point(65, 298);
            this.grdPaymentManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdPaymentManagement.Name = "grdPaymentManagement";
            this.grdPaymentManagement.RowHeadersVisible = false;
            this.grdPaymentManagement.RowHeadersWidth = 62;
            this.grdPaymentManagement.Size = new System.Drawing.Size(1179, 457);
            this.grdPaymentManagement.TabIndex = 6;
            this.grdPaymentManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPaymentManagement_CellContentClick);
            this.grdPaymentManagement.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdPaymentManagement_CellFormatting);
            // 
            // AddPayment
            // 
            this.AddPayment.HeaderText = "Add Payment";
            this.AddPayment.MinimumWidth = 8;
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Text = "Add Payment";
            this.AddPayment.UseColumnTextForLinkValue = true;
            // 
            // ViewDetails
            // 
            this.ViewDetails.HeaderText = "ViewDetails";
            this.ViewDetails.MinimumWidth = 8;
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Text = "ViewDetails";
            this.ViewDetails.UseColumnTextForLinkValue = true;
            // 
            // cmbbxName
            // 
            this.cmbbxName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxName.FormattingEnabled = true;
            this.cmbbxName.Location = new System.Drawing.Point(436, 199);
            this.cmbbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxName.Name = "cmbbxName";
            this.cmbbxName.Size = new System.Drawing.Size(192, 31);
            this.cmbbxName.TabIndex = 5;
            this.cmbbxName.SelectedIndexChanged += new System.EventHandler(this.cmbbxName_SelectedIndexChanged);
            // 
            // cmbbxCourse
            // 
            this.cmbbxCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCourse.FormattingEnabled = true;
            this.cmbbxCourse.Location = new System.Drawing.Point(150, 199);
            this.cmbbxCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxCourse.Name = "cmbbxCourse";
            this.cmbbxCourse.Size = new System.Drawing.Size(192, 31);
            this.cmbbxCourse.TabIndex = 4;
            this.cmbbxCourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourse_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(347, 199);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 27);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name :";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(50, 199);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(103, 27);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course :";
            // 
            // lblPayMan
            // 
            this.lblPayMan.AutoSize = true;
            this.lblPayMan.BackColor = System.Drawing.Color.Transparent;
            this.lblPayMan.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMan.Location = new System.Drawing.Point(57, 38);
            this.lblPayMan.Name = "lblPayMan";
            this.lblPayMan.Size = new System.Drawing.Size(464, 49);
            this.lblPayMan.TabIndex = 0;
            this.lblPayMan.Text = "Payment Management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(1051, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 29);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Green;
            this.pictureBox3.Location = new System.Drawing.Point(1243, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 29);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(1051, 229);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 29);
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.Location = new System.Drawing.Point(1243, 174);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 29);
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(907, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "For 1st Installment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1100, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "For 4th Installment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(907, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "For 3rd Installment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1096, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "For 2nd Installment";
            // 
            // frmPaymentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1441, 798);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPaymentsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Management Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaymentsManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPaymentManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbbxName;
        private System.Windows.Forms.ComboBox cmbbxCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblPayMan;
        private System.Windows.Forms.DataGridView grdPaymentManagement;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbbxStatus;
        private System.Windows.Forms.PictureBox pictbxExcel;
        private System.Windows.Forms.PictureBox pictbxPDF;
        private System.Windows.Forms.PictureBox pictRefresh;
        private System.Windows.Forms.PictureBox picbxFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.PictureBox picbxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSMS;
        private System.Windows.Forms.Button btnpc;
        private System.Windows.Forms.Button btnpp;
        private System.Windows.Forms.DataGridViewLinkColumn AddPayment;
        private System.Windows.Forms.DataGridViewLinkColumn ViewDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}