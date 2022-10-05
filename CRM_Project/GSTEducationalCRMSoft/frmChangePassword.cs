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
using System.Configuration;

namespace GSTEducationalCRMSoft
{
    public partial class frmChangePassword : Form
    {
        public string StaffCde;
        public frmChangePassword()
        {
            InitializeComponent();
        }
        public frmChangePassword(string Code)
        {
            InitializeComponent();
            StaffCde = Code;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password does not match...!!!");
            }
            else
            {
                Counsellor objchange = new Counsellor(txtOldPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text);
                objchange.UpdatePassword();
                MessageBox.Show("Changed Passwrod Succesfully...!!!");
                this.Close();
            }
        }

        private void btnPasswordOn_Click(object sender, EventArgs e)
        {
            if(txtOldPassword.UseSystemPasswordChar == true)
            {
                btnPasswordOn.BringToFront();
                txtOldPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnPasswordOff_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.UseSystemPasswordChar == false)
            {
                btnPasswordOff.BringToFront();
                txtOldPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnPasswordOn2_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar == true)
            {
                btnPasswordOn2.BringToFront();
                txtNewPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnPasswordOff2_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar == false)
            {
                btnPasswordOff2.BringToFront();
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnPasswordOn3_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.UseSystemPasswordChar == true)
            {
                btnPasswordOn3.BringToFront();
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnPasswordOff3_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.UseSystemPasswordChar == false)
            {
                btnPasswordOff3.BringToFront();
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
