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
using clsAdmin;
using System.Text.RegularExpressions;

namespace GSTEducationalCRMSoft
{

    public partial class frmNewEnquiry : Form
    {
        public string StaffName { get; set; }
        string Gender;
        string TimePreferd;
        string ProfessionalStatus;
        string ReferenceFrom;
        string Qualification;
        string Number = ("^[0-9]");
        string Words = ("^[a-zA-Z]");
        string EmailPattern = (@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-][a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.][a-zA-Z]$");

        public Action<object> loadForm;

        public frmNewEnquiry(string sc)
        {
            InitializeComponent();
            lblsn.Text = sc;
            lblsn.Hide();
        }

        //public frmNewEnquiry(string sc, Action<object> loadForm) : this(sc)
        //{
        //    this.loadForm = loadForm;
        //}

        private void frmNewEnquiry_Load(object sender, EventArgs e)
        {
            AdminClass objAdmin = new AdminClass();
            DataTable dt = new DataTable();
            dt = objAdmin.FetchCountry();
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.DataSource = dt;

            AdminClass objGraduation = new AdminClass();
            DataTable dtGraduation = new DataTable();
            dtGraduation = objGraduation.FetchGraduation();
            cmbbxGraduation.ValueMember = "GradId";
            cmbbxGraduation.DisplayMember = "GradName";
            cmbbxGraduation.DataSource = dtGraduation;

            Counsellor objEnquirySource = new Counsellor();
            DataTable dtEnquirySource = new DataTable();
            dtEnquirySource = objEnquirySource.GetEnquirySource();
            cmbbxEnquirySource.ValueMember = "EnquirySourceId";
            cmbbxEnquirySource.DisplayMember = "EnquirySourceName";
            cmbbxEnquirySource.DataSource = dtEnquirySource;


            Counsellor objCourseType = new Counsellor();
            DataTable dtCourseType = new DataTable();
            dtCourseType = objCourseType.Get_CourseType();
            cmbbxCourseType.ValueMember = "CourseTypeId";
            cmbbxCourseType.DisplayMember = "CourseTypeName";
            cmbbxCourseType.DataSource = dtCourseType;

            Counsellor objInventoryStatus = new Counsellor();
            DataTable dta = new DataTable();
            dta = objInventoryStatus.GetEnquirySourceStatus();
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.DataSource = dta;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string names = txtFirstName.Text;
            string StudCode = null;
            AdminClass objgenstudcode = new AdminClass();
            SqlDataReader dr = objgenstudcode.GenStudCode();
            if (dr.Read())
            {
                string studcode = dr[0].ToString();
                int j = Convert.ToInt32(studcode);
                j = j + 1;
                StudCode = "RTS" + names + j.ToString();
            }
            else
            {
                StudCode = "RTS" + 1;
            }
            string FullName = txtFirstName.Text + ' ' + txtMiddleName.Text + ' ' + txtLastName.Text;
            string ContactNumber = txtContactNumber.Text;
            string AlternateNumber = txtAlternateNumber.Text;
            string EmailId = txtEmailId.Text;
            string Gender;
            string LocalAddress = txtLocalAddress.Text;
            string PermanentAddress = txtPermanentAddress.Text;
            int City = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());
            string Pin = txtPin.Text;
            DateTime EnquiryDate = DateTime.Now;
            DateTime RegistrationDate = DateTime.Now;
            int Graduation = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
            int PG = Convert.ToInt32(cmbbxPG.SelectedValue.ToString());
            string OtherQualification = txtOtherQualification.Text;
            string ProfessionalStatus = null;
            string References = null;
            int EnquirySource = Convert.ToInt32(cmbbxEnquirySource.SelectedValue.ToString());
            int CourseInterested = Convert.ToInt32(cmbbxCourseInterested.SelectedValue.ToString());
            int CourseType = Convert.ToInt32(cmbbxCourseType.SelectedValue.ToString());
            string TimePreferred = null;
            string PreviousExperience = null;
            string CompanyName = null;
            string Designation = null;
            string Period = null;
            DateTime DOB = new DateTime(2015, 12, 31);
            string FatherName = null;
            string MotherName = null;
            string FatherContactNo = null;
            string MotherContactNo = null;
            string CollageName = null;
            int StatusId = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());
            string ResistrationFees = null;
            int NumberOfInstallments = 0;
            string PaymentMethod = null;
            string TransactionId = null;
            string RaiseDiscount = null;
            string EnquiryComment = txtEnquiryCommentBox.Text;
            string PhotoFile = null;
            string AdharCardFile = null;
            string PanCardFile = null;
            string UnderGraduationFile = null;
            string GraduationFile = null;
            string PGFile = null;
            int CenterId = 0;
            string StaffName = lblsn.Text;



