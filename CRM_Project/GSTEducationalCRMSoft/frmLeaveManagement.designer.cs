namespace GSTEducationalCRMSoft
{
    partial class frmLeaveManagement
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
            this.s = new System.Windows.Forms.Panel();
            this.pictRefresh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltot1 = new System.Windows.Forms.Label();
            this.lbltotal1 = new System.Windows.Forms.Label();
            this.lblCasual3 = new System.Windows.Forms.Label();
            this.lblsick3 = new System.Windows.Forms.Label();
            this.lblpaid3 = new System.Windows.Forms.Label();
            this.lblCasual2 = new System.Windows.Forms.Label();
            this.lblPaid2 = new System.Windows.Forms.Label();
            this.lblsick2 = new System.Windows.Forms.Label();
            this.lblYearlyLeave = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltot = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblMonthlyLeave = new System.Windows.Forms.Label();
            this.lblsick = new System.Windows.Forms.Label();
            this.lblcasual1 = new System.Windows.Forms.Label();
            this.lblSick1 = new System.Windows.Forms.Label();
            this.lblCasual = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblpaid1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictbxPlus1 = new System.Windows.Forms.PictureBox();
            this.btnApplyForLeave = new System.Windows.Forms.Button();
            this.lblLeaveManagement = new System.Windows.Forms.Label();
            this.grdMonthlyLeave = new System.Windows.Forms.DataGridView();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.s.Controls.Add(this.pictRefresh);
            this.s.Controls.Add(this.label1);
            this.s.Controls.Add(this.lblName);
            this.s.Controls.Add(this.panel2);
            this.s.Controls.Add(this.panel1);
            this.s.Controls.Add(this.pictbxPlus1);
            this.s.Controls.Add(this.btnApplyForLeave);
            this.s.Controls.Add(this.lblLeaveManagement);
            this.s.Controls.Add(this.grdMonthlyLeave);
            this.s.Controls.Add(this.label2);
            this.s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s.Location = new System.Drawing.Point(0, 0);
            this.s.Margin = new System.Windows.Forms.Padding(4);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(1482, 791);
            this.s.TabIndex = 6;
            this.s.Paint += new System.Windows.Forms.PaintEventHandler(this.s_Paint);
            // 
            // pictRefresh
            // 
            this.pictRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRefresh.Image = global::GSTEducationalCRMSoft.Properties.Resources.refresh2;
            this.pictRefresh.Location = new System.Drawing.Point(341, 101);
            this.pictRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.pictRefresh.Name = "pictRefresh";
            this.pictRefresh.Size = new System.Drawing.Size(42, 41);
            this.pictRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictRefresh.TabIndex = 27;
            this.pictRefresh.TabStop = false;
            this.pictRefresh.Click += new System.EventHandler(this.pictRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Staff Name :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(824, 159);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 29);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.lbltot1);
            this.panel2.Controls.Add(this.lbltotal1);
            this.panel2.Controls.Add(this.lblCasual3);
            this.panel2.Controls.Add(this.lblsick3);
            this.panel2.Controls.Add(this.lblpaid3);
            this.panel2.Controls.Add(this.lblCasual2);
            this.panel2.Controls.Add(this.lblPaid2);
            this.panel2.Controls.Add(this.lblsick2);
            this.panel2.Controls.Add(this.lblYearlyLeave);
            this.panel2.Location = new System.Drawing.Point(845, 212);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 175);
            this.panel2.TabIndex = 24;
            // 
            // lbltot1
            // 
            this.lbltot1.AutoSize = true;
            this.lbltot1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltot1.Location = new System.Drawing.Point(47, 143);
            this.lbltot1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltot1.Name = "lbltot1";
            this.lbltot1.Size = new System.Drawing.Size(48, 24);
            this.lbltot1.TabIndex = 27;
            this.lbltot1.Text = "Total";
            this.lbltot1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbltotal1
            // 
            this.lbltotal1.AutoSize = true;
            this.lbltotal1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltotal1.Location = new System.Drawing.Point(139, 143);
            this.lbltotal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal1.Name = "lbltotal1";
            this.lbltotal1.Size = new System.Drawing.Size(48, 24);
            this.lbltotal1.TabIndex = 28;
            this.lbltotal1.Text = "Total";
            // 
            // lblCasual3
            // 
            this.lblCasual3.AutoSize = true;
            this.lblCasual3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasual3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCasual3.Location = new System.Drawing.Point(139, 112);
            this.lblCasual3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasual3.Name = "lblCasual3";
            this.lblCasual3.Size = new System.Drawing.Size(72, 24);
            this.lblCasual3.TabIndex = 25;
            this.lblCasual3.Text = "Casual3";
            // 
            // lblsick3
            // 
            this.lblsick3.AutoSize = true;
            this.lblsick3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsick3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsick3.Location = new System.Drawing.Point(139, 53);
            this.lblsick3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsick3.Name = "lblsick3";
            this.lblsick3.Size = new System.Drawing.Size(50, 24);
            this.lblsick3.TabIndex = 24;
            this.lblsick3.Text = "sick3";
            // 
            // lblpaid3
            // 
            this.lblpaid3.AutoSize = true;
            this.lblpaid3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpaid3.Location = new System.Drawing.Point(139, 84);
            this.lblpaid3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaid3.Name = "lblpaid3";
            this.lblpaid3.Size = new System.Drawing.Size(53, 24);
            this.lblpaid3.TabIndex = 23;
            this.lblpaid3.Text = "Paid3";
            // 
            // lblCasual2
            // 
            this.lblCasual2.AutoSize = true;
            this.lblCasual2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasual2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCasual2.Location = new System.Drawing.Point(41, 112);
            this.lblCasual2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasual2.Name = "lblCasual2";
            this.lblCasual2.Size = new System.Drawing.Size(63, 24);
            this.lblCasual2.TabIndex = 22;
            this.lblCasual2.Text = "Casual";
            // 
            // lblPaid2
            // 
            this.lblPaid2.AutoSize = true;
            this.lblPaid2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaid2.Location = new System.Drawing.Point(47, 84);
            this.lblPaid2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid2.Name = "lblPaid2";
            this.lblPaid2.Size = new System.Drawing.Size(44, 24);
            this.lblPaid2.TabIndex = 21;
            this.lblPaid2.Text = "Paid";
            // 
            // lblsick2
            // 
            this.lblsick2.AutoSize = true;
            this.lblsick2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsick2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsick2.Location = new System.Drawing.Point(47, 53);
            this.lblsick2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsick2.Name = "lblsick2";
            this.lblsick2.Size = new System.Drawing.Size(43, 24);
            this.lblsick2.TabIndex = 20;
            this.lblsick2.Text = "Sick";
            // 
            // lblYearlyLeave
            // 
            this.lblYearlyLeave.AutoSize = true;
            this.lblYearlyLeave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyLeave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYearlyLeave.Location = new System.Drawing.Point(47, 14);
            this.lblYearlyLeave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearlyLeave.Name = "lblYearlyLeave";
            this.lblYearlyLeave.Size = new System.Drawing.Size(130, 24);
            this.lblYearlyLeave.TabIndex = 19;
            this.lblYearlyLeave.Text = "Yearly Leave";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lbltot);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.lblMonthlyLeave);
            this.panel1.Controls.Add(this.lblsick);
            this.panel1.Controls.Add(this.lblcasual1);
            this.panel1.Controls.Add(this.lblSick1);
            this.panel1.Controls.Add(this.lblCasual);
            this.panel1.Controls.Add(this.lblPaid);
            this.panel1.Controls.Add(this.lblpaid1);
            this.panel1.Location = new System.Drawing.Point(510, 212);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 175);
            this.panel1.TabIndex = 23;
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltot.Location = new System.Drawing.Point(43, 145);
            this.lbltot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(48, 24);
            this.lbltot.TabIndex = 26;
            this.lbltot.Text = "Total";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltotal.Location = new System.Drawing.Point(139, 143);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(48, 24);
            this.lbltotal.TabIndex = 25;
            this.lbltotal.Text = "Total";
            this.lbltotal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMonthlyLeave
            // 
            this.lblMonthlyLeave.AutoSize = true;
            this.lblMonthlyLeave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyLeave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMonthlyLeave.Location = new System.Drawing.Point(40, 14);
            this.lblMonthlyLeave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyLeave.Name = "lblMonthlyLeave";
            this.lblMonthlyLeave.Size = new System.Drawing.Size(148, 24);
            this.lblMonthlyLeave.TabIndex = 15;
            this.lblMonthlyLeave.Text = "Monthly Leave";
            // 
            // lblsick
            // 
            this.lblsick.AutoSize = true;
            this.lblsick.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsick.Location = new System.Drawing.Point(37, 55);
            this.lblsick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsick.Name = "lblsick";
            this.lblsick.Size = new System.Drawing.Size(43, 24);
            this.lblsick.TabIndex = 14;
            this.lblsick.Text = "Sick";
            this.lblsick.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcasual1
            // 
            this.lblcasual1.AutoSize = true;
            this.lblcasual1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcasual1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcasual1.Location = new System.Drawing.Point(140, 112);
            this.lblcasual1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcasual1.Name = "lblcasual1";
            this.lblcasual1.Size = new System.Drawing.Size(72, 24);
            this.lblcasual1.TabIndex = 22;
            this.lblcasual1.Text = "Casual1";
            this.lblcasual1.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblSick1
            // 
            this.lblSick1.AutoSize = true;
            this.lblSick1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSick1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSick1.Location = new System.Drawing.Point(140, 55);
            this.lblSick1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSick1.Name = "lblSick1";
            this.lblSick1.Size = new System.Drawing.Size(52, 24);
            this.lblSick1.TabIndex = 16;
            this.lblSick1.Text = "Sick1";
            this.lblSick1.Click += new System.EventHandler(this.lblSick1_Click);
            // 
            // lblCasual
            // 
            this.lblCasual.AutoSize = true;
            this.lblCasual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCasual.Location = new System.Drawing.Point(37, 112);
            this.lblCasual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasual.Name = "lblCasual";
            this.lblCasual.Size = new System.Drawing.Size(63, 24);
            this.lblCasual.TabIndex = 21;
            this.lblCasual.Text = "Casual";
            this.lblCasual.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaid.Location = new System.Drawing.Point(40, 84);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(44, 24);
            this.lblPaid.TabIndex = 17;
            this.lblPaid.Text = "Paid";
            // 
            // lblpaid1
            // 
            this.lblpaid1.AutoSize = true;
            this.lblpaid1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpaid1.Location = new System.Drawing.Point(139, 84);
            this.lblpaid1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaid1.Name = "lblpaid1";
            this.lblpaid1.Size = new System.Drawing.Size(53, 24);
            this.lblpaid1.TabIndex = 20;
            this.lblpaid1.Text = "Paid1";
            this.lblpaid1.Click += new System.EventHandler(this.lblpaid1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 493);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // pictbxPlus1
            // 
            this.pictbxPlus1.BackColor = System.Drawing.Color.Transparent;
            this.pictbxPlus1.Image = global::GSTEducationalCRMSoft.Properties.Resources.plus1;
            this.pictbxPlus1.Location = new System.Drawing.Point(71, 110);
            this.pictbxPlus1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictbxPlus1.Name = "pictbxPlus1";
            this.pictbxPlus1.Size = new System.Drawing.Size(35, 25);
            this.pictbxPlus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxPlus1.TabIndex = 10;
            this.pictbxPlus1.TabStop = false;
            // 
            // btnApplyForLeave
            // 
            this.btnApplyForLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnApplyForLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyForLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyForLeave.ForeColor = System.Drawing.Color.Black;
            this.btnApplyForLeave.Location = new System.Drawing.Point(60, 101);
            this.btnApplyForLeave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplyForLeave.Name = "btnApplyForLeave";
            this.btnApplyForLeave.Size = new System.Drawing.Size(260, 42);
            this.btnApplyForLeave.TabIndex = 9;
            this.btnApplyForLeave.Text = "Apply For Leave";
            this.btnApplyForLeave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplyForLeave.UseVisualStyleBackColor = false;
            this.btnApplyForLeave.Click += new System.EventHandler(this.btnApplyForLeave_Click);
            // 
            // lblLeaveManagement
            // 
            this.lblLeaveManagement.AutoSize = true;
            this.lblLeaveManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblLeaveManagement.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveManagement.ForeColor = System.Drawing.Color.Black;
            this.lblLeaveManagement.Location = new System.Drawing.Point(52, 28);
            this.lblLeaveManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeaveManagement.Name = "lblLeaveManagement";
            this.lblLeaveManagement.Size = new System.Drawing.Size(408, 49);
            this.lblLeaveManagement.TabIndex = 0;
            this.lblLeaveManagement.Text = "Leave Management";
            // 
            // grdMonthlyLeave
            // 
            this.grdMonthlyLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMonthlyLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMonthlyLeave.Location = new System.Drawing.Point(295, 418);
            this.grdMonthlyLeave.Margin = new System.Windows.Forms.Padding(4);
            this.grdMonthlyLeave.Name = "grdMonthlyLeave";
            this.grdMonthlyLeave.RowHeadersVisible = false;
            this.grdMonthlyLeave.RowHeadersWidth = 62;
            this.grdMonthlyLeave.Size = new System.Drawing.Size(1059, 321);
            this.grdMonthlyLeave.TabIndex = 2;
            this.grdMonthlyLeave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMonthlyLeave_CellContentClick);
            // 
            // frmLeaveManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 791);
            this.Controls.Add(this.s);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLeaveManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLeaveManagement_Load);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictRefresh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxPlus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyLeave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdMonthlyLeave;
        private System.Windows.Forms.Panel s;
        private System.Windows.Forms.Label lblLeaveManagement;
        private System.Windows.Forms.PictureBox pictbxPlus1;
        private System.Windows.Forms.Button btnApplyForLeave;
        private System.Windows.Forms.Label lblcasual1;
        private System.Windows.Forms.Label lblCasual;
        private System.Windows.Forms.Label lblpaid1;
        private System.Windows.Forms.Label lblYearlyLeave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblMonthlyLeave;
        private System.Windows.Forms.Label lblsick;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCasual3;
        private System.Windows.Forms.Label lblsick3;
        private System.Windows.Forms.Label lblpaid3;
        private System.Windows.Forms.Label lblCasual2;
        private System.Windows.Forms.Label lblPaid2;
        private System.Windows.Forms.Label lblsick2;
        private System.Windows.Forms.Label lblSick1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltotal1;
        private System.Windows.Forms.Label lbltot1;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictRefresh;
    }
}