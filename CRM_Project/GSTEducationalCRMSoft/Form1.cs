using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCounsellor;

namespace GSTEducationalCRMSoft
{
    public partial class Form1 : Form
    {
        public string staffc;
        public string StaffPosition;
        public Form1()
        {
            InitializeComponent();
           
        }
        public Form1(string sc, string sp)
        {
            InitializeComponent();
            IsMdiContainer = true;
            staffc = sc;
            StaffPosition = sp;
        }
        
        public void LoadForm(object Form)
        {
            if (this.panelBody1.Controls.Count > 0)
                this.panelBody1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelBody1.Controls.Add(f);
            this.panelBody1.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm(new frmDashboard());
            //frmDashboard objfrmDashboard = new frmDashboard();
            //objfrmDashboard.Show();

        }

        private void taskManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm (new frmTaskManagement (staffc));
            //frmTaskManagement objTaskManagment = new frmTaskManagement(staffc);
            //objTaskManagment.Show();
            //objTaskManagment.MdiParent = this;
        }

        private void leaveManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmLeaveManagement(staffc));
            //frmLeaveManagement objleave = new frmLeaveManagement(staffc);
            //objleave.Show();
            // objleave.MdiParent = this;
        }

        private void syllabusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmSyllabus());
            //frmSyllabus objSyllabus = new frmSyllabus();
            //objSyllabus.Show();
           // objSyllabus.MdiParent = this;
        }


        private void leadReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmLeadReports());
        //    frmLeadReports objfrmLeadReports=new frmLeadReports();
        //    objfrmLeadReports.Show();
        }

        private void internalPlacementReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmInternalPlacementReports());
            //frmInternalPlacementReports objPlacedStudent = new frmInternalPlacementReports();
            //objPlacedStudent.Show();
        }

        private void enquiryFollowUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmEnquiryFollowUp());
            //frmEnquiryFollowUp objfrmEnquiryFollowUp = new frmEnquiryFollowUp();
            //objfrmEnquiryFollowUp.Show();
        }

        private void enqueryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmEnquiryManagement(staffc));
            //frmEnquiryManagement objfrmEnquiryManagement = new frmEnquiryManagement();
            //objfrmEnquiryManagement.Show();

            //foreach (frmEnquiryManagement frm in this.MdiChildren)
            //{
            //    if (!frm.Focused)
            //    {
            //        frm.Visible = false;
            //        frm.Dispose();
            //    }
            //}
            //panelBody1.Hide();
            //frmEnquiryManagement objem = new frmEnquiryManagement();
            //objem.MdiParent = this;
            //objem.Show();
        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmAdmission());
            //frmAdmission objadmission = new frmAdmission();
            //objadmission.Show();
        }

        private void demoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadForm(new frmArrangeDemo());
            //frmArrangeDemo objfrmArrangeDemo = new frmArrangeDemo();
            //objfrmArrangeDemo.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profuleSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmProfileSetting(staffc,StaffPosition,LoadForm));
            //frmProfileSetting objprofile = new frmProfileSetting(staffc, StaffPosition);
            //objprofile.Show();
        }

        private void brochureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmbrochure());
            //frmbrochure objbrochure  = new frmbrochure();
            //objbrochure.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEnquiryManagement objfrmEnquiryManagement = new frmEnquiryManagement(staffc);
            objfrmEnquiryManagement.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmEnquiryManagement objMonthlyEnquiry=new frmEnquiryManagement(staffc);
            objMonthlyEnquiry.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdmission objAdmission = new frmAdmission();
            objAdmission.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //LoadForm(new frmDashboard());
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDashboard());
        }   

        private void panelBody1_Paint(object sender, PaintEventArgs e)
        {

            //// TODO: This line of code loads data into the 'gSTEducationalCRMSoftwareDataSet1.tblGSTCRMCandidate' table. You can move, or remove it, as needed.
            //// this.tblGSTCRMCandidateTableAdapter.Fill(this.gSTEducationalCRMSoftwareDataSet1.tblGSTCRMCandidate);
            ////Daily Enquiries
            //Counsellor obj = new Counsellor();
            //DataTable dt = new DataTable();
            //dt = obj.DailyEnquiries();
            //lblDailyEnquiries.Text = dt.Rows[0][0].ToString();

            ////DailyAdmission
            //Counsellor obj5 = new Counsellor();
            //DataTable dt5 = new DataTable();
            //dt5 = obj5.GetDailyAdmission();
            //lblDailyAdmission.Text = dt5.Rows[0][0].ToString();



            ////MonthlyEnquiries
            //Counsellor obj2 = new Counsellor();
            //DataTable dt2 = new DataTable();
            //dt2 = obj2.MonthlyEnquiries();
            //lblMonthlyEnquiries.Text = dt2.Rows[0][0].ToString();

            ////MonthlyAdmission
            //Counsellor obj3 = new Counsellor();
            //DataTable dt3 = new DataTable();
            //dt3 = obj3.MonthlyAdmission();
            //lblMonthlyAdmission.Text = dt3.Rows[0][0].ToString();

            //Counsellor obj4 = new Counsellor();
            //DataTable dt4 = new DataTable();
            //dt4 = obj4.Getghrph();
            //chart1.DataSource = dt4;
            //chart1.Series["Addmission"].XValueMember = "Month";
            //chart1.Series["Addmission"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //chart1.Series["Addmission"].YValueMembers = "Addmission";
            //chart1.Series["Addmission"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            ////Total Enquiries Count
            //lblTotal.Text = (Convert.ToInt32(lblDailyEnquiries.Text) + Convert.ToInt32(lblMonthlyEnquiries.Text)).ToString();

            ////Total Admission Count
            //lblATotal.Text = (Convert.ToInt32(lblDailyAdmission.Text) + Convert.ToInt32(lblMonthlyAdmission.Text)).ToString();
        }
    }
}
