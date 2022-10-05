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
using clsCounsellor;


namespace GSTEducationalCRMSoft
{
    public partial class frmLeadReports : Form
    {
        DataTable dtNewLeadReports = new DataTable();
        public frmLeadReports()
        {
            InitializeComponent();
        }
        
        private void frmLeadReports_Load(object sender, EventArgs e)
        {
            Counsellor objCourse = new Counsellor();
            DataTable dtCourse = new DataTable();
            dtCourse = objCourse.GetInterestedCourse();
            cmbbxInterestedCourse.ValueMember = "CourseId";
            cmbbxInterestedCourse.DisplayMember = "CourseName";
            cmbbxInterestedCourse.DataSource = dtCourse;
            cmbbxInterestedCourse.Show();

            //**********************GridView*******************//

            Counsellor objLeadreport = new Counsellor();
            dtNewLeadReports = objLeadreport.GetNewLeadReports();
            grdLeadReport.DataSource = dtNewLeadReports;
            grdLeadReport.Show();

            //***********************EnquirySource***************//

            Counsellor objEnquirySource = new Counsellor();
            DataTable dtEnquierySource = new DataTable();
            dtEnquierySource = objEnquirySource.GetEnquirySource();
            cmbbxEnquirySource.ValueMember = "EnquirySourceId";
            cmbbxEnquirySource.DisplayMember = "EnquirySourceName";
            cmbbxEnquirySource.DataSource = dtEnquierySource;
            cmbbxEnquirySource.Show();
        
            //**************************EnquiryStatus***************//

            Counsellor objEnquiryStatus = new Counsellor();
            DataTable dtEnquieryStatus = new DataTable();
            dtEnquieryStatus = objEnquiryStatus.GetLeadEnquiryStatus();
            cmbbxEnquiryStatus.ValueMember = "StatusId";
            cmbbxEnquiryStatus.DisplayMember = "Status";
            cmbbxEnquiryStatus.DataSource = dtEnquieryStatus;
            cmbbxEnquiryStatus.Show();

            //***************************Qualification*******************//
            Counsellor objGraduation = new Counsellor();
            DataTable dtGraduation = new DataTable();
            dtGraduation = objGraduation.GetGraduation();
            cmbbxQualification.ValueMember = "GradId";
            cmbbxQualification.DisplayMember = "GradName";
            cmbbxQualification.DataSource = dtGraduation;
            cmbbxQualification.Show();

            /****************filter************/
            cmbbxEnquirySource.Hide();
            cmbbxEnquiryStatus.Hide();
            cmbbxInterestedCourse.Hide();
            cmbbxQualification.Hide();
            datePickerFromDate.Hide();
            datePickerToDate.Hide();
            pictbxCalender1.Hide();
            pictbxCalender2.Hide();
            pictbxSearch1.Hide();
            
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            lblStartDate.Hide();
            lblEndDate.Hide();

        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxInterestedCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void cmbbxEnquirySource_SelectedIndexChanged(object sender, EventArgs e)
        {
            int courseid = Convert.ToInt32(cmbbxEnquirySource.SelectedValue.ToString());
            Counsellor objSourceView = new Counsellor(courseid);
            DataTable dtEnquierySourceview = new DataTable();
            dtEnquierySourceview = objSourceView.EnquirySourceFilter();
            grdLeadReport.DataSource = dtEnquierySourceview;
            grdLeadReport.Show();
            if (cmbbxEnquirySource.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxEnquiryStatus.Text = "";
                cmbbxInterestedCourse.Text = "";
                cmbbxQualification.Text = "";
                datePickerFromDate.Text = "";
                datePickerToDate.Text = "";
            }


        }

        private void cmbbxEnquiryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
          int statusid = Convert.ToInt32(cmbbxEnquiryStatus.SelectedValue.ToString());
            Counsellor objStatusView = new Counsellor(statusid);
            DataTable dtEnquieryStatusview = new DataTable();
            dtEnquieryStatusview = objStatusView.EnquiryStatusFilter();
            grdLeadReport.DataSource = dtEnquieryStatusview;
            grdLeadReport.Show();
            if (cmbbxEnquiryStatus.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxInterestedCourse.Text = "";
                cmbbxEnquirySource.Text = "";
                cmbbxQualification.Text = "";
            }
        }

        private void cmbbxInterestedCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxInterestedCourse.SelectedValue.ToString());
            Counsellor objCourseView = new Counsellor(cid);
            DataTable dtCourseView = new DataTable();
            dtCourseView = objCourseView.InterestedCourseFilter();
            grdLeadReport.DataSource = dtCourseView;
            grdLeadReport.Show();
            if (cmbbxInterestedCourse.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxEnquiryStatus.Text = "";
                cmbbxEnquirySource.Text = "";
                cmbbxQualification.Text = "";
            }
           
        }

        private void cmbbxQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gid = Convert.ToInt32(cmbbxQualification.SelectedValue.ToString());
            Counsellor objQualificationView = new Counsellor(gid);
            DataTable dtQualificationView = new DataTable();
            dtQualificationView = objQualificationView.QualificationFilter();
            grdLeadReport.DataSource = dtQualificationView;
            grdLeadReport.Show();
            if (cmbbxQualification.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxEnquiryStatus.Text = "";
                cmbbxEnquirySource.Text = "";
                cmbbxInterestedCourse.Text = "";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtNewLeadReports.DefaultView;
            dv.RowFilter = "FullName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR MobileNo Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Email Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Qualification Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR CourseName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR EnquirySourceName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Status Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR StaffName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Comment Like '" + txtSearch.Text + "%'";
            grdLeadReport.DataSource = dv;
        }

        

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxEnquirySource.Show();
            cmbbxEnquiryStatus.Show();
            cmbbxInterestedCourse.Show();
            cmbbxQualification.Show();
            datePickerFromDate.Show();
            datePickerToDate.Show();
            pictbxCalender1.Show();
            pictbxCalender2.Show();
            pictbxSearch1.Show();

            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            lblEndDate.Show();
            lblStartDate.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime StartDate = datePickerFromDate.Value;
            DateTime EndDate = datePickerToDate.Value;
            Counsellor objDate = new Counsellor(StartDate, EndDate, this.Text);
            DataTable dt = new DataTable();
            dt = objDate.LeadReportFromDateToDate();
            grdLeadReport.DataSource = dt;
            grdLeadReport.Show();
        }
    }
}
