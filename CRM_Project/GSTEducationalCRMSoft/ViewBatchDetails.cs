using clsCoOrdinator;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace GSTEducationalCRMSoft
{
    public partial class ViewBatchDetails : Form
    {     
        public int bid { get;set; }
        public string getstudcode { get; set; }
        public int nos { get; set; }
        public string bname { get; set; }
        public int CourseId { get; set; }
        DataTable dtAddStudent = new DataTable();
        DataTable dt1 = new DataTable();

        int FlagSave = 0;
        int FlagUpdate = 0;

        public ViewBatchDetails(string trainer, string coursename, string batchname, int Batchid,int c)
        {
            InitializeComponent();
            labelTrainer.Text = trainer;
            lblcourse.Text = coursename;
            CourseId = c;
            bname = batchname;
             bid=Batchid;
        }
       
        private void label3_Click(object sender, EventArgs e){}

        private void ViewBatchDetails_Load(object sender, EventArgs e)
        {
            lbladdstudents.Hide();
            lblselectcourse.Hide();
            lblbatch.Hide();
            cmbbxbatchname.Hide();
            cmbbxselectcourse.Hide();
            gridviewAddStudent.Hide();
            lblCourseType.Hide();
            lblselectcourse.Hide();
            labelbatch.Text = bname;
            grdviewStudent();
        }

        public void grdviewStudent()
        {
            CoOrdinator obj1 = new CoOrdinator(bid);
            SqlDataReader dr;
            DataTable dtstudent = new DataTable();
            dr = obj1.GetBatchStudent();
            string[] sc;

            while (dr.Read())
            {
                getstudcode = dr["StudCode"].ToString();
                string Totalstudent = dr["NoOfStudent"].ToString();
                nos = Convert.ToInt32(Totalstudent);
                sc = getstudcode.Split(',');
                for (int i = 0; i < sc.Length; i++)
                {
                    CoOrdinator objstud = new CoOrdinator(sc[i]);
                    dtstudent = objstud.GetgrdStudent();
                    if (i == 0)
                    {
                        dt1 = dtstudent.Clone();
                    }
                    foreach (DataRow temp in dtstudent.Rows)
                    {
                        dt1.ImportRow(temp);
                    }
                }
            }
            gridviewStudentdetail.DataSource = dt1;
            gridviewStudentdetail.Show();
            gridviewStudentdetail.Columns[1].Visible = false;
            gridviewStudentdetail.Columns[4].Visible = false;
            gridviewStudentdetail.RowHeadersVisible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbbxselectcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Courseid = Convert.ToInt32(cmbbxselectcourse.SelectedValue.ToString());
            CoOrdinator objbatch = new CoOrdinator(Courseid,bid);
            DataTable dt = new DataTable();
            dt = objbatch.GetBatchView();
            cmbbxbatchname.ValueMember = "BatchId";
            cmbbxbatchname.DisplayMember = "BatchName";
            cmbbxbatchname.DataSource = dt;
        }

       public void grdAddStudent()
        {
            int Batchid = Convert.ToInt32(cmbbxbatchname.SelectedValue.ToString());
            CoOrdinator obj = new CoOrdinator(Batchid);
            SqlDataReader dr;
            DataTable dtstudent = new DataTable();
            dr = obj.GetBatchStudent();
            string[] sc;

            while (dr.Read())
            {
                string studcode = dr["StudCode"].ToString();
                sc = studcode.Split(',');
                for (int i = 0; i < sc.Length; i++)
                {
                    CoOrdinator objstud = new CoOrdinator(sc[i]);
                    dtstudent = objstud.GetgrdStudent();
                    if (i == 0)
                    {
                        dtAddStudent = dtstudent.Clone();
                    }
                    foreach (DataRow temp in dtstudent.Rows)
                    {
                        dtAddStudent.ImportRow(temp);
                    }
                }
                gridviewAddStudent.DataSource = dtAddStudent;
                gridviewAddStudent.Show();
                gridviewAddStudent.Columns[1].Visible = false;
                gridviewAddStudent.Columns[4].Visible = false;
                gridviewAddStudent.RowHeadersVisible = false;

            }

        }
        private void cmbbxbatchname_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdAddStudent();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            string mergescode = gridviewStudentdetail.Rows[gridviewStudentdetail.CurrentRow.Index].Cells[1].Value.ToString();
            int cid =Convert.ToInt32(gridviewStudentdetail.Rows[gridviewStudentdetail.CurrentRow.Index].Cells[4].Value.ToString());

            if (e.ColumnIndex == 0)
            {
                labelbatch.Text = bname;
                TransferStudent obj = new TransferStudent(mergescode,bname,getstudcode,bid,cid);
                obj.Show();
                this.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Update Sucessfull");
                this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            CoOrdinator objgetname = new CoOrdinator(CourseId);
            SqlDataReader dr;
            string coursetypeid = null;
            dr=objgetname.GetCourseTypeName();
            while(dr.Read())
            {
                label2.Text = dr["CourseTypeName"].ToString();
                coursetypeid = dr["CourseTypeId"].ToString();
            }
            int CourseTypeid = Convert.ToInt32(coursetypeid);
            CoOrdinator obj = new CoOrdinator(CourseTypeid);
            DataTable dtCourse = new DataTable();
            dtCourse = obj.GetCoursefromCourseType();
            cmbbxselectcourse.ValueMember = "CourseId";
            cmbbxselectcourse.DisplayMember = "CourseName";
            cmbbxselectcourse.DataSource = dtCourse;
            //CourseId=Convert.ToInt32(lblcourse.Text.ToString());

            lblCourseType.Show();
            lblselectcourse.Show();
            lbladdstudents.Show();
            lblselectcourse.Show();
            lblbatch.Show();
            cmbbxbatchname.Show();
            cmbbxselectcourse.Show();
            gridviewAddStudent.Show();  
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int batchid = Convert.ToInt32(cmbbxbatchname.SelectedValue.ToString());
            string cname = lblcourse.Text;
            string changecourse = cmbbxselectcourse.Text.ToString();
            string sc = null;
            string scode2 = null;
            int k = 0, i = 0, j = 0, m = 0;
            string sc2 = null;
            string scodefinal = null;
            for (i = 0; i < gridviewAddStudent.Rows.Count; i++)
            {
                
                if (Convert.ToBoolean(gridviewAddStudent.Rows[i].Cells["checkbox"].Value))
                {
                    FlagSave = 1;

                    for (j = 1; j < gridviewAddStudent.Columns.Count-1; j++)
                    {
                        string scode1 = gridviewAddStudent.Rows[i].Cells[j].Value.ToString();
                        if (j == 1)
                        {
                            sc = String.Concat(scode1, ",");
                            k++;
                        }
                        
                    }
                    scode2 = String.Concat(scode2, sc);

                }
                else
                {
                    string scodenew = null;
                    string sc3 = null;
                    for (int l = 1; l < gridviewAddStudent.Columns.Count - 1; l++)
                    {
                        sc3 = gridviewAddStudent.Rows[i].Cells[l].Value.ToString();
                        if (l == 1)
                        {
                            scodenew = String.Concat(sc3, ",");
                            m++;
                        }

                    }
                    sc2 = String.Concat(sc2, scodenew);
                }
            }


            

            scodefinal = String.Concat(getstudcode, ",", scode2);
            int scodefinalNumber = k + nos;
            if(cname!=changecourse)
            {
                string[] newcourseid;
                newcourseid = scode2.Split(',');
                for(int p=0;p<newcourseid.Length;p++)
                {
                    string newsc = newcourseid[p];
                    CoOrdinator objUpdatestud = new CoOrdinator(CourseId, newsc);
                    objUpdatestud.UpdateCandidateByChangeCourse();
                }
            }

            if(m==0)
            {
                CoOrdinator obj = new CoOrdinator(scodefinal, scodefinalNumber, bid);
                obj.UpdateBatch();
                CoOrdinator objdelete = new CoOrdinator(batchid);
                objdelete.DeleteExistingBatch();
            }
            else
            {
                CoOrdinator objNewString = new CoOrdinator(scodefinal, scodefinalNumber, bid);
                objNewString.UpdateBatch();
                CoOrdinator objoldString = new CoOrdinator(sc2, m, batchid);
                objoldString.UpdateBatch();
            }
            
            grdAddStudent();
            grdviewStudent();
        }
    }
}
