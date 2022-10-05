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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using clsCounsellor;

namespace GSTEducationalCRMSoft
{
    public partial class frmForgotPassword : Form
    {

        public string StaffEmail { get; set; }

        public string StaffPassword { get; set; }
        public object Client { get; private set; }

        string randomcode;

        public static string to;

        public frmForgotPassword()
        {
            InitializeComponent();
        }
 
        protected void btnContinue_Click(object sender, EventArgs e)
        {
            string EmailPattern = (@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (string.IsNullOrEmpty(txtEmail.Text) == true || Regex.IsMatch(txtEmail.Text, EmailPattern) == false)
            {
                errorProvider1.SetError(txtEmail, "Enter Valid Email ID...!");
                MessageBox.Show("Enter Valid Email ID");
                errorProvider1.Clear();
            }
            else
            {
                string email = txtEmail.Text;
                Counsellor obj = new Counsellor(email);
                SqlDataReader dr;
                dr = obj.ForgotPassword();
                while (dr.Read() == true)
                {
                    string EmailID = dr["StaffEmail"].ToString();
                    string Password = dr["StaffPassword"].ToString();
                    if (EmailID == email)
                    {
                        string from = "gsteducationalcrmsoft@gmail.com";
                        string to = EmailID;
                        MailMessage msg = new MailMessage(from, to);
                        string mailbody = "Your Recovery Password is " + Password;
                        msg.Subject = "GayasoftCRM";
                        msg.Body = mailbody;
                        msg.BodyEncoding = Encoding.UTF8;
                        msg.IsBodyHtml = true;
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        System.Net.NetworkCredential a = new System.Net.NetworkCredential("gsteducationalcrmsoft@gmail.com", "crmsoft@57");
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = a;
                        try
                        {
                            client.Send(msg);
                            MessageBox.Show("Password send");
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Check Internet Connection");
                        }
                    }
                }
            }
            this.Hide();




            //string from, pass, messagebody;
            //Random ran = new Random();
            //randomcode = (ran.Next(9999999)).ToString();
            //MailMessage message = new MailMessage();
            //to = (txtEmail.Text).ToString();
            //from = "vampire00173@gmail.com";
            //pass = "Aquareacto3";
            //messagebody = $"Your Reset Code is{randomcode}";
            //message.To.Add(to);
            //message.From = new MailAddress(from);
            //message.Body = messagebody;
            //message.Subject = "Password Reset Code";
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.EnableSsl = true;
            //smtp.Port = 25;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Credentials = new NetworkCredential(from, pass);
            //try
            //{
            //    smtp.Send(message);
            //    MessageBox.Show("Email Send Successfully...!!!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
