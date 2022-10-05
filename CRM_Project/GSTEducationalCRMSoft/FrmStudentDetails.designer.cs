namespace GSTEducationalCRMSoft
{
    partial class FrmStudentDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.cmbbxCourseName = new System.Windows.Forms.ComboBox();
            this.cmbbxTrainerName = new System.Windows.Forms.ComboBox();
            this.cmbbxBatchName = new System.Windows.Forms.ComboBox();
            this.grdStudentDetail = new System.Windows.Forms.DataGridView();
            this.pictbxExcel = new System.Windows.Forms.PictureBox();
            this.picbxFilters = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.picbxSearch = new System.Windows.Forms.PictureBox();
            this.lblStudentDetails = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(32, 200);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(144, 25);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name :";
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerName.Location = new System.Drawing.Point(390, 200);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(142, 25);
            this.lblTrainerName.TabIndex = 1;
            this.lblTrainerName.Text = "Trainer Name :";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchName.Location = new System.Drawing.Point(750, 200);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(130, 25);
            this.lblBatchName.TabIndex = 2;
            this.lblBatchName.Text = "Batch Name :";
            // 
            // cmbbxCourseName
            // 
            this.cmbbxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCourseName.FormattingEnabled = true;
            this.cmbbxCourseName.Location = new System.Drawing.Point(182, 198);
            this.cmbbxCourseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxCourseName.Name = "cmbbxCourseName";
            this.cmbbxCourseName.Size = new System.Drawing.Size(179, 33);
            this.cmbbxCourseName.TabIndex = 3;
            this.cmbbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourseName_SelectedIndexChanged);
            // 
            // cmbbxTrainerName
            // 
            this.cmbbxTrainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTrainerName.FormattingEnabled = true;
            this.cmbbxTrainerName.Location = new System.Drawing.Point(547, 198);
            this.cmbbxTrainerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxTrainerName.Name = "cmbbxTrainerName";
            this.cmbbxTrainerName.Size = new System.Drawing.Size(179, 33);
            this.cmbbxTrainerName.TabIndex = 4;
            this.cmbbxTrainerName.SelectedIndexChanged += new System.EventHandler(this.cmbbxTrainerName_SelectedIndexChanged);
            // 
            // cmbbxBatchName
            // 
            this.cmbbxBatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxBatchName.FormattingEnabled = true;
            this.cmbbxBatchName.Location = new System.Drawing.Point(887, 198);
            this.cmbbxBatchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxBatchName.Name = "cmbbxBatchName";
            this.cmbbxBatchName.Size = new System.Drawing.Size(172, 33);
            this.cmbbxBatchName.TabIndex = 5;
            this.cmbbxBatchName.SelectedIndexChanged += new System.EventHandler(this.cmbbxBatchName_SelectedIndexChanged);
            // 
            // grdStudentDetail
            // 
            this.grdStudentDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudentDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdStudentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdStudentDetail.Location = new System.Drawing.Point(27, 264);
            this.grdStudentDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdStudentDetail.Name = "grdStudentDetail";
            this.grdStudentDetail.RowHeadersVisible = false;
            this.grdStudentDetail.RowHeadersWidth = 62;
            this.grdStudentDetail.Size = new System.Drawing.Size(1055, 389);
            this.grdStudentDetail.TabIndex = 6;
            this.grdStudentDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudentDetail_CellContentClick);
            // 
            // pictbxExcel
            // 
            this.pictbxExcel.BackColor = System.Drawing.Color.Transparent;
            this.pictbxExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxExcel.Image = global::GSTEducationalCRMSoft.Properties.Resources.ms_excel;
            this.pictbxExcel.Location = new System.Drawing.Point(307, 108);
            this.pictbxExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictbxExcel.Name = "pictbxExcel";
            this.pictbxExcel.Size = new System.Drawing.Size(42, 38);
            this.pictbxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxExcel.TabIndex = 32;
            this.pictbxExcel.TabStop = false;
            this.pictbxExcel.Click += new System.EventHandler(this.pictbxExcel_Click);
            // 
            // picbxFilters
            // 
            this.picbxFilters.BackColor = System.Drawing.Color.Transparent;
            this.picbxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxFilters.Image = global::GSTEducationalCRMSoft.Properties.Resources.filter3;
            this.picbxFilters.Location = new System.Drawing.Point(389, 113);
            this.picbxFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbxFilters.Name = "picbxFilters";
            this.picbxFilters.Size = new System.Drawing.Size(32, 24);
            this.picbxFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxFilters.TabIndex = 28;
            this.picbxFilters.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(72, 107);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnFilters.Location = new System.Drawing.Point(378, 106);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(132, 40);
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
            this.picbxSearch.Location = new System.Drawing.Point(32, 107);
            this.picbxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbxSearch.Name = "picbxSearch";
            this.picbxSearch.Size = new System.Drawing.Size(43, 40);
            this.picbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxSearch.TabIndex = 23;
            this.picbxSearch.TabStop = false;
            // 
            // lblStudentDetails
            // 
            this.lblStudentDetails.AutoSize = true;
            this.lblStudentDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentDetails.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDetails.Location = new System.Drawing.Point(33, 27);
            this.lblStudentDetails.Name = "lblStudentDetails";
            this.lblStudentDetails.Size = new System.Drawing.Size(304, 47);
            this.lblStudentDetails.TabIndex = 33;
            this.lblStudentDetails.Text = "Student Details";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "StudentList";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Text = "StudentsList";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // FrmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1603, 693);
            this.Controls.Add(this.lblStudentDetails);
            this.Controls.Add(this.pictbxExcel);
            this.Controls.Add(this.picbxFilters);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.picbxSearch);
            this.Controls.Add(this.grdStudentDetail);
            this.Controls.Add(this.cmbbxBatchName);
            this.Controls.Add(this.cmbbxTrainerName);
            this.Controls.Add(this.cmbbxCourseName);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblTrainerName);
            this.Controls.Add(this.lblCourseName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmStudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.ComboBox cmbbxCourseName;
        private System.Windows.Forms.ComboBox cmbbxTrainerName;
        private System.Windows.Forms.ComboBox cmbbxBatchName;
        private System.Windows.Forms.DataGridView grdStudentDetail;
        private System.Windows.Forms.PictureBox pictbxExcel;
        private System.Windows.Forms.PictureBox picbxFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.PictureBox picbxSearch;
        private System.Windows.Forms.Label lblStudentDetails;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
    }
}