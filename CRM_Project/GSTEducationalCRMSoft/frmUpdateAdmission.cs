using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using clsCounsellor;
using System.Text.RegularExpressions;

namespace GSTEducationalCRMSoft
{
    public partial class frmUpdateAdmission : Form
    {
        public string StudCode = null;
        public string Countryname = null;
        public string Statename = null;
        public string Cityname = null;

        public string CourseName = null;
        public string CourseTypeName = null;

        public string GraduationName = null;
        public string PGName = null;

        public frmUpdateAdmission()
        {
            InitializeComponent();
        }
        public frmUpdateAdmission(string studcode)
        {
            StudCode = studcode;
            InitializeComponent();
        }
        public string StudFullName;
        public string gender;
        public string Experience;
        public string CompanyName;
        public string Designation;
        public string Period;
        public string Discount;
        public string Photo;
        public string Aadhar;
        public string Pan;
        public string UnderGrad;
        public string Grad;
        public string PG;
        public int HSC;
        public int SSC;
        public int Diploma;
        public int StatusId;
        public string PreviousExperience;
        public int NoOfInstallments;
        public string PaymentMode;
        public int SSCYear;
        public int HSCYear;
        public int DiplomaYear;
        public int CountryId;
        public int StateId;
        public int CityId;
        public int GradId;
        public int PGId;
        public int CourseTypeId;
        public int CourseId;
        public string dateDOB; 
        public DateTime dateAdmissionDate;
        public DateTime dateEnquiryDate;
        public int GraduationYear;
        public int PGYear;
        public int OtherCourseYear;
        public int RegistrationFees;

