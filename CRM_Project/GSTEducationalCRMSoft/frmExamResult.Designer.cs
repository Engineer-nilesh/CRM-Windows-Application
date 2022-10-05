namespace GSTEducationalCRMSoft
{
    partial class frmExamResult
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
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.cmbbxExamTitle = new System.Windows.Forms.ComboBox();
            this.cmbbxCourseName = new System.Windows.Forms.ComboBox();
            this.cmbbxBatchName = new System.Windows.Forms.ComboBox();
            this.grdExamResult = new System.Windows.Forms.DataGridView();
            this.lnkViewStudents = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lnkEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdExamResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchName.Location = new System.Drawing.Point(680, 158);
            this.lblBatchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(123, 23);
            this.lblBatchName.TabIndex = 0;
            this.lblBatchName.Text = "Batch Name:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(350, 158);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(136, 23);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExamTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTitle.Location = new System.Drawing.Point(56, 158);
            this.lblExamTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(107, 23);
            this.lblExamTitle.TabIndex = 2;
            this.lblExamTitle.Text = "Exam Title:";
            // 
            // cmbbxExamTitle
            // 
            this.cmbbxExamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxExamTitle.FormattingEnabled = true;
            this.cmbbxExamTitle.Location = new System.Drawing.Point(169, 153);
            this.cmbbxExamTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbbxExamTitle.Name = "cmbbxExamTitle";
            this.cmbbxExamTitle.Size = new System.Drawing.Size(164, 33);
            this.cmbbxExamTitle.TabIndex = 3;
            this.cmbbxExamTitle.SelectedIndexChanged += new System.EventHandler(this.cmbbxExamTitle_SelectedIndexChanged);
            // 
            // cmbbxCourseName
            // 
            this.cmbbxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCourseName.FormattingEnabled = true;
            this.cmbbxCourseName.Location = new System.Drawing.Point(493, 153);
            this.cmbbxCourseName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbbxCourseName.Name = "cmbbxCourseName";
            this.cmbbxCourseName.Size = new System.Drawing.Size(169, 33);
            this.cmbbxCourseName.TabIndex = 4;
            this.cmbbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourseName_SelectedIndexChanged);
            // 
            // cmbbxBatchName
            // 
            this.cmbbxBatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxBatchName.FormattingEnabled = true;
            this.cmbbxBatchName.Location = new System.Drawing.Point(811, 153);
            this.cmbbxBatchName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbbxBatchName.Name = "cmbbxBatchName";
            this.cmbbxBatchName.Size = new System.Drawing.Size(168, 33);
            this.cmbbxBatchName.TabIndex = 5;
            this.cmbbxBatchName.SelectedIndexChanged += new System.EventHandler(this.cmbbxBatchName_SelectedIndexChanged);
            // 
            // grdExamResult
            // 
            this.grdExamResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdExamResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExamResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lnkViewStudents,
            this.lnkEdit});
            this.grdExamResult.Location = new System.Drawing.Point(58, 220);
            this.grdExamResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdExamResult.Name = "grdExamResult";
            this.grdExamResult.RowHeadersVisible = false;
            this.grdExamResult.RowHeadersWidth = 51;
            this.grdExamResult.RowTemplate.Height = 24;
            this.grdExamResult.Size = new System.Drawing.Size(1462, 338);
            this.grdExamResult.TabIndex = 6;
            this.grdExamResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExamResult_CellContentClick);
            // 
            // lnkViewStudents
            // 
            this.lnkViewStudents.HeaderText = "View Students";
            this.lnkViewStudents.MinimumWidth = 6;
            this.lnkViewStudents.Name = "lnkViewStudents";
            this.lnkViewStudents.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lnkViewStudents.Text = "View Students";
            this.lnkViewStudents.ToolTipText = "View Students";
            this.lnkViewStudents.UseColumnTextForLinkValue = true;
            // 
            // lnkEdit
            // 
            this.lnkEdit.HeaderText = "Edit";
            this.lnkEdit.MinimumWidth = 6;
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.Text = "Edit";
            this.lnkEdit.ToolTipText = "Edit";
            this.lnkEdit.UseColumnTextForLinkValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exam Result";
            // 
            // frmExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1603, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdExamResult);
            this.Controls.Add(this.cmbbxBatchName);
            this.Controls.Add(this.cmbbxCourseName);
            this.Controls.Add(this.cmbbxExamTitle);
            this.Controls.Add(this.lblExamTitle);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblBatchName);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmExamResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExamResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExamResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.ComboBox cmbbxExamTitle;
        private System.Windows.Forms.ComboBox cmbbxCourseName;
        private System.Windows.Forms.ComboBox cmbbxBatchName;
        private System.Windows.Forms.DataGridView grdExamResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewLinkColumn lnkViewStudents;
        private System.Windows.Forms.DataGridViewLinkColumn lnkEdit;
        private System.Windows.Forms.Label label1;
    }
}