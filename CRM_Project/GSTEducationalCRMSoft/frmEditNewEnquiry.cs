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
    public partial class frmEditNewEnquiry : Form
    {
        string TimePreferd;
        string ProfessionalStatus;
        string ReferenceFrom;
        string Qualification;
        public string studcode { get; set; }
        public int cid { get; set; }
        public frmEditNewEnquiry()
        {
            InitializeComponent();
           
        }
        public frmEditNewEnquiry(string name,string mobile,string email,string sc)
        {
            InitializeComponent();
            txtFullName.Text = name;
            txtContactNumber.Text= mobile;
            txtEmailId.Text= email;
            studcode= sc;
        }
        //public frmEditNewEnquiry(int cid)
        //{
        //    InitializeComponent();

        //}

        private void frmEditNewEnquiry_Load(object sender, EventArgs e)
        {
            Counsellor objCountry = new Counsellor();
            DataTable dtCountry = new DataTable();
            dtCountry = objCountry.GetCountry();
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.DataSource = dtCountry;


            Counsellor objGraduation = new Counsellor();
            DataTable dtGraduation = new DataTable();
            dtGraduation = objGraduation.GetGraduation();
            cmbbxGraduation.ValueMember = "GradId";
            cmbbxGraduation.DisplayMember = "GradName";
            cmbbxGraduation.DataSource = dtGraduation;

            Counsellor objEnquirySource = new Counsellor();
            DataTable dtEnquirySource = new DataTable();
            dtEnquirySource = objEnquirySource.GetEnquirySource();
            cmbbxEnquirySource.ValueMember = "EnquirySourceId";
            cmbbxEnquirySource.DisplayMember = "EnquirySourceName";
            cmbbxEnquirySource.DataSource = dtEnquirySource;

 
            Counsellor objCourse = new Counsellor();
            DataTable dtCourse = new DataTable();
            dtCourse = objCourse.GetCourse();
            cmbbxCourseInterested.ValueMember = "CourseId";
            cmbbxCourseInterested.DisplayMember = "CourseName";
            cmbbxCourseInterested.DataSource = dtCourse;

            Counsellor objAllstudent = new Counsellor(studcode);
            SqlDataReader dr;
            dr = objAllstudent.GetAllStudent();
            while (dr.Read())
            {
                txtPermanentAddress.Text = dr["StudPermanentAddress"].ToString();
                txtPin.Text = dr["StudPinNo"].ToString();
            }




        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            string FullName = txtFullName.Text;
            string ContactNumber = txtContactNumber.Text;
            string EmailId = txtEmailId.Text;
            string PermanentAddress = txtPermanentAddress.Text;
            int City = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());
            string Pin = txtPin.Text;
            DateTime EnquiryDate = DateTime.Now;
            DateTime RegistrationDate = DateTime.Now;
            int Graduation = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
            int PG = Convert.ToInt32(cmbbxPG.SelectedValue.ToString());
            int EnquirySource = Convert.ToInt32(cmbbxEnquirySource.SelectedValue.ToString());
            int CourseInterested = Convert.ToInt32(cmbbxCourseInterested.SelectedValue.ToString());
            
            string TimePreferred = null;
            if (rdobtnMorning.Checked == true)
            {
                TimePreferd = "Morning";
            }
            else if (rdobtnEvening.Checked == true)
            {
                TimePreferd = "Evening";
            }
            else if (rdobtnAfternoon.Checked == true)
            {
                TimePreferd = "Afternoon";
            }
            else
            {
                TimePreferd = "Weekend";
            }
            if (rdobtnStudent.Checked == true)
            {
                ProfessionalStatus = "Student";
            }
            else if (rdobtnEmployee.Checked == true)
            {
                ProfessionalStatus = "Employee";
            }
            else if (rdobtnSelfEmployed.Checked == true)
            {
                ProfessionalStatus = "SelfEmployed";
            }
            else
            {
                ProfessionalStatus = "NonEmployee";
            }
            
            int ssc = 0;
            int hsc = 0;
            int diploma = 0;
            if (chbxSSC.Checked == true)
            {
                ssc = 1;
            }
            else
            {
                ssc = 0;
            }
            if (chbxHSC.Checked == true)
            {
                hsc = 1;
            }
            else
            {
                hsc = 0;
            }
            if (chbxDiploma.Checked == true)
            {
                diploma = 1;
            }
            else
            {
                diploma = 0;
            }
            int gradid = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
            int pggrad = Convert.ToInt32(cmbbxPG.SelectedValue.ToString());


            Counsellor obj = new Counsellor(FullName, ContactNumber, EmailId, PermanentAddress, City, Pin,
            RegistrationDate, Graduation, PG, ProfessionalStatus, EnquirySource, CourseInterested,
            TimePreferred, studcode);
            obj.EditEnquiry();
            Counsellor objqualification = new Counsellor(hsc, ssc, diploma, gradid, pggrad, studcode);
            objqualification.updateEnqueryQualification();
            MessageBox.Show("Submit Sucessfully");
            this.Close();

           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbxSSC_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSSC.Checked == true)
            {
                Qualification = chbxSSC.Text;
            }
            else
            {
                Qualification = "";
            }
        }

        private void chbxHSC_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxHSC.Checked == true)
            {
                Qualification = chbxHSC.Text;
            }
            else
            {
                Qualification = "";
            }
        }

        private void chbxDiploma_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDiploma.Checked == true)
            {
                Qualification = chbxDiploma.Text;
            }
            else
            {
                Qualification = "";
            }
        }

        private void cmbbxGraduation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
            Counsellor objpg = new Counsellor(cid);
            DataTable dtpg = new DataTable();
            dtpg = objpg.GetPG();
            cmbbxPG.ValueMember = "GradId";
            cmbbxPG.DisplayMember = "PGName";
            cmbbxPG.DataSource = dtpg;
        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxState.SelectedValue.ToString());
            Counsellor objCity = new Counsellor(cid);
            DataTable dt = new DataTable();
            dt = objCity.GetCity();
            cmbbxCity.ValueMember = "CityId";
            cmbbxCity.DisplayMember = "CityName";
            cmbbxCity.DataSource = dt;
        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            Counsellor objState = new Counsellor(cid);
            DataTable dtState = new DataTable();
            dtState = objState.GetState();
            cmbbxState.ValueMember = "StateId";
            cmbbxState.DisplayMember = "StateName";
            cmbbxState.DataSource = dtState;
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
