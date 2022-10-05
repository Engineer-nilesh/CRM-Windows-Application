using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTEducationalCRMSoft
{
    
    public partial class frmCoOrdinator : Form
    {
        public string staffc;
        public string StaffPosition;
        public frmCoOrdinator()
        {
            InitializeComponent();
        }
        public frmCoOrdinator(string sc, string staffPosition)
        {
            InitializeComponent();
            IsMdiContainer = true;
            staffc = sc;
            StaffPosition = staffPosition;
        }
        public void LoadForm(object Form)
        {
            if (this.pnlBody2.Controls.Count > 0)
                this.pnlBody2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlBody2.Controls.Add(f);
            this.pnlBody2.Tag = f;
            f.Show();
        }
        private void taskAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm (new frmTaskManagement(staffc));
            //frmTaskManagement objTaskManagment = new frmTaskManagement(staffc);
            //objTaskManagment.Show();
            //objTaskManagment.MdiParent = this;
        }

        private void leaveManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmLeaveManagement(staffc));
            //frmLeaveManagement objleave = new frmLeaveManagement(staffc);
            //objleave.Show();
            // objleave.MdiParent = this;
        }

        private void trainerToStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmFeedbackTrainertoStudent());
            //frmFeedbackTrainertoStudent objFeedback = new frmFeedbackTrainertoStudent();
            //objFeedback.Show();
        }

        private void studentToTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmFeedbackStudenttoTrainer());
            //frmFeedbackStudenttoTrainer objfeedbackStT=new frmFeedbackStudenttoTrainer();
            //objfeedbackStT.Show();
        }

        private void testManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmTestManagement());
            //frmTestManagement objfrmTestManagement=new frmTestManagement();
            //objfrmTestManagement.Show();
        }

        private void labManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmLabManagement());
            //frmLabManagement objlabManagement=new frmLabManagement();
            //objlabManagement.Show();
        }

        private void batchManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Batchmangement());
            //Batchmangement objbatch = new Batchmangement();
            //objbatch.Show();
        }

        private void testimonialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmTestimonial());
            //frmTestimonial objtesti = new frmTestimonial();
            //objtesti.Show();
        }

        private void changeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmChangeCourse());
            //frmChangeCourse objchange = new frmChangeCourse();
            //objchange.Show();
        }

        private void paymentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPaymentsManagement());
            // frmPaymentsManagement objpayment = new  frmPaymentsManagement();
            //objpayment.Show();
        }

        private void inventoryManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmInventoryManagment());
            //frmInventoryManagment objinevntory = new frmInventoryManagment();
            //objinevntory.Show();
        }

        private void certificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmCertification());
            //frmCertification objceritificate = new frmCertification();
            //objceritificate.Show();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmStudentDetails());
            //FrmStudentDetails objstud = new FrmStudentDetails();
            //objstud.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void profileSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmProfileSetting(staffc,StaffPosition,LoadForm));
            //frmProfileSetting objprofile = new frmProfileSetting(staffc, StaffPosition);
            //objprofile.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new FormDash());
            //FormDash objdashboard = new FormDash();
            //objdashboard.Show();
        }

        private void frmCoOrdinator_Load(object sender, EventArgs e)
        {
            LoadForm(new FormDash());
        }
    }
}
