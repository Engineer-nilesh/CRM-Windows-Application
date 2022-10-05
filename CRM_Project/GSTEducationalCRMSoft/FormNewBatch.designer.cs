namespace GSTEducationalCRMSoft
{
    partial class FormNewBatch
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cmbbxCourseName = new System.Windows.Forms.ComboBox();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.lblBatchTime = new System.Windows.Forms.Label();
            this.lblLabName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.cmbbxBatchTime = new System.Windows.Forms.ComboBox();
            this.cmbbxLabName = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbbxStatus = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.lblTentativeEndDate = new System.Windows.Forms.Label();
            this.cmbbxTrainer = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(65, 53);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(173, 27);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name :";
            // 
            // cmbbxCourseName
            // 
            this.cmbbxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCourseName.FormattingEnabled = true;
            this.cmbbxCourseName.Location = new System.Drawing.Point(275, 49);
            this.cmbbxCourseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxCourseName.Name = "cmbbxCourseName";
            this.cmbbxCourseName.Size = new System.Drawing.Size(225, 33);
            this.cmbbxCourseName.TabIndex = 1;
            this.cmbbxCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbbxCourseName_SelectedIndexChanged);
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchName.Location = new System.Drawing.Point(81, 105);
            this.lblBatchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(158, 27);
            this.lblBatchName.TabIndex = 2;
            this.lblBatchName.Text = "Batch Name :";
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainer.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainer.Location = new System.Drawing.Point(143, 159);
            this.lblTrainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(100, 27);
            this.lblTrainer.TabIndex = 3;
            this.lblTrainer.Text = "Trainer :";
            // 
            // lblBatchTime
            // 
            this.lblBatchTime.AutoSize = true;
            this.lblBatchTime.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchTime.Location = new System.Drawing.Point(617, 42);
            this.lblBatchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatchTime.Name = "lblBatchTime";
            this.lblBatchTime.Size = new System.Drawing.Size(146, 27);
            this.lblBatchTime.TabIndex = 4;
            this.lblBatchTime.Text = "Batch Time :";
            // 
            // lblLabName
            // 
            this.lblLabName.AutoSize = true;
            this.lblLabName.BackColor = System.Drawing.Color.Transparent;
            this.lblLabName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabName.Location = new System.Drawing.Point(625, 95);
            this.lblLabName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabName.Name = "lblLabName";
            this.lblLabName.Size = new System.Drawing.Size(136, 27);
            this.lblLabName.TabIndex = 5;
            this.lblLabName.Text = "Lab Name :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(107, 206);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(134, 27);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date :";
            // 
            // txtBatchName
            // 
            this.txtBatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchName.Location = new System.Drawing.Point(275, 102);
            this.txtBatchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(225, 30);
            this.txtBatchName.TabIndex = 7;
            // 
            // cmbbxBatchTime
            // 
            this.cmbbxBatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxBatchTime.FormattingEnabled = true;
            this.cmbbxBatchTime.Items.AddRange(new object[] {
            "10amto11pm",
            "11amto12pm",
            "12pmto1pm",
            "2pmto3pm",
            "3pmto4pm",
            "4pmto5pm",
            "5pmto6pm",
            "6pmo7pm"});
            this.cmbbxBatchTime.Location = new System.Drawing.Point(797, 38);
            this.cmbbxBatchTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxBatchTime.Name = "cmbbxBatchTime";
            this.cmbbxBatchTime.Size = new System.Drawing.Size(225, 33);
            this.cmbbxBatchTime.TabIndex = 11;
            this.cmbbxBatchTime.SelectedValueChanged += new System.EventHandler(this.cmbbxBatchTime_SelectedValueChanged);
            // 
            // cmbbxLabName
            // 
            this.cmbbxLabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxLabName.FormattingEnabled = true;
            this.cmbbxLabName.Location = new System.Drawing.Point(797, 90);
            this.cmbbxLabName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxLabName.Name = "cmbbxLabName";
            this.cmbbxLabName.Size = new System.Drawing.Size(225, 33);
            this.cmbbxLabName.TabIndex = 12;
            this.cmbbxLabName.SelectedIndexChanged += new System.EventHandler(this.cmbbxLabName_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(381, 281);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 27);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status :";
            // 
            // cmbbxStatus
            // 
            this.cmbbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxStatus.FormattingEnabled = true;
            this.cmbbxStatus.Location = new System.Drawing.Point(509, 277);
            this.cmbbxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxStatus.Name = "cmbbxStatus";
            this.cmbbxStatus.Size = new System.Drawing.Size(225, 33);
            this.cmbbxStatus.TabIndex = 14;
            this.cmbbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxStatus_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(396, 469);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 36);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(537, 469);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 36);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblAddStudent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudent.Location = new System.Drawing.Point(313, 366);
            this.lblAddStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(161, 27);
            this.lblAddStudent.TabIndex = 18;
            this.lblAddStudent.Text = "Add Student :";
            // 
            // lblTentativeEndDate
            // 
            this.lblTentativeEndDate.AutoSize = true;
            this.lblTentativeEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTentativeEndDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativeEndDate.Location = new System.Drawing.Point(532, 202);
            this.lblTentativeEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTentativeEndDate.Name = "lblTentativeEndDate";
            this.lblTentativeEndDate.Size = new System.Drawing.Size(228, 27);
            this.lblTentativeEndDate.TabIndex = 22;
            this.lblTentativeEndDate.Text = "Tentative End Date :";
            // 
            // cmbbxTrainer
            // 
            this.cmbbxTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTrainer.FormattingEnabled = true;
            this.cmbbxTrainer.Location = new System.Drawing.Point(275, 155);
            this.cmbbxTrainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxTrainer.Name = "cmbbxTrainer";
            this.cmbbxTrainer.Size = new System.Drawing.Size(225, 33);
            this.cmbbxTrainer.TabIndex = 10;
            this.cmbbxTrainer.SelectedIndexChanged += new System.EventHandler(this.cmbbxTrainer_SelectedIndexChanged);
            this.cmbbxTrainer.TextChanged += new System.EventHandler(this.cmbbxTrainer_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 201);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 34);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(797, 199);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(225, 34);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox});
            this.dataGridView1.Location = new System.Drawing.Point(509, 337);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(327, 106);
            this.dataGridView1.TabIndex = 25;
            // 
            // checkbox
            // 
            this.checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkbox.HeaderText = "";
            this.checkbox.MinimumWidth = 8;
            this.checkbox.Name = "checkbox";
            // 
            // FormNewBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTentativeEndDate);
            this.Controls.Add(this.lblAddStudent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbbxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbbxLabName);
            this.Controls.Add(this.cmbbxBatchTime);
            this.Controls.Add(this.cmbbxTrainer);
            this.Controls.Add(this.txtBatchName);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLabName);
            this.Controls.Add(this.lblBatchTime);
            this.Controls.Add(this.lblTrainer);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.cmbbxCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNewBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewBatch";
            this.Load += new System.EventHandler(this.FormNewBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cmbbxCourseName;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.Label lblBatchTime;
        private System.Windows.Forms.Label lblLabName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.ComboBox cmbbxBatchTime;
        private System.Windows.Forms.ComboBox cmbbxLabName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbbxStatus;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.Label lblTentativeEndDate;
        private System.Windows.Forms.ComboBox cmbbxTrainer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
    }
}