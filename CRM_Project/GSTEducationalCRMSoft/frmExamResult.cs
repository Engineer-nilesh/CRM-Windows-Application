using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsCoOrdinator;
using System.Windows.Forms;

namespace GSTEducationalCRMSoft
{
    public partial class frmExamResult : Form
    {
        int TestId { get; set; }
        public frmExamResult()
        {
            InitializeComponent();
        }

        private void frmExamResult_Load(object sender, EventArgs e)
        {
            //int testid = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator obj = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = obj.Get_Test();
            cmbbxExamTitle.ValueMember = "TestId";
            cmbbxExamTitle.DisplayMember = "TestName";
            cmbbxExamTitle.DataSource = dt;


            CoOrdinator objcourse = new CoOrdinator();
            DataTable dtcourse = new DataTable();
            dtcourse = objcourse.GetCourseExam();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseName";
            cmbbxCourseName.DataSource = dtcourse;

            CoOrdinator objBatch = new CoOrdinator();
            DataTable dtBatch = new DataTable();
            dtBatch = objBatch.GetBatchExam();
            cmbbxBatchName.ValueMember = "BatchId";
            cmbbxBatchName.DisplayMember = "BatchName";
            cmbbxBatchName.DataSource = dtBatch;

            /****************** Grid View***********************************/

            CoOrdinator objgrd = new CoOrdinator();
            DataTable dtt = new DataTable();
            dtt = objgrd.FetchResult();
            grdExamResult.DataSource = dtt;
            grdExamResult.Show();

            //grdExamResult.Columns["TestId"].Visible = false;
        }

        private void grdExamResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string ExamTitle = grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[3].Value.ToString();
                string Course = grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[4].Value.ToString();
                string Batch = grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[5].Value.ToString();
                //string sc = (grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[9].Value.ToString());
                int test = Convert.ToInt32(grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[6].Value.ToString());

                frmViewStudents objstudent = new frmViewStudents(ExamTitle, Course, Batch, test);
                objstudent.Show();
            }

            else if (grdExamResult.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string ExamTitle = grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[3].Value.ToString();
                string Course = grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[4].Value.ToString();
                string Batch = grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[5].Value.ToString();

                //int testid = Convert.ToInt32(grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[6].Value.ToString());

                //int courseid = Convert.ToInt32(grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[4].Value.ToString());
                //int batchid = Convert.ToInt32(grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[5].Value.ToString());
                string StudFullName = grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[10].Value.ToString();
                int marks = Convert.ToInt32(grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[9].Value.ToString());
                string id = (grdExamResult.Rows[grdExamResult.CurrentRow.Index].Cells[2].Value.ToString());

                frmEditResult objedit = new frmEditResult(ExamTitle, Course, Batch, StudFullName, marks, id);
                objedit.Show();



            }
             
        }

        private void cmbbxExamTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TestId = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator obj = new CoOrdinator(TestId);
            DataTable dt = new DataTable();
            dt = obj.ResultTitleView();
            grdExamResult.DataSource = dt;
            grdExamResult.Show();
            if (cmbbxExamTitle.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxCourseName.Text = "";
                cmbbxBatchName.Text = "";
                
            }

        }

        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            CoOrdinator objcourse = new CoOrdinator(CourseId);
            DataTable dtcourse = new DataTable();
            dtcourse = objcourse.ResultCourseView();
            grdExamResult.DataSource = dtcourse;
            grdExamResult.Show();
            if (cmbbxCourseName.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxBatchName.Text = "";
                cmbbxExamTitle.Text = "";
               
            }
        }

        private void cmbbxBatchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int BatchId = Convert.ToInt32(cmbbxBatchName.SelectedValue.ToString());
            CoOrdinator objBatch = new CoOrdinator(BatchId);
            DataTable dtBatch = new DataTable();
            dtBatch = objBatch.ResultBatchView();
            grdExamResult.DataSource = dtBatch;
            grdExamResult.Show();
            if (cmbbxBatchName.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxCourseName.Text = "";
                cmbbxExamTitle.Text = "";
                
            }
        }
    }
}
