namespace GSTEducationalCRMSoft
{
    partial class frmViewStudents
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
            this.grdViewStudent = new System.Windows.Forms.DataGridView();
            this.lnkViewMore = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewStudent
            // 
            this.grdViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lnkViewMore});
            this.grdViewStudent.Location = new System.Drawing.Point(48, 251);
            this.grdViewStudent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdViewStudent.Name = "grdViewStudent";
            this.grdViewStudent.RowHeadersVisible = false;
            this.grdViewStudent.RowHeadersWidth = 51;
            this.grdViewStudent.RowTemplate.Height = 24;
            this.grdViewStudent.Size = new System.Drawing.Size(936, 292);
            this.grdViewStudent.TabIndex = 0;
            this.grdViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewStudent_CellContentClick);
            // 
            // lnkViewMore
            // 
            this.lnkViewMore.HeaderText = "View More";
            this.lnkViewMore.MinimumWidth = 6;
            this.lnkViewMore.Name = "lnkViewMore";
            this.lnkViewMore.Text = "View More";
            this.lnkViewMore.ToolTipText = "View More";
            this.lnkViewMore.UseColumnTextForLinkValue = true;
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExamTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTitle.Location = new System.Drawing.Point(56, 168);
            this.lblExamTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(130, 27);
            this.lblExamTitle.TabIndex = 1;
            this.lblExamTitle.Text = "Exam Title:";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchName.Location = new System.Drawing.Point(662, 168);
            this.lblBatchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(151, 27);
            this.lblBatchName.TabIndex = 2;
            this.lblBatchName.Text = "Batch Name:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(338, 168);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(166, 27);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(202, 172);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(62, 23);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "label1";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(521, 172);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(62, 23);
            this.lblCourse.TabIndex = 5;
            this.lblCourse.Text = "label2";
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.BackColor = System.Drawing.Color.Transparent;
            this.lblBatch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(827, 172);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(62, 23);
            this.lblBatch.TabIndex = 6;
            this.lblBatch.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "View Student ";
            // 
            // frmViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblExamTitle);
            this.Controls.Add(this.grdViewStudent);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmViewStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student Details";
            this.Load += new System.EventHandler(this.frmViewStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewStudent;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.DataGridViewLinkColumn lnkViewMore;
        private System.Windows.Forms.Label label1;
    }
}