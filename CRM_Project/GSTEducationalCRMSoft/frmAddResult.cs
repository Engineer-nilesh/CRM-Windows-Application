using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using clsCoOrdinator;
using System.Windows.Forms;

namespace GSTEducationalCRMSoft
{
    public partial class frmAddResult : Form
    {
        public string sc { get; set; }
        public frmAddResult()
        {
            InitializeComponent();
        }

        private void frmAddResult_Load(object sender, EventArgs e)
        {
            CoOrdinator obj = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = obj.Get_Test();
            cmbbxExamTitle.ValueMember = "TestId";
            cmbbxExamTitle.DisplayMember = "TestName";
            cmbbxExamTitle.DataSource = dt;

         
        }

        private void cmbbxExamTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TestId = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objcourse = new CoOrdinator(TestId);
            DataTable dtcourse = new DataTable();
            dtcourse = objcourse.Get_ResultCourse();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseName";
            cmbbxCourseName.DataSource = dtcourse;
        }

        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int TestId = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            int CourseId = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            CoOrdinator objBatch = new CoOrdinator(CourseId);
            DataTable dtBatch = new DataTable();
            dtBatch = objBatch.Get_ResultBatch();
            cmbbxBatchName.ValueMember = "BatchId";
            cmbbxBatchName.DisplayMember = "BatchName";
            cmbbxBatchName.DataSource = dtBatch;

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int id1 = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            int id2 = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            int id3 = Convert.ToInt32(cmbbxBatchName.SelectedValue.ToString());

                for (int i=0;i<grdaddresult.Rows.Count;i++)
                {
                    //for(int j = 1; j < grdaddresult.Columns.Count;j++)
                    //{
                        string scode1 = grdaddresult.Rows[i].Cells[1].Value.ToString();
                        int marks =Convert.ToInt32(grdaddresult.Rows[i].Cells[0].Value.ToString());
                      int BatchMarks = Convert.ToInt32(txttotalMarks.Text);
                        CoOrdinator objsubmit = new CoOrdinator(id1, id2, id3, scode1, marks);
                        objsubmit.AddResult();
                    //}
                }
            MessageBox.Show("Save Succefully....");
            
        }

        private void lblBatchMarks_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < grdaddresult.Rows.Count; i++)
            {
                int marks = Convert.ToInt32(grdaddresult.Rows[i].Cells[0].Value);
                sum = sum + marks;
            }
            txttotalMarks.Text = sum.ToString();


        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
            

            

        }

        private void cmbbxBatchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Batchid = Convert.ToInt32(cmbbxBatchName.SelectedValue.ToString());
            CoOrdinator objexam = new CoOrdinator(Batchid);
            DataTable dtexam = new DataTable();
            dtexam = objexam.getResult();
            grdaddresult.DataSource = dtexam;
            grdaddresult.Show();



        }
    }
}