            if (rdobtnMale.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
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
            if (rdobtnSeminarAttended.Checked == true)
            {
                ReferenceFrom = "SeminarAttended";
            }
            else if (rdobtnFriendsReference.Checked == true)
            {
                ReferenceFrom = "FriendsReference";
            }
            else if (rdobtnPosterBanners.Checked == true)
            {
                ReferenceFrom = "PosterBanners";
            }
            else
            {
                ReferenceFrom = "Others";
            }

            /// Validation 

            if (txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("Enter First Name...");
            }
            else if (txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Enter Last Name...");
            }

            else if (txtContactNumber.Text == string.Empty)
            {
                MessageBox.Show("Enter Contact Number...");
            }

            else if (txtAlternateNumber.Text == string.Empty)
            {
                txtAlternateNumber.Focus();
                MessageBox.Show("Please enter Alternate number...");
            }
            else if (txtEmailId.Text == string.Empty)
            {
                txtEmailId.Focus();
                MessageBox.Show("Please enter Email Id...");
            }
            else if (txtPin.Text == string.Empty)
            {
                txtPin.Focus();
                MessageBox.Show("Enter Pin Number...");
            }
            else if (txtLocalAddress.Text == string.Empty)
            {
                txtLocalAddress.Focus();
                MessageBox.Show("Enter Local Address...");
            }
            else if (txtPermanentAddress.Text == string.Empty)
            {
                txtPermanentAddress.Focus();
                MessageBox.Show("Enter your permanant Address...");
            }
            else
            {
                Counsellor obj = new Counsellor(StudCode, FullName, ContactNumber, AlternateNumber, EmailId, Gender, LocalAddress, PermanentAddress, City, Pin,
                EnquiryDate, RegistrationDate, Graduation, PG, OtherQualification, ProfessionalStatus, References, EnquirySource, CourseInterested, CourseType,
                TimePreferred, PreviousExperience, CompanyName, Designation, Period, DOB, FatherName, MotherName, FatherContactNo, MotherContactNo,
                CollageName, StatusId, ResistrationFees, NumberOfInstallments, PaymentMethod, TransactionId, RaiseDiscount, EnquiryComment, PhotoFile,
                AdharCardFile, PanCardFile, UnderGraduationFile, GraduationFile, PGFile, CenterId, StaffName);
                obj.InsertNewEnquiry();
                int ssc = 0;
                int hsc = 0;
                int diploma = 0;
                string other = null;
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
                if (txtOtherQualification.Text == "")
                {
                    other = null;
                }
                else
                {
                    other = txtOtherQualification.Text;
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
                string staffcode = null;
                int hscyear = 0;
                string hscfile = null;
                int sscyear = 0;
                string sscfile = null;
                int diplomayear = 0;
                string diplomafile = null;
                int gradyear = 0;
                string gradfile = null;
                int pgyear = 0;
                string pgfile = null;
                int otheryear = 0;

                Counsellor objqualification = new Counsellor(StudCode, staffcode, hsc, hscyear, hscfile, ssc, sscyear, sscfile, diploma, diplomayear, diplomafile, gradid, gradyear, gradfile, pggrad, pgyear, pgfile, other, otheryear);
                objqualification.InsertEnqueryQualification();

                MessageBox.Show("Submit Sucessfully");
                this.Close();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
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

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            AdminClass objState = new AdminClass(cid);
            DataTable dtState = new DataTable();
            dtState = objState.FetchState();
            cmbbxState.ValueMember = "StateId";
            cmbbxState.DisplayMember = "StateName";
            cmbbxState.DataSource = dtState;
        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxState.SelectedValue.ToString());
            AdminClass objCity = new AdminClass(cid);
            DataTable dt = new DataTable();
            dt = objCity.FetchCity();
            cmbbxCity.ValueMember = "CityId";
            cmbbxCity.DisplayMember = "CityName";
            cmbbxCity.DataSource = dt;

        }

        private void cmbbxGraduation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
            AdminClass objpg = new AdminClass(cid);
            DataTable dtpg = new DataTable();
            dtpg = objpg.FetchPostGraduation();
            cmbbxPG.ValueMember = "GradId";
            cmbbxPG.DisplayMember = "PGName";
            cmbbxPG.DataSource = dtpg;
        }

