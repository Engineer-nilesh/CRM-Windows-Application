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
using System.Data.SqlClient;
namespace GSTEducationalCRMSoft
{
    public partial class frmViewTask : Form
    {
       public int TaskId { get; set; }
        public string StatusName { get; set; }
        public frmViewTask()
        {
            InitializeComponent();
        }

       public frmViewTask(string TaskName, int taskId, string status)
        {
            InitializeComponent();
            label2.Text = TaskName;
            TaskId = taskId;
            StatusName = status;
        }
        private void frmViewTask_Load(object sender, EventArgs e)
        {
            // Show Status in ComboBox
            Counsellor objStatus = new Counsellor();
            DataTable dt = new DataTable();
            dt = objStatus.GetTaskStatus();
            cmbbxtaskStatus.ValueMember = "StatusId";
            cmbbxtaskStatus.DisplayMember = "Status";
            cmbbxtaskStatus.DataSource = dt;

            if (StatusName == "Complete")
            {
                datePickerNewdDate.Enabled = false;
                datePickerNewStartDate.Enabled = false;
                TimePickerStartTime.Enabled = false;
                TimePickerEndTime.Enabled = false;
                richtxtComments.Enabled = false;
                cmbbxtaskStatus.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
           DateTime StartDate = datePickerNewStartDate.Value;
            DateTime EndDate = datePickerNewdDate.Value;
            DateTime SartTime = TimePickerStartTime.Value;
            DateTime EndTime= TimePickerEndTime.Value;
            int Sid = Convert.ToInt32(cmbbxtaskStatus.SelectedValue.ToString());
            string Comments= richtxtComments.Text;
           
            Counsellor objUdateTask = new Counsellor(StartDate,EndDate,SartTime,EndTime,Sid,Comments,TaskId);
            objUdateTask.UpdateTask();
            MessageBox.Show("Update Task Sucessfully....!");
            this.Close();
        }

        private void panelTaskManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