        private void frmNewAdmission_Load(object sender, EventArgs e)
        {
            Counsellor objUpdateAdmission = new Counsellor(StudCode);
            SqlDataReader CandidateReader = objUpdateAdmission.GetStudentDetailsForUpdate();
            CandidateReader.Read();
            if (CandidateReader.HasRows)
            {
                string StudFullname = CandidateReader["StudFullName"].ToString();
                String[] fullname = StudFullname.Split(' ');
                if (fullname.Length == 2)
                {
                    txtFirstName.Text = fullname[0].ToString();
                    txtLastName.Text = fullname[1].ToString();
                }
                else if (fullname.Length == 3)
                {
                    txtFirstName.Text = fullname[0].ToString();
                    txtMiddleName.Text = fullname[1].ToString();
                    txtLastName.Text = fullname[2].ToString();
                }
                if (fullname.Length == 3)
                {
                    txtLastName.Text = fullname[2].ToString();
                }
                txtContactNo.Text = CandidateReader["StudContactNo"].ToString();
                txtAlternateNo.Text = CandidateReader["StudAlternateNo"].ToString();
                txtEmail.Text = CandidateReader["StudEmail"].ToString();
                dtDOB.Text = CandidateReader["StudDOB"].ToString();
                if (CandidateReader["StudGender"].ToString() == "Female")
                {
                    rdbtnFemale.Checked = true;
                }
                else
                {
                    rdbtnMale.Checked = true;
                }
                if (Convert.ToInt32(CandidateReader["SSC"]) == 1)
                {
                    chkbxSSC.Checked = true;
                    txtSSCYear.Text = CandidateReader["SSCYear"].ToString();
                }
                if (Convert.ToInt32(CandidateReader["HSC"]) == 1)
                {
                    chkbxHSC.Checked = true;
                    txtHSCYear.Text = CandidateReader["HSCYear"].ToString();
                }
                if (Convert.ToInt32(CandidateReader["Diploma"]) == 1)
                {
                    chkbxDiploma.Checked = true;
                    txtDiplomaYear.Text = CandidateReader["DiplomaYear"].ToString();
                }
                if (CandidateReader["StudGender"].ToString() == "Female")
                {
                    rdbtnFemale.Checked = true;
                }
                else
                {
                    rdbtnMale.Checked = true;
                }
                if (CandidateReader["StudPreviousExperience"].ToString() == "Yes")
                {
                    rdbtnYes.Checked = true;
                }
                else
                {
                    rdbtnNo.Checked = true;
                }
                txtFatherName.Text = CandidateReader["StudFatherName"].ToString();
                txtFatherContact.Text = CandidateReader["StudFatherContactNo"].ToString();
                txtMotherName.Text = CandidateReader["StudMotherName"].ToString();
                txtMotherContact.Text = CandidateReader["StudMotherContactNo"].ToString();
                rtbLocalAddress.Text = CandidateReader["StudLocalAddress"].ToString();
                rtbPermanentAddress.Text = CandidateReader["StudPermanentAddress"].ToString();
                txtPin.Text = CandidateReader["StudPinNo"].ToString();
                dtEnquiryDate.Text = CandidateReader["StudEnquiryDate"].ToString();
                txtOtherQualification.Text = CandidateReader["StudOtherQualification"].ToString();
                //Qualification Year
                txtSSCYear.Text = CandidateReader["SSCYear"].ToString();
                txtHSCYear.Text = CandidateReader["HSCYear"].ToString();
                txtDiplomaYear.Text = CandidateReader["DiplomaYear"].ToString();
                txtGraduationYear.Text = CandidateReader["GradYear"].ToString();
                txtPGYear.Text = CandidateReader["PGYear"].ToString();
                txtOtherCourseYear.Text = CandidateReader["OtherCourseYear"].ToString();
                //LocationFetch
                CityId = Convert.ToInt32(CandidateReader["StudCityId"].ToString());
                //CourseFetch
                CourseId = Convert.ToInt32(CandidateReader["CourseId"].ToString());
                //QualificationFetch
                GradId = Convert.ToInt32(CandidateReader["GradId"].ToString());

                txtCollegeName.Text = CandidateReader["StudCollageName"].ToString();
                txtCompanyName.Text = CandidateReader["StudCompanyName"].ToString();
                txtDesignation.Text = CandidateReader["StudDesignation"].ToString();
                txtPeriod.Text = CandidateReader["StudPeriod"].ToString();
                photoFile.Text = CandidateReader["StudPhotoFile"].ToString();
                txtRegistrationFee.Text = CandidateReader["StudRegistrationFees"].ToString();
                cmbbxInstallments.Text = CandidateReader["StudNumberOfInstallments"].ToString();
                cmbbxPaymentMode.Text = CandidateReader["StudPaymentMethod"].ToString();
                txtTransactionId.Text = CandidateReader["StudTransactionId"].ToString();
            }
            CandidateReader.Close();
            Counsellor objLocation = new Counsellor(StudCode, CityId);
            SqlDataReader LocationReader = objLocation.FetchLocation();
            LocationReader.Read();
            if (LocationReader.HasRows)
            {
                //Location fetch
                StateId = Convert.ToInt32(LocationReader["StateId"].ToString());
                CountryId = Convert.ToInt32(LocationReader["CountryId"].ToString());
                Countryname = LocationReader["CountryName"].ToString();
                Statename = LocationReader["StateName"].ToString();
                Cityname = LocationReader["CityName"].ToString();

                Counsellor objCountry = new Counsellor();
                DataTable dtCountry = new DataTable();
                dtCountry = objCountry.GetCountry();
                //cmbbxCountry.Text = Countryname;
                cmbbxCountry.ValueMember = "CountryId";
                cmbbxCountry.DisplayMember = "CountryName";
                cmbbxCountry.DataSource = dtCountry;
                cmbbxCountry.Text = Countryname;
                cmbbxState.Text = Statename;
                cmbbxCity.Text = Cityname;
                //cmbbxState.Text = LocationReader["StateName"].ToString();
                //cmbbxCity.Text = LocationReader["CityName"].ToString();
                //cmbbxCountry.SelectedValue = LocationReader["CountryId"]
            }
            LocationReader.Close();
            Counsellor Course = new Counsellor(StudCode, CourseId);
            SqlDataReader CourseReader = Course.FetchCourse();
            CourseReader.Read();
            if (CourseReader.HasRows)
            {
                CourseTypeId = Convert.ToInt32(CourseReader["CourseTypeId"].ToString());
                CourseTypeName = CourseReader["CourseTypeName"].ToString();
                CourseName = CourseReader["CourseName"].ToString();

                Counsellor objCourseType = new Counsellor();
                DataTable dtCourseType = new DataTable();
                dtCourseType = objCourseType.GetCourseType();

                cmbbxCourseType.ValueMember = "CourseTypeId";
                cmbbxCourseType.DisplayMember = "CourseTypeName";
                cmbbxCourseType.DataSource = dtCourseType;
                cmbbxCourseType.Text = CourseTypeName;
                cmbbxCourseEnroll.Text = CourseName;
            }
            CourseReader.Close(); 
            Counsellor Qualification = new Counsellor(StudCode, GradId);
            SqlDataReader QualificationReader = Qualification.FetchQualification();
            QualificationReader.Read();
            if (QualificationReader.HasRows)
            {
                GradId = Convert.ToInt32(QualificationReader["GradId"].ToString());
                GraduationName = QualificationReader["GradName"].ToString();
                PGName = QualificationReader["PGName"].ToString();

                Counsellor objGraduation = new Counsellor();
                DataTable dtGraduation = new DataTable();
                dtGraduation = objGraduation.GetGraduation();

                cmbbxGraduation.ValueMember = "GradId";
                cmbbxGraduation.DisplayMember = "GradName";
                cmbbxGraduation.DataSource = dtGraduation;
                cmbbxGraduation.Text = GraduationName;
                cmbbxPG.Text = PGName;
            }
            QualificationReader.Close();
            pnlAdmission.Location = new Point(
            this.ClientSize.Width / 2 - pnlAdmission.Size.Width / 2,
            this.ClientSize.Height / 2 - pnlAdmission.Size.Height / 2);
            pnlAdmission.Anchor = AnchorStyles.None;
            Discount = "No";

        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            Counsellor obj = new Counsellor(id);
            DataTable dt = new DataTable();
            dt = obj.GetState();

            cmbbxState.ValueMember = "StateId";
            cmbbxState.DisplayMember = "StateName";
            cmbbxState.DataSource = dt;
        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbbxState.SelectedValue.ToString());
            Counsellor obj = new Counsellor(id);
            DataTable dt = new DataTable();
            dt = obj.GetCity();

