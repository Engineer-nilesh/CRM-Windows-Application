namespace GSTEducationalCRMSoft
{
    partial class ViewBatchDetails
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
            this.lblcoursename = new System.Windows.Forms.Label();
            this.lblbatchname = new System.Windows.Forms.Label();
            this.lbltrainer = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.labelbatch = new System.Windows.Forms.Label();
            this.labelTrainer = new System.Windows.Forms.Label();
            this.lblselectcourse = new System.Windows.Forms.Label();
            this.lblbatch = new System.Windows.Forms.Label();
            this.cmbbxselectcourse = new System.Windows.Forms.ComboBox();
            this.cmbbxbatchname = new System.Windows.Forms.ComboBox();
            this.lbladdstudents = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridviewStudentdetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gridviewAddStudent = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCourseType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudentdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAddStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.BackColor = System.Drawing.Color.Transparent;
            this.lblcoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(393, 356);
            this.lblcoursename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(144, 25);
            this.lblcoursename.TabIndex = 0;
            this.lblcoursename.Text = "Course Name :";
            // 
            // lblbatchname
            // 
            this.lblbatchname.AutoSize = true;
            this.lblbatchname.BackColor = System.Drawing.Color.Transparent;
            this.lblbatchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbatchname.Location = new System.Drawing.Point(409, 315);
            this.lblbatchname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbatchname.Name = "lblbatchname";
            this.lblbatchname.Size = new System.Drawing.Size(130, 25);
            this.lblbatchname.TabIndex = 1;
            this.lblbatchname.Text = "Batch Name :";
            // 
            // lbltrainer
            // 
            this.lbltrainer.AutoSize = true;
            this.lbltrainer.BackColor = System.Drawing.Color.Transparent;
            this.lbltrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrainer.Location = new System.Drawing.Point(437, 279);
            this.lbltrainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltrainer.Name = "lbltrainer";
            this.lbltrainer.Size = new System.Drawing.Size(85, 25);
            this.lbltrainer.TabIndex = 2;
            this.lbltrainer.Text = "Trainer :";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.BackColor = System.Drawing.Color.Transparent;
            this.lblcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourse.Location = new System.Drawing.Point(627, 359);
            this.lblcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(64, 25);
            this.lblcourse.TabIndex = 3;
            this.lblcourse.Text = "label1";
            // 
            // labelbatch
            // 
            this.labelbatch.AutoSize = true;
            this.labelbatch.BackColor = System.Drawing.Color.Transparent;
            this.labelbatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbatch.Location = new System.Drawing.Point(627, 326);
            this.labelbatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbatch.Name = "labelbatch";
            this.labelbatch.Size = new System.Drawing.Size(64, 25);
            this.labelbatch.TabIndex = 4;
            this.labelbatch.Text = "label2";
            this.labelbatch.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTrainer
            // 
            this.labelTrainer.AutoSize = true;
            this.labelTrainer.BackColor = System.Drawing.Color.Transparent;
            this.labelTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainer.Location = new System.Drawing.Point(627, 279);
            this.labelTrainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrainer.Name = "labelTrainer";
            this.labelTrainer.Size = new System.Drawing.Size(64, 25);
            this.labelTrainer.TabIndex = 5;
            this.labelTrainer.Text = "label3";
            this.labelTrainer.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblselectcourse
            // 
            this.lblselectcourse.AutoSize = true;
            this.lblselectcourse.BackColor = System.Drawing.Color.Transparent;
            this.lblselectcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectcourse.Location = new System.Drawing.Point(968, 295);
            this.lblselectcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblselectcourse.Name = "lblselectcourse";
            this.lblselectcourse.Size = new System.Drawing.Size(147, 25);
            this.lblselectcourse.TabIndex = 6;
            this.lblselectcourse.Text = "Select Course :";
            // 
            // lblbatch
            // 
            this.lblbatch.AutoSize = true;
            this.lblbatch.BackColor = System.Drawing.Color.Transparent;
            this.lblbatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbatch.Location = new System.Drawing.Point(986, 348);
            this.lblbatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbatch.Name = "lblbatch";
            this.lblbatch.Size = new System.Drawing.Size(130, 25);
            this.lblbatch.TabIndex = 7;
            this.lblbatch.Text = "Batch Name :";
            // 
            // cmbbxselectcourse
            // 
            this.cmbbxselectcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxselectcourse.FormattingEnabled = true;
            this.cmbbxselectcourse.Location = new System.Drawing.Point(1153, 288);
            this.cmbbxselectcourse.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxselectcourse.Name = "cmbbxselectcourse";
            this.cmbbxselectcourse.Size = new System.Drawing.Size(224, 33);
            this.cmbbxselectcourse.TabIndex = 8;
            this.cmbbxselectcourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxselectcourse_SelectedIndexChanged);
            // 
            // cmbbxbatchname
            // 
            this.cmbbxbatchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxbatchname.FormattingEnabled = true;
            this.cmbbxbatchname.Location = new System.Drawing.Point(1153, 341);
            this.cmbbxbatchname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxbatchname.Name = "cmbbxbatchname";
            this.cmbbxbatchname.Size = new System.Drawing.Size(224, 33);
            this.cmbbxbatchname.TabIndex = 9;
            this.cmbbxbatchname.SelectedIndexChanged += new System.EventHandler(this.cmbbxbatchname_SelectedIndexChanged);
            // 
            // lbladdstudents
            // 
            this.lbladdstudents.AutoSize = true;
            this.lbladdstudents.BackColor = System.Drawing.Color.Transparent;
            this.lbladdstudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdstudents.Location = new System.Drawing.Point(873, 452);
            this.lbladdstudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdstudents.Name = "lbladdstudents";
            this.lbladdstudents.Size = new System.Drawing.Size(142, 25);
            this.lbladdstudents.TabIndex = 10;
            this.lbladdstudents.Text = "Add Students :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(964, 700);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 48);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(801, 700);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 48);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridviewStudentdetail
            // 
            this.gridviewStudentdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewStudentdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewStudentdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gridviewStudentdetail.Location = new System.Drawing.Point(325, 406);
            this.gridviewStudentdetail.Margin = new System.Windows.Forms.Padding(4);
            this.gridviewStudentdetail.Name = "gridviewStudentdetail";
            this.gridviewStudentdetail.RowHeadersVisible = false;
            this.gridviewStudentdetail.RowHeadersWidth = 62;
            this.gridviewStudentdetail.Size = new System.Drawing.Size(440, 231);
            this.gridviewStudentdetail.TabIndex = 18;
            this.gridviewStudentdetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Marge";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // gridviewAddStudent
            // 
            this.gridviewAddStudent.AllowUserToAddRows = false;
            this.gridviewAddStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewAddStudent.ColumnHeadersHeight = 29;
            this.gridviewAddStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox});
            this.gridviewAddStudent.Location = new System.Drawing.Point(1153, 398);
            this.gridviewAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gridviewAddStudent.Name = "gridviewAddStudent";
            this.gridviewAddStudent.RowHeadersVisible = false;
            this.gridviewAddStudent.RowHeadersWidth = 62;
            this.gridviewAddStudent.Size = new System.Drawing.Size(357, 194);
            this.gridviewAddStudent.TabIndex = 19;
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "Select";
            this.checkbox.MinimumWidth = 8;
            this.checkbox.Name = "checkbox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Batch Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1073, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 64);
            this.button1.TabIndex = 21;
            this.button1.Text = "Click Here To Add from Other Course";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1148, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select Course :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(907, 497);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 51);
            this.button2.TabIndex = 23;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCourseType
            // 
            this.lblCourseType.AutoSize = true;
            this.lblCourseType.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseType.Location = new System.Drawing.Point(969, 250);
            this.lblCourseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseType.Name = "lblCourseType";
            this.lblCourseType.Size = new System.Drawing.Size(137, 25);
            this.lblCourseType.TabIndex = 24;
            this.lblCourseType.Text = "Course Type :";
            // 
            // ViewBatchDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1818, 1055);
            this.Controls.Add(this.lblCourseType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridviewAddStudent);
            this.Controls.Add(this.gridviewStudentdetail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbladdstudents);
            this.Controls.Add(this.cmbbxbatchname);
            this.Controls.Add(this.cmbbxselectcourse);
            this.Controls.Add(this.lblbatch);
            this.Controls.Add(this.lblselectcourse);
            this.Controls.Add(this.labelTrainer);
            this.Controls.Add(this.labelbatch);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lbltrainer);
            this.Controls.Add(this.lblbatchname);
            this.Controls.Add(this.lblcoursename);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewBatchDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewBatchDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudentdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAddStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Label lblbatchname;
        private System.Windows.Forms.Label lbltrainer;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label labelbatch;
        private System.Windows.Forms.Label labelTrainer;
        private System.Windows.Forms.Label lblselectcourse;
        private System.Windows.Forms.Label lblbatch;
        private System.Windows.Forms.ComboBox cmbbxselectcourse;
        private System.Windows.Forms.ComboBox cmbbxbatchname;
        private System.Windows.Forms.Label lbladdstudents;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridviewStudentdetail;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridView gridviewAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.Label lblCourseType;
    }
}