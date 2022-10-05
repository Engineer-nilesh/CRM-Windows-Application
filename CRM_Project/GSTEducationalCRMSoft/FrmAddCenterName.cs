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

namespace GSTEducationalCRMSoft
{
    public partial class FrmAddCenterName : Form
    {
        public FrmAddCenterName()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string AddCenterAddress = txtCenterAddress.Text;
            CoOrdinator obj = new CoOrdinator(txtCenterAddress.Text);
            obj.InsertCenterAddress();
            MessageBox.Show("Center Saved sucessfully...");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCenterAddress.Clear();
        }

        private void lblCenterName_Click(object sender, EventArgs e)
        {

        }

        private void txtCenterName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmChangeCenterName_Load(object sender, EventArgs e)
        {

        }

        private void lblAddCenterAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
