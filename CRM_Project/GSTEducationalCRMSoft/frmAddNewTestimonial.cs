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
using System.IO;
using clsCoOrdinator;

namespace GSTEducationalCRMSoft
{
    public partial class frmAddNewTestimonial : Form
    {
        public frmAddNewTestimonial()
        {
            InitializeComponent();
        }

        public string studcode;

        public int Desig;

        public int Comapny;

        private void frmAddNewTestimonial_Load(object sender, EventArgs e)
        {
            /******************Get Testimonial Candidate**************/

            CoOrdinator objgettesti = new CoOrdinator();
            DataTable dtgettesti = new DataTable();
            dtgettesti = objgettesti.GetTestimonialCandidate();
            cmbbxCandidateName.ValueMember = "StudCode";
            cmbbxCandidateName.DisplayMember = "StudFullName";
            cmbbxCandidateName.DataSource = dtgettesti;         
        }

        private void btnUploadVideo_Click(object sender, EventArgs e)
        {
            //openFileDialogVideo.ShowDialog();
            //string filename = openFileDialogVideo.FileName;
            //string savefile = File.ReadAllText(filename);

            DialogResult result = openFileDialogVideo.ShowDialog();
            if(result == DialogResult.OK)
                txtUploadVideo.Text = openFileDialogVideo.FileName;
        }

        private void btnUploadPDF_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogPDF.ShowDialog();
            if(result == DialogResult.OK)
                txtUploadPDF.Text = openFileDialogPDF.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbbxCandidateName.Text == string.Empty)
            {
                cmbbxCandidateName.Focus();
                MessageBox.Show("Please Select Candidate Name...");
            }
            else if (txtCommetsForRIS.Text == string.Empty)
            {
                txtCommetsForRIS.Focus();
                MessageBox.Show("Please write your valuable comments for Raahitech Solution...!!!");
            }
            else
            {
                string code = studcode;
                string name = cmbbxCandidateName.Text;
                string qualif = labelQualification.Text;
                string desigid = lbldesignationid.Text.ToString();
                string desig = labelDesignation.Text;
                string companyid = lblcompanyid.Text;
                string comp = labelCompany.Text;
                string salary = labelPackage.Text;
                lblDateOfJoining.Text = DateTime.Now.ToString();
                string comment = txtCommetsForRIS.Text;
                string vid = txtUploadVideo.Text;
                string pdf = txtUploadPDF.Text;

                CoOrdinator objsave = new CoOrdinator(code,name, qualif, desigid,desig, companyid,comp, salary, comment, vid, pdf);
                objsave.AddTestimonial();
                MessageBox.Show("You'r Data Is Saved Successfully...!!!");
                this.Close();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCommetsForRIS.Text = "";
            txtUploadVideo.Text = "";
            txtUploadPDF.Text = "";
        }

        private void cmbbxCandidateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            /******************Get All Details Of Testimonial*******************/

            SqlDataReader dr;
            string StudCode = cmbbxCandidateName.SelectedValue.ToString();
            CoOrdinator objStudCode = new CoOrdinator(StudCode);
            dr = objStudCode.GetAllDetailsofTestimonial();
            while (dr.Read())
            {
                //int Desig = Convert.ToInt32(dr["DesignationId"].ToString());
                studcode = dr["StudCode"].ToString();
                labelDesignation.Text = dr["DesignationName"].ToString();
                labelQualification.Text = dr["Qualification"].ToString();
                lblcompanyid.Text = dr["CompanyId"].ToString();
                labelCompany.Text = dr["CompanyName"].ToString();
                labelDateOfJoining.Text = dr["DateOfJoining"].ToString();
                labelPackage.Text = dr["Package"].ToString();
                lbldesignationid.Text = dr["DesignationId"].ToString();
            }
        }
    }
}
