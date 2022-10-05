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
    public partial class frmProfileSetting : Form
    {
        public string StaffCde;
        public string StaffPosition;
        private Action<object> LoadForm;

        public frmProfileSetting()
        {
            InitializeComponent();
        }
        public frmProfileSetting(string Code , string staffp)
        {
            InitializeComponent();
            StaffCde = Code;
            StaffPosition = staffp;
        }

        public frmProfileSetting(string staffPosition)
        {
            InitializeComponent();
            StaffPosition = staffPosition;
        }

        public frmProfileSetting(string Code, string staffp, Action<object> loadForm) : this(Code, staffp)
        {
            StaffCde = Code;
            StaffPosition = staffp;
            LoadForm = loadForm;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new frmEditUser(StaffCde, StaffPosition,LoadForm));
            
            //frmEditUser obj = new frmEditUser(StaffCde, StaffPosition);
            //obj.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            LoadForm(new frmChangePassword(StaffCde));
            //frmChangePassword obj = new frmChangePassword(StaffCde);
            //obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
