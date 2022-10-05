using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using clsCoOrdinator;
using clsCounsellor; 

namespace GSTEducationalCRMSoft
{
     
    public partial class frmLeaveManagement : Form
    {
        //Pending Query
        public frmLeaveManagement()
        {
            InitializeComponent();
            

        }
         //public string StaffName { get; set; }
         //string sc { get; set; }
        public frmLeaveManagement(string sc)
        {

            InitializeComponent();
            this.Text = sc;
          //  string StaffCode =SC;
            Counsellor objStaff = new Counsellor(this.Text);
            SqlDataReader StaffName = objStaff.GetStaffName();
            StaffName.Read();
            if(StaffName.HasRows)
            {
                lblName.Text = StaffName["StaffName"].ToString();
            }
            //this.Text = sc;
            //StaffName = staffname;
            //label1.Text = staffname;

            Counsellor objm = new Counsellor(sc);
            SqlDataReader monthlysick = objm.MonthlyLeaves();
            monthlysick.Read();
            if (monthlysick.HasRows)
            { 
                lblSick1.Text = monthlysick["SickLeave"].ToString();
                lblcasual1.Text = monthlysick["Casual"].ToString();
                lblpaid1.Text = monthlysick["paidLeave"].ToString();
                lbltotal.Text = monthlysick["Total"].ToString();
            }

            Counsellor objy = new Counsellor(sc);
            SqlDataReader yearlyleave = objy.YearlyLeaves();
            yearlyleave.Read();
            if (yearlyleave.HasRows)
            {

                lblsick3.Text = yearlyleave["SickLeave"].ToString();
                lblCasual3.Text = yearlyleave["Casual"].ToString();
                lblpaid3.Text = yearlyleave["paidLeave"].ToString();
                lbltotal1.Text = yearlyleave["Total"].ToString();
            }


            }
            //   DataTable dtt = new DataTable();
            private void lblMonthlyLeaves_Click(object sender, EventArgs e)
        {
        }

        private void lblYearlyLeaves_Click(object sender, EventArgs e)
        {
        }

        private void grdMonthlyLeave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmLeaveManagement_Load(object sender, EventArgs e)
        {

            Counsellor objftch = new Counsellor(this.Text);
            DataTable dtld = new DataTable();
            dtld = objftch.LeaveDetails();
            grdMonthlyLeave.DataSource = dtld;
            grdMonthlyLeave.Show();

            //Counsellor obj = new Counsellor(this.Text);
            //DataTable dtt = new DataTable();
            //dtt = obj.YearlyLeaves();
            //grdYearlyLeaves.DataSource = dtt;
            //grdYearlyLeaves.Show();


     

        }

        private void grdYearlyLeaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void btnApplyForLeave_Click(object sender, EventArgs e)
        {
            frmApplyLeaves objApplyLeav=new frmApplyLeaves(this.Text);
            objApplyLeav.Show();
        }

        private void btnml_Click(object sender, EventArgs e)
        {
            //Counsellor objftch = new Counsellor(this.Text);
            //DataTable dtm = new DataTable();
            //dtm = objftch.MonthlyLeaves();
            //grdMonthlyLeave.DataSource = dtm;
            //grdMonthlyLeave.Show();

        }

        private void btnyl_Click(object sender, EventArgs e)
        {
            //Counsellor obj = new Counsellor(this.Text);
            //DataTable dtt = new DataTable();
            //dtt = obj.YearlyLeaves();
            //grdMonthlyLeave.DataSource = dtt;
            //grdMonthlyLeave.Show();

        }

        private void s_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSick1_Click(object sender, EventArgs e)
        {

        }

        private void lblpaid1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictRefresh_Click(object sender, EventArgs e)
        {
            Counsellor objftch = new Counsellor(this.Text);
            DataTable dtld = new DataTable();
            dtld = objftch.LeaveDetails();
            grdMonthlyLeave.DataSource = dtld;
            grdMonthlyLeave.Show();
        }
    }
}
