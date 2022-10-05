namespace GSTEducationalCRMSoft
{
    partial class FormDash
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStudentsCount = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCoursesCount = new System.Windows.Forms.Label();
            this.lblTotalCourses = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBatchesCount = new System.Windows.Forms.Label();
            this.lblActiveBatches = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblStudentsCount);
            this.panel1.Controls.Add(this.lblTotalStudents);
            this.panel1.Location = new System.Drawing.Point(201, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 162);
            this.panel1.TabIndex = 0;
            // 
            // lblStudentsCount
            // 
            this.lblStudentsCount.AutoSize = true;
            this.lblStudentsCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentsCount.Location = new System.Drawing.Point(95, 84);
            this.lblStudentsCount.Name = "lblStudentsCount";
            this.lblStudentsCount.Size = new System.Drawing.Size(107, 39);
            this.lblStudentsCount.TabIndex = 1;
            this.lblStudentsCount.Text = "Count";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalStudents.Location = new System.Drawing.Point(28, 37);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(204, 35);
            this.lblTotalStudents.TabIndex = 1;
            this.lblTotalStudents.Text = "Total Students";
            this.lblTotalStudents.Click += new System.EventHandler(this.lblTotalStudents_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.lblCoursesCount);
            this.panel2.Controls.Add(this.lblTotalCourses);
            this.panel2.Location = new System.Drawing.Point(573, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 162);
            this.panel2.TabIndex = 1;
            // 
            // lblCoursesCount
            // 
            this.lblCoursesCount.AutoSize = true;
            this.lblCoursesCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoursesCount.Location = new System.Drawing.Point(87, 84);
            this.lblCoursesCount.Name = "lblCoursesCount";
            this.lblCoursesCount.Size = new System.Drawing.Size(107, 39);
            this.lblCoursesCount.TabIndex = 1;
            this.lblCoursesCount.Text = "Count";
            // 
            // lblTotalCourses
            // 
            this.lblTotalCourses.AutoSize = true;
            this.lblTotalCourses.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCourses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalCourses.Location = new System.Drawing.Point(33, 37);
            this.lblTotalCourses.Name = "lblTotalCourses";
            this.lblTotalCourses.Size = new System.Drawing.Size(197, 35);
            this.lblTotalCourses.TabIndex = 1;
            this.lblTotalCourses.Text = "Total Courses";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.lblBatchesCount);
            this.panel3.Controls.Add(this.lblActiveBatches);
            this.panel3.Location = new System.Drawing.Point(968, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 162);
            this.panel3.TabIndex = 2;
            // 
            // lblBatchesCount
            // 
            this.lblBatchesCount.AutoSize = true;
            this.lblBatchesCount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblBatchesCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBatchesCount.Location = new System.Drawing.Point(89, 85);
            this.lblBatchesCount.Name = "lblBatchesCount";
            this.lblBatchesCount.Size = new System.Drawing.Size(107, 39);
            this.lblBatchesCount.TabIndex = 1;
            this.lblBatchesCount.Text = "Count";
            // 
            // lblActiveBatches
            // 
            this.lblActiveBatches.AutoSize = true;
            this.lblActiveBatches.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveBatches.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActiveBatches.Location = new System.Drawing.Point(32, 38);
            this.lblActiveBatches.Name = "lblActiveBatches";
            this.lblActiveBatches.Size = new System.Drawing.Size(210, 35);
            this.lblActiveBatches.TabIndex = 1;
            this.lblActiveBatches.Text = "Active Batches";
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Active Batch";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Blue;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(121, 247);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "No. Of Students";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1234, 591);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // FormDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GSTEducationalCRMSoft.Properties.Resources.LoginBackground6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1677, 961);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStudentsCount;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCoursesCount;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBatchesCount;
        private System.Windows.Forms.Label lblActiveBatches;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}