        private void chbxHSC_CheckedChanged_1(object sender, EventArgs e)
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

        private void chbxDiploma_CheckedChanged_1(object sender, EventArgs e)
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

        private void cmbbxCourseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCourseType.SelectedValue.ToString());
            AdminClass objCourse = new AdminClass(cid);
            DataTable dtCourse = new DataTable();
            dtCourse = objCourse.FetchCourse();
            cmbbxCourseInterested.ValueMember = "CourseId";
            cmbbxCourseInterested.DisplayMember = "CourseName";
            cmbbxCourseInterested.DataSource = dtCourse;
        }

        private void picbxenquirysrc_Click(object sender, EventArgs e)
        {
            frmAddNewEnquirySource objAddNew = new frmAddNewEnquirySource();
            objAddNew.Show();
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtFirstName.Text) == true || Regex.IsMatch(txtFirstName.Text, Words) == false || txtFirstName.Text.Length >= 115))
            {
                txtFirstName.Focus();
                erpFirstName.SetError(txtFirstName, "Please Enter Valid Name!");
                MessageBox.Show("Enter Staff Name with Alphabetical words and Character Lenght must be from 3 to onwords!");
                erpFirstName.Clear();
            }

        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {

        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtLastName.Text) == true || Regex.IsMatch(txtLastName.Text, Words) == false || txtLastName.Text.Length >= 115))
            {
                txtLastName.Focus();
                erpLastName.SetError(txtLastName, "Please Enter Valid Name!");
                MessageBox.Show("Enter Staff Name with Alphabetical words and Character Lenght must be from 3 to onwords!");
                erpLastName.Clear();
            }

        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactNumber.Text) == true || (Regex.IsMatch(txtContactNumber.Text, Number) == false) || (txtContactNumber.Text.Length <= 9 || txtContactNumber.Text.Length >= 16))
            {
                txtContactNumber.Focus();
                MessageBox.Show("Please Enter valid Contact Number. Range from 10 to 16 Digits");
                erpAlternateNumber.Clear();
            }
            else if (!string.IsNullOrEmpty(txtContactNumber.Text) == true)
            {
                Counsellor objCheckExistingPhone = new Counsellor(txtContactNumber.Text);
                SqlDataReader dr = objCheckExistingPhone.CheckExistingCandidatePhone();
                dr.Read();
                if (dr.HasRows)
                {
                    txtContactNumber.Focus();
                    erpContactNomber.SetError(txtContactNumber, "Phone Number already Exists");
                    MessageBox.Show("Phone Number Already Exists!!");
                    erpContactNomber.Clear();
                }
            }
        }

        private void txtAlternateNumber_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtAlternateNumber.Text) == true || Regex.IsMatch(txtAlternateNumber.Text, Number) == false) || (txtAlternateNumber.Text.Length <= 9 || txtAlternateNumber.Text.Length >= 16))
            {
                txtAlternateNumber.Focus();
                MessageBox.Show("Please Enter valid Contact Number. Range from 10 to 16 Digits");
                erpAlternateNumber.Clear();
            }

        }

        private void txtEmailId_Leave(object sender, EventArgs e)
        {

            Counsellor objCheckExisting = new Counsellor(txtEmailId.Text);
            SqlDataReader dr = objCheckExisting.CheckExistingCandidateEmail();
            dr.Read();
            if (dr.HasRows)
            {
                txtEmailId.Focus();
                erpEmailId.SetError(txtEmailId, "Email Already Exists");
                MessageBox.Show("Email Already Exists!!");
                erpEmailId.Clear();

            }
        }

        private void txtPin_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtPin.Text) == true || Regex.IsMatch(txtPin.Text, Number) == false) || !(txtPin.Text.Length == 6))
            {
                txtPin.Focus();
                MessageBox.Show("Please Enter valid Pin Number. Range from 6 Digits");
                erpPin.Clear();
            }
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
