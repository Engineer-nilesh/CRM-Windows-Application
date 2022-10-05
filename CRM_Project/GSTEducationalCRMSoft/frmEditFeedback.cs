using GSTEducationalCRMSoft.Properties;
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
namespace GSTEducationalCRMSoft
{
    public partial class frmEditFeedback : Form
    {
        public int fid { get; set; }
    
        
        public frmEditFeedback()
        {
            InitializeComponent();
        }
        public frmEditFeedback(int id,string sc,string bname,string cname,string tname)
        {
            InitializeComponent();
            label2.Text = cname;
            label3.Text = bname;
            label4.Text = tname;
            label5.Text = sc;  
            fid = id;
        }
       
        private void frmEditFeedbackStT_Load(object sender, EventArgs e)
        {
        }
        
        private void pbStar1_Click_1(object sender, EventArgs e)
        {
            pbStar2.Image = Resources.whitestar;
            pbStar3.Image = Resources.whitestar;
            pbStar4.Image = Resources.whitestar;
            pbStar5.Image = Resources.whitestar;
            pbStar1.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Very Poor";
        }

        private void pbStar2_Click_1(object sender, EventArgs e)
        {
            pbStar3.Image = Resources.whitestar;
            pbStar4.Image = Resources.whitestar;
            pbStar5.Image = Resources.whitestar;
            pbStar1.Image = Resources.yellowstar;
            pbStar2.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Poor";
        }

        private void pbStar3_Click_1(object sender, EventArgs e)
        {
            pbStar4.Image = Resources.whitestar;
            pbStar5.Image = Resources.whitestar;
            pbStar1.Image = Resources.yellowstar;
            pbStar2.Image = Resources.yellowstar;
            pbStar3.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Good";
        }

        private void pbStar4_Click_1(object sender, EventArgs e)
        {
            pbStar5.Image = Resources.whitestar;
            pbStar1.Image = Resources.yellowstar;
            pbStar2.Image = Resources.yellowstar;
            pbStar3.Image = Resources.yellowstar;
            pbStar4.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Very Good";
        }

        private void pbStar5_Click_1(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.yellowstar;
            pbStar2.Image = Resources.yellowstar;
            pbStar3.Image = Resources.yellowstar;
            pbStar4.Image = Resources.yellowstar;
            pbStar5.Image = Resources.yellowstar;
            lblPerformance.Text = "Your Performance is Excellant";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            int rating = 0;
            int id = 0;
            string performance = null;
            if (lblPerformance.Text == "Your Performance is Very Poor")
            {
                rating = 1;
                performance = "Very Poor";
            }
            else if (lblPerformance.Text == "Your Performance is Poor")
            {
                rating = 2;
                performance = "Poor";
            }
            else if (lblPerformance.Text == "Your Performance is Good")
            {
                rating = 3;
                performance = "Good";
            }
            else if (lblPerformance.Text == "Your Performance is Very Good")
            {
                rating = 4;
                performance = "Very Good";
            }
            else
            {
                rating = 5;
                performance = "Excellent";
            }
            string comment = richtxtComments.Text;
            
                CoOrdinator objStudentToTrainerUpdate = new CoOrdinator(rating, performance, comment, fid);
                objStudentToTrainerUpdate.UpdateFeedback();
                MessageBox.Show("Feedback Update Sucessfully");
                this.Close();
            

        }
    }
}

