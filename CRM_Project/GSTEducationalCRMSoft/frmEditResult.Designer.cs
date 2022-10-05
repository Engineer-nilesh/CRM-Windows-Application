namespace GSTEducationalCRMSoft
{
    partial class frmEditResult
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
            this.lblExamName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.cmbbxexamname = new System.Windows.Forms.ComboBox();
            this.cmbbxbatchname = new System.Windows.Forms.ComboBox();
            this.cmbbxcoursename = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdupdateresult = new System.Windows.Forms.DataGridView();
            this.StudCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbxmrks = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdupdateresult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.BackColor = System.Drawing.Color.Transparent;
            this.lblExamName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamName.Location = new System.Drawing.Point(102, 49);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(122, 23);
            this.lblExamName.TabIndex = 0;
            this.lblExamName.Text = "Exam Name:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(101, 107);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(136, 23);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Batch Performance:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Name";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchName.Location = new System.Drawing.Point(114, 163);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(123, 23);
            this.lblBatchName.TabIndex = 5;
            this.lblBatchName.Text = "Batch Name:";
            // 
            // cmbbxexamname
            // 
            this.cmbbxexamname.FormattingEnabled = true;
            this.cmbbxexamname.Location = new System.Drawing.Point(285, 49);
            this.cmbbxexamname.Name = "cmbbxexamname";
            this.cmbbxexamname.Size = new System.Drawing.Size(153, 24);
            this.cmbbxexamname.TabIndex = 6;
            // 
            // cmbbxbatchname
            // 
            this.cmbbxbatchname.FormattingEnabled = true;
            this.cmbbxbatchname.Location = new System.Drawing.Point(285, 166);
            this.cmbbxbatchname.Name = "cmbbxbatchname";
            this.cmbbxbatchname.Size = new System.Drawing.Size(153, 24);
            this.cmbbxbatchname.TabIndex = 7;
            // 
            // cmbbxcoursename
            // 
            this.cmbbxcoursename.FormattingEnabled = true;
            this.cmbbxcoursename.Location = new System.Drawing.Point(285, 106);
            this.cmbbxcoursename.Name = "cmbbxcoursename";
            this.cmbbxcoursename.Size = new System.Drawing.Size(153, 24);
            this.cmbbxcoursename.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Obtained Marks";
            // 
            // grdupdateresult
            // 
            this.grdupdateresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdupdateresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdupdateresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudCode,
            this.ObtainedMarks});
            this.grdupdateresult.Location = new System.Drawing.Point(67, 272);
            this.grdupdateresult.Name = "grdupdateresult";
            this.grdupdateresult.RowHeadersVisible = false;
            this.grdupdateresult.RowHeadersWidth = 51;
            this.grdupdateresult.RowTemplate.Height = 24;
            this.grdupdateresult.Size = new System.Drawing.Size(483, 224);
            this.grdupdateresult.TabIndex = 10;
            // 
            // StudCode
            // 
            this.StudCode.HeaderText = "Student Name";
            this.StudCode.MinimumWidth = 6;
            this.StudCode.Name = "StudCode";
            this.StudCode.ToolTipText = "Student Name";
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.MinimumWidth = 6;
            this.ObtainedMarks.Name = "ObtainedMarks";
            // 
            // txtbxmrks
            // 
            this.txtbxmrks.Location = new System.Drawing.Point(318, 518);
            this.txtbxmrks.Name = "txtbxmrks";
            this.txtbxmrks.Size = new System.Drawing.Size(135, 22);
            this.txtbxmrks.TabIndex = 11;
            this.txtbxmrks.TextChanged += new System.EventHandler(this.txtbxmrks_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(136, 579);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 44);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Transparent;
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(334, 579);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(119, 44);
            this.btnCancle.TabIndex = 13;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = false;
            // 
            // frmEditResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 675);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtbxmrks);
            this.Controls.Add(this.grdupdateresult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbbxcoursename);
            this.Controls.Add(this.cmbbxbatchname);
            this.Controls.Add(this.cmbbxexamname);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblExamName);
            this.Name = "frmEditResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Result";
            this.Load += new System.EventHandler(this.frmEditResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdupdateresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.ComboBox cmbbxexamname;
        private System.Windows.Forms.ComboBox cmbbxbatchname;
        private System.Windows.Forms.ComboBox cmbbxcoursename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdupdateresult;
        private System.Windows.Forms.TextBox txtbxmrks;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
    }
}