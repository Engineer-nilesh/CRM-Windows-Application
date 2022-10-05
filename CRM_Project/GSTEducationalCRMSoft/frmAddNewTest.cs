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
using System.Text.RegularExpressions;
using clsCounsellor;

namespace GSTEducationalCRMSoft
{
    public partial class frmAddNewTest : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SWAPNIL;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");
        public frmAddNewTest()
        {
            InitializeComponent();
        }

        private void frmAddNewTest_Load(object sender, EventArgs e)
        {

            //****************Course***********//

            Counsellor obj  = new Counsellor();
            DataTable dt=new DataTable();
            dt = obj.GetInterestedCourse();
            cmbbxTestCourseName.ValueMember = "CourseId";
            cmbbxTestCourseName.DisplayMember = "CourseName";
            cmbbxTestCourseName.DataSource = dt;
            cmbbxTestCourseName.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxTestCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*******************Batch**************//

            int cid = Convert.ToInt32(cmbbxTestCourseName.SelectedValue.ToString());
            CoOrdinator objBatch = new CoOrdinator(cid);
            DataTable dtBatch = new DataTable();
            dtBatch = objBatch.GetBatchByCourse();
            cmbbxTestBatchName.ValueMember = "BatchId";
            cmbbxTestBatchName.DisplayMember = "BatchName";
            cmbbxTestBatchName.DataSource = dtBatch;
            cmbbxTestBatchName.Show();
        }

        private void cmbbxTestBatchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*******************Trainer**************//


            int bid = Convert.ToInt32(cmbbxTestBatchName.SelectedValue.ToString());
            int cid = Convert.ToInt32(cmbbxTestCourseName.SelectedValue.ToString());
            CoOrdinator objTrainer = new CoOrdinator(cid,bid);
            DataTable dtTrainer = new DataTable();
            dtTrainer = objTrainer.GetTrainerByName();
            cmbbxTestTrainer.ValueMember = "StaffId";
            cmbbxTestTrainer.DisplayMember = "StaffName";
            cmbbxTestTrainer.DataSource = dtTrainer;
            cmbbxTestTrainer.Show();

            //********************Lab****************//

            int id = Convert.ToInt32(cmbbxTestBatchName.SelectedValue.ToString());
            CoOrdinator obj = new CoOrdinator(id);
            DataTable dtt = new DataTable();
            dtt = obj.GetTestLab();
            cmbbxTestLab.ValueMember = "LabId";
            cmbbxTestLab.DisplayMember = "LabName";
            cmbbxTestLab.DataSource = dtt;
            cmbbxTestLab.Show();

            //*********************Status********************//

