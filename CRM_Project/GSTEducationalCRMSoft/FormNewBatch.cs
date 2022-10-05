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
    public partial class FormNewBatch : Form
    {
        public class btime
        {
            public int id { get; set; }
            public string batchtime { get; set; }
        }
        public FormNewBatch()
        {
            InitializeComponent();
        }
       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            string studcode = null;
            int totalstudent = 0;
            string batchname = txtBatchName.Text;
            string staffcode = cmbbxTrainer.SelectedValue.ToString();
            string batchtime = cmbbxBatchTime.SelectedItem.ToString();
            int labid = Convert.ToInt32(cmbbxLabName.SelectedValue.ToString());
            DateTime startdate = dateTimePicker1.Value;
            DateTime enddate = dateTimePicker2.Value;
            int Statusid = 6;
            string sc = null;
            string scode2 = null;

            int k = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["checkbox"].Value))
                {

                    for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        string scode1 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        if (j == 1)
                        {
                            sc = String.Concat(scode1, ",");
                            k++;
                        }
                        scode2 = String.Concat(scode2, sc);
                    }
                }
            }
            totalstudent = k;
            if (txtBatchName.Text == "")
            {
                MessageBox.Show("Enter Batch Name");
            }
            else if (cmbbxLabName.Items == null)
            {
                MessageBox.Show("Select Lab");
            }
            else
            {
                string scode = scode2;
                CoOrdinator objSave = new CoOrdinator(cid, scode, batchname, totalstudent, staffcode, batchtime, labid, startdate, enddate, Statusid);
                objSave.CreateBatch();
                MessageBox.Show("Batch Save Succesfully");
                this.Close();
            }
        }

        private void FormNewBatch_Load(object sender, EventArgs e)
        { 
            //GetCourse
            CoOrdinator obj = new CoOrdinator();
            DataTable dtCourse = new DataTable();
            dtCourse = obj.GetCourse();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseName";
            cmbbxCourseName.DataSource = dtCourse;



            //GetLabName
            CoOrdinator objLab = new CoOrdinator();
            DataTable dtLab = new DataTable();
            dtLab = objLab.GetLabName();
            cmbbxLabName.ValueMember = "LabId";
            cmbbxLabName.DisplayMember = "LabName";
            cmbbxLabName.DataSource = dtLab;


            //GetStatus
            CoOrdinator objStatus = new CoOrdinator();
            DataTable dtStatus = new DataTable();
            dtStatus = objStatus.GetBatchStatus();
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.DataSource = dtStatus;

        }

        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid=Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            CoOrdinator obj1 = new CoOrdinator(cid);
            DataTable dt1 = new DataTable();
            dt1 = obj1.GetTrainer();
            cmbbxTrainer.ValueMember = "StaffCode";
            cmbbxTrainer.DisplayMember = "StaffName";
            cmbbxTrainer.DataSource = dt1;
        }

        private void cmbbxTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sid = cmbbxTrainer.SelectedValue.ToString();
            string TimeColor;
            //string labColor;
            CoOrdinator objtimecolor = new CoOrdinator(sid);
            DataTable dttimecolor = new DataTable();
            dttimecolor = objtimecolor.GetBatchTimeColor();


            for (int i = 0; i < dttimecolor.Rows.Count; i++)
            {
                TimeColor = dttimecolor.Rows[i]["BatchTime"].ToString();
                for (int j = 0; j < cmbbxBatchTime.Items.Count; j++)
                {

                    string comparetime = cmbbxBatchTime.GetItemText(cmbbxBatchTime.Items[j]);
                    if (TimeColor == comparetime)
                    {
                        cmbbxBatchTime.Items.Remove(cmbbxBatchTime.Items[j]);
                    }
                }
            }
        }

        private void cmbbxLabName_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Sid=Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());
            int cid = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            CoOrdinator obj = new CoOrdinator(Sid, cid);
            DataTable dt1 = new DataTable();
            dt1 = obj.GetStatusStudent();
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[1].Visible= false;

        }

        private void cmbbxTrainer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbbxBatchTime_SelectedValueChanged(object sender, EventArgs e)
        {
            string batchtime = (cmbbxBatchTime.Text.ToString());
            CoOrdinator objLab = new CoOrdinator(batchtime);
            DataTable dtlab = new DataTable();
            dtlab = objLab.GetBatchLab();
            cmbbxLabName.ValueMember = "LabId";
            cmbbxLabName.DisplayMember = "LabName";
            cmbbxLabName.DataSource = dtlab;
        }
    }
}
