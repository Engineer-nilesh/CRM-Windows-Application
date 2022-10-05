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
    public partial class frmLabInfo : Form
    {
        public frmLabInfo(string LabName, int CapacityOfLab, int AvailableSystem,string LabId)
        {
            InitializeComponent();
            
            label2.Text =LabName;
            label3.Text = CapacityOfLab.ToString();
            txtAvailableSystem.Text = AvailableSystem.ToString();
            lblLabId.Text = LabId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLabInfo_Load(object sender, EventArgs e)
        {
            string CenterAddress = cmbbxCenter.Text;
            CoOrdinator objCenter = new CoOrdinator(CenterAddress);
            DataTable dtfcn = new DataTable();
            dtfcn = objCenter.GetCenterName ();
            cmbbxCenter.DisplayMember = "CenterAddress";
            cmbbxCenter.DataSource = dtfcn;
        }
       
        

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int AvailableSystem = Convert.ToInt32(txtAvailableSystem.Text);
            int LabId = Convert.ToInt32(lblLabId.Text.ToString());
            CoOrdinator obj = new CoOrdinator(AvailableSystem,LabId);
            obj.UpadateLab();
            MessageBox.Show("UpadateLab");
            this.Close();

        }

        private void lblEditLabInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbbxCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
} 