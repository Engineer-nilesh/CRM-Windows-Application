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
    public partial class frmApplyLeaves : Form
    {
        public frmApplyLeaves()
        {
            InitializeComponent();
        }
        public frmApplyLeaves(string sc)
        {
            InitializeComponent();
            this.Text = sc;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
           string LeaveType = cmbbxLeavesType.Text;
           DateTime FromDate = dateTimePicker1.Value;
           DateTime ToDate = dateTimePicker2.Value;
           string Description = richtxtDescription.Text;
            DateTime today = DateTime.Now;
          int StatusId = 2;
            if (LeaveType == cmbbxLeavesType.Text && Description == richtxtDescription.Text)
            {
                Counsellor obj = new Counsellor(LeaveType, FromDate, ToDate, today, Description, StatusId,this.Text);
                obj.SaveLeave();
                MessageBox.Show("Save Sucessfully.....!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Save Failed.....!");
            }
        }
        
        private void cmbbxLeavesType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApplyLeaves_Load(object sender, EventArgs e)
        {
            cmbbxLeavesType.Items.Add("Sick");
            cmbbxLeavesType.Items.Add("Casual");
            cmbbxLeavesType.Items.Add("Paid");
            
        }

        private void txtStatusId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtDescription.Text))
            //{
            //    e.Cancel = true;
            //    txtDescription.Focus();
            //    errorProvider1.SetError(txtDescription, "Please Enter description....!");

            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtDescription, null);
            //}
        }

        private void txtStatusId_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void cmbbxLeavesType_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(cmbbxLeavesType.Text))
            //{
            //    e.Cancel = true;
            //    cmbbxLeavesType.Focus();
            //    errorProvider2.SetError(cmbbxLeavesType, "Please Enter Select Your LeavesType....!");

            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider2.SetError(cmbbxLeavesType, null);
            //}
        }
    }
}
