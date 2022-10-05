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
using clsCoOrdinator;
namespace GSTEducationalCRMSoft
{
    public partial class frmEditInventory : Form
    {
        public frmEditInventory()
        {
            InitializeComponent();
        }
        public frmEditInventory(string Category, string ItemName, string Quantity, string Price, string TotalPrice, string VendorName, string VendorAddress, string Bill, string Remark, string ItemId)
        {
            InitializeComponent();
            txtCategory.Text = Category;
            txtItemName.Text = ItemName;
            txtQuantity.Text = Quantity;
            txtPrice.Text = Price;
            txtTotalPrice.Text = TotalPrice;
            txtVendorName.Text = VendorName;
            txtVendorAddress.Text = VendorAddress;
            txtBill.Text = Bill;
            txtRemark.Text = Remark;
            txtItemId.Text = ItemId;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogEditInventory.ShowDialog();
            if (result == DialogResult.OK)
                txtBill.Text = openFileDialogEditInventory.FileName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(txtItemId.Text);
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

            CoOrdinator obj = new CoOrdinator(iname, category, quantity, price, totalP, vendorname, vendoraddress, bill, remark, date, Convert.ToInt32(statusid).ToString(), ItemId);
            obj.UpdateInventory();
            MessageBox.Show("Update Sucessfully");
            this.Close();
        }

        private void frmEditInventory_Load(object sender, EventArgs e)
        {
            CoOrdinator objInventoryStatus = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = objInventoryStatus.GetInventoryStatus();
            cmbbxStatus.ValueMember = "StatusId";
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
