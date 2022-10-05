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
using System.Data.SqlClient;


namespace GSTEducationalCRMSoft
{
  
public partial class frmArrangeDemo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QDFG7OL\\SQLEXPRESS;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");

        public frmArrangeDemo()
        {
            InitializeComponent();
        }


        private void frmArrangeDemo_Load(object sender, EventArgs e)
        {
            Counsellor obj = new Counsellor();
            DataTable dt = new DataTable();
            dt = obj.GetDemoCourse();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseName";
            cmbbxCourseName.DataSource = dt;


            /************Get Arrange Demmo************/
            Counsellor objDemo = new Counsellor();
            DataTable dtDemo = new DataTable();
            dtDemo = objDemo.GetArrangeDemoDetails();
            grdArrangeDemoManagement.DataSource = dtDemo;
            grdArrangeDemoManagement.Show();

        }

        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            Counsellor obj = new Counsellor(cid);
            DataTable dtstud = new DataTable();
            dtstud = obj.GetDemoStudent();
         
            dataGridView1.DataSource = dtstud;
            dataGridView1.Show();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int cid = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            bool select = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Selected;

            //string scode = checkedListBox1.Text + '.' + checkedListBox1.Text + '.' + checkedListBox1.Text;
            string scode = null;

            string scode2 = null;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value) == true)
                {

                    {
                        for (int j = 1; j < dataGridView1.Columns.Count; j++)
                        {
                            string scode1 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            if (j == 1)
                            {
                                scode = String.Concat(scode1, ",");
                            }
                            scode2 = String.Concat(scode, scode2);

                        }
                    }
                }

                }
            
            DateTime expecteddate = dateTimePickerDemo.Value;
            Counsellor obj = new Counsellor(cid, scode2, expecteddate);
            obj.SaveDemo();
            MessageBox.Show("Demo Arranged Sucessfully...!!!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdArrangeDemoManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePickerDemo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictbxRefresh2_Click(object sender, EventArgs e)
        {
            Counsellor objDemo = new Counsellor();
            DataTable dtDemo = new DataTable();
            dtDemo = objDemo.GetArrangeDemoDetails();
            grdArrangeDemoManagement.DataSource = dtDemo;
            grdArrangeDemoManagement.Show();
        }
    }
}
