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
    public partial class FrmStudentInfo : Form
    {
        public string StudCode { get; set; }
       // public DateTime StudRegistrationDate { get; set; }
        public FrmStudentInfo()
        {
            InitializeComponent();
        }
        public FrmStudentInfo(string studcode)
        {
            InitializeComponent();
            StudCode = studcode;
            CoOrdinator objStudDetails = new CoOrdinator(StudCode);
            SqlDataReader CandidateDetails = objStudDetails.GetLableStudent();
            CandidateDetails.Read();
            if (CandidateDetails.HasRows)
            {

                lblStudRegistrationDate.Text = CandidateDetails["StudRegistrationDate"].ToString();
                lblStudEnquiryDate.Text = CandidateDetails["StudEnquiryDate"].ToString();
                lblStudCode.Text = CandidateDetails["StudCode"].ToString();
                lblCenterId.Text = CandidateDetails["CenterId"].ToString();

                lblstudname.Text = CandidateDetails["StudFullName"].ToString();
                lblStudDOB.Text = CandidateDetails["StudDOB"].ToString();
                lblStudLocalAddress.Text = CandidateDetails["StudLocalAddress"].ToString();
                lblStudPermanentAddress.Text = CandidateDetails["StudPermanentAddress"].ToString();
            

                lblStudContactNo.Text = CandidateDetails["StudContactNo"].ToString();
                lblStudAlternateNo.Text = CandidateDetails["StudAlternateNo"].ToString();
                lblGradName. Text = CandidateDetails["GradName"].ToString();
                lblStudEmail.Text = CandidateDetails["StudEmail"].ToString();

                lblStudFatherContactNo.Text = CandidateDetails["StudFatherContactNo"].ToString();
                lblStudMotherContactNo.Text = CandidateDetails["StudMotherContactNo"].ToString();

                lblPaidAmount.Text = CandidateDetails["PaidAmount"].ToString();
                lblBalanceAmount.Text = CandidateDetails["BalanceAmount"].ToString();
                lblCourseFess.Text = CandidateDetails["CourseFees"].ToString();
                lblCourseName.Text = CandidateDetails["CourseName"].ToString();
            }
        }

        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblstudname_Click(object sender, EventArgs e)
        {

        }

        private void lblGradName_Click(object sender, EventArgs e)
        {

        }

        private void lblStudRegistrationDate_Click(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblBatchName_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
