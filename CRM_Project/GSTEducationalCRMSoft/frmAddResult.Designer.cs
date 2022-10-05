namespace GSTEducationalCRMSoft
{
    partial class frmAddResult
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
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblObtainedMarks = new System.Windows.Forms.Label();
            this.lblBatchMarks = new System.Windows.Forms.Label();
            this.cmbbxExamTitle = new System.Windows.Forms.ComboBox();
            this.cmbbxBatchName = new System.Windows.Forms.ComboBox();
            this.cmbbxCourseName = new System.Windows.Forms.ComboBox();
            this.txttotalMarks = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdaddresult = new System.Windows.Forms.DataGridView();
            this.txtmarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdaddresult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.BackColor = System.Drawing.Color.Transparent;
            this.lblTestName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(157, 100);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(110, 23);
            this.lblTestName.TabIndex = 0;
            this.lblTestName.Text = "Test Name:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(140, 168);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(136, 23);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchName.Location = new System.Drawing.Point(153, 238);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(123, 23);
            this.lblBatchName.TabIndex = 2;
            this.lblBatchName.Text = "Batch Name:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(142, 300);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(134, 23);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Student Name";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // lblObtainedMarks
            // 
            this.lblObtainedMarks.AutoSize = true;
            this.lblObtainedMarks.BackColor = System.Drawing.Color.Transparent;
            this.lblObtainedMarks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObtainedMarks.Location = new System.Drawing.Point(322, 300);
            this.lblObtainedMarks.Name = "lblObtainedMarks";
            this.lblObtainedMarks.Size = new System.Drawing.Size(151, 23);
            this.lblObtainedMarks.TabIndex = 4;
            this.lblObtainedMarks.Text = "Obtained Marks";
            // 
            // lblBatchMarks
            // 
            this.lblBatchMarks.AutoSize = true;
            this.lblBatchMarks.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchMarks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchMarks.Location = new System.Drawing.Point(153, 569);
            this.lblBatchMarks.Name = "lblBatchMarks";
            this.lblBatchMarks.Size = new System.Drawing.Size(127, 23);
            this.lblBatchMarks.TabIndex = 5;
            this.lblBatchMarks.Text = "Batch Marks:";
            this.lblBatchMarks.Click += new System.EventHandler(this.lblBatchMarks_Click);
            // 
            // cmbbxExamTitle
            // 
            this.cmbbxExamTitle.FormattingEnabled = true;
            this.cmbbxExamTitle.Location = new System.Drawing.Point(326, 100);
            this.cmbbxExamTitle.Name = "cmbbxExamTitle";
            this.cmbbxExamTitle.Size = new System.Drawing.Size(147, 24);
            this.cmbbxExamTitle.TabIndex = 6;
            this.cmbbxExamTitle.SelectedIndexChanged += new System.EventHandler(this.cmbbxExamTitle_SelectedIndexChanged);
            // 
            // cmbbxBatchName
            // 
            this.cmbbxBatchName.FormattingEnabled = true;
            this.cmbbxBatchName.Location = new System.Drawing.Point(326, 241);
            this.cmbbxBatchName.Name = "cmbbxBatchName";
            this.cmbbxBatchName.Size = new System.Drawing.Size(147, 24);
            this.cmbbxBatchName.TabIndex = 7;
            this.cmbbxBatchName.SelectedIndexChanged += new System.EventHandler(this.cmbbxBatchName_SelectedIndexChanged);
            // 
            // cmbbxCourseName
            // 
            this.cmbbxCourseName.FormattingEnabled = true;
            this.cmbbxCourseName.Location = new System.Drawing.Point(326, 171);
            this.cmbbxCourseName.Name = "cmbbxCourseName";
            this.cmbbxCourseName.Size = new System.Drawing.Size(147, 24);
            this.cmbbxCourseName.TabIndex = 8;
            this.cmbbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourseName_SelectedIndexChanged);
            // 
            // txttotalMarks
            // 
            this.txttotalMarks.Location = new System.Drawing.Point(338, 572);
            this.txttotalMarks.Name = "txttotalMarks";
            this.txttotalMarks.Size = new System.Drawing.Size(147, 22);
            this.txttotalMarks.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(153, 645);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 41);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(338, 645);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 41);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // grdaddresult
            // 
            this.grdaddresult.AllowUserToAddRows = false;
            this.grdaddresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdaddresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdaddresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtmarks});
            this.grdaddresult.Location = new System.Drawing.Point(129, 339);
            this.grdaddresult.Name = "grdaddresult";
            this.grdaddresult.RowHeadersWidth = 51;
            this.grdaddresult.RowTemplate.Height = 24;
            this.grdaddresult.Size = new System.Drawing.Size(436, 215);
            this.grdaddresult.TabIndex = 12;
            // 
            // txtmarks
            // 
            this.txtmarks.HeaderText = "Marks";
            this.txtmarks.MinimumWidth = 6;
            this.txtmarks.Name = "txtmarks";
            this.txtmarks.ToolTipText = "Marks";
            // 
            // frmAddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 766);
            this.Controls.Add(this.grdaddresult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txttotalMarks);
            this.Controls.Add(this.cmbbxCourseName);
            this.Controls.Add(this.cmbbxBatchName);
            this.Controls.Add(this.cmbbxExamTitle);
            this.Controls.Add(this.lblBatchMarks);
            this.Controls.Add(this.lblObtainedMarks);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblTestName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmAddResult";
            this.Text = "Add Result";
            this.Load += new System.EventHandler(this.frmAddResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdaddresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblObtainedMarks;
        private System.Windows.Forms.Label lblBatchMarks;
        private System.Windows.Forms.ComboBox cmbbxExamTitle;
        private System.Windows.Forms.ComboBox cmbbxBatchName;
        private System.Windows.Forms.ComboBox cmbbxCourseName;
        private System.Windows.Forms.TextBox txttotalMarks;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView grdaddresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmarks;
    }
}