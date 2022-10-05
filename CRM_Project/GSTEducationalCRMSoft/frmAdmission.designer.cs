namespace GSTEducationalCRMSoft
{
    partial class frmAdmission
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
            this.btnFetchRegular = new System.Windows.Forms.Button();
            this.btnFetchDiscount = new System.Windows.Forms.Button();
            this.grdAdmission = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxAllCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnApplyForLeave = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictMail = new System.Windows.Forms.PictureBox();
            this.pictbxDelete = new System.Windows.Forms.PictureBox();
            this.pictbxPlus1 = new System.Windows.Forms.PictureBox();
            this.pictbxFilters = new System.Windows.Forms.PictureBox();
            this.pictbxPdf = new System.Windows.Forms.PictureBox();
            this.pictbxExel = new System.Windows.Forms.PictureBox();
            this.pictbxRefresh2 = new System.Windows.Forms.PictureBox();
            this.pictbxSearch2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAdmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxRefresh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSearch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFetchRegular
            // 
            this.btnFetchRegular.BackColor = System.Drawing.Color.Transparent;
            this.btnFetchRegular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetchRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchRegular.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchRegular.ForeColor = System.Drawing.Color.Black;
            this.btnFetchRegular.Location = new System.Drawing.Point(69, 44);
            this.btnFetchRegular.Margin = new System.Windows.Forms.Padding(2);
            this.btnFetchRegular.Name = "btnFetchRegular";
            this.btnFetchRegular.Size = new System.Drawing.Size(213, 38);
            this.btnFetchRegular.TabIndex = 0;
            this.btnFetchRegular.Text = "Regular Admission";
            this.btnFetchRegular.UseVisualStyleBackColor = false;
            this.btnFetchRegular.Click += new System.EventHandler(this.btnFetchRegular_Click);
            // 
            // btnFetchDiscount
            // 
            this.btnFetchDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnFetchDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetchDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchDiscount.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnFetchDiscount.Location = new System.Drawing.Point(314, 44);
            this.btnFetchDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnFetchDiscount.Name = "btnFetchDiscount";
            this.btnFetchDiscount.Size = new System.Drawing.Size(213, 38);
            this.btnFetchDiscount.TabIndex = 1;
            this.btnFetchDiscount.Text = "Discount Admission";
            this.btnFetchDiscount.UseVisualStyleBackColor = false;
            this.btnFetchDiscount.Click += new System.EventHandler(this.btnFetchDiscount_Click);
            // 
            // grdAdmission
            // 
            this.grdAdmission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAdmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAdmission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.Edit});
            this.grdAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdAdmission.Location = new System.Drawing.Point(67, 325);
            this.grdAdmission.Margin = new System.Windows.Forms.Padding(2);
            this.grdAdmission.Name = "grdAdmission";
            this.grdAdmission.RowHeadersVisible = false;
            this.grdAdmission.RowHeadersWidth = 62;
            this.grdAdmission.RowTemplate.Height = 28;
            this.grdAdmission.Size = new System.Drawing.Size(1193, 535);
            this.grdAdmission.TabIndex = 2;
            this.grdAdmission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAdmission_CellClick);
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "";
            this.checkbox.MinimumWidth = 8;
            this.checkbox.Name = "checkbox";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course";
            // 
            // cmbbxAllCourse
            // 
            this.cmbbxAllCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxAllCourse.FormattingEnabled = true;
            this.cmbbxAllCourse.Location = new System.Drawing.Point(67, 253);
            this.cmbbxAllCourse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxAllCourse.Name = "cmbbxAllCourse";
            this.cmbbxAllCourse.Size = new System.Drawing.Size(214, 31);
            this.cmbbxAllCourse.TabIndex = 4;
            this.cmbbxAllCourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxAllCourse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "From Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "To Date";
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Location = new System.Drawing.Point(312, 253);
            this.dtStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(214, 30);
            this.dtStart.TabIndex = 10;
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Location = new System.Drawing.Point(562, 252);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(214, 30);
            this.dtEnd.TabIndex = 11;
            // 
            // btnApplyForLeave
            // 
            this.btnApplyForLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnApplyForLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyForLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyForLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyForLeave.ForeColor = System.Drawing.Color.Black;
            this.btnApplyForLeave.Location = new System.Drawing.Point(330, 132);
            this.btnApplyForLeave.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyForLeave.Name = "btnApplyForLeave";
            this.btnApplyForLeave.Size = new System.Drawing.Size(228, 42);
            this.btnApplyForLeave.TabIndex = 61;
            this.btnApplyForLeave.Text = "New Admission";
            this.btnApplyForLeave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplyForLeave.UseVisualStyleBackColor = false;
            this.btnApplyForLeave.Click += new System.EventHandler(this.btnApplyForLeave_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilters.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(1048, 132);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(152, 44);
            this.btnFilters.TabIndex = 59;
            this.btnFilters.Text = "Filters";
            this.btnFilters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilters.UseVisualStyleBackColor = false;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMail.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.Location = new System.Drawing.Point(918, 133);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(112, 42);
            this.btnMail.TabIndex = 58;
            this.btnMail.Text = "Mail";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMail.UseVisualStyleBackColor = false;
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.Transparent;
            this.btnDelet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelet.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelet.Location = new System.Drawing.Point(750, 132);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(147, 43);
            this.btnDelet.TabIndex = 57;
            this.btnDelet.Text = "Delete";
            this.btnDelet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(112, 133);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 41);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictMail
            // 
            this.pictMail.Image = global::GSTEducationalCRMSoft.Properties.Resources.email;
            this.pictMail.Location = new System.Drawing.Point(925, 142);
            this.pictMail.Name = "pictMail";
            this.pictMail.Size = new System.Drawing.Size(30, 27);
            this.pictMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictMail.TabIndex = 64;
            this.pictMail.TabStop = false;
            // 
            // pictbxDelete
            // 
            this.pictbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pictbxDelete.Image = global::GSTEducationalCRMSoft.Properties.Resources.delete4;
            this.pictbxDelete.Location = new System.Drawing.Point(762, 139);
            this.pictbxDelete.Name = "pictbxDelete";
            this.pictbxDelete.Size = new System.Drawing.Size(30, 28);
            this.pictbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxDelete.TabIndex = 63;
            this.pictbxDelete.TabStop = false;
            // 
            // pictbxPlus1
            // 
            this.pictbxPlus1.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPlus1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPlus1.Image = global::GSTEducationalCRMSoft.Properties.Resources.plus1;
            this.pictbxPlus1.Location = new System.Drawing.Point(338, 140);
            this.pictbxPlus1.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxPlus1.Name = "pictbxPlus1";
            this.pictbxPlus1.Size = new System.Drawing.Size(32, 25);
            this.pictbxPlus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPlus1.TabIndex = 62;
            this.pictbxPlus1.TabStop = false;
            this.pictbxPlus1.Click += new System.EventHandler(this.pictbxPlus1_Click);
            // 
            // pictbxFilters
            // 
            this.pictbxFilters.Image = global::GSTEducationalCRMSoft.Properties.Resources.filter3;
            this.pictbxFilters.Location = new System.Drawing.Point(1063, 138);
            this.pictbxFilters.Name = "pictbxFilters";
            this.pictbxFilters.Size = new System.Drawing.Size(30, 28);
            this.pictbxFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxFilters.TabIndex = 60;
            this.pictbxFilters.TabStop = false;
            // 
            // pictbxPdf
            // 
            this.pictbxPdf.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPdf.Image = global::GSTEducationalCRMSoft.Properties.Resources.pdf;
            this.pictbxPdf.Location = new System.Drawing.Point(625, 133);
            this.pictbxPdf.Name = "pictbxPdf";
            this.pictbxPdf.Size = new System.Drawing.Size(48, 42);
            this.pictbxPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPdf.TabIndex = 56;
            this.pictbxPdf.TabStop = false;
            this.toolTip1.SetToolTip(this.pictbxPdf, "PDF Button");
            this.pictbxPdf.Click += new System.EventHandler(this.pictbxPdf_Click);
            // 
            // pictbxExel
            // 
            this.pictbxExel.BackColor = System.Drawing.Color.Transparent;
            this.pictbxExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxExel.Image = global::GSTEducationalCRMSoft.Properties.Resources.ms_excel;
            this.pictbxExel.Location = new System.Drawing.Point(682, 132);
            this.pictbxExel.Name = "pictbxExel";
            this.pictbxExel.Size = new System.Drawing.Size(48, 42);
            this.pictbxExel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxExel.TabIndex = 55;
            this.pictbxExel.TabStop = false;
            this.toolTip1.SetToolTip(this.pictbxExel, "Excel Button");
            this.pictbxExel.Click += new System.EventHandler(this.pictbxExel_Click);
            // 
            // pictbxRefresh2
            // 
            this.pictbxRefresh2.BackColor = System.Drawing.Color.Transparent;
            this.pictbxRefresh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxRefresh2.Image = global::GSTEducationalCRMSoft.Properties.Resources.refresh2;
            this.pictbxRefresh2.Location = new System.Drawing.Point(563, 132);
            this.pictbxRefresh2.Name = "pictbxRefresh2";
            this.pictbxRefresh2.Size = new System.Drawing.Size(53, 42);
            this.pictbxRefresh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxRefresh2.TabIndex = 54;
            this.pictbxRefresh2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictbxRefresh2, "Refresh Button");
            this.pictbxRefresh2.Click += new System.EventHandler(this.pictbxRefresh2_Click);
            // 
            // pictbxSearch2
            // 
            this.pictbxSearch2.BackColor = System.Drawing.Color.Transparent;
            this.pictbxSearch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxSearch2.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.pictbxSearch2.Location = new System.Drawing.Point(775, 250);
            this.pictbxSearch2.Name = "pictbxSearch2";
            this.pictbxSearch2.Size = new System.Drawing.Size(44, 32);
            this.pictbxSearch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxSearch2.TabIndex = 52;
            this.pictbxSearch2.TabStop = false;
            this.pictbxSearch2.Click += new System.EventHandler(this.pictbxSearch2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(67, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1453, 898);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictMail);
            this.Controls.Add(this.pictbxDelete);
            this.Controls.Add(this.pictbxPlus1);
            this.Controls.Add(this.btnApplyForLeave);
            this.Controls.Add(this.pictbxFilters);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.pictbxPdf);
            this.Controls.Add(this.pictbxExel);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.pictbxRefresh2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictbxSearch2);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbxAllCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdAdmission);
            this.Controls.Add(this.btnFetchDiscount);
            this.Controls.Add(this.btnFetchRegular);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admission";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAdmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxRefresh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxSearch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFetchRegular;
        private System.Windows.Forms.Button btnFetchDiscount;
        private System.Windows.Forms.DataGridView grdAdmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxAllCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.PictureBox pictbxPlus1;
        private System.Windows.Forms.Button btnApplyForLeave;
        private System.Windows.Forms.PictureBox pictbxFilters;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.PictureBox pictbxPdf;
        private System.Windows.Forms.PictureBox pictbxExel;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.PictureBox pictbxRefresh2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictbxSearch2;
        private System.Windows.Forms.PictureBox pictbxDelete;
        private System.Windows.Forms.PictureBox pictMail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}