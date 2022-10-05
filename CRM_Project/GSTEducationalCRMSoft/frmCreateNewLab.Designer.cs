namespace GSTEducationalCRMSoft
{
    partial class frmCreateNewLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCenter = new System.Windows.Forms.Label();
            this.lblLabName = new System.Windows.Forms.Label();
            this.lblCapacityOfLab = new System.Windows.Forms.Label();
            this.lblAvailableSystem = new System.Windows.Forms.Label();
            this.cmbbxCenter = new System.Windows.Forms.ComboBox();
            this.txtLabName = new System.Windows.Forms.TextBox();
            this.txtCapacityOfLab = new System.Windows.Forms.TextBox();
            this.txtAvailableSystem = new System.Windows.Forms.TextBox();
            this.btnCreateLab = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picboxAddCenterName = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAddCenterName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Lab";
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.BackColor = System.Drawing.Color.Transparent;
            this.lblCenter.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenter.Location = new System.Drawing.Point(179, 169);
            this.lblCenter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(98, 27);
            this.lblCenter.TabIndex = 1;
            this.lblCenter.Text = "Center :";
            this.lblCenter.Click += new System.EventHandler(this.lblCenter_Click);
            // 
            // lblLabName
            // 
            this.lblLabName.AutoSize = true;
            this.lblLabName.BackColor = System.Drawing.Color.Transparent;
            this.lblLabName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabName.Location = new System.Drawing.Point(145, 222);
            this.lblLabName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabName.Name = "lblLabName";
            this.lblLabName.Size = new System.Drawing.Size(129, 27);
            this.lblLabName.TabIndex = 2;
            this.lblLabName.Text = "LabName :";
            // 
            // lblCapacityOfLab
            // 
            this.lblCapacityOfLab.AutoSize = true;
            this.lblCapacityOfLab.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacityOfLab.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityOfLab.Location = new System.Drawing.Point(83, 280);
            this.lblCapacityOfLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacityOfLab.Name = "lblCapacityOfLab";
            this.lblCapacityOfLab.Size = new System.Drawing.Size(192, 27);
            this.lblCapacityOfLab.TabIndex = 3;
            this.lblCapacityOfLab.Text = "Capacity Of Lab:";
            // 
            // lblAvailableSystem
            // 
            this.lblAvailableSystem.AutoSize = true;
            this.lblAvailableSystem.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableSystem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSystem.Location = new System.Drawing.Point(65, 345);
            this.lblAvailableSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableSystem.Name = "lblAvailableSystem";
            this.lblAvailableSystem.Size = new System.Drawing.Size(209, 27);
            this.lblAvailableSystem.TabIndex = 4;
            this.lblAvailableSystem.Text = "Available System :";
            // 
            // cmbbxCenter
            // 
            this.cmbbxCenter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCenter.FormattingEnabled = true;
            this.cmbbxCenter.Location = new System.Drawing.Point(314, 166);
            this.cmbbxCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxCenter.Name = "cmbbxCenter";
            this.cmbbxCenter.Size = new System.Drawing.Size(307, 31);
            this.cmbbxCenter.TabIndex = 5;
            this.cmbbxCenter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbbxCenter.Validating += new System.ComponentModel.CancelEventHandler(this.cmbbxCenter_Validating);
            // 
            // txtLabName
            // 
            this.txtLabName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabName.Location = new System.Drawing.Point(314, 219);
            this.txtLabName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLabName.Name = "txtLabName";
            this.txtLabName.Size = new System.Drawing.Size(307, 30);
            this.txtLabName.TabIndex = 6;
            this.txtLabName.TextChanged += new System.EventHandler(this.txtLabName_TextChanged);
            this.txtLabName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLabName_Validating);
            // 
            // txtCapacityOfLab
            // 
            this.txtCapacityOfLab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacityOfLab.Location = new System.Drawing.Point(314, 280);
            this.txtCapacityOfLab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCapacityOfLab.Name = "txtCapacityOfLab";
            this.txtCapacityOfLab.Size = new System.Drawing.Size(307, 30);
            this.txtCapacityOfLab.TabIndex = 7;
            this.txtCapacityOfLab.Validating += new System.ComponentModel.CancelEventHandler(this.txtCapacityOfLab_Validating);
            // 
            // txtAvailableSystem
            // 
            this.txtAvailableSystem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableSystem.Location = new System.Drawing.Point(314, 342);
            this.txtAvailableSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAvailableSystem.Name = "txtAvailableSystem";
            this.txtAvailableSystem.Size = new System.Drawing.Size(307, 30);
            this.txtAvailableSystem.TabIndex = 8;
            this.txtAvailableSystem.Validating += new System.ComponentModel.CancelEventHandler(this.txtAvailableSystem_Validating);
            // 
            // btnCreateLab
            // 
            this.btnCreateLab.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateLab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateLab.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLab.Location = new System.Drawing.Point(383, 426);
            this.btnCreateLab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateLab.Name = "btnCreateLab";
            this.btnCreateLab.Size = new System.Drawing.Size(155, 39);
            this.btnCreateLab.TabIndex = 9;
            this.btnCreateLab.Text = "Create Lab";
            this.btnCreateLab.UseVisualStyleBackColor = false;
            this.btnCreateLab.Click += new System.EventHandler(this.btnCreateLab_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(567, 426);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picboxAddCenterName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblCenter);
            this.panel1.Controls.Add(this.btnCreateLab);
            this.panel1.Controls.Add(this.cmbbxCenter);
            this.panel1.Controls.Add(this.txtAvailableSystem);
            this.panel1.Controls.Add(this.lblLabName);
            this.panel1.Controls.Add(this.lblAvailableSystem);
            this.panel1.Controls.Add(this.txtCapacityOfLab);
            this.panel1.Controls.Add(this.txtLabName);
            this.panel1.Controls.Add(this.lblCapacityOfLab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 494);
            this.panel1.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // picboxAddCenterName
            // 
            this.picboxAddCenterName.BackColor = System.Drawing.Color.Black;
            this.picboxAddCenterName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxAddCenterName.Image = global::GSTEducationalCRMSoft.Properties.Resources.plus1;
            this.picboxAddCenterName.InitialImage = null;
            this.picboxAddCenterName.Location = new System.Drawing.Point(654, 168);
            this.picboxAddCenterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxAddCenterName.Name = "picboxAddCenterName";
            this.picboxAddCenterName.Size = new System.Drawing.Size(41, 28);
            this.picboxAddCenterName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxAddCenterName.TabIndex = 69;
            this.picboxAddCenterName.TabStop = false;
            this.picboxAddCenterName.Click += new System.EventHandler(this.picboxAddCenterName_Click);
            // 
            // frmCreateNewLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 494);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCreateNewLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCreate New Lab";
            this.Load += new System.EventHandler(this.frmCreateNewLab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAddCenterName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.Label lblLabName;
        private System.Windows.Forms.Label lblCapacityOfLab;
        private System.Windows.Forms.Label lblAvailableSystem;
        private System.Windows.Forms.ComboBox cmbbxCenter;
        private System.Windows.Forms.TextBox txtLabName;
        private System.Windows.Forms.TextBox txtCapacityOfLab;
        private System.Windows.Forms.TextBox txtAvailableSystem;
        private System.Windows.Forms.Button btnCreateLab;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.PictureBox picboxAddCenterName;
    }
}