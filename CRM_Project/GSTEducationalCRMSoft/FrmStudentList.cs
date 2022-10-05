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
    public partial class FrmStudentList : Form
    {
        public FrmStudentList(string batchid)
        {
            InitializeComponent();

            lblBatchId.Text = batchid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            string StudCode = grdStudentsList.Rows[grdStudentsList.CurrentRow.Index].Cells[1].Value.ToString();
           
            FrmStudentInfo obj = new FrmStudentInfo(StudCode);
            obj.Show();
        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            int Bid = Convert.ToInt32(lblBatchId.Text);
            CoOrdinator obj1 = new CoOrdinator(Bid);
            SqlDataReader dr;
            DataTable dtstudent = new DataTable();
            dr = obj1.GetBatchNameStudent();
            DataTable dt1 = new DataTable();
            string[] sc;

            while (dr.Read())
            {
                string studcode = dr["StudCode"].ToString();
                sc = studcode.Split(',');
                for (int i = 0; i < sc.Length; i++)
                {
                    CoOrdinator objstud = new CoOrdinator(sc[i]);
                    dtstudent = objstud.GetStudentName();
                    if (i == 0)
                    {
                        dt1 = dtstudent.Clone();
                    }
                    foreach (DataRow temp in dtstudent.Rows)
                    {
                        dt1.ImportRow(temp);
                    }
                }
            }
            grdStudentsList.DataSource = dt1;
            grdStudentsList.Show();
          


    }
    }
}
