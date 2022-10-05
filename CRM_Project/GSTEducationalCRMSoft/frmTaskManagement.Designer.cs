namespace GSTEducationalCRMSoft
{
    partial class frmTaskManagement
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
            this.panelTaskManagement = new System.Windows.Forms.Panel();
            this.pictRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictbxCalender2 = new System.Windows.Forms.PictureBox();
            this.pictbxCalender1 = new System.Windows.Forms.PictureBox();
            this.grdTaskManagementView = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cmbbxtaskStatus = new System.Windows.Forms.ComboBox();
            this.datePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTaskManagement = new System.Windows.Forms.Label();
            this.panelTaskManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskManagementView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskManagement
            // 
            this.panelTaskManagement.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panelTaskManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTaskManagement.Controls.Add(this.pictRefresh);
            this.panelTaskManagement.Controls.Add(this.pictureBox1);
            this.panelTaskManagement.Controls.Add(this.pictbxCalender2);
            this.panelTaskManagement.Controls.Add(this.pictbxCalender1);
            this.panelTaskManagement.Controls.Add(this.grdTaskManagementView);
            this.panelTaskManagement.Controls.Add(this.lblTaskStatus);
            this.panelTaskManagement.Controls.Add(this.lblEndDate);
            this.panelTaskManagement.Controls.Add(this.lblStartDate);
            this.panelTaskManagement.Controls.Add(this.cmbbxtaskStatus);
            this.panelTaskManagement.Controls.Add(this.datePickerEndDate);
            this.panelTaskManagement.Controls.Add(this.datePickerStartDate);
            this.panelTaskManagement.Controls.Add(this.lblTaskManagement);
            this.panelTaskManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskManagement.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTaskManagement.Location = new System.Drawing.Point(0, 0);
            this.panelTaskManagement.Margin = new System.Windows.Forms.Padding(2);
            this.panelTaskManagement.Name = "panelTaskManagement";
            this.panelTaskManagement.Size = new System.Drawing.Size(1406, 829);
            this.panelTaskManagement.TabIndex = 1;
            this.panelTaskManagement.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTaskManagement_Paint);
            // 
            // pictRefresh
            // 
            this.pictRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRefresh.Image = global::GSTEducationalCRMSoft.Properties.Resources.refresh2;
            this.pictRefresh.Location = new System.Drawing.Point(432, 45);
            this.pictRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.pictRefresh.Name = "pictRefresh";
            this.pictRefresh.Size = new System.Drawing.Size(42, 38);
            this.pictRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictRefresh.TabIndex = 44;
            this.pictRefresh.TabStop = false;
            this.pictRefresh.Click += new System.EventHandler(this.pictRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GSTEducationalCRMSoft.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(701, 215);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictbxCalender2
            // 
            this.pictbxCalender2.BackColor = System.Drawing.Color.Transparent;
            this.pictbxCalender2.Image = global::GSTEducationalCRMSoft.Properties.Resources.calendar;
            this.pictbxCalender2.Location = new System.Drawing.Point(642, 215);
            this.pictbxCalender2.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxCalender2.Name = "pictbxCalender2";
            this.pictbxCalender2.Size = new System.Drawing.Size(32, 28);
            this.pictbxCalender2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxCalender2.TabIndex = 10;
            this.pictbxCalender2.TabStop = false;
            // 
            // pictbxCalender1
            // 
            this.pictbxCalender1.BackColor = System.Drawing.Color.Transparent;
            this.pictbxCalender1.Image = global::GSTEducationalCRMSoft.Properties.Resources.calendar;
            this.pictbxCalender1.Location = new System.Drawing.Point(317, 212);
            this.pictbxCalender1.Margin = new System.Windows.Forms.Padding(2);
            this.pictbxCalender1.Name = "pictbxCalender1";
            this.pictbxCalender1.Size = new System.Drawing.Size(32, 28);
            this.pictbxCalender1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxCalender1.TabIndex = 9;
            this.pictbxCalender1.TabStop = false;
            // 
            // grdTaskManagementView
            // 
            this.grdTaskManagementView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTaskManagementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaskManagementView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View});
            this.grdTaskManagementView.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdTaskManagementView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grdTaskManagementView.Location = new System.Drawing.Point(37, 293);
            this.grdTaskManagementView.Margin = new System.Windows.Forms.Padding(2);
            this.grdTaskManagementView.Name = "grdTaskManagementView";
            this.grdTaskManagementView.RowHeadersVisible = false;
            this.grdTaskManagementView.RowHeadersWidth = 62;
            this.grdTaskManagementView.RowTemplate.Height = 28;
            this.grdTaskManagementView.Size = new System.Drawing.Size(1280, 493);
            this.grdTaskManagementView.TabIndex = 7;
            this.grdTaskManagementView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTaskManagementView_CellContentClick);
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 8;
            this.View.Name = "View";
            this.View.Text = "View";
            this.View.ToolTipText = "View";
            this.View.UseColumnTextForLinkValue = true;
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.AutoSize = true;
            this.lblTaskStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskStatus.ForeColor = System.Drawing.Color.Black;
            this.lblTaskStatus.Location = new System.Drawing.Point(51, 147);
            this.lblTaskStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(88, 27);
            this.lblTaskStatus.TabIndex = 6;
            this.lblTaskStatus.Text = "Status:";
            this.lblTaskStatus.Click += new System.EventHandler(this.lblTaskStatus_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblEndDate.Location = new System.Drawing.Point(362, 213);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(120, 27);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(51, 213);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(127, 27);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            // 
            // cmbbxtaskStatus
            // 
            this.cmbbxtaskStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxtaskStatus.FormattingEnabled = true;
            this.cmbbxtaskStatus.Location = new System.Drawing.Point(177, 143);
            this.cmbbxtaskStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxtaskStatus.Name = "cmbbxtaskStatus";
            this.cmbbxtaskStatus.Size = new System.Drawing.Size(181, 31);
            this.cmbbxtaskStatus.TabIndex = 3;
            this.cmbbxtaskStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxtaskStatus_SelectedIndexChanged);
            // 
            // datePickerEndDate
            // 
            this.datePickerEndDate.CustomFormat = "yyyy-mm-dd";
            this.datePickerEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerEndDate.Location = new System.Drawing.Point(482, 212);
            this.datePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerEndDate.Name = "datePickerEndDate";
            this.datePickerEndDate.Size = new System.Drawing.Size(131, 30);
            this.datePickerEndDate.TabIndex = 2;
            this.datePickerEndDate.Value = new System.DateTime(2022, 7, 2, 19, 57, 4, 0);
            this.datePickerEndDate.ValueChanged += new System.EventHandler(this.datePickerEndDate_ValueChanged);
            // 
            // datePickerStartDate
            // 
            this.datePickerStartDate.CustomFormat = "yyyy-mm-dd";
            this.datePickerStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerStartDate.Location = new System.Drawing.Point(177, 212);
            this.datePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerStartDate.Name = "datePickerStartDate";
            this.datePickerStartDate.Size = new System.Drawing.Size(136, 30);
            this.datePickerStartDate.TabIndex = 1;
            this.datePickerStartDate.Value = new System.DateTime(2022, 7, 2, 0, 0, 0, 0);
            this.datePickerStartDate.ValueChanged += new System.EventHandler(this.datePickerStartDate_ValueChanged_1);
            // 
            // lblTaskManagement
            // 
            this.lblTaskManagement.AutoSize = true;
            this.lblTaskManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskManagement.ForeColor = System.Drawing.Color.Black;
            this.lblTaskManagement.Location = new System.Drawing.Point(37, 35);
            this.lblTaskManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskManagement.Name = "lblTaskManagement";
            this.lblTaskManagement.Size = new System.Drawing.Size(380, 48);
            this.lblTaskManagement.TabIndex = 0;
            this.lblTaskManagement.Text = "Task Management";
            // 
            // frmTaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1406, 829);
            this.Controls.Add(this.panelTaskManagement);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTaskManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaskManagement_Load);
            this.panelTaskManagement.ResumeLayout(false);
            this.panelTaskManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxCalender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskManagementView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTaskManagement;
        private System.Windows.Forms.Panel panelTaskManagement;
        private System.Windows.Forms.DataGridView grdTaskManagementView;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbbxtaskStatus;
        private System.Windows.Forms.DateTimePicker datePickerEndDate;
        private System.Windows.Forms.DateTimePicker datePickerStartDate;
        private System.Windows.Forms.DataGridViewLinkColumn View;
        private System.Windows.Forms.PictureBox pictbxCalender2;
        private System.Windows.Forms.PictureBox pictbxCalender1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictRefresh;
    }
}