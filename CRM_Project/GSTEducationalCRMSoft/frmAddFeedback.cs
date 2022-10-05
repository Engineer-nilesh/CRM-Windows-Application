using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCoOrdinator;
using System.Data.SqlClient;
using GSTEducationalCRMSoft.Properties;

namespace GSTEducationalCRMSoft
{
  
    public partial class frmAddFeedback : Form
    {
        public int temp { get; set; }

        public frmAddFeedback()
        {
            InitializeComponent();
        }
        public frmAddFeedback(int i)
        {
            InitializeComponent();
            temp = i;
        }

        private void frmAddFollowupStT_Load(object sender, EventArgs e)
        {
            CoOrdinator objcourse = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = objcourse.Get_Course();
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.DataSource = dt;
        }

        private void cmbbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int courseid = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            CoOrdinator objBatch = new CoOrdinator(courseid);
            DataTable dtBatch = new DataTable();
            dtBatch = objBatch.GetBatchByCourse();
            cmbbxBatch.ValueMember = "BatchId";
            cmbbxBatch.DisplayMember = "BatchName";
            cmbbxBatch.DataSource = dtBatch;
        }

        private void cmbbxBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Courseid = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            int Batchid = Convert.ToInt32(cmbbxBatch.SelectedValue.ToString());
            CoOrdinator objTrainer = new CoOrdinator(Courseid,Batchid);
            DataTable dtTrainer = new DataTable();
            dtTrainer = objTrainer.GetTrainerByName();
            cmbbxTrainer.ValueMember = "StaffCode";
            cmbbxTrainer.DisplayMember = "StaffName";
            cmbbxTrainer.DataSource = dtTrainer;

            CoOrdinator objstudent = new CoOrdinator(Batchid);
            SqlDataReader dr;
            DataTable dtstud = new DataTable();
            dr = objstudent.GetBatchStudent();
            DataTable dt = new DataTable();
            string[] sc;
            
            while (dr.Read())
            {
                string studcode = dr["StudCode"].ToString();
                sc = studcode.Split(',');
                for (int i = 0; i < sc.Length; i++)
                {
                    CoOrdinator objStud = new CoOrdinator(sc[i]);
                    dtstud = objStud.GetStudentName();
                    if (i == 0)
                    {
                        dt = dtstud.Clone();
                    }
                    foreach (DataRow temp in dtstud.Rows)
                    {
                        dt.ImportRow(temp);
                    }
                }
                cmbbxStudent.ValueMember = "StudCode";
                cmbbxStudent.DisplayMember = "StudFullName";
                cmbbxStudent.DataSource = dt;
            }
        }

        private void pbStar1_Click(object sender, EventArgs e)
        {
            pbStar2.Image = Resources.whitestar;
            pbStar3.Image = Resources.whitestar;
            pbStar4.Image = Resources.whitestar;
            pbStar5.Image = Resources.whitestar;
            pbStar1.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Very Poor";
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            pbStar3.Image = Resources.whitestar;
            pbStar4.Image = Resources.whitestar;
            pbStar5.Image = Resources.whitestar;
            pbStar1.Image = Resources.yellowstar;
            pbStar2.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Poor";
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            pbStar4.Image = Resources.whitestar;
            pbStar5.Image = Resources.whitestar;
            pbStar1.Image = Resources.yellowstar;
            pbStar2.Image = Resources.yellowstar;
            pbStar3.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Good";
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            pbStar5.Image = Resources.whitestar;
            pbStar1.Image = Resources.yellowstar;
            pbStar2.Image = Resources.yellowstar;
            pbStar3.Image = Resources.yellowstar;
            pbStar4.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Very Good";
        }

        private void pbStar5_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.yellowstar;
            pbStar2.Image = Resources.yellowstar;
            pbStar3.Image = Resources.yellowstar;
            pbStar4.Image = Resources.yellowstar;
            pbStar5.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Excellent";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            int bid = Convert.ToInt32(cmbbxBatch.SelectedValue.ToString());
            string staff = cmbbxTrainer.SelectedValue.ToString();
            string student = cmbbxStudent.SelectedValue.ToString();
            int rating = 0;
            string performance = null;
            if (lblPerformance.Text == "Your Performance is Very Poor")
            {
                rating = 1;
                performance = "Very Poor";
            }
            else if (lblPerformance.Text == "Your Performance is Poor")
            {
                rating = 2;
                performance = "Poor";
            }
            else if (lblPerformance.Text == "Your Performance is Good")
            {
                rating = 3;
                performance = "Good";
            }
            else if (lblPerformance.Text == "Your Performance is Very Good")
            {
                rating = 4;
                performance = "Very Good";
            }
            else
            {
                rating = 5;
                performance = "Excellent";
            }
            string comment = richtxtComments.Text;
            if (temp == 1)
            {
                CoOrdinator objSave = new CoOrdinator(cid, bid, staff,student, rating, performance, comment);
                objSave.SaveFeedback();
                MessageBox.Show("Feedback Save Sucessfully");
                this.Close();
            }
            else
            {
                CoOrdinator objSave = new CoOrdinator(cid, bid, student, staff, rating, performance, comment);
                objSave.SaveFeedback();
                MessageBox.Show("Feedback Save Sucessfully");
                this.Close();
            }
        }
    }
}
