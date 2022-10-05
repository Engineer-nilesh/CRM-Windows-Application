namespace GSTEducationalCRMSoft
{
    partial class Batchmangement
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
            this.grdBatchManagement = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmMerge = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmViewBatch = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lbltrainername = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblbatchname = new System.Windows.Forms.Label();
            this.cmbbxtrainername = new System.Windows.Forms.ComboBox();
            this.cmbbxcourse = new System.Windows.Forms.ComboBox();
            this.cmbbxbatchname = new System.Windows.Forms.ComboBox();
            this.pictbxExcel = new System.Windows.Forms.PictureBox();
            this.pictbxPDF = new System.Windows.Forms.PictureBox();
            this.pictRefresh = new System.Windows.Forms.PictureBox();
            this.pictbxPlus = new System.Windows.Forms.PictureBox();
            this.picbxFilters = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.picbxSearch = new System.Windows.Forms.PictureBox();
            this.btnNewBatch = new System.Windows.Forms.Button();
            this.picbxDelete = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolTipRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPDF = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExcel = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdBatchManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBatchManagement
            // 
            this.grdBatchManagement.AllowUserToAddRows = false;
            this.grdBatchManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBatchManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.clmMerge,
            this.clmViewBatch});
            this.grdBatchManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdBatchManagement.Location = new System.Drawing.Point(60, 198);
            this.grdBatchManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdBatchManagement.Name = "grdBatchManagement";
            this.grdBatchManagement.RowHeadersVisible = false;
            this.grdBatchManagement.RowHeadersWidth = 62;
            this.grdBatchManagement.Size = new System.Drawing.Size(1248, 512);
            this.grdBatchManagement.TabIndex = 0;
            this.grdBatchManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBatchManagement_CellClick);
            this.grdBatchManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBatchManagement_CellContentClick);
            // 
            // checkbox
            // 
            this.checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.checkbox.HeaderText = "";
            this.checkbox.MinimumWidth = 8;
            this.checkbox.Name = "checkbox";
            this.checkbox.Width = 8;
            // 
            // clmMerge
            // 
            this.clmMerge.HeaderText = "";
            this.clmMerge.MinimumWidth = 8;
            this.clmMerge.Name = "clmMerge";
            this.clmMerge.Text = "Merge";
            this.clmMerge.UseColumnTextForLinkValue = true;
            this.clmMerge.Width = 70;
            // 
            // clmViewBatch
            // 
            this.clmViewBatch.HeaderText = "";
            this.clmViewBatch.MinimumWidth = 8;
            this.clmViewBatch.Name = "clmViewBatch";
            this.clmViewBatch.Text = "View Batch";
            this.clmViewBatch.UseColumnTextForLinkValue = true;
            this.clmViewBatch.Width = 70;
            // 
            // lbltrainername
            // 
            this.lbltrainername.AutoSize = true;
            this.lbltrainername.BackColor = System.Drawing.Color.Transparent;
            this.lbltrainername.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrainername.Location = new System.Drawing.Point(55, 142);
            this.lbltrainername.Name = "lbltrainername";
            this.lbltrainername.Size = new System.Drawing.Size(170, 27);
            this.lbltrainername.TabIndex = 1;
            this.lbltrainername.Text = "Trainer Name :";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.BackColor = System.Drawing.Color.Transparent;
            this.lblcourse.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourse.Location = new System.Drawing.Point(415, 142);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(103, 27);
            this.lblcourse.TabIndex = 2;
            this.lblcourse.Text = "Course :";
            // 
            // lblbatchname
            // 
            this.lblbatchname.AutoSize = true;
            this.lblbatchname.BackColor = System.Drawing.Color.Transparent;
            this.lblbatchname.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbatchname.Location = new System.Drawing.Point(712, 142);
            this.lblbatchname.Name = "lblbatchname";
            this.lblbatchname.Size = new System.Drawing.Size(158, 27);
            this.lblbatchname.TabIndex = 3;
            this.lblbatchname.Text = "Batch Name :";
            // 
            // cmbbxtrainername
            // 
            this.cmbbxtrainername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxtrainername.FormattingEnabled = true;
            this.cmbbxtrainername.Location = new System.Drawing.Point(227, 142);
            this.cmbbxtrainername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxtrainername.Name = "cmbbxtrainername";
            this.cmbbxtrainername.Size = new System.Drawing.Size(179, 33);
            this.cmbbxtrainername.TabIndex = 4;
            this.cmbbxtrainername.SelectedIndexChanged += new System.EventHandler(this.cmbbxtrainername_SelectedIndexChanged);
            // 
            // cmbbxcourse
            // 
            this.cmbbxcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxcourse.FormattingEnabled = true;
            this.cmbbxcourse.Location = new System.Drawing.Point(522, 142);
            this.cmbbxcourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxcourse.Name = "cmbbxcourse";
            this.cmbbxcourse.Size = new System.Drawing.Size(172, 33);
            this.cmbbxcourse.TabIndex = 5;
            this.cmbbxcourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxcourse_SelectedIndexChanged);
            // 
            // cmbbxbatchname
            // 
            this.cmbbxbatchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxbatchname.FormattingEnabled = true;
            this.cmbbxbatchname.Location = new System.Drawing.Point(872, 142);
            this.cmbbxbatchname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxbatchname.Name = "cmbbxbatchname";
            this.cmbbxbatchname.Size = new System.Drawing.Size(186, 33);
            this.cmbbxbatchname.TabIndex = 6;
            this.cmbbxbatchname.SelectedIndexChanged += new System.EventHandler(this.cmbbxbatchname_SelectedIndexChanged);
            // 
            // pictbxExcel
            // 
            this.pictbxExcel.BackColor = System.Drawing.Color.Transparent;
            this.pictbxExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxExcel.Image = global::GSTEducationalCRMSoft.Properties.Resources.ms_excel;
            this.pictbxExcel.Location = new System.Drawing.Point(638, 41);
            this.pictbxExcel.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxExcel.Name = "pictbxExcel";
            this.pictbxExcel.Size = new System.Drawing.Size(48, 41);
            this.pictbxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxExcel.TabIndex = 32;
            this.pictbxExcel.TabStop = false;
            this.toolTipExcel.SetToolTip(this.pictbxExcel, "Excel Button");
            this.pictbxExcel.Click += new System.EventHandler(this.pictbxExcel_Click_1);
            // 
            // pictbxPDF
            // 
            this.pictbxPDF.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPDF.Image = global::GSTEducationalCRMSoft.Properties.Resources.pdf;
            this.pictbxPDF.Location = new System.Drawing.Point(587, 41);
            this.pictbxPDF.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxPDF.Name = "pictbxPDF";
            this.pictbxPDF.Size = new System.Drawing.Size(48, 41);
            this.pictbxPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPDF.TabIndex = 31;
            this.pictbxPDF.TabStop = false;
            this.toolTipPDF.SetToolTip(this.pictbxPDF, "PDF Button");
            this.pictbxPDF.Click += new System.EventHandler(this.pictbxPDF_Click_1);
            // 
            // pictRefresh
            // 
            this.pictRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRefresh.Image = global::GSTEducationalCRMSoft.Properties.Resources.refresh2;
            this.pictRefresh.Location = new System.Drawing.Point(533, 40);
            this.pictRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.pictRefresh.Name = "pictRefresh";
            this.pictRefresh.Size = new System.Drawing.Size(42, 40);
            this.pictRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictRefresh.TabIndex = 30;
            this.pictRefresh.TabStop = false;
            this.toolTipRefresh.SetToolTip(this.pictRefresh, "Refresh Button");
            this.pictRefresh.Click += new System.EventHandler(this.pictRefresh_Click_1);
            // 
            // pictbxPlus
            // 
            this.pictbxPlus.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxPlus.Image = global::GSTEducationalCRMSoft.Properties.Resources.plus1;
            this.pictbxPlus.Location = new System.Drawing.Point(352, 48);
            this.pictbxPlus.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxPlus.Name = "pictbxPlus";
            this.pictbxPlus.Size = new System.Drawing.Size(32, 24);
            this.pictbxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPlus.TabIndex = 29;
            this.pictbxPlus.TabStop = false;
            // 
            // picbxFilters
            // 
            this.picbxFilters.BackColor = System.Drawing.Color.Transparent;
            this.picbxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxFilters.Image = global::GSTEducationalCRMSoft.Properties.Resources.filter3;
            this.picbxFilters.Location = new System.Drawing.Point(862, 49);
            this.picbxFilters.Margin = new System.Windows.Forms.Padding(2);
            this.picbxFilters.Name = "picbxFilters";
            this.picbxFilters.Size = new System.Drawing.Size(32, 26);
            this.picbxFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxFilters.TabIndex = 28;
            this.picbxFilters.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(103, 41);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 40);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(852, 42);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(132, 41);
            this.btnFilters.TabIndex = 27;
            this.btnFilters.Text = "Filters";
            this.btnFilters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilters.UseVisualStyleBackColor = false;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click_1);
            // 
            // picbxSearch
            // 
            this.picbxSearch.BackColor = System.Drawing.Color.Transparent;
            this.picbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxSearch.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.picbxSearch.Location = new System.Drawing.Point(60, 42);
            this.picbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.picbxSearch.Name = "picbxSearch";
            this.picbxSearch.Size = new System.Drawing.Size(43, 40);
            this.picbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxSearch.TabIndex = 23;
            this.picbxSearch.TabStop = false;
            // 
            // btnNewBatch
            // 
            this.btnNewBatch.BackColor = System.Drawing.Color.Transparent;
            this.btnNewBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewBatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBatch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBatch.Location = new System.Drawing.Point(337, 41);
            this.btnNewBatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewBatch.Name = "btnNewBatch";
            this.btnNewBatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNewBatch.Size = new System.Drawing.Size(183, 40);
            this.btnNewBatch.TabIndex = 24;
            this.btnNewBatch.Text = "New Batch";
            this.btnNewBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewBatch.UseVisualStyleBackColor = false;
            this.btnNewBatch.Click += new System.EventHandler(this.btnNewBatch_Click);
            // 
            // picbxDelete
            // 
            this.picbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.picbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxDelete.Image = global::GSTEducationalCRMSoft.Properties.Resources.delete4;
            this.picbxDelete.Location = new System.Drawing.Point(713, 48);
            this.picbxDelete.Margin = new System.Windows.Forms.Padding(2);
            this.picbxDelete.Name = "picbxDelete";
            this.picbxDelete.Size = new System.Drawing.Size(32, 26);
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
            this.btnDelete.Location = new System.Drawing.Point(703, 41);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 41);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Batchmangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 772);
            this.Controls.Add(this.pictbxExcel);
            this.Controls.Add(this.pictbxPDF);
            this.Controls.Add(this.pictRefresh);
            this.Controls.Add(this.pictbxPlus);
            this.Controls.Add(this.picbxFilters);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.picbxSearch);
            this.Controls.Add(this.btnNewBatch);
            this.Controls.Add(this.picbxDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbbxbatchname);
            this.Controls.Add(this.cmbbxcourse);
            this.Controls.Add(this.cmbbxtrainername);
            this.Controls.Add(this.lblbatchname);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lbltrainername);
            this.Controls.Add(this.grdBatchManagement);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Batchmangement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bachmangement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bachmangement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBatchManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBatchManagement;
        private System.Windows.Forms.Label lbltrainername;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblbatchname;
        private System.Windows.Forms.ComboBox cmbbxtrainername;
        private System.Windows.Forms.ComboBox cmbbxcourse;
        private System.Windows.Forms.ComboBox cmbbxbatchname;
        private System.Windows.Forms.PictureBox pictbxExcel;
        private System.Windows.Forms.PictureBox pictbxPDF;
        private System.Windows.Forms.PictureBox pictRefresh;
        private System.Windows.Forms.PictureBox pictbxPlus;
        private System.Windows.Forms.PictureBox picbxFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.PictureBox picbxSearch;
        private System.Windows.Forms.Button btnNewBatch;
        private System.Windows.Forms.PictureBox picbxDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTipRefresh;
        private System.Windows.Forms.ToolTip toolTipPDF;
        private System.Windows.Forms.ToolTip toolTipExcel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewLinkColumn clmMerge;
        private System.Windows.Forms.DataGridViewLinkColumn clmViewBatch;
    }
}