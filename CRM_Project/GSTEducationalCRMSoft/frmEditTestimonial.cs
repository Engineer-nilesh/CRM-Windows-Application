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
using clsCoOrdinator;

namespace GSTEducationalCRMSoft
{
    public partial class frmEditTestimonial : Form
    {
        public frmEditTestimonial(int id1,string name, string qualif, string desig, string company, string salary, string comment, string vid, string pdf)
        {
            InitializeComponent();

            lblTestimonialId.Text = id1.ToString();
            txtCandidateName.Text = name;
            txtQualification.Text = qualif;
            txtDesignation.Text = desig;
            txtCompany.Text = company;
            txtSalary.Text = salary;
            txtCommetsForRIS.Text = comment;
            txtUploadVideo.Text = vid;
            txtUploadPDF.Text = pdf;
        }

        private void btnUploadVideo_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogVideo.ShowDialog();
            if (result == DialogResult.OK)
                txtUploadVideo.Text = openFileDialogVideo.FileName;
        }

        private void btnUploadPDF_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogPDF.ShowDialog();
            if(result == DialogResult.OK)
                txtUploadPDF.Text = openFileDialogPDF.FileName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id1 = Convert.ToInt32(lblTestimonialId.Text);
            string name = txtCandidateName.Text;
            string qualif = txtQualification.Text;
            string desig = txtDesignation.Text;
            string company = txtCompany.Text;
            string salary = txtSalary.Text;
            string comment = txtCommetsForRIS.Text;
            string vid = txtUploadVideo.Text;
            string pdf = txtUploadPDF.Text;

            CoOrdinator objupdate = new CoOrdinator(id1, name, qualif,desig,company,salary,comment,vid,pdf);
            objupdate.UpdateTestimonial();
            MessageBox.Show("You'r Data Is Updated Successfully...!!!");
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCandidateName.Text = "";
            txtQualification.Text = "";
            txtDesignation.Text = "";
            txtCompany.Text = "";
            txtSalary.Text = "";
            txtCommetsForRIS.Text = "";
            txtUploadVideo.Text = "";
            txtUploadPDF.Text = "";
        }
    }
}
