namespace GSTEducationalCRMSoft
{
    partial class FrmStudentList
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
            this.grdStudentsList = new System.Windows.Forms.DataGridView();
            this.lblBatchId = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentsList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStudentsList
            // 
            this.grdStudentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdStudentsList.Location = new System.Drawing.Point(110, 117);
            this.grdStudentsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdStudentsList.Name = "grdStudentsList";
            this.grdStudentsList.RowHeadersVisible = false;
            this.grdStudentsList.RowHeadersWidth = 62;
            this.grdStudentsList.Size = new System.Drawing.Size(790, 344);
            this.grdStudentsList.TabIndex = 0;
            this.grdStudentsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblBatchId
            // 
            this.lblBatchId.AutoSize = true;
            this.lblBatchId.Location = new System.Drawing.Point(547, 142);
            this.lblBatchId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatchId.Name = "lblBatchId";
            this.lblBatchId.Size = new System.Drawing.Size(44, 16);
            this.lblBatchId.TabIndex = 1;
            this.lblBatchId.Text = "lable1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Details";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Details";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student List";
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdStudentsList);
            this.Controls.Add(this.lblBatchId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentList";
            this.Load += new System.EventHandler(this.FrmStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStudentsList;
        private System.Windows.Forms.Label lblBatchId;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.Label label1;
    }
}