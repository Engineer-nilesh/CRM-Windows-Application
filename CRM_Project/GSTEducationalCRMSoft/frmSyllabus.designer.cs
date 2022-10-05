namespace GSTEducationalCRMSoft
{
    partial class frmSyllabus
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
            this.openFileDialogSyll = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictbxRefresh2 = new System.Windows.Forms.PictureBox();
            this.rtbxDescription = new System.Windows.Forms.RichTextBox();
            this.txtSyllabusName = new System.Windows.Forms.TextBox();
            this.cmbbxCourse = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSyllabusName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.lblSyllabus = new System.Windows.Forms.Label();
            this.grdSyllabusView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxRefresh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSyllabusView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogSyll
            // 
            this.openFileDialogSyll.FileName = "openFileDialogSyll";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictbxRefresh2);
            this.panel1.Controls.Add(this.rtbxDescription);
            this.panel1.Controls.Add(this.txtSyllabusName);
            this.panel1.Controls.Add(this.cmbbxCourse);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblSyllabusName);
            this.panel1.Controls.Add(this.lblCourseName);
            this.panel1.Controls.Add(this.btnUploadFile);
            this.panel1.Controls.Add(this.lblSyllabus);
            this.panel1.Controls.Add(this.grdSyllabusView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 666);
            this.panel1.TabIndex = 0;
            // 
            // pictbxRefresh2
            // 
            this.pictbxRefresh2.BackColor = System.Drawing.Color.Transparent;
            this.pictbxRefresh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbxRefresh2.Image = global::GSTEducationalCRMSoft.Properties.Resources.refresh2;
            this.pictbxRefresh2.Location = new System.Drawing.Point(267, 30);
            this.pictbxRefresh2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictbxRefresh2.Name = "pictbxRefresh2";
            this.pictbxRefresh2.Size = new System.Drawing.Size(38, 38);
            this.pictbxRefresh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxRefresh2.TabIndex = 55;
            this.pictbxRefresh2.TabStop = false;
            this.pictbxRefresh2.Click += new System.EventHandler(this.pictbxRefresh2_Click);
            // 
            // rtbxDescription
            // 
            this.rtbxDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxDescription.Location = new System.Drawing.Point(293, 246);
            this.rtbxDescription.Name = "rtbxDescription";
            this.rtbxDescription.Size = new System.Drawing.Size(259, 53);
            this.rtbxDescription.TabIndex = 28;
            this.rtbxDescription.Text = "";
            // 
            // txtSyllabusName
            // 
            this.txtSyllabusName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSyllabusName.Location = new System.Drawing.Point(293, 188);
            this.txtSyllabusName.Name = "txtSyllabusName";
            this.txtSyllabusName.Size = new System.Drawing.Size(259, 30);
            this.txtSyllabusName.TabIndex = 27;
            // 
            // cmbbxCourse
            // 
            this.cmbbxCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCourse.FormattingEnabled = true;
            this.cmbbxCourse.Location = new System.Drawing.Point(293, 132);
            this.cmbbxCourse.Name = "cmbbxCourse";
            this.cmbbxCourse.Size = new System.Drawing.Size(259, 31);
            this.cmbbxCourse.TabIndex = 26;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(132, 258);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(139, 26);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description :";
            // 
            // lblSyllabusName
            // 
            this.lblSyllabusName.AutoSize = true;
            this.lblSyllabusName.BackColor = System.Drawing.Color.Transparent;
            this.lblSyllabusName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyllabusName.Location = new System.Drawing.Point(97, 192);
            this.lblSyllabusName.Name = "lblSyllabusName";
            this.lblSyllabusName.Size = new System.Drawing.Size(174, 26);
            this.lblSyllabusName.TabIndex = 23;
            this.lblSyllabusName.Text = "Syllabus Name :";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(111, 137);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(160, 26);
            this.lblCourseName.TabIndex = 22;
            this.lblCourseName.Text = "CourseName :";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadFile.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.Location = new System.Drawing.Point(326, 323);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(179, 42);
            this.btnUploadFile.TabIndex = 20;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // lblSyllabus
            // 
            this.lblSyllabus.AutoSize = true;
            this.lblSyllabus.BackColor = System.Drawing.Color.Transparent;
            this.lblSyllabus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyllabus.Location = new System.Drawing.Point(49, 20);
            this.lblSyllabus.Name = "lblSyllabus";
            this.lblSyllabus.Size = new System.Drawing.Size(179, 48);
            this.lblSyllabus.TabIndex = 19;
            this.lblSyllabus.Text = "Syllabus";
            // 
            // grdSyllabusView
            // 
            this.grdSyllabusView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSyllabusView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.grdSyllabusView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSyllabusView.Location = new System.Drawing.Point(138, 387);
            this.grdSyllabusView.Name = "grdSyllabusView";
            this.grdSyllabusView.RowHeadersVisible = false;
            this.grdSyllabusView.RowHeadersWidth = 51;
            this.grdSyllabusView.RowTemplate.Height = 24;
            this.grdSyllabusView.Size = new System.Drawing.Size(574, 236);
            this.grdSyllabusView.TabIndex = 0;
            this.grdSyllabusView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSyllabusView_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Download";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Text = "Download";
            this.Column3.ToolTipText = "Download";
            this.Column3.UseColumnTextForLinkValue = true;
            // 
            // frmSyllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 666);
            this.Controls.Add(this.panel1);
            this.Name = "frmSyllabus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syllabus Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSyllabus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxRefresh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSyllabusView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdSyllabusView;
        private System.Windows.Forms.Label lblSyllabus;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogSyll;
        private System.Windows.Forms.RichTextBox rtbxDescription;
        private System.Windows.Forms.TextBox txtSyllabusName;
        private System.Windows.Forms.ComboBox cmbbxCourse;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSyllabusName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.PictureBox pictbxRefresh2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
    }
}