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


namespace GSTEducationalCRMSoft
{
    public partial class frmAddNewEnquirySource : Form
    {
        public frmAddNewEnquirySource()
        {
            InitializeComponent();
        }

        private void txtEnquirySource_TextChanged(object sender, EventArgs e)
        {
           // InsertEnquirySource

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEnquirySourceName.Text == string.Empty)
            {
                txtEnquirySourceName.Focus();
                MessageBox.Show("Please Enter New Source...");
            }
            else
            {
                Counsellor obj = new Counsellor(txtEnquirySourceName.Text);
                obj.InsertEnquirySource();
                MessageBox.Show("Saved...");
                this.Close();
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnquirySourceName.Clear();
        }

        private void frmAddNewEnquirySource_Load(object sender, EventArgs e)
        {

        }

        private void txtEnquirySourceName_Leave(object sender, EventArgs e)
        {
            Counsellor objCheckExisting = new Counsellor(txtEnquirySourceName.Text);
            SqlDataReader dr = objCheckExisting.CheckExistingEnquirySource();
            dr.Read();
            if (dr.HasRows)
            {
                txtEnquirySourceName.Focus();
                erpNewSource.SetError(txtEnquirySourceName, "Source Already Exists");
                MessageBox.Show("Source Already Exists!!");
                erpNewSource.Clear();
            }
        }
    }
}
