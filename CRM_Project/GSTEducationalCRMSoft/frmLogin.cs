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
using System.Text.RegularExpressions;
namespace GSTEducationalCRMSoft
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string staffPosition = null;
            String StaffCode = null;
            Counsellor objlogin = new Counsellor(txtUserEmail.Text, txtPassword.Text);
            SqlDataReader dr;
            dr = objlogin.Login();
            while (dr.Read())
            {
                txtUserEmail.Text = dr["StaffEmail"].ToString();
                txtPassword.Text = dr["StaffPassword"].ToString();
                staffPosition = dr["StaffPositionId"].ToString();
                StaffCode = dr["StaffCode"].ToString();
            }

            if (dr.HasRows && staffPosition == "3")
            {
                Form1 obj = new Form1(StaffCode,staffPosition);
                MessageBox.Show("Login Succesfull...!!!");
                obj.Show();
            }
            else if (dr.HasRows && staffPosition == "2")
            {
                frmAdmin obj = new frmAdmin(StaffCode, staffPosition);
                MessageBox.Show("Login Succesfull...!!!");
                obj.Show();
            }
            else if (dr.HasRows && staffPosition == "5")
            {
                frmCoOrdinator obj = new frmCoOrdinator(StaffCode, staffPosition);
                MessageBox.Show("Login Succesfull...!!!");
                obj.Show();
                
            }
            else if (txtUserEmail.Text.Length == 0)
            {
                MessageBox.Show("Username can not be blank...!!!");
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
            {
                MessageBox.Show("Invalid Password can not use special character password");
            }
            else
            {
                MessageBox.Show("Login Failed...!!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserEmail.Text = "";
            txtPassword.Text = "";
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword obj = new frmForgotPassword();
            obj.Show();
        }

        private void chkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxShowPassword.Checked)

            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
