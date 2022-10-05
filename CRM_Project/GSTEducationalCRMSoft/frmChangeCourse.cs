using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using clsCoOrdinator;

namespace GSTEducationalCRMSoft
{
    public partial class frmChangeCourse : Form
    {
        string getbatch = null;
        //string coursefees = null;
        string getstudcode = null;
        string merge=null;
        string removeconcat = null;
        int totalMergeStudent = 0;
        string[] sc = null;
        int total = 0;
        string totalStudent = null;
        int oldbid = 0;
        public string studentcode { get; set; }
       
        public frmChangeCourse()
        {
            InitializeComponent();
        }

        private void frmChangeCourse_Load(object sender, EventArgs e)
        {
            CoOrdinator objname = new CoOrdinator();
            DataTable dtname = new DataTable();
            dtname = objname.GetName();
            cmbbxNames.ValueMember = "StudCode";
            cmbbxNames.DisplayMember = "StudFullName";
            cmbbxNames.DataSource = dtname;




            CoOrdinator obj = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = obj.GetCourse();
            cmbbxSelectCourseToChange.ValueMember = "CourseId";
            cmbbxSelectCourseToChange.DisplayMember = "CourseName";
            cmbbxSelectCourseToChange.DataSource = dt;

           // int Course = Convert.ToInt32(cmbbxSelectCourseToChange.SelectedValue.ToString());
            CoOrdinator objBatchName = new CoOrdinator();
            DataTable dtbn = new DataTable();
            dtbn = objBatchName.GetBatch();
            comboBox2.ValueMember = "BatchId";
            comboBox2.DisplayMember = "BatchName";
            comboBox2.DataSource = dtbn;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbbxSelectCourseToChange.SelectedIndex = -1;
          //  cmbbxNames.Clear();
            txtCourseName.Clear();
            txtBatchName.Clear();
            comboBox2.SelectedIndex= -1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            int cid= Convert.ToInt32(cmbbxSelectCourseToChange.SelectedValue.ToString());
            string studcode = null;
            CoOrdinator objstudent = new CoOrdinator(id);
            SqlDataReader drbatch;
            drbatch = objstudent.GetBatchStudent();
            while (drbatch.Read())
            {
                studcode = drbatch["StudCode"].ToString();
                totalStudent = drbatch["NoOfStudent"].ToString();

            }


            merge = String.Concat(studcode, ",", studentcode);
            totalMergeStudent = Convert.ToInt32(totalStudent) + 1;


            for (int i = 0; i < sc.Length; i++)
            {
                if (sc[i] != studentcode)
                {
                    string temp = sc[i];
                    if (i == 0)
                    {
                        string remove = String.Concat(temp, ",");
                        removeconcat = String.Concat(removeconcat, ",");
                    }
                    removeconcat = String.Concat(removeconcat, temp);
                    total++;
                }
            }

            CoOrdinator objoldString = new CoOrdinator(removeconcat, total,oldbid);
            objoldString.UpdateBatch();

            CoOrdinator objnewString = new CoOrdinator(merge, totalMergeStudent, id);
            objnewString.UpdateBatch();

            CoOrdinator objupdateStud = new CoOrdinator(cid, studentcode);
            objupdateStud.UpdateCandidateByChangeCourse();
            MessageBox.Show("Update Sucessfully");
            this.Close();
        }


        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            //string sname = cmbbxNames.Text;
            //CoOrdinator obj = new CoOrdinator(sname);
            //int courseid = 0;
            //SqlDataReader dr;
            //dr = obj.GetCourseBySname();
            //while (dr.Read())
            //{
            //    txtCourseName.Text = dr["CourseName"].ToString();
            //    label3.Text = dr["CourseFees"].ToString();
            //    studentcode = dr["StudCode"].ToString();
            //    courseid = Convert.ToInt32(dr["CourseId"].ToString());
            //}   
            //CoOrdinator objstudent = new CoOrdinator(courseid);
            //DataTable dtbatch = new DataTable();
            //dtbatch = objstudent.GetBatchForCourseChange();
           
