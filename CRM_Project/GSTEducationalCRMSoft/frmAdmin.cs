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
    public partial class frmAdmin : Form
    {
        public string StaffCde;
        public string StaffPosition;
        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(string Code,string staffPosition)
        {
            InitializeComponent();
            StaffCde = Code;
            StaffPosition = staffPosition;
        }
        public void LoadForm(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmCreateNewUser());

            //frmCreateNewUser obj = new frmCreateNewUser();
            //obj.Show();

            //foreach (frmCreateNewUser frm in this.MdiChildren)
            //{
            //    if (!frm.Focused)
            //    {
            //        frm.Visible = false;
            //        frm.Dispose();
            //    }
            //}
            //panelbody.Hide();
            //frmCreateNewUser objcreateuser = new frmCreateNewUser();
            //objcreateuser.MdiParent = this;
            //objcreateuser.Show();
        }

        private void profileSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmProfileSetting(StaffCde,StaffPosition, LoadForm));

            //frmProfileSetting obj = new frmProfileSetting(StaffCde, StaffPosition);
            //obj.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
