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
    public partial class frmViewFollowUp : Form
    {
        public frmViewFollowUp(string StudFullName,string studecode)
        {
            InitializeComponent();
            label2.Text = StudFullName;
            label1.Text= studecode;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmViewFollowUp_Load(object sender, EventArgs e)
        {
            string StudCode = label1.Text;
            Counsellor objView = new Counsellor(StudCode);
            DataTable dtt = new DataTable();
            dtt = objView.ViewFollowUp();
            grdViewFollowUp.DataSource = dtt;
            grdViewFollowUp.Show();

        }
    }
}
