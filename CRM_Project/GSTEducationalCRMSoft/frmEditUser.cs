using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsAdmin;
using System.Data.SqlClient;
using clsCounsellor;
namespace GSTEducationalCRMSoft
{
    public partial class frmEditUser : Form
    {
        string Gender;
        public string StaffPosition;
        private Action<object> loadForm;

        public string StaffCde { get; set; }
        public frmEditUser()
        {
            InitializeComponent();
        }
        public frmEditUser(string Code, string staffc)
        {
            InitializeComponent();
            StaffCde = Code;
            StaffPosition = staffc;
        }

        public frmEditUser(string Code, string staffc, Action<object> loadForm) : this(Code, staffc)
        {
            this.loadForm = loadForm;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
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

            AdminClass objAdmin2 = new AdminClass();
            DataTable dt2 = new DataTable();
            dt2 = objAdmin2.FetchPostGraduation();
            cmbbxPostGraduation.ValueMember = "PGId";
            cmbbxPostGraduation.DisplayMember = "PGName";
            cmbbxPostGraduation.DataSource = dt2;

            if (StaffPosition == "2")
            {
                AdminClass objAdmin3 = new AdminClass(StaffCde);
                SqlDataReader dr;
                dr = objAdmin3.GetStaff();
                while (dr.Read())
                {
                    txtbxStaffFullName.Text = dr["StaffName"].ToString();
                    txtbxContact.Text = dr["StaffContact"].ToString();
                    txtbxEmailID.Text = dr["StaffEmail"].ToString();
                    txtbxAddess.Text = dr["StaffAddress"].ToString();
                    if (dr["StaffGender"].ToString() == "Female")
                    {
                        rdbbtnFemale.Checked = true;
                    }
                    else
                    {
                        rdbbtnMale.Checked = true;
                    }
                    txtbxPanNo.Text = dr["StaffPan"].ToString();
                    txtBankName.Text = dr["StaffBank"].ToString();
                    txtbxAdharNo.Text = dr["StaffAdhar"].ToString();
                    txtAccountNo.Text = dr["StaffAccount"].ToString();
                    txtIFSCCode.Text = dr["StaffIFSC"].ToString();
                    txtBankAddress.Text = dr["StaffBranch"].ToString();
                }
                dr.Close();
                AdminClass adminClass = new AdminClass(StaffCde);
                SqlDataReader dr1;
                dr1 = adminClass.GetQualification();
                while (dr1.Read())
                {
                    txtbxSSCYear.Text = dr1["SSCYear"].ToString();
                    txtbxSSCFile.Text = dr1["SSCFile"].ToString();
                    txtbxHSCYear.Text = dr1["HSCYear"].ToString();
                    txtHSCFile.Text = dr1["HSCFile"].ToString();
                    txtbxGraduationYear.Text = dr1["GradYear"].ToString();
                    txtbxGradFile.Text = dr1["GraduationFile"].ToString();
                    txtbxPostGraduationYear.Text = dr1["PGYear"].ToString();
                    txtbxPostGradFile.Text = dr1["PGFile"].ToString();
                }
                dr1.Close();
            }
            else if (StaffPosition == "3")
            {
                AdminClass objAdmin3 = new AdminClass(StaffCde);
                SqlDataReader dr;
                dr = objAdmin3.GetStaff();
                while (dr.Read())
                {
                    txtbxStaffFullName.Text = dr["StaffName"].ToString();
                    txtbxContact.Text = dr["StaffContact"].ToString();
                    txtbxEmailID.Text = dr["StaffEmail"].ToString();
                    txtbxAddess.Text = dr["StaffAddress"].ToString();
                    if (dr["StaffGender"].ToString() == "Female")
                    {
                        rdbbtnFemale.Checked = true;
                    }
                    else
                    {
                        rdbbtnMale.Checked = true;
                    }
                    txtbxPanNo.Text = dr["StaffPan"].ToString();
                    txtBankName.Text = dr["StaffBank"].ToString();
                    txtbxAdharNo.Text = dr["StaffAdhar"].ToString();
                    txtAccountNo.Text = dr["StaffAccount"].ToString();
                    txtIFSCCode.Text = dr["StaffIFSC"].ToString();
                    txtBankAddress.Text = dr["StaffBranch"].ToString();
                    
                }
                dr.Close();
                AdminClass adminClass = new AdminClass(StaffCde);
                SqlDataReader dr1;
                dr1 = adminClass.GetQualification();
                while (dr1.Read())
                {
                    txtbxSSCYear.Text = dr1["SSCYear"].ToString();
                    txtbxSSCFile.Text = dr1["SSCFile"].ToString();
                    txtbxHSCYear.Text = dr1["HSCYear"].ToString();
                    txtHSCFile.Text = dr1["HSCFile"].ToString();
                    txtbxGraduationYear.Text = dr1["GradYear"].ToString();
                    txtbxGradFile.Text = dr1["GraduationFile"].ToString();
                    txtbxPostGraduationYear.Text = dr1["PGYear"].ToString();
                    txtbxPostGradFile.Text = dr1["PGFile"].ToString();
                }
                dr1.Close();
            }

            else if (StaffPosition == "5")
            {
                AdminClass objAdmin3 = new AdminClass(StaffCde);
                SqlDataReader dr;
                dr = objAdmin3.GetStaff();
                while (dr.Read())
                {
                    txtbxStaffFullName.Text = dr["StaffName"].ToString();
                    txtbxContact.Text = dr["StaffContact"].ToString();
                    txtbxEmailID.Text = dr["StaffEmail"].ToString();
                    txtbxAddess.Text = dr["StaffAddress"].ToString();
                    if (dr["StaffGender"].ToString() == "Female")
                    {
                        rdbbtnFemale.Checked = true;
                    }
                    else
                    {
                        rdbbtnMale.Checked = true;
                    }
                    txtbxPanNo.Text = dr["StaffPan"].ToString();
                    txtBankName.Text = dr["StaffBank"].ToString();
                    txtbxAdharNo.Text = dr["StaffAdhar"].ToString();
                    txtAccountNo.Text = dr["StaffAccount"].ToString();
                    txtIFSCCode.Text = dr["StaffIFSC"].ToString();
                    txtBankAddress.Text = dr["StaffBranch"].ToString();
                }
                dr.Close();
                AdminClass adminClass = new AdminClass(StaffCde);
                SqlDataReader dr1;
                dr1 = adminClass.GetQualification();
                while (dr1.Read())
                {
                    txtbxSSCYear.Text = dr1["SSCYear"].ToString();
                    txtbxSSCFile.Text = dr1["SSCFile"].ToString();
                    txtbxHSCYear.Text = dr1["HSCYear"].ToString();
                    txtHSCFile.Text = dr1["HSCFile"].ToString();
                    txtbxGraduationYear.Text = dr1["GradYear"].ToString();
                    txtbxGradFile.Text = dr1["GraduationFile"].ToString();
                    txtbxPostGraduationYear.Text = dr1["PGYear"].ToString();
                    txtbxPostGradFile.Text = dr1["PGFile"].ToString();
                }
                dr1.Close();

            }

        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCountry.SelectedValue.ToString());
            AdminClass objAdmin = new AdminClass(cid);
            DataTable dt = new DataTable();
            dt = objAdmin.FetchState();
            combxState.ValueMember = "StateId";
            combxState.DisplayMember = "StateName";
            combxState.DataSource = dt;
        }

