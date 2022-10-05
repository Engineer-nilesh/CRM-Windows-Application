using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using clsAdmin;
using System.Text.RegularExpressions;

namespace GSTEducationalCRMSoft
{
    public partial class frmCreateNewUser : Form
    {
        string Gender;
        string Number = ("^[0-9]");
        string Words = ("^[a-zA-Z]");
        string EmailPattern = (@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        public frmCreateNewUser()
        {
            InitializeComponent();
        }
        private void frmCreateNewUser_Load(object sender, EventArgs e)
        {
            AdminClass objAdmin = new AdminClass();
            DataTable dt = new DataTable();
            dt = objAdmin.FetchCountry();
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.DataSource = dt;

            AdminClass objAdmin1 = new AdminClass();
            DataTable dt1 = new DataTable();
            dt1 = objAdmin1.FetchGraduation();
            cmbbxGraduation.ValueMember = "GradId";
            cmbbxGraduation.DisplayMember = "GradName";
            cmbbxGraduation.DataSource = dt1;

            AdminClass objAdmin3 = new AdminClass();
            DataTable dt3 = new DataTable();
            dt3 = objAdmin3.FetchReportingPerson();
            cmbbxReportingPerson.ValueMember = "StaffId";
            cmbbxReportingPerson.DisplayMember = "StaffName";
            cmbbxReportingPerson.DataSource = dt3;
            cmbbxReportingPerson.Show();

            AdminClass objAdmin4 = new AdminClass();
            DataTable dt4 = new DataTable();
            dt4 = objAdmin4.FetchStaffPositionIdforadmin();
            cmbbxStaffPossition.ValueMember = "StaffPositionId";
            cmbbxStaffPossition.DisplayMember = "StaffPosition";
            cmbbxStaffPossition.DataSource = dt4;

            AdminClass objAdmin5 = new AdminClass();
            DataTable dt5 = new DataTable();
            dt5 = objAdmin5.FetchCourse();
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.DataSource = dt5;

            AdminClass objAdmin6 = new AdminClass();
            DataTable dt6 = new DataTable();
            dt6 = objAdmin6.FetchCenter();
            cmbbxCenter.ValueMember = "CenterId";
            cmbbxCenter.DisplayMember = "CenterName";
            cmbbxCenter.DataSource = dt6;

            AdminClass objAdmin7 = new AdminClass();
            DataTable dt7 = new DataTable();
            dt7 = objAdmin7.FetchStatus();
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.DataSource = dt7;
        }
        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            AdminClass objAdmin = new AdminClass(cid);
            DataTable dt = new DataTable();
            dt = objAdmin.FetchState();
            cmbbxState.ValueMember = "StateId";
            cmbbxState.DisplayMember = "StateName";
            cmbbxState.DataSource = dt;
        }
        private void combxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Sid = Convert.ToInt32(cmbbxState.SelectedValue.ToString());
            AdminClass objAdmin = new AdminClass(Sid);
            DataTable dt = new DataTable();
            dt = objAdmin.FetchCity();
            combxCity.ValueMember = "CityId";
            combxCity.DisplayMember = "CityName";
            combxCity.DataSource = dt;
        }
        private void cmbbxGraduation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Gid = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
            AdminClass objAdmin = new AdminClass(Gid);
            DataTable dt = new DataTable();
            dt = objAdmin.FetchPostGraduation();
            cmbbxPostGraduation.ValueMember = "PGId";
            cmbbxPostGraduation.DisplayMember = "PGName";
            cmbbxPostGraduation.DataSource = dt;
        }
        private void btnSSCFileUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtbxSSCFile.Text = openFileDialog1.FileName;
                //string file = openFileDialog1.FileName;

                //string[] f = file.Split('\\');  //('\u002C');
                //string fn = f[(f.Length) - 1];
                //string dest = @"D:\OLD LAPTOP\# Doc\" + fn;

                //File.Copy(file, dest, true);
            }
        }
        private void btnHSCFileUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
                txtHSCFile.Text = openFileDialog2.FileName;
        }
      
        private void btnGraduationFileUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog4.ShowDialog();
            if (result == DialogResult.OK)
                txtbxGradFile.Text = openFileDialog4.FileName;
        }
        private void btnPostGradFileUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog5.ShowDialog();
            if (result == DialogResult.OK)
                txtbxPostGradFile.Text = openFileDialog5.FileName;
        }
        private void txtbxStaffFullName_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxStaffFullName.Text) == true || Regex.IsMatch(txtbxStaffFullName.Text, Words) == false) || (txtbxStaffFullName.Text.Length <= 3 || txtbxStaffFullName.Text.Length >= 115))
            {
                txtbxStaffFullName.Focus();
                errorProvider1.SetError(txtbxStaffFullName, "Please Enter Valid Name!");
                MessageBox.Show("Enter Staff Name with Alphabetical words and Character Lenght must be from 3 to onwords!");
                errorProvider1.Clear();
            }
        }
        private void txtbxContact_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxContact.Text) == true || Regex.IsMatch(txtbxContact.Text, Number) == false) || (txtbxContact.Text.Length <= 9 || txtbxContact.Text.Length >= 16))
            {
                txtbxContact.Focus();
                MessageBox.Show("Please Enter valid Contact Number. Range from 10 to 16 Digits");
                errorProvider2.Clear();
            }
        }

        private void txtbxAlternateNo_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxAlternateNo.Text) == true || Regex.IsMatch(txtbxAlternateNo.Text, Number) == false) || (txtbxAlternateNo.Text.Length <= 9 || txtbxAlternateNo.Text.Length >= 16))
            {
                txtbxAlternateNo.Focus();
                MessageBox.Show("Please Enter valid Contact Number. Range from 10 to 16 Digits");
                errorProvider2.Clear();
            }
        }

        private void txtbxEmailID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxEmailID.Text) == true || Regex.IsMatch(txtbxEmailID.Text, EmailPattern) == false)
            {
                txtbxEmailID.Focus();
                errorProvider4.SetError(txtbxEmailID, "Enter Valid Email ID...!");
                MessageBox.Show("Enter Valid Email ID");
                errorProvider4.Clear();
            }
        }

        private void txtbxAdharNo_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxAdharNo.Text) == true || Regex.IsMatch(txtbxAdharNo.Text, Number) == false) || txtbxAdharNo.Text.Length <= 11)
            {
                txtbxAdharNo.Focus();
                MessageBox.Show("Invalid Adhar Number.");
                errorProvider2.Clear();
            }
        }

        private void txtbxPanNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxPanNo.Text) == true || txtbxPanNo.Text.Length <= 9)
            {
                txtbxPanNo.Focus();
                MessageBox.Show("Please Enter Valid Pan Number.");
                errorProvider2.Clear();
            }
        }

        private void txtbxSSCYear_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxSSCYear.Text) == true || Regex.IsMatch(txtbxSSCYear.Text, Number) == false) || txtbxSSCYear.Text.Length <= 3)
            {
                txtbxSSCYear.Focus();
                MessageBox.Show("Please Enter Valid SSC Year.");
                errorProvider2.Clear();
            }
        }

        private void txtbxHSCYear_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxHSCYear.Text) == true || Regex.IsMatch(txtbxHSCYear.Text, Number) == false) || txtbxHSCYear.Text.Length <= 3)
            {
                txtbxHSCYear.Focus();
                MessageBox.Show("Please Enter Valid HSC Year.");
                errorProvider2.Clear();
            }
        }

        private void txtbxGraduationYear_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxGraduationYear.Text) == true || Regex.IsMatch(txtbxGraduationYear.Text, Number) == false) || txtbxGraduationYear.Text.Length <= 3)
            {
                txtbxGraduationYear.Focus();
                MessageBox.Show("Please Enter Valid Graduation Year.");
                errorProvider2.Clear();
            }
        }

        private void txtbxPostGraduationYear_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtbxPostGraduationYear.Text) == true || Regex.IsMatch(txtbxPostGraduationYear.Text, Number) == false) || txtbxPostGraduationYear.Text.Length <= 3)
            {
                txtbxPostGraduationYear.Focus();
                MessageBox.Show("Please Enter Valid Post Graduation Year.");
                errorProvider2.Clear();
            }
        }

        private void txtBankName_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBankName.Text) == true || Regex.IsMatch(txtBankName.Text, Words) == false) || txtBankName.Text.Length <= 3)
            {
                txtBankName.Focus();
                MessageBox.Show("Please Enter Valid Bank Name.");
                errorProvider2.Clear();
            }
        }

        private void txtAccountNo_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtAccountNo.Text) == true || Regex.IsMatch(txtAccountNo.Text, Number) == false) || txtBankName.Text.Length <= 3)
            {
                txtAccountNo.Focus();
                MessageBox.Show("Please Enter Valid Bank Account Number.");
                errorProvider2.Clear();
            }
        }

        private void txtBankBranch_Leave(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBankBranch.Text) == true || Regex.IsMatch(txtBankBranch.Text, Words) == false) || txtBankBranch.Text.Length <= 3)
            {
                txtBankBranch.Focus();
                MessageBox.Show("Please Enter Valid Branch Name.");
                errorProvider2.Clear();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string names=txtbxStaffFullName.Text;
            var name = names.Split(' '); 
            string firstname=name[0];
            string StaffCode = null;
            //string StaffId = null;
            AdminClass obj = new AdminClass();
            SqlDataReader dr = obj.GenStaffCode();
            if (dr.Read())
            {
                string StaffId = dr[0].ToString();
                //   int j = Convert.ToInt32(StaffId.Substring(3));
                int j = Convert.ToInt32(StaffId);
                j = j + 1;
                StaffCode = "RTS" + firstname + j.ToString();
            }
            else
            {
                StaffCode = "RTS" + firstname + 1;
            }

            if (!(rdbbtnFemale.Checked || rdbbtnMale.Checked))
            {
                errorProvider2.SetError(lblGender, "Select Gender");
                MessageBox.Show("Select Gender");
                errorProvider2.Clear();
            }
            else if (txtbxContact.Text == string.Empty)
            {
                txtbxContact.Focus();
                MessageBox.Show("Please Enter Contact Number");
            }
            else if (txtbxAlternateNo.Text == string.Empty)
            {
                txtbxAlternateNo.Focus();
                MessageBox.Show("Please Enter Alternate Contact Number");
            }
            else if (cmbbxCountry.Text == "Select")
            {
                cmbbxCountry.Focus();
                MessageBox.Show("Please Select Your Country...");
            }
            else if (txtbxEmailID.Text == string.Empty)
            {
                txtbxEmailID.Focus();
                MessageBox.Show("Please Enter Email Id");
            }
            else if (txtbxAddess.Text == string.Empty)
            {
                txtbxAddess.Focus();
                MessageBox.Show("Please enter Address...");
            }
            else if (txtbxAdharNo.Text == string.Empty)
            {
                txtbxAdharNo.Focus();
                MessageBox.Show("Please enter Adhar number...");
            }
            else if (txtbxPanNo.Text == string.Empty)
            {
                txtbxPanNo.Focus();
                MessageBox.Show("Enter Pancard Number...");
            }
            else if (cmbbxGraduation.Text == "Select")
            {
                cmbbxGraduation.Focus();
                MessageBox.Show("Please Select Graduation...");
            }
            else if (txtbxSSCYear.Text == string.Empty)
            {
                txtbxSSCYear.Focus();
                MessageBox.Show("Enter SSC Year...");
            }
            else if (txtbxHSCYear.Text == string.Empty)
            {
                txtbxHSCYear.Focus();
                MessageBox.Show("Enter HSC Year...");
            }
            else if (txtbxGraduationYear.Text == string.Empty)
            {
                txtbxGraduationYear.Focus();
                MessageBox.Show("Enter Graduation Year...");
            }
            else if (txtbxPostGraduationYear.Text == string.Empty)
            {
                txtbxPostGraduationYear.Focus();
                MessageBox.Show("Enter Post Graduation Year...");
            }
            else if (txtBankName.Text == string.Empty)
            {
                txtBankName.Focus();
                MessageBox.Show("Enter Bank Name...");
            }
            else if (txtIFSCCode.Text == string.Empty)
            {
                txtIFSCCode.Focus();
                MessageBox.Show("Enter Bank IFSC code...");
            }
            else if (txtAccountNo.Text == string.Empty)
            {
                txtAccountNo.Focus();
                MessageBox.Show("Enter Account Number...");
            }
            else if (txtBankBranch.Text == string.Empty)
            {
                txtBankBranch.Focus();
                MessageBox.Show("Enter Bank Branch...");
            }
            else if (cmbbxReportingPerson.Text == "Select")
            {
                cmbbxReportingPerson.Focus();
                MessageBox.Show("Enter Reporting Person...");
            }
            else if (cmbbxStaffPossition.Text == "Select")
            {
                cmbbxStaffPossition.Focus();
                MessageBox.Show("Enter Staff Position...");
            }
            else if (cmbbxStatus.Text == "Select")
            {
                cmbbxStatus.Focus();
                MessageBox.Show("Please Enter Staff Status ...");
            }
            else if (cmbbxCourse.Text == "Select")
            {
                cmbbxCourse.Focus();
                MessageBox.Show("Please Select Course...");
            }
            else if (txtbxPassword.Text == string.Empty)
            {
                txtbxPassword.Focus();
                MessageBox.Show("Enter User Password...");
            }
            else
            {
                if (rdbbtnMale.Checked == true)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }

                try
                {
                    int CId = Convert.ToInt32(combxCity.SelectedValue.ToString());
                    int GId = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
                    int PId = Convert.ToInt32(cmbbxPostGraduation.SelectedValue.ToString());
                    int RId = Convert.ToInt32(cmbbxReportingPerson.SelectedValue.ToString());
                    int Center = Convert.ToInt32(cmbbxCenter.SelectedValue.ToString());
                    int Staff = Convert.ToInt32(cmbbxStaffPossition.SelectedValue.ToString());
                    int course = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
                    int Status = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());

                    AdminClass objAdmin = new AdminClass(StaffCode, txtbxStaffFullName.Text, txtbxContact.Text, txtbxAlternateNo.Text,
                        txtbxAddess.Text, CId, txtbxAdharNo.Text, txtbxPanNo.Text, txtbxEmailID.Text, Gender, dtDOB.Value, GId, PId,
                        txtBankName.Text, txtIFSCCode.Text, txtAccountNo.Text, txtBankBranch.Text, RId, Center, Staff, course, txtbxPassword.Text,
                        dtStaffJoiningDate.Value, Status);
                    objAdmin.SaveStaff();

                    int SSCYear = Convert.ToInt32(txtbxSSCYear.Text.ToString());
                    int HSCYear = Convert.ToInt32(txtbxHSCYear.Text.ToString());
                    int GradYear = Convert.ToInt32(txtbxGraduationYear.Text.ToString());
                    int PGYear = Convert.ToInt32(txtbxPostGraduationYear.Text.ToString());
                    AdminClass objAdmin1 = new AdminClass(StaffCode, SSCYear, txtbxSSCFile.Text, HSCYear, txtHSCFile.Text, GId, GradYear,
                        txtbxGradFile.Text, PId, PGYear, txtbxPostGradFile.Text);
                    objAdmin1.SaveQualification();

                    MessageBox.Show("Saved Sucessfully!!!...");
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Plaese fill All Data...");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e){}
        private void combxCity_SelectedIndexChanged(object sender, EventArgs e){}
        private void cmbbxReportingPerson_SelectedIndexChanged(object sender, EventArgs e){}
        private void txtbxStaffFullName_TextChanged(object sender, EventArgs e){}
    }
}