            //for (int i = 0; i < dtbatch.Rows.Count; i++)
            //{
            //    getstudcode = dtbatch.Rows[i]["StudCode"].ToString();
            //    getbatch = dtbatch.Rows[i]["BatchName"].ToString();
            //    string bid = dtbatch.Rows[i]["BatchId"].ToString();
            //    oldbid = Convert.ToInt32(bid);
            //    sc = getstudcode.Split(',');
            //    for (int j = 0; j < sc.Length; j++)
            //    {
            //        if (sc[j] == studentcode)
            //        {
            //            txtBatchName.Text = getbatch;
            //            break;
            //        }
            //    }
            //}


        }

        private void cmbbxSelectCourseToChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Course = Convert.ToInt32(cmbbxSelectCourseToChange.SelectedValue.ToString());
            SqlDataReader dr;
            CoOrdinator objcoursefees = new CoOrdinator(Course);
            dr = objcoursefees.GetCourseFees();
            while(dr.Read())
            {
                label2.Text = dr["CourseFees"].ToString();
            }
            CoOrdinator objBatchName = new CoOrdinator(Course);
            DataTable dtbn = new DataTable();
            dtbn = objBatchName.GetBatch();
            comboBox2.ValueMember = "BatchId";
            comboBox2.DisplayMember = "BatchName";
            comboBox2.DataSource = dtbn;

        }

        private void cmbbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sname = cmbbxNames.Text;
            //CoOrdinator obj = new CoOrdinator(sname);
            //int courseid = 0;
            //SqlDataReader dr;
            //dr = obj.GetCourseBySname();
            //while (dr.Read())
            //{
            //    txtCourseName.Text = dr["CourseName"].ToString();
            //    label3.Text = dr["CourseFees"].ToString();
            //    studentcode = dr["StudCode"].ToString();
            //    courseid = Convert.ToInt32(dr["CourseId"].ToString());
            //}
            //CoOrdinator objstudent = new CoOrdinator(courseid);
            //DataTable dtbatch = new DataTable();
            //dtbatch = objstudent.GetBatchForCourseChange();

            //for (int i = 0; i < dtbatch.Rows.Count; i++)
            //{
            //    getstudcode = dtbatch.Rows[i]["StudCode"].ToString();
            //    getbatch = dtbatch.Rows[i]["BatchName"].ToString();
            //    string bid = dtbatch.Rows[i]["BatchId"].ToString();
            //    oldbid = Convert.ToInt32(bid);
            //    sc = getstudcode.Split(',');
            //    for (int j = 0; j < sc.Length; j++)
            //    {
            //        if (sc[j] == studentcode)
            //        {
            //            txtBatchName.Text = getbatch;
            //            break;
            //        }
            //    }
            //}


        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxNames_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           string sname = cmbbxNames.Text;
            CoOrdinator obj = new CoOrdinator(sname);
            int courseid = 0;
            SqlDataReader dr;
            dr = obj.GetCourseBySname();
            while (dr.Read())
            {
                txtCourseName.Text = dr["CourseName"].ToString();
                label3.Text = dr["CourseFees"].ToString();
                studentcode = dr["StudCode"].ToString();
                courseid = Convert.ToInt32(dr["CourseId"].ToString());
            }
            CoOrdinator objstudent = new CoOrdinator(courseid);
            DataTable dtbatch = new DataTable();
            dtbatch = objstudent.GetBatchForCourseChange();

            for (int i = 0; i < dtbatch.Rows.Count; i++)
            {
                getstudcode = dtbatch.Rows[i]["StudCode"].ToString();
                getbatch = dtbatch.Rows[i]["BatchName"].ToString();
                string bid = dtbatch.Rows[i]["BatchId"].ToString();
                oldbid = Convert.ToInt32(bid);
                sc = getstudcode.Split(',');
                for (int j = 0; j < sc.Length; j++)
                {
                    if (sc[j] == studentcode)
                    {
                        txtBatchName.Text = getbatch;
                        break;
                    }
                }
            }

        }
    }
}
