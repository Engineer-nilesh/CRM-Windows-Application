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
using System.Text.RegularExpressions;


namespace GSTEducationalCRMSoft
{
    public partial class frmEditTest : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SWAPNIL;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");
        
        public frmEditTest(string testid, string testname, String cname, string bname, string tname, string marks,string lname, String sname, string stime, string duration, string sfile)
        {
            InitializeComponent();
            label14.Text = testid;
            cmbbxTestName.Text = testname;
            cmbbxTestCourseName.Text = cname;
            cmbbxTestBatchName.Text = bname;
            cmbbxTestTrainer.Text = tname;
            cmbbxTestLab.Text = lname;
            cmbbxTestStatus.Text = sname;
            cmbbxSTime.Text = stime;
            cmbbxTestDuration.Text = duration;
            txtTestSelectFile.Text = sfile;
            txtMaximumMarks.Text = marks;
        }

        private void dateTimePicker1TestDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmEditTest_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            int testid = Convert.ToInt32(label14.Text.ToString());
            string testname = cmbbxTestName.Text;
            DateTime tdate = dateTimePicker1TestDate.Value;
            DateTime rdate = DateTime.Now;
            int mmarks = Convert.ToInt32(txtMaximumMarks.Text);
            string duration = cmbbxTestDuration.Text;
            string stime = cmbbxSTime.Text;
            string selectfile = txtTestSelectFile.Text;
            CoOrdinator obj = new CoOrdinator(testname, tdate, rdate, mmarks, stime, duration, selectfile, testid);
            obj.UpdateTest();
            MessageBox.Show("Your Data Is Update Successfully...!!!");
            this.Close();

        }

        private void cmbbxTestName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
                txtTestSelectFile.Text = openFileDialog1.FileName;
        }

        private void cmbbxSTime_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(cmbbxSTime.Text))
            //{
            //    e.Cancel = true;
            //    cmbbxSTime.Focus();
            //    errorProviderEditStime.SetError(cmbbxSTime, "Start Time shouldn't be blank!");
            //}

            //else
            //{
            //    e.Cancel = false;
            //    errorProviderEditStime.SetError(cmbbxSTime, "");
            //}

        }

        private void cmbbxTestDuration_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(cmbbxTestDuration.Text))
            //{
            //    e.Cancel = true;
            //    cmbbxTestDuration.Focus();
            //    errorProviderDuration.SetError(cmbbxTestDuration, "Duration shouldn't be blank!");
            //}

            //else
            //{
            //    e.Cancel = false;
            //    errorProviderDuration.SetError(cmbbxTestDuration, "");
            //}
        }

        private void txtMaximumMarks_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtMaximumMarks.Text))
            //{
            //    e.Cancel = true;
            //    txtMaximumMarks.Focus();
            //    errorProviderMarks.SetError(txtMaximumMarks, "Marks shouldn't be blank!");
            //}
            //else if (!Regex.IsMatch(txtMaximumMarks.Text, "[0-9]{2,3}"))
            //{
            //    errorProviderMarks.SetError(txtMaximumMarks, "Marks format is not correct!");
            //}

            //else
            //{
            //    e.Cancel = false;
            //    errorProviderMarks.SetError(txtMaximumMarks, "");
            //}
        }

        private void txtTestSelectFile_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtTestSelectFile.Text))
            //{
            //    e.Cancel = true;
            //    txtTestSelectFile.Focus();
            //    errorProviderSelectFile.SetError(txtTestSelectFile, "Select File.. shouldn't be blank!");
            //}

            //else
            //{
            //    e.Cancel = false;
            //    errorProviderSelectFile.SetError(txtTestSelectFile, "");
            //}

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbbxSTime_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxSTime.Text) == true)
            {
                cmbbxSTime.Focus();
                errorProviderEditStime.SetError(cmbbxSTime, "Please select Time..!");
                MessageBox.Show("Please select Time ..!");
                errorProviderEditStime.Clear();

            }
        }

        private void cmbbxTestDuration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxTestDuration_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxTestDuration.Text) == true)
            {
                cmbbxTestDuration.Focus();
                errorProviderDuration.SetError(cmbbxTestDuration, "Please select Duration..!");
                MessageBox.Show("Please select Duration ..!");
                errorProviderDuration.Clear();

            }
        }

        private void txtMaximumMarks_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaximumMarks.Text) == true)
            {
                txtMaximumMarks.Focus();
                errorProviderMarks.SetError(txtMaximumMarks, "Please Enter marks..!");
                MessageBox.Show("Please Enter Marks ..!");
                errorProviderMarks.Clear();

            }
        }

        private void txtTestSelectFile_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestSelectFile.Text) == true)
            {
                txtTestSelectFile.Focus();
                errorProviderSelectFile.SetError(txtTestSelectFile, "Please Select File..!");
                MessageBox.Show("Please Select File ..!");
                errorProviderSelectFile.Clear();

            }
        }
    }
}
