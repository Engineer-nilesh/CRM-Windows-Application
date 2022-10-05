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
using System.Text.RegularExpressions;

namespace GSTEducationalCRMSoft
{
    public partial class AddFollowUp : Form
    {
        public AddFollowUp(string StudFullName, string MobileNo,String StudCode, string EnquiryStaffName)
        {
            InitializeComponent();
            label5.Text = EnquiryStaffName;
            label1.Text =StudFullName;
            label2.Text = MobileNo;
            label3.Text = StudCode;
          //  label5.Hide();

    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddFollowUp_Load(object sender, EventArgs e)
        {
            Counsellor objStatus = new Counsellor();
            DataTable dtt = new DataTable();
            dtt = objStatus.GetEnquiryStatus();
            cmbbxEnquiryStatus.ValueMember = "StatusId";
            cmbbxEnquiryStatus.DisplayMember = "Status";
            cmbbxEnquiryStatus.DataSource = dtt;



            string StudCode = label3.Text;
            Counsellor objView = new Counsellor(StudCode);
            DataTable dttv= new DataTable();
            dttv = objView.ViewFollowUp();
            grdvfd.DataSource = dttv;
            grdvfd.Show();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string StudFullName = label1.Text;
            string StudCode = label3.Text;
            string staffname = label5.Text;
            string Note = txtNote.Text;
            DateTime NextFollowUpDate = dateTimePicker1.Value;

            if (txtNote.Text == "")
            {
                MessageBox.Show("Fill The FollowUp Note...!!!");
            }
            else
            {
                DateTime FollowUpDate = DateTime.Now;
                int StatusId = Convert.ToInt32(cmbbxEnquiryStatus.SelectedValue.ToString());
                Counsellor objadd = new Counsellor(StudCode, Note, FollowUpDate, NextFollowUpDate, StatusId,staffname);
                objadd.InsertFollowUp();
                Counsellor objupdate = new Counsellor(StatusId, StudCode);
                objupdate.Updateandidatebyfollowup();
                MessageBox.Show("Save Successfully....!");
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
