namespace GSTEducationalCRMSoft
{
    partial class frmApplyLeaves
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Button();
            this.lblApplyForLeave = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.cmbbxLeavesType = new System.Windows.Forms.ComboBox();
            this.lblLeavesType = new System.Windows.Forms.Label();
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.richtxtDescription);
            this.panel1.Controls.Add(this.lblCancel);
            this.panel1.Controls.Add(this.lblApplyForLeave);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblToDate);
            this.panel1.Controls.Add(this.lblFromDate);
            this.panel1.Controls.Add(this.cmbbxLeavesType);
            this.panel1.Controls.Add(this.lblLeavesType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 515);
            this.panel1.TabIndex = 18;
            // 
            // lblCancel
            // 
            this.lblCancel.BackColor = System.Drawing.Color.Transparent;
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCancel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.Black;
            this.lblCancel.Location = new System.Drawing.Point(463, 454);
            this.lblCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(164, 39);
            this.lblCancel.TabIndex = 11;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.UseVisualStyleBackColor = false;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // lblApplyForLeave
            // 
            this.lblApplyForLeave.AutoSize = true;
            this.lblApplyForLeave.BackColor = System.Drawing.Color.Transparent;
            this.lblApplyForLeave.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplyForLeave.ForeColor = System.Drawing.Color.Black;
            this.lblApplyForLeave.Location = new System.Drawing.Point(57, 52);
            this.lblApplyForLeave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplyForLeave.Name = "lblApplyForLeave";
            this.lblApplyForLeave.Size = new System.Drawing.Size(348, 49);
            this.lblApplyForLeave.TabIndex = 16;
            this.lblApplyForLeave.Text = "Apply For Leave";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(269, 454);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(176, 39);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "YYYY-MM-DD";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(697, 249);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(247, 30);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "YYYY-MM-DD";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 249);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 30);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(112, 313);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 27);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description :";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblToDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(580, 249);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(107, 27);
            this.lblToDate.TabIndex = 3;
            this.lblToDate.Text = "To Date :";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFromDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(119, 249);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(139, 27);
            this.lblFromDate.TabIndex = 2;
            this.lblFromDate.Text = "From Date :";
            this.lblFromDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbbxLeavesType
            // 
            this.cmbbxLeavesType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxLeavesType.FormattingEnabled = true;
            this.cmbbxLeavesType.Location = new System.Drawing.Point(269, 185);
            this.cmbbxLeavesType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxLeavesType.Name = "cmbbxLeavesType";
            this.cmbbxLeavesType.Size = new System.Drawing.Size(247, 31);
            this.cmbbxLeavesType.TabIndex = 1;
            this.cmbbxLeavesType.SelectedIndexChanged += new System.EventHandler(this.cmbbxLeavesType_SelectedIndexChanged);
            this.cmbbxLeavesType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbbxLeavesType_Validating);
            // 
            // lblLeavesType
            // 
            this.lblLeavesType.AutoSize = true;
            this.lblLeavesType.BackColor = System.Drawing.Color.Transparent;
            this.lblLeavesType.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeavesType.Location = new System.Drawing.Point(105, 185);
            this.lblLeavesType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeavesType.Name = "lblLeavesType";
            this.lblLeavesType.Size = new System.Drawing.Size(153, 27);
            this.lblLeavesType.TabIndex = 0;
            this.lblLeavesType.Text = "LeavesType :";
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtDescription.Location = new System.Drawing.Point(269, 313);
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.Size = new System.Drawing.Size(458, 96);
            this.richtxtDescription.TabIndex = 17;
            this.richtxtDescription.Text = "";
            // 
            // frmApplyLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 515);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmApplyLeaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply Leaves Details";
            this.Load += new System.EventHandler(this.frmApplyLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLeavesType;
        private System.Windows.Forms.ComboBox cmbbxLeavesType;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button lblCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblApplyForLeave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richtxtDescription;
    }
}