        private void combxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Sid = Convert.ToInt32(combxState.SelectedValue.ToString());
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
                txtbxSSCFile.Text = openFileDialog1.FileName;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rdbbtnMale.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            if (cmbbxCountry.Text == "Select")
            {
                cmbbxCountry.Focus();
                MessageBox.Show("Please select Your Country...");
            }
            else if (cmbbxGraduation.Text == "Select")
            {
                cmbbxGraduation.Focus();
                MessageBox.Show("Please select your Graduation...");
            }
            else
            {
                int CId = Convert.ToInt32(combxCity.SelectedValue.ToString());
                int GId = Convert.ToInt32(cmbbxGraduation.SelectedValue.ToString());
                int PId = Convert.ToInt32(cmbbxPostGraduation.SelectedValue.ToString());

                AdminClass objAdmin = new AdminClass(txtbxStaffFullName.Text, txtbxContact.Text, txtbxAddess.Text, CId, txtbxAdharNo.Text, txtbxPanNo.Text,
                    txtbxEmailID.Text, Gender, dtDOB.Value, txtBankName.Text, txtIFSCCode.Text, txtAccountNo.Text, txtBankAddress.Text, StaffCde);
                objAdmin.UpdateStaff();

                int SSCYear = Convert.ToInt32(txtbxSSCYear.Text.ToString());
                int HSCYear = Convert.ToInt32(txtbxHSCYear.Text.ToString());
                int GradYear = Convert.ToInt32(txtbxGraduationYear.Text.ToString());
                int PGYear = Convert.ToInt32(txtbxPostGraduationYear.Text.ToString());
                AdminClass objAdmin1 = new AdminClass(SSCYear, txtbxSSCFile.Text, HSCYear, txtHSCFile.Text, GId, GradYear, txtbxGradFile.Text,
                    PId, PGYear, txtbxPostGradFile.Text, StaffCde);
                objAdmin1.UpdateQualification();

                MessageBox.Show("All Data Updated....");
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
