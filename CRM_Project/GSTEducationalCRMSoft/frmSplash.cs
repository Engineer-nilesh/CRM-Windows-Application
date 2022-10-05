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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void PrgsbrLoding_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
        }

        private void timerCRM_Tick(object sender, EventArgs e)
        {
            timerCRM.Enabled = true;
            PrgsbrLoding.Increment(5);
            if(PrgsbrLoding.Value == 100)
            {
                timerCRM.Enabled = false;
                frmLogin objlogin = new frmLogin();
                objlogin.Show();
                this.Hide();
            }
        }
    }
}
