using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using clsCoOrdinator;

namespace GSTEducationalCRMSoft
{
    public partial class frmAddInventarycs : Form
    {
        public frmAddInventarycs()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string iname = txtItemName.Text;
            string category = txtCategory.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int price = Convert.ToInt32(txtPrice.Text);
            int totalP = Convert.ToInt32(txtTotalPrice.Text);
            string vendorname = txtVendorName.Text;
            string vendoraddress = txtVendorAddress.Text;
            string bill = txtBill.Text;
            string remark = txtRemark.Text;
            int statusid = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());
            DateTime date = DateTime.Now;
            CoOrdinator objSaveInventory = new CoOrdinator(iname, category, quantity, price, totalP, vendorname, vendoraddress, bill, remark, date, Convert.ToInt32(statusid).ToString());
            objSaveInventory.AddInventory();
            MessageBox.Show("Save Sucessfully");
            this.Close();
        }

        private void frmAddInventarycs_Load(object sender, EventArgs e)
        {
            int j = 0;
            CoOrdinator obj = new CoOrdinator();
            SqlDataReader dr = obj.GenInventoryCode();
            if (dr.Read())
            {
                string InventoryId = dr[0].ToString();
                j = Convert.ToInt32(InventoryId);
                j = j + 1;
            }
            label2.Text = Convert.ToString(j);

            CoOrdinator objGetInventoryStatus = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = objGetInventoryStatus.GetInventoryStatus();
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.DataSource = dt;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogAddInventory.ShowDialog();
            if (result == DialogResult.OK)
                txtBill.Text = openFileDialogAddInventory.FileName;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int q=Convert.ToInt32(txtQuantity.Text);
            int p=Convert.ToInt32(txtPrice.Text);
            txtTotalPrice.Text = (q * p).ToString();
        }
    }
}