            int id2 = Convert.ToInt32(cmbbxTestBatchName.SelectedValue.ToString());
            CoOrdinator objStatus = new CoOrdinator(id2);
            DataTable dt1 = new DataTable();
            dt1 = objStatus.GetTestStatus();
            cmbbxTestStatus.ValueMember = "StatusId";
            cmbbxTestStatus.DisplayMember = "Status";
            cmbbxTestStatus.DataSource = dt1;
            cmbbxTestStatus.Show();


        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxTestCourseName.SelectedValue.ToString());
            int bid = Convert.ToInt32(cmbbxTestBatchName.SelectedValue.ToString());
           
            string tid = cmbbxTestTrainer.Text;
            int lid = Convert.ToInt32(cmbbxTestLab.SelectedValue.ToString());
            int sid=Convert.ToInt32(cmbbxTestStatus.SelectedValue.ToString());
            string testname = txtTestName.Text;
            DateTime tdate = dateTimePicker1TestDate.Value;
            DateTime rdate = DateTime.Now;
            int mmarks = Convert.ToInt32(txtmmarks.Text);
            string duration = cmbbxTestDuration.Text;
            string stime = cmbbxStartTime.Text;
            string selectfile = txtTestSelectFile.Text;
            //if (txtTestName.Text != "" && cmbbxTestCourseName.Text != null && txtmmarks.Text != "" && cmbbxStartTime.Text != null && cmbbxTestDuration.Text != null && txtTestSelectFile.Text != "")
            //{
            //    MessageBox.Show(" Failed...!!!");
            ////}
            //else
            //{
                CoOrdinator obj = new CoOrdinator(testname, tdate, rdate, cid, bid, tid, mmarks, stime, duration, lid, sid, selectfile);
                obj.AddNewTest();
                MessageBox.Show("Your Data Is Saved Successfully...!!!");
                this.Close();
                
            //}
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            DialogResult result=openFileDialog1.ShowDialog();
            if( result==DialogResult.OK)
                txtTestSelectFile.Text=openFileDialog1.FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTestName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTestName_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtTestName.Text))
            //{
            //    e.Cancel = true;
            //    txtTestName.Focus();
            //    errorProviderTestName.SetError(txtTestName, "Name shouldn't be blank!");
            //}
            //else if (!Regex.IsMatch(txtTestName.Text, "[A-Za-z]"))
            //{
            //    errorProviderTestName.SetError(txtTestName, "Name format is not correct!");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProviderTestName.SetError(txtTestName, "");
            //}
        }

        private void txtmmarks_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrWhiteSpace(txtmmarks.Text))
            //{
            //    e.Cancel = true;
            //    txtmmarks.Focus();
            //    errorProviderMarks.SetError(txtmmarks, "Marks shouldn't be blank!");
            //}
            //else if (!Regex.IsMatch(txtmmarks.Text, "[0-9]{2,3}"))
            //{
            //    errorProviderMarks.SetError(txtmmarks, "Marks format is not correct!");
            //}

            //else
            //{
            //    e.Cancel = false;
            //   errorProviderMarks.SetError(txtmmarks, "");
            //}
        }

        private void cmbbxStartTime_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(cmbbxStartTime.Text))
            //{
            //    e.Cancel = true;
            //    cmbbxStartTime.Focus();
            //    errorProviderSTime.SetError(cmbbxStartTime, "Start Time shouldn't be blank!");
            //}

            //else
            //{
            //    e.Cancel = false;
            //    errorProviderSTime.SetError(cmbbxStartTime, "");
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

        private void txtTestName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestName.Text) == true)
            {
                txtTestName.Focus();
                errorProviderTestName.SetError(txtTestName, "Please enter Testname..!");
                MessageBox.Show("Please Enter TestName ..!");
                errorProviderTestName.Clear();
            }
        }

        private void cmbbxTestCourseName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxTestCourseName.Text) == true)
            {
                cmbbxTestCourseName.Focus();
                errorProviderCourseName.SetError(cmbbxTestCourseName, "Please Select Course..!");
                MessageBox.Show("Please Select Course..!");
                errorProviderCourseName.Clear();
            }
        }

        private void txtmmarks_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmmarks.Text) == true)
            {
                txtmmarks.Focus();
                errorProviderMarks.SetError(txtmmarks, "Please enter Marks..!");
                MessageBox.Show("Please Enter Marks ..!");
                errorProviderMarks.Clear();
            }
        }

        private void cmbbxStartTime_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxStartTime.Text) == true)
            {
                cmbbxStartTime.Focus();
                errorProviderSTime.SetError(cmbbxStartTime, "Please enter Testname..!");
                MessageBox.Show("Please Select TestTime ..!");
                errorProviderSTime.Clear();
            }
        }

        private void cmbbxTestDuration_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxTestDuration.Text) == true)
            {
                cmbbxTestDuration.Focus();
                errorProviderDuration.SetError(cmbbxTestDuration, "Please Select Duration..!");
                MessageBox.Show("Please Select Duration..!");
                errorProviderDuration.Clear();
            }
        }

        private void txtTestSelectFile_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtTestSelectFile.Text) == true)
            //{
            //    txtTestSelectFile.Focus();
            //    errorProviderSelectFile.SetError(txtTestSelectFile, "Please Select File..!");
            //    MessageBox.Show("Please Select File..!");
            //    txtTestSelectFile.Clear();
            //}
        }
    }
}
