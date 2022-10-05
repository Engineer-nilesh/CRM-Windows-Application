using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCoOrdinator;
using System.Data.SqlClient;
using System.Data;

namespace GSTEducationalCRMSoft
{
    public partial class frmAddCertificateDetailss : Form
    {

        public frmAddCertificateDetailss()
        {
            InitializeComponent();
        }
       

        private void frmAddCertificateDetailss_Load(object sender, EventArgs e)
        {
           
            CoOrdinator obj = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = obj.GetCourse();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseName";
            cmbbxCourseName.DataSource = dt;
            cmbbxCourseName.Show();

        }


        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            CoOrdinator objStudent = new CoOrdinator(cid);
            DataTable dtStudent = new DataTable();
            dtStudent = objStudent.Get_Student_Name();
            cmbbxStudName.ValueMember = "StudCode";
            cmbbxStudName.DisplayMember = "StudFullName";
            cmbbxStudName.DataSource = dtStudent;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime issudate = DateTime.Now;
            string cno = txtCertificateNo.Text;
            int cid = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            string studname = cmbbxStudName.Text;
            string studcode = txtStudentCode.Text;
            DateTime adate = dateTimePickerAdmission.Value;
            DateTime cdate = dateTimePickerTo.Value;
            string grade = txtGrade.Text;
            CoOrdinator obj = new CoOrdinator(issudate, cno, cid, studname, studcode, adate, cdate, grade);
            obj.InsertCertificationDetails();
            MessageBox.Show("Save Sucessfully");
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lblCourseName_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxStudName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string studcode = cmbbxStudName.SelectedValue.ToString();
            CoOrdinator objStudent = new CoOrdinator(studcode);
            dr = objStudent.GetCertificateStudDetail();
            while (dr.Read())
            {
                txtStudentCode.Text = dr["StudCode"].ToString();
                txtContactNumber.Text = dr["StudContactNo"].ToString();
                txtEmailId.Text = dr["StudEmail"].ToString();
                dateTimePickerAdmission.Text = dr["StudRegistrationDate"].ToString();
            }

        }

        private void lblAddCertificateDetails_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerAdmission_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCertificateNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentCode_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailId_Click(object sender, EventArgs e)
        {

        }

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }

        private void lblCertificateDate_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmissionDate_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void lblCertificateNo_Click(object sender, EventArgs e)
        {

        }
    }
}
