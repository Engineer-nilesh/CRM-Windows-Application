using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCounsellor;
using System.Data.SqlClient;
using System.Data;



namespace GSTEducationalCRMSoft
{
    public partial class frmDashboard : Form
    {
        
        SqlConnection con =new SqlConnection ("Data Source=DESKTOP-BK2RLHN\\SQLEXPRESS;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSTEducationalCRMSoftwareDataSet1.tblGSTCRMCandidate' table. You can move, or remove it, as needed.
            // this.tblGSTCRMCandidateTableAdapter.Fill(this.gSTEducationalCRMSoftwareDataSet1.tblGSTCRMCandidate);
            //Daily Enquiries
            Counsellor obj = new Counsellor();
            DataTable dt = new DataTable();
            dt = obj.DailyEnquiries();
            lblDailyEnquiries.Text = dt.Rows[0][0].ToString();

            //DailyAdmission
            Counsellor obj5 = new Counsellor();
            DataTable dt5 = new DataTable();
            dt5 = obj5.GetDailyAdmission();
            lblDailyAdmission.Text = dt5.Rows[0][0].ToString();



            //MonthlyEnquiries
            Counsellor obj2 = new Counsellor();
            DataTable dt2 = new DataTable();
            dt2 = obj2.MonthlyEnquiries();
            lblMonthlyEnquiries.Text = dt2.Rows[0][0].ToString();

            //MonthlyAdmission
            Counsellor obj3 = new Counsellor();
            DataTable dt3 = new DataTable();
            dt3 = obj3.MonthlyAdmission();
            lblMonthlyAdmission.Text = dt3.Rows[0][0].ToString();

            Counsellor obj4 = new Counsellor();
            DataTable dt4 = new DataTable();
            dt4 = obj4.Getghrph();
            chart1.DataSource = dt4;
            chart1.Series["Addmission"].XValueMember = "Month";
            chart1.Series["Addmission"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series["Addmission"].YValueMembers = "Addmission";
            chart1.Series["Addmission"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            //Total Enquiries Count
            lblTotal.Text = (Convert.ToInt32(lblDailyEnquiries.Text) + Convert.ToInt32(lblMonthlyEnquiries.Text)).ToString();

            //Total Admission Count
            lblATotal.Text = (Convert.ToInt32(lblDailyAdmission.Text) + Convert.ToInt32(lblMonthlyAdmission.Text)).ToString();
        }
        private void lblDailyEnquiries_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           /*Counsellor obj = new Counsellor();
            DataTable dt = new DataTable();
            dt = obj.Getghrph();
            chart1.DataSource = dt;
            chart1.Series["Addmission"].XValueMember = "Month";
            chart1.Series["Addmission"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series["Addmission"].YValueMembers = "Addmission";
            chart1.Series["Addmission"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;*/







        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void lblMonthlyLeadEnquiries_Click(object sender, EventArgs e)
        {
           
        }

        private void lblMonthlyAdmission_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmEnquiryManagement objopen = new frmEnquiryManagement();
            //objopen.Show();
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmEnquiryManagement objopen = new frmEnquiryManagement();
            //objopen.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdmission objopen = new frmAdmission();
            objopen.Show();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdmission objopen = new frmAdmission();
            objopen.Show();
        }
    }
}