            cmbbxCity.ValueMember = "CityId";
            cmbbxCity.DisplayMember = "CityName";
            cmbbxCity.DataSource = dt;
        }

        private void cmbbxGraduation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
            Counsellor obj = new Counsellor(id);
            DataTable dt = new DataTable();
            dt = obj.GetPG();

            cmbbxPG.ValueMember = "PGId";
            cmbbxPG.DisplayMember = "PGName";
            cmbbxPG.DataSource = dt;
        }

        private void cmbbxCourseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbbxCourseType.SelectedValue.ToString());
            Counsellor obj = new Counsellor(id);
            DataTable dt = new DataTable();
            dt = obj.GetCourseId();

            cmbbxCourseEnroll.ValueMember = "CourseId";
            cmbbxCourseEnroll.DisplayMember = "CourseName";
            cmbbxCourseEnroll.DataSource = dt;

        }

        private void cmbbxCourseEnroll_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbbxCourseEnroll.SelectedValue.ToString());
            Counsellor objCourseFees = new Counsellor(id);
            SqlDataReader dr;

            dr = objCourseFees.GetCourseFees();
            while (dr.Read())
            {
                txtCourseFee.Text = dr["CourseFees"].ToString();
            }
            dr.Close();

        }


        private void rdbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            PreviousExperience = "Yes";
            txtCompanyName.Enabled = true;
            txtDesignation.Enabled = true;
            txtPeriod.Enabled = true;
            Experience = "Yes";
        }

        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            PreviousExperience = "No";
            txtCompanyName.Enabled = false;
            txtDesignation.Enabled = false;
            txtPeriod.Enabled = false;
            Experience = "No";
            CompanyName = "Null";
            Designation = "Null";
            Period = "Null";
        }

        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void chkRaiseDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if(chkRaiseDiscount.Checked == true)
            {
                Discount = "Yes";
            }
            else
            {
                Discount = "No";
            }
        }
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Photo = openFileDialog1.FileName;
                photoFile.Text = openFileDialog1.SafeFileName;
            }
        }

        private void btnAadhar_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                Aadhar = openFileDialog2.FileName;
                AadharFile.Text = openFileDialog2.SafeFileName;
            }
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog3.ShowDialog();
            if (result == DialogResult.OK)
            {
                Pan = openFileDialog3.FileName;
                PanFile.Text = openFileDialog3.SafeFileName;
            }
        }

        private void btnUnderGrad_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog4.ShowDialog();
            if (result == DialogResult.OK)
            {
                UnderGrad = openFileDialog4.FileName;
                UnderGradFile.Text = openFileDialog4.SafeFileName;
            }
        }

        private void btnGrad_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog5.ShowDialog();
            if (result == DialogResult.OK)
            {
                Grad = openFileDialog5.FileName;
                GradFile.Text = openFileDialog5.SafeFileName;
            }
        }

        private void btnPG_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog6.ShowDialog();
            if (result == DialogResult.OK)
            {
                PG = openFileDialog6.FileName;
                PGFile.Text = openFileDialog6.SafeFileName;
            }
        }

        //private void btnRegister_Click(object sender, EventArgs e)
        //{
        //    Counsellor objStudCode = new Counsellor();
        //    SqlDataReader dr = objStudCode.GenStudCode();
        //    if (dr.Read())
        //    {
        //        string StudId = dr[0].ToString();
        //        int i = Convert.ToInt32(StudId);
        //        i += 1;
        //        StudCode = "RTS" + txtFirstName.Text + i.ToString();
        //    }
        //    else
        //    {
        //        StudCode = "RTS" + txtFirstName.Text + 1;
        //    }

        //    StudFullName = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;

        //    CityId = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());
        //    GradId = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
        //    PGId = Convert.ToInt32(cmbbxPG.SelectedValue.ToString());
        //    CourseId = Convert.ToInt32(cmbbxCourseEnroll.SelectedValue.ToString());
        //    CourseTypeId = Convert.ToInt32(cmbbxCourseType.SelectedValue.ToString());
        //    CompanyName = txtCompanyName.Text;
        //    Designation = txtDesignation.Text;
        //    Period = txtPeriod.Text;
        //    dateDOB = dtDOB.Value.ToString("yyyy-MM-dd");
        //    dateAdmissionDate = dtAdmissionDate.Value.ToString("yyyy-MM-dd");
        //    dateEnquiryDate = dtEnquiryDate.Value.ToString("yyyy-MM-dd");
        //    StatusId = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());
        //    NoOfInstallments = Convert.ToInt32(cmbbxInstallments.SelectedItem.ToString());
        //    if(txtSSCYear.Text == "")
        //    {
        //        SSCYear = 0;
        //    }else
        //    {
        //        SSCYear = Convert.ToInt32(txtSSCYear.Text);
        //    }
        //    if (txtHSCYear.Text == "")
        //    {
        //        HSCYear = 0;
        //    }
        //    else
        //    {
        //        HSCYear = Convert.ToInt32(txtHSCYear.Text);
        //    }
        //    if (txtDiplomaYear.Text == "")
        //    {
        //        DiplomaYear = 0;
        //    }
        //    else
        //    {
        //        DiplomaYear = Convert.ToInt32(txtGraduationYear.Text);
        //    }
        //    if (txtDiplomaYear.Text == "")
        //    {
        //        GraduationYear = 0;
        //    }
        //    else
        //    {
        //        GraduationYear = Convert.ToInt32(txtGraduationYear.Text);
        //    }
        //    if (txtDiplomaYear.Text == "")
        //    {
        //        PGYear = 0;
        //    }
        //    else
        //    {
        //        PGYear = Convert.ToInt32(txtPGYear.Text);
        //    }
        //    if (txtDiplomaYear.Text == "")
        //    {
        //        OtherCourseYear = 0;
        //    }
        //    else
        //    {
        //        OtherCourseYear = Convert.ToInt32(txtOtherCourseYear.Text);
        //    }
        //    RegistrationFees = Convert.ToInt32(txtRegistrationFee.Text);
        //    PaymentMode = cmbbxPaymentMode.SelectedItem.ToString();


        //    Counsellor objaddcandidate = new Counsellor(StudCode,
        //        StudFullName,
        //        txtContactNo.Text,
        //        txtAlternateNo.Text,
        //        txtEmail.Text,
        //        dateDOB,
        //        gender,
        //        txtFatherName.Text,
        //        txtFatherContact.Text,
        //        txtMotherName.Text,
        //        txtMotherContact.Text,
        //        txtLocalAddress.Text,
        //        txtPermanentAddress.Text,
        //        CityId,
        //        txtPin.Text,
        //        dateEnquiryDate,
        //        dateAdmissionDate,
        //        SSC,
        //        SSCYear,
        //        HSC,
        //        HSCYear,
        //        Diploma,
        //        DiplomaYear,
        //        GradId,
        //        GraduationYear,
        //        PGId,
        //        PGYear,
        //        txtOtherQualification.Text,
        //        OtherCourseYear,
        //        txtCollegeName.Text,
        //        CourseTypeId,
        //        CourseId,
        //        StatusId,
        //        PreviousExperience,
        //        CompanyName,
        //        Designation,
        //        Period,
        //        Photo,
        //        Aadhar,
        //        Pan,
        //        UnderGrad,
        //        Grad,
        //        PG,
        //        RegistrationFees,
        //        NoOfInstallments,
        //        PaymentMode,
        //        txtTransactionId.Text,
        //        Discount
        //        );
        //    objaddcandidate.InsertCandidate();
        //    objaddcandidate.InsertQualification();
        //    MessageBox.Show("Student Added!!!");
        //}

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Regex validateEmailRegex = new Regex("([a-zA-Z0-9]+)([\\.{1}])?([a-zA-Z0-9]+)\\@gmail([\\.])com");

            if (string.IsNullOrEmpty(txtFirstName.Text) == true)
            {
                txtFirstName.Focus();
                erPFirstName.SetError(txtFirstName, "FirstName should not be empty");
                MessageBox.Show("FirstName should not be empty");
                erPFirstName.Clear();
            }

            else if (string.IsNullOrEmpty(txtLastName.Text) == true)
            {
                txtLastName.Focus();
                erPLastName.SetError(txtLastName, "LastName should not be empty");
                MessageBox.Show("LastName should not be empty");
                erPLastName.Clear();
            }

            else if (string.IsNullOrEmpty(txtContactNo.Text) == true)
            {
                txtContactNo.Focus();
                erPContactNo.SetError(txtContactNo, "Contact Number should not be empty");
                MessageBox.Show("Contact Number should not be empty");
                erPContactNo.Clear();
            }

            else if (string.IsNullOrEmpty(txtAlternateNo.Text) == true)
            {
                txtAlternateNo.Focus();
                erPAlternateNo.SetError(txtAlternateNo, "Alternate Number should not be empty");
                MessageBox.Show("Alternate Number should not be empty");
                erPAlternateNo.Clear();
            }


            else if (!validateEmailRegex.IsMatch(txtEmail.Text))
            {
                txtEmail.Focus();
                erPEmail.SetError(txtEmail, "Email should be in proper format and should not be empty");
                MessageBox.Show("Email should be in proper format and should not be empty");
                erPEmail.Clear();
            }

            else if (string.IsNullOrEmpty(txtFatherName.Text) == true)
            {
                txtFatherName.Focus();
                erPFatherName.SetError(txtFatherName, "Father's Name should not be empty");
                MessageBox.Show("Father's Name should not be empty");
                erPFatherName.Clear();
            }

            else if (string.IsNullOrEmpty(txtFatherContact.Text) == true)
            {
                txtFatherContact.Focus();
                erPFatherContact.SetError(txtFatherContact, "Father's Contact should not be empty");
                MessageBox.Show("Father's Name should not be empty");
                erPFatherContact.Clear();
            }

            else if (string.IsNullOrEmpty(txtMotherName.Text) == true)
            {
                txtMotherName.Focus();
                erPMotherName.SetError(txtMotherName, "Mother's Name should not be empty");
                MessageBox.Show("Mother's Name should not be empty");
                erPMotherName.Clear();
            }

            else if (string.IsNullOrEmpty(txtMotherContact.Text) == true)
            {
                txtMotherContact.Focus();
                erPMotherContact.SetError(txtMotherContact, "Mother's Contact should not be empty");
                MessageBox.Show("Mother's Name should not be empty");
                erPMotherContact.Clear();
            }

            else if (string.IsNullOrEmpty(rtbLocalAddress.Text) == true)
            {
                rtbLocalAddress.Focus();
                erPLocalAddress.SetError(rtbLocalAddress, "Local Address should not be empty");
                MessageBox.Show("Local Address should not be empty");
                erPLocalAddress.Clear();
            }

            else if (string.IsNullOrEmpty(rtbPermanentAddress.Text) == true)
            {
                rtbPermanentAddress.Focus();
                erPPermanentAddress.SetError(rtbPermanentAddress, "Permanent Address should not be empty");
                MessageBox.Show("Permanent Address should not be empty");
                erPPermanentAddress.Clear();
            }

            else if (string.IsNullOrEmpty(txtPin.Text) == true)
            {
                txtPin.Focus();
                erPPin.SetError(txtPin, "Pincode should not be empty");
                MessageBox.Show("Pincode should not be empty");
                erPPin.Clear();
            }

            else if (string.IsNullOrEmpty(txtCollegeName.Text) == true)
            {
                txtCollegeName.Focus();
                erPCollegeName.SetError(txtCollegeName, "College Name should not be empty");
                MessageBox.Show("College Name should not be empty");
                erPCollegeName.Clear();
            }

            else if (string.IsNullOrEmpty(photoFile.Text) == true)
            {
                photoFile.Focus();
                erPPhotoFile.SetError(photoFile, "Please Upload Photo");
                MessageBox.Show("Please Upload Photo");
                erPPhotoFile.Clear();
            }

            else if (string.IsNullOrEmpty(txtRegistrationFee.Text) == true)
            {
                txtRegistrationFee.Focus();
                erPRegistrationFees.SetError(txtRegistrationFee, "Registration Fees should not be empty");
                MessageBox.Show("Registration Fees should not be empty");
                erPRegistrationFees.Clear();
            }

            else if (string.IsNullOrEmpty(cmbbxInstallments.Text) == true)
            {
                cmbbxInstallments.Focus();
                erPInstallments.SetError(cmbbxInstallments, "Installments should not be empty");
                MessageBox.Show("Installments should not be empty");
                erPInstallments.Clear();
            }

            else if (string.IsNullOrEmpty(cmbbxPaymentMode.Text) == true)
            {
                cmbbxPaymentMode.Focus();
                erPPaymentMode.SetError(cmbbxPaymentMode, "Payment mode should not be empty");
                MessageBox.Show("Payment Mode should not be empty");
                erPPaymentMode.Clear();
            }

            else if (string.IsNullOrEmpty(txtTransactionId.Text) == true)
            {
                txtTransactionId.Focus();
                erPTransactionId.SetError(txtTransactionId, "TransactionId should not be empty");
                MessageBox.Show("TransactionId should not be empty");
                erPTransactionId.Clear();
            }
            else
            {
                try
                {
                    StudFullName = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;

                    CityId = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());
                    GradId = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
                    PGId = Convert.ToInt32(cmbbxPG.SelectedValue.ToString());
                    CourseId = Convert.ToInt32(cmbbxCourseEnroll.SelectedValue.ToString());
                    CourseTypeId = Convert.ToInt32(cmbbxCourseType.SelectedValue.ToString());
                    CompanyName = txtCompanyName.Text;
                    Designation = txtDesignation.Text;
                    Period = txtPeriod.Text;
                    dateDOB = dtDOB.Value.ToString("yyyy-MM-dd");
                    dateAdmissionDate = dtAdmissionDate.Value;
                    dateEnquiryDate = dtEnquiryDate.Value;
                    NoOfInstallments = Convert.ToInt32(cmbbxInstallments.SelectedItem.ToString());
                    if (txtSSCYear.Text == "")
                    {
                        HSCYear = 0;
                    }
                    else
                    {
                        HSCYear = Convert.ToInt32(txtHSCYear.Text);
                    }
                    if (txtHSCYear.Text == "")
                    {
                        SSCYear = 0;
                    }
                    else
                    {
                        SSCYear = Convert.ToInt32(txtSSCYear.Text);
                    }
                    if (txtDiplomaYear.Text == "")
                    {
                        DiplomaYear = 0;
                    }
                    else
                    {
                        DiplomaYear = Convert.ToInt32(txtGraduationYear.Text);
                    }
                    if (txtGraduationYear.Text == "")
                    {
                        GraduationYear = 0;
                    }
                    else
                    {
                        GraduationYear = Convert.ToInt32(txtGraduationYear.Text);
                    }
                    if (txtPGYear.Text == "")
                    {
                        PGYear = 0;
                    }
                    else
                    {
                        PGYear = Convert.ToInt32(txtPGYear.Text);
                    }
                    if (txtOtherCourseYear.Text == "")
                    {
                        OtherCourseYear = 0;
                    }
                    else
                    {
                        OtherCourseYear = Convert.ToInt32(txtOtherCourseYear.Text);
                    }
                    RegistrationFees = Convert.ToInt32(txtRegistrationFee.Text);
                    PaymentMode = cmbbxPaymentMode.SelectedItem.ToString();
                    StatusId = 5;

                    Counsellor objUpdatecandidate = new Counsellor(StudCode,
                        StudFullName,
                        txtContactNo.Text,
                        txtAlternateNo.Text,
                        txtEmail.Text,
                        dateDOB,
                        gender,
                        txtFatherName.Text,
                        txtFatherContact.Text,
                        txtMotherName.Text,
                        txtMotherContact.Text,
                        rtbLocalAddress.Text,
                        rtbPermanentAddress.Text,
                        CityId,
                        txtPin.Text,
                        dateEnquiryDate,
                        dateAdmissionDate,
                        SSC,
                        SSCYear,
                        HSC,
                        HSCYear,
                        Diploma,
                        DiplomaYear,
                        GradId,
                        GraduationYear,
                        PGId,
                        PGYear,
                        txtOtherQualification.Text,
                        OtherCourseYear,
                        txtCollegeName.Text,
                        CourseTypeId,
                        CourseId,
                        StatusId,
                        PreviousExperience,
                        CompanyName,
                        Designation,
                        Period,
                        Photo,
                        Aadhar,
                        Pan,
                        UnderGrad,
                        Grad,
                        PG,
                        RegistrationFees,
                        NoOfInstallments,
                        PaymentMode,
                        txtTransactionId.Text,
                        Discount
                        );
                    objUpdatecandidate.UpdateCandidate();
                    objUpdatecandidate.UpdateQualification();
                    MessageBox.Show("Student Updated!!!");
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Fill All Required Data!!!");
                }
            }

            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbxSSC_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxSSC.Checked == true)
            {
                if (chkbxSSC.Checked == true)
                {
                    HSC = 1;
                    txtSSCYear.Enabled = true;
                }
                else
                {
                    SSC = 0;
                    txtSSCYear.Enabled = false;
                }
            }
        }

        private void chkbxHSC_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbxHSC.Checked == true)
            {
                HSC = 1;
                txtHSCYear.Enabled = true;
            }
            else
            {
                SSC = 0;
                txtHSCYear.Enabled = false;
            }
        }

        private void chkbxDiploma_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbxDiploma.Checked == true)
            {
                Diploma = 1;
                txtDiplomaYear.Enabled = true;
            }
            else
            {
                SSC = 0;
                txtDiplomaYear.Enabled = false;
            }

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$"))
            {
                txtFirstName.Focus();
                erPFirstName.SetError(txtFirstName, "First Name can only contain Alphabets");
                MessageBox.Show("First Name can only contain Alphabets");
                erPFirstName.Clear();
            }
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtMiddleName.Text, @"^[a-zA-Z]+$"))
            {
                txtMiddleName.Focus();
                erpMiddleName.SetError(txtMiddleName, "Middle Name can only contain Alphabets");
                MessageBox.Show("Middle Name can only contain Alphabets");
                erpMiddleName.Clear();
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$"))
            {
                txtLastName.Focus();
                erPLastName.SetError(txtLastName, "Last Name can only contain Alphabets");
                MessageBox.Show("Last Name can only contain Alphabets");
                erPLastName.Clear();
            }
        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtFatherName.Text, @"^[a-zA-Z ]+$"))
            {
                txtFatherName.Focus();
                erPFatherName.SetError(txtFatherName, "Father's Name can only contain Alphabets");
                MessageBox.Show("Father's Name can only contain Alphabets");
                erPFatherName.Clear();
            }
        }

        private void txtMotherName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtMotherName.Text, @"^[a-zA-Z ]+$"))
            {
                txtMotherName.Focus();
                erPMotherName.SetError(txtMotherName, "Mother's Name can only contain Alphabets");
                MessageBox.Show("Mother's Name can only contain Alphabets");
                erPMotherName.Clear();
            }
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPin.Text, @"^[0-9]+$"))
            {
                txtPin.Focus();
                erPPin.SetError(txtPin, "Pin can only contain numbers!!");
                MessageBox.Show("Pin can only contain numbers!!");
                erPPin.Clear();
            }
        }

        private void txtSSCYear_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSSCYear.Text, @"^[0-9]+$") || txtSSCYear.Text.Length > 4)
            {
                txtSSCYear.Focus();
                erPSSCYear.SetError(txtSSCYear, "Invalid SSC Year");
                MessageBox.Show("Invalid SSC Year");
                erPSSCYear.Clear();
            }
        }

        private void txtHSCYear_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtHSCYear.Text, @"^[0-9]+$") || txtHSCYear.Text.Length > 4)
            {
                txtHSCYear.Focus();
                erPHSCYear.SetError(txtHSCYear, "Invalid HSC Year");
                MessageBox.Show("Invalid HSC Year");
                erPHSCYear.Clear();
            }
        }

        private void txtOtherCourseYear_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtOtherCourseYear.Text, @"^[0-9]+$") || txtOtherCourseYear.Text.Length > 4)
            {
                txtOtherCourseYear.Focus();
                erPOtherYear.SetError(txtOtherCourseYear, "Invalid Other Course Year");
                MessageBox.Show("Invalid Other Course Year");
                erPOtherYear.Clear();
            }
        }

        private void txtGraduationYear_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtGraduationYear.Text, @"^[0-9]+$") || txtGraduationYear.Text.Length > 4)
            {
                txtGraduationYear.Focus();
                erPGradYear.SetError(txtGraduationYear, "Invalid Graduation Year");
                MessageBox.Show("Invalid Graduation Year");
                erPGradYear.Clear();
            }
        }

        private void txtPGYear_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPGYear.Text, @"^[0-9]+$") || txtPGYear.Text.Length > 4)
            {
                txtPGYear.Focus();
                erPPGYear.SetError(txtPGYear, "Invalid PG Year");
                MessageBox.Show("Invalid PG Year");
                erPPGYear.Clear();
            }
        }

        private void txtRegistrationFee_TextChanged(object sender, EventArgs e)
        {
            //if (!Regex.IsMatch(txtRegistrationFee.Text, @"^[0-9]+$"))
            //{
            //    txtRegistrationFee.Focus();
            //    erPRegistrationFees.SetError(txtRegistrationFee, "Please Enter Valid Fee Amount");
            //    MessageBox.Show("Please Enter Valid Fee Amount");
            //    erPRegistrationFees.Clear();
            //}
            //else if (Convert.ToInt32(txtRegistrationFee.Text) > Convert.ToInt32(txtCourseFee.Text))
            //{
            //    txtRegistrationFee.Focus();
            //    erPRegistrationFees.SetError(txtRegistrationFee, "Registration Amount cannot be more that CourseFees");
            //    MessageBox.Show("Registration Amount cannot be more that CourseFees");
            //    erPRegistrationFees.Clear();
            //}
        }

        private void txtDiplomaYear_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtDiplomaYear.Text, @"^[0-9]+$") || txtDiplomaYear.Text.Length > 4)
            {
                txtDiplomaYear.Focus();
                erPDiplomaYear.SetError(txtDiplomaYear, "Invalid Diploma Year");
                MessageBox.Show("Invalid Diploma Year");
                erPDiplomaYear.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Counsellor objCheckExisting = new Counsellor(StudCode, txtEmail.Text);
            SqlDataReader dr = objCheckExisting.CheckExistingCandidate();
            dr.Read();
            if (dr.HasRows)
            {
                txtEmail.Focus();
                erpEmailFormat.SetError(txtEmail, "Email Already Exists");
                MessageBox.Show("Email already Exists!!");
                erpEmailFormat.Clear();
            }
        }

        private void txtPGYear_Leave(object sender, EventArgs e)
        {
            if (txtPGYear.Text.Length != 4)
            {
                MessageBox.Show("Invalid PG Year");
            }
        }

        private void txtOtherCourseYear_Leave(object sender, EventArgs e)
        {
            if (txtOtherCourseYear.Text.Length != 4)
            {
                MessageBox.Show("Invalid Other Course Year");
            }
        }

        private void txtDiplomaYear_Leave(object sender, EventArgs e)
        {
            if (txtDiplomaYear.Text.Length != 4)
            {
                MessageBox.Show("Invalid Diploma Year");
            }
        }

        private void txtGraduationYear_Leave(object sender, EventArgs e)
        {
            if (txtGraduationYear.Text.Length != 4)
            {
                MessageBox.Show("Invalid Graduation Year");
            }
        }

        private void txtSSCYear_Leave(object sender, EventArgs e)
        {
            if (txtSSCYear.Text.Length != 4)
            {
                txtSSCYear.Focus();
                erPSSCYear.SetError(txtSSCYear, "Invalid SSC Year");
                MessageBox.Show("Invalid SSC Year");
                erPSSCYear.Clear();
            }
        }

        private void txtHSCYear_Leave(object sender, EventArgs e)
        {
            if (txtHSCYear.Text.Length != 4)
            {
                txtHSCYear.Focus();
                erPHSCYear.SetError(txtHSCYear, "Invalid HSC Year");
                MessageBox.Show("Invalid HSC Year");
                erPHSCYear.Clear();
            }
        }

        private void txtContactNo_Leave(object sender, EventArgs e)
        {
            Counsellor objCheckExisting = new Counsellor(StudCode, txtContactNo.Text);
            SqlDataReader dr = objCheckExisting.CheckExistingPhone();
            dr.Read();
            if (dr.HasRows)
            {
                txtContactNo.Focus();
                erPContactNo.SetError(txtContactNo, "Contact Number Already Exists");
                MessageBox.Show("Contact Number Already Exists");
                erPContactNo.Clear();
            }
        }
    }
}
