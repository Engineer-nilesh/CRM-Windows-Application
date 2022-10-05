using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCounsellor;
namespace GSTEducationalCRMSoft
{
    public partial class frmTaskManagement : Form
    {
        DataTable dtRefresh = new DataTable();
        public frmTaskManagement()
        {
            InitializeComponent();
        }
        public frmTaskManagement(string sc)
        {
            InitializeComponent();
            this.Text = sc;

        }
        private void frmTaskManagement_Load(object sender, EventArgs e)
        {
            
            // Show Status in ComboBox
            Counsellor objStatus = new Counsellor();
            DataTable dt = new DataTable();
            dt = objStatus.GetTaskStatus();
            cmbbxtaskStatus.ValueMember = "StatusId";
            cmbbxtaskStatus.DisplayMember = "Status";
            cmbbxtaskStatus.DataSource = dt;
            // Show all details for task in Grid view
            Counsellor objTask=new Counsellor(this.Text);
            
            dtRefresh = objTask.ViewTask();
            grdTaskManagementView.DataSource = dtRefresh;
            grdTaskManagementView.Show();

        }
        private void datePickerStartDate_ValueChanged_1(object sender, EventArgs e)
        {
           
        }
        private void datePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void grdTaskManagementView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int TaskId;
            bool select = grdTaskManagementView.Rows[grdTaskManagementView.CurrentRow.Index].Cells[0].Selected;
            String TaskName= grdTaskManagementView.Rows[grdTaskManagementView.CurrentRow.Index].Cells[2].Value.ToString();
            TaskId = Convert.ToInt32(grdTaskManagementView.Rows[grdTaskManagementView.CurrentRow.Index].Cells[1].Value.ToString());
            string TaskStatus= grdTaskManagementView.Rows[grdTaskManagementView.CurrentRow.Index].Cells[7].Value.ToString();
            
            frmViewTask objViewTask = new frmViewTask(TaskName,TaskId, TaskStatus);
            objViewTask.Show();
        }

        private void panelTaskManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbbxtaskStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(cmbbxtaskStatus.SelectedValue.ToString());
            Counsellor objTask = new Counsellor(this.Text, sid);
            DataTable dtt = new DataTable();
            dtt = objTask.taskstatusFillter();
            grdTaskManagementView.DataSource = dtt;
            grdTaskManagementView.Show();
        }

        private void lblTaskStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {

        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime StartDate = datePickerStartDate.Value;
            DateTime EndDate = datePickerEndDate.Value;
            Counsellor objDate = new Counsellor(StartDate, EndDate,this.Text);
            DataTable dt = new DataTable();
            dt = objDate.FilterTaskGridviewDate();
            grdTaskManagementView.DataSource = dt;
            grdTaskManagementView.Show();
        }

        private void pictRefresh_Click(object sender, EventArgs e)
        {
            Counsellor objTask = new Counsellor(this.Text);
            dtRefresh = objTask.ViewTask();
            grdTaskManagementView.DataSource = dtRefresh;
            grdTaskManagementView.Show();
        }
    }
}
