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
    public partial class ViewPaymentDetails : Form
    {
        public ViewPaymentDetails(string StudCode,string StudFullName)
        {
            InitializeComponent();
            label1.Text = StudCode;
            label2.Text = StudFullName;
        }

        public string TranstactionId { get; set; }

        string randomcode;

        private void ViewPaymentDetails_Load(object sender, EventArgs e)
        {
                string StudCode = label1.Text;
                CoOrdinator objView = new CoOrdinator(StudCode);
                DataTable dtt = new DataTable();
                dtt = objView.ViewPaymentDetails();
                grdpaymentDetails.DataSource = dtt;
                grdpaymentDetails.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
