using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCounsellor;

namespace GSTEducationalCRMSoft
{
    public partial class frmDetails : Form
    {

        public frmDetails()
        {
            InitializeComponent();
        }
        public frmDetails(
            string candidate,string qualification, string companyname,string designation,string package,string dateofjoining,string Comments)
        {

            InitializeComponent();

            lblCandidate.Text = candidate;
            lblqualification.Text = qualification;
            lblCompany.Text = companyname;
            lblDesignation.Text = designation;
            lblSalary.Text = package;
            lblDateOfJoining.Text = dateofjoining;
            lblCommentrahitech.Text=Comments;


        }

        private void frmDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
