using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsCoOrdinator;
using System.Windows.Forms;

namespace GSTEducationalCRMSoft
{
    public partial class frmViewMore : Form
    {

        public string sc { get; set; }
        public int testid { get; set; }

        public frmViewMore( string id)
        {
            InitializeComponent();

            sc = id;
            
        }
        

        private void frmViewMore_Load(object sender, EventArgs e)
        {
            CoOrdinator objgrd = new CoOrdinator(sc);
            DataTable dt = new DataTable();
            dt = objgrd.ViewMore();
            grdviewmore.DataSource = dt;
            grdviewmore.Show();
        }
    }
}
