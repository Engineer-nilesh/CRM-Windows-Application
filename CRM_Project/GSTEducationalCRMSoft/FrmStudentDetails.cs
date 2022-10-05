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
    
    public partial class FrmStudentDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SWAPNIL;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");
        public int BatchId { get; set; }

        //Pending Query
        public FrmStudentDetails()
        {
            InitializeComponent();
        }
        public FrmStudentDetails(int Batchid)
        {
            InitializeComponent();
             BatchId = Batchid;

        }

        DataTable dtstud = new DataTable();

        private void FrmStudentDetails_Load(object sender, EventArgs e)
        {
            CoOrdinator objstud = new CoOrdinator();
            dtstud = objstud.GetStudentsDetails();
            grdStudentDetail.DataSource = dtstud;
            grdStudentDetail.Show();

            

            /*************Filter***************/
            cmbbxBatchName.Hide();
            cmbbxCourseName.Hide();
            cmbbxTrainerName.Hide();
            lblBatchName.Hide();
            lblCourseName.Hide();
            lblTrainerName.Hide();
        }

        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Cid =Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            CoOrdinator objC = new CoOrdinator(Cid);
            DataTable dtC = new DataTable();
            dtC = objC.FillterCourse();
            grdStudentDetail.DataSource = dtC;
            grdStudentDetail.Show();

            if(cmbbxCourseName.SelectedItem == "true")
            {

            }
            else
            {
                cmbbxTrainerName.Text = "";
                cmbbxBatchName.Text = "";
            }
        }

        private void cmbbxTrainerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tid = (cmbbxTrainerName.SelectedValue.ToString());
            CoOrdinator objT = new CoOrdinator(Tid);
            DataTable dtT = new DataTable();
            dtT = objT.FillterTrainer();
            grdStudentDetail.DataSource = dtT;
            grdStudentDetail.Show();

            if (cmbbxTrainerName.SelectedItem == "true")
            {

            }
            else
            {
                cmbbxCourseName.Text = "";
                cmbbxBatchName.Text = "";
            }
        }

        private void cmbbxBatchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Bid = Convert.ToInt32(cmbbxBatchName.SelectedValue.ToString());
            CoOrdinator objB = new CoOrdinator(Bid);
            DataTable dtB = new DataTable();
            dtB = objB.FillterBatch();
            grdStudentDetail.DataSource = dtB;
            grdStudentDetail.Show();

            if (cmbbxBatchName.SelectedItem == "true")
            {

            }
            else
            {
                cmbbxCourseName.Text = "";
                cmbbxTrainerName.Text = "";
            }


        }

        private void grdStudentDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string  Batchid =grdStudentDetail.Rows[grdStudentDetail.CurrentRow.Index].Cells[3].Value.ToString();
            string StudRagisterDate = null;
            string StudCode = null;
            CoOrdinator objDate = new CoOrdinator();
            SqlDataReader dr;
            dr = objDate.GetLableStudent();
            while (dr.Read())
            {
                StudRagisterDate = dr["StudRegistrationDate"].ToString();
                StudCode = dr["StudCode"].ToString();
            }
            FrmStudentList obj = new FrmStudentList(Batchid);
            obj.Show();
        }

        private void pictbxExcel_Click(object sender, EventArgs e)
        {

            if (grdStudentDetail.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < grdStudentDetail.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdStudentDetail.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdStudentDetail.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < grdStudentDetail.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdStudentDetail.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtstud.DefaultView;
            dv.RowFilter = "CourseName Like '" + txtSearch.Text + "%'";
            dv.RowFilter = "OR TrainerName'" + txtSearch.Text + "%'";
            dv.RowFilter = "OR BatchName'" + txtSearch.Text + "%'";
            dv.RowFilter = "OR LabCapacity'" + txtSearch.Text + "%'";
            grdStudentDetail.DataSource = dv;
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxBatchName.Show();
            cmbbxCourseName.Show();
            cmbbxTrainerName.Show();
            lblBatchName.Show();
            lblCourseName.Show();
            lblTrainerName.Show();

            CoOrdinator obj = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = obj.GetCourseName();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseName";
            cmbbxCourseName.DataSource = dt;

            CoOrdinator obj2 = new CoOrdinator();
            DataTable dt2 = new DataTable();
            dt2 = obj2.GetBatchNameDr();
            cmbbxBatchName.ValueMember = "BatchId";
            cmbbxBatchName.DisplayMember = "BatchName";
            cmbbxBatchName.DataSource = dt2;


            CoOrdinator obj1 = new CoOrdinator();
            DataTable dt1 = new DataTable();
            dt1 = obj1.GetTrainerName();
            cmbbxTrainerName.ValueMember = "StaffCode";
            cmbbxTrainerName.DisplayMember = "StaffName";
            cmbbxTrainerName.DataSource = dt1;



        }
    }
}
