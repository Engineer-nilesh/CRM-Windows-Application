namespace GSTEducationalCRMSoft
{
    partial class frmLabManagement
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
            this.lblLabName = new System.Windows.Forms.Label();
            this.cmbbxLabName = new System.Windows.Forms.ComboBox();
            this.grdLabManagement = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblLabManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbbxCenterName = new System.Windows.Forms.ComboBox();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.pictbxExcel = new System.Windows.Forms.PictureBox();
            this.pictbxPDF = new System.Windows.Forms.PictureBox();
            this.pictRefresh = new System.Windows.Forms.PictureBox();
            this.pictbxPlus = new System.Windows.Forms.PictureBox();
            this.picbxFilters = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.picbxSearch = new System.Windows.Forms.PictureBox();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.picbxDelete = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLabManagement)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLabName
            // 
            this.lblLabName.AutoSize = true;
            this.lblLabName.BackColor = System.Drawing.Color.Transparent;
            this.lblLabName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabName.Location = new System.Drawing.Point(76, 216);
            this.lblLabName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabName.Name = "lblLabName";
            this.lblLabName.Size = new System.Drawing.Size(129, 27);
            this.lblLabName.TabIndex = 0;
            this.lblLabName.Text = "LabName :";
            // 
            // cmbbxLabName
            // 
            this.cmbbxLabName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxLabName.FormattingEnabled = true;
            this.cmbbxLabName.Location = new System.Drawing.Point(216, 218);
            this.cmbbxLabName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxLabName.Name = "cmbbxLabName";
            this.cmbbxLabName.Size = new System.Drawing.Size(200, 31);
            this.cmbbxLabName.TabIndex = 1;
            this.cmbbxLabName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grdLabManagement
            // 
            this.grdLabManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLabManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLabManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.Edit});
            this.grdLabManagement.Location = new System.Drawing.Point(68, 282);
            this.grdLabManagement.Margin = new System.Windows.Forms.Padding(4);
            this.grdLabManagement.Name = "grdLabManagement";
            this.grdLabManagement.RowHeadersVisible = false;
            this.grdLabManagement.RowHeadersWidth = 62;
            this.grdLabManagement.Size = new System.Drawing.Size(1126, 516);
            this.grdLabManagement.TabIndex = 2;
            this.grdLabManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLabManagement_CellContentClick);
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
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // lblLabManagement
            // 
            this.lblLabManagement.AutoSize = true;
            this.lblLabManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblLabManagement.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabManagement.Location = new System.Drawing.Point(61, 39);
            this.lblLabManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabManagement.Name = "lblLabManagement";
            this.lblLabManagement.Size = new System.Drawing.Size(365, 49);
            this.lblLabManagement.TabIndex = 3;
            this.lblLabManagement.Text = "Lab Management";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cmbbxCenterName);
            this.panel1.Controls.Add(this.lblCenterName);
            this.panel1.Controls.Add(this.pictbxExcel);
            this.panel1.Controls.Add(this.pictbxPDF);
            this.panel1.Controls.Add(this.pictRefresh);
            this.panel1.Controls.Add(this.pictbxPlus);
            this.panel1.Controls.Add(this.picbxFilters);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnFilters);
            this.panel1.Controls.Add(this.picbxSearch);
            this.panel1.Controls.Add(this.btnNewTask);
            this.panel1.Controls.Add(this.picbxDelete);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblLabManagement);
            this.panel1.Controls.Add(this.grdLabManagement);
            this.panel1.Controls.Add(this.cmbbxLabName);
            this.panel1.Controls.Add(this.lblLabName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 848);
            this.panel1.TabIndex = 4;
            // 
            // cmbbxCenterName
            // 
            this.cmbbxCenterName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCenterName.FormattingEnabled = true;
            this.cmbbxCenterName.Location = new System.Drawing.Point(634, 218);
            this.cmbbxCenterName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxCenterName.Name = "cmbbxCenterName";
            this.cmbbxCenterName.Size = new System.Drawing.Size(200, 31);
            this.cmbbxCenterName.TabIndex = 50;
            this.cmbbxCenterName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCenterName_SelectedIndexChanged);
            // 
            // lblCenterName
            // 
            this.lblCenterName.AutoSize = true;
            this.lblCenterName.BackColor = System.Drawing.Color.Transparent;
            this.lblCenterName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterName.Location = new System.Drawing.Point(444, 218);
            this.lblCenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.Size = new System.Drawing.Size(175, 27);
            this.lblCenterName.TabIndex = 49;
            this.lblCenterName.Text = " Center Name :";
            // 
            // pictbxExcel
            // 
            this.pictbxExcel.BackColor = System.Drawing.Color.Transparent;
            this.pictbxExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxExcel.Image = global::GSTEducationalCRMSoft.Properties.Resources.ms_excel;
            this.pictbxExcel.Location = new System.Drawing.Point(653, 134);
            this.pictbxExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictbxExcel.Name = "pictbxExcel";
            this.pictbxExcel.Size = new System.Drawing.Size(44, 39);
            this.pictbxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxExcel.TabIndex = 45;
            this.pictbxExcel.TabStop = false;
            this.pictbxExcel.Click += new System.EventHandler(this.pictbxExcel_Click);
            // 
            // pictbxPDF
            // 
            this.pictbxPDF.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPDF.Image = global::GSTEducationalCRMSoft.Properties.Resources.pdf;
            this.pictbxPDF.Location = new System.Drawing.Point(610, 134);
            this.pictbxPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictbxPDF.Name = "pictbxPDF";
            this.pictbxPDF.Size = new System.Drawing.Size(43, 39);
            this.pictbxPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPDF.TabIndex = 44;
            this.pictbxPDF.TabStop = false;
            this.pictbxPDF.Click += new System.EventHandler(this.pictbxPDF_Click);
            // 
            // pictRefresh
            // 
            this.pictRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRefresh.Image = global::GSTEducationalCRMSoft.Properties.Resources.refresh2;
            this.pictRefresh.Location = new System.Drawing.Point(554, 133);
            this.pictRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictRefresh.Name = "pictRefresh";
            this.pictRefresh.Size = new System.Drawing.Size(44, 38);
            this.pictRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictRefresh.TabIndex = 43;
            this.pictRefresh.TabStop = false;
            this.pictRefresh.Click += new System.EventHandler(this.pictRefresh_Click);
            // 
            // pictbxPlus
            // 
            this.pictbxPlus.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPlus.Image = global::GSTEducationalCRMSoft.Properties.Resources.plus1;
            this.pictbxPlus.Location = new System.Drawing.Point(376, 142);
            this.pictbxPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictbxPlus.Name = "pictbxPlus";
            this.pictbxPlus.Size = new System.Drawing.Size(35, 25);
            this.pictbxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPlus.TabIndex = 42;
            this.pictbxPlus.TabStop = false;
            // 
            // picbxFilters
            // 
            this.picbxFilters.BackColor = System.Drawing.Color.Transparent;
            this.picbxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxFilters.Image = global::GSTEducationalCRMSoft.Properties.Resources.filter3;
            this.picbxFilters.Location = new System.Drawing.Point(858, 142);
            this.picbxFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbxFilters.Name = "picbxFilters";
            this.picbxFilters.Size = new System.Drawing.Size(35, 25);
            this.picbxFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxFilters.TabIndex = 41;
            this.picbxFilters.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(111, 134);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 40);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(844, 133);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(141, 39);
            this.btnFilters.TabIndex = 40;
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
            this.picbxSearch.Location = new System.Drawing.Point(68, 134);
            this.picbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbxSearch.Name = "picbxSearch";
            this.picbxSearch.Size = new System.Drawing.Size(46, 41);
            this.picbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxSearch.TabIndex = 36;
            this.picbxSearch.TabStop = false;
            // 
            // btnNewTask
            // 
            this.btnNewTask.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTask.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTask.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewTask.Location = new System.Drawing.Point(360, 134);
            this.btnNewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNewTask.Size = new System.Drawing.Size(188, 39);
            this.btnNewTask.TabIndex = 37;
            this.btnNewTask.Text = "New Lab";
            this.btnNewTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTask.UseVisualStyleBackColor = false;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // picbxDelete
            // 
            this.picbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.picbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxDelete.Image = global::GSTEducationalCRMSoft.Properties.Resources.delete4;
            this.picbxDelete.Location = new System.Drawing.Point(712, 142);
            this.picbxDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbxDelete.Name = "picbxDelete";
            this.picbxDelete.Size = new System.Drawing.Size(35, 25);
            this.picbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxDelete.TabIndex = 39;
            this.picbxDelete.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(701, 134);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 39);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmLabManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 848);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLabManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLabManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLabManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLabManagement)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLabName;
        private System.Windows.Forms.ComboBox cmbbxLabName;
        private System.Windows.Forms.DataGridView grdLabManagement;
        private System.Windows.Forms.Label lblLabManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictbxExcel;
        private System.Windows.Forms.PictureBox pictbxPDF;
        private System.Windows.Forms.PictureBox pictRefresh;
        private System.Windows.Forms.PictureBox pictbxPlus;
        private System.Windows.Forms.PictureBox picbxFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.PictureBox picbxSearch;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.PictureBox picbxDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.ComboBox cmbbxCenterName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
    }
}