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
    public partial class frmCreateNewLab : Form
    {
        public frmCreateNewLab()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateLab_Click(object sender, EventArgs e)
        {
           
            int CenterId = Convert.ToInt32(cmbbxCenter.SelectedValue.ToString());
            string LabName = txtLabName.Text;
            int LabCapacity = Convert.ToInt32(txtCapacityOfLab.Text);
            int AvailableSystem = Convert.ToInt32(txtAvailableSystem.Text);
            string CenterAddress = cmbbxCenter.Text;
            //if (cmbbxCenter.Text==null && txtLabName.Text=="" && txtCapacityOfLab.Text==null &&  txtAvailableSystem.Text=="")
                
            {
                CoOrdinator obj = new CoOrdinator(CenterId, LabName, LabCapacity, AvailableSystem);
                obj.SaveLab();
                MessageBox.Show("Save Lab.....!");
                this.Close();
            }
            //else
            //{
              //  MessageBox.Show("Failed Lab.....!");
            //}
        }

        private void frmCreateNewLab_Load(object sender, EventArgs e)
        {
            CoOrdinator objCenter = new CoOrdinator();
            DataTable dtt = new DataTable();
            dtt = objCenter.GetCenterName();
            cmbbxCenter.ValueMember = "CenterId";
            cmbbxCenter.DisplayMember = "CenterAddress";
            cmbbxCenter.DataSource = dtt;
        
        }

        private void lblCenter_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLabName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxCenter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbbxCenter.Text))
            {
                e.Cancel = true;
                cmbbxCenter.Focus();
                errorProvider1.SetError(cmbbxCenter, "Please Enter Select Your Center....!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbbxCenter, null);
            }
        
        }

        private void txtLabName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLabName.Text))
            {
                e.Cancel = true;
                txtLabName.Focus();
                errorProvider2.SetError(txtLabName, "Please Enter Select Your LabName....!");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtLabName, null);
            }
        }

        private void txtCapacityOfLab_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCapacityOfLab.Text))
            {
                e.Cancel = true;
                txtCapacityOfLab.Focus();
                errorProvider3.SetError(txtCapacityOfLab, "Please Enter Select Your LabCapacity....!");

            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtCapacityOfLab, null);
            }
        }

        private void txtAvailableSystem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAvailableSystem.Text))
            {
                e.Cancel = true;
                txtAvailableSystem.Focus();
                errorProvider4.SetError(txtAvailableSystem, "Please Enter Select Your AvailableSystem....!");

            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtAvailableSystem, null);
            }

        }

        private void picboxAddCenterName_Click(object sender, EventArgs e)
        {
            FrmAddCenterName objAddName =new FrmAddCenterName();
            objAddName.Show();
        }
    }
}
