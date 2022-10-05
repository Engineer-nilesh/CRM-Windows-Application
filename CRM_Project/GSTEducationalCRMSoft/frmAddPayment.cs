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
    public partial class AddPayment : Form
    {
        public int bamount { get; set; }
        public string studcode { get; set; }
        public AddPayment(string StudCode,string StudFullName,string CourseName, string TotalFee,int BalanceAmount)
        {
            InitializeComponent();
            studcode = StudCode;
            label1.Text = StudFullName;
            label4.Text = CourseName;
            label6.Text = TotalFee;
         //  lblInvoice.Text = InvoiceNo;
           lblLastBalAmo.Text= BalanceAmount.ToString();
          //  txtpaidA.Text = PaidAmount;
            bamount = BalanceAmount;
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtpaidA_TextChanged(object sender, EventArgs e)
        {
            int PaidAmount = Convert.ToInt32(txtpaidA.Text.ToString());
            //int BalanceAmount = Convert.ToInt32(label9.Text);
            int NewBalanceAmount = 0;
            if (PaidAmount > 1000)
            {
                NewBalanceAmount = bamount - PaidAmount;
                label9.Text = NewBalanceAmount.ToString();
            }
           // else if(PaidAmount>10000)
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int statusid = 2;
            //string StudCode = label2.Text;
            int PaidAmount = Convert.ToInt32(txtpaidA.Text);
            int BalanceAmount = Convert.ToInt32(label9.Text);
            string PaidMode = ccmbbxPayMode.Text;
            DateTime PaidDate = DateTime.Now;// string progress = label3.Text;
            CoOrdinator obj = new CoOrdinator(studcode, PaidAmount, BalanceAmount, PaidMode, PaidDate, statusid);
            obj.UpdatePayment();


            //CoOrdinator objtan = new CoOrdinator();
            //SqlDataReader dr = objtan.GenInvoice();
            //if (dr.Read())
            //{
            //    string TransactionId = dr[0].ToString();
            //    int i = Convert.ToInt32(TransactionId);
            //    i = i + 1;
            //}

                MessageBox.Show("Updated  Successfully.....");
                 this.Close();



            }

            private void ccmbbxPayMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtpaidA_MouseEnter(object sender, EventArgs e)
        {
            //int PaidAmount = Convert.ToInt32(txtpaidA.Text.ToString());
            //int BalanceAmount = Convert.ToInt32(label9.Text);
            //int NewBalanceAmount = 0;
            //NewBalanceAmount = BalanceAmount - PaidAmount;
            //label9.Text = NewBalanceAmount.ToString();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngetreceipt_Click(object sender, EventArgs e)
        {
            frmGetReceipt objgetReceipt = new frmGetReceipt();
            objgetReceipt.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
