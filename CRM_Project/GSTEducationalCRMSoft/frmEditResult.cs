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
    public partial class frmEditResult : Form
    {
        public string sc { get; set; }
       // public string marks { get; set; }

        public int TestId { get; set; }
        public int CourseId { get; set; }
        public int BatchId { get; set; }

        public frmEditResult()
        {
            InitializeComponent();
            
        }
        public frmEditResult(string examtitle,string course,string batch, string StudFullName, int marks, string id)//, int courseid, int batchid,string StudFullName,int marks, string id)
        {
            InitializeComponent();
            //cmbbxexamname.Text = Convert.ToString(testid);
            
            cmbbxexamname.Text = Convert.ToString(examtitle);
            cmbbxcoursename.Text = Convert.ToString(course);
            cmbbxbatchname.Text = Convert.ToString(batch);

            grdupdateresult.Rows.Add();
            grdupdateresult.Rows[0].Cells[0].Value = StudFullName;
            grdupdateresult.Rows[0].Cells[1].Value = marks;
            //txtbxmrks.Text = Convert.ToString(marks);
            sc = id;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int courseid = Convert.ToInt32(cmbbxcoursename.Text.ToString());
            //int testid = Convert.ToInt32(cmbbxexamname.Text.ToString());
            //int batchid = Convert.ToInt32(cmbbxbatchname.Text.ToString());

            int courseid = Convert.ToInt32(cmbbxcoursename.SelectedIndex.ToString());
            int testid = Convert.ToInt32(cmbbxexamname.SelectedIndex.ToString());
            int batchid = Convert.ToInt32(cmbbxbatchname.SelectedIndex.ToString());

            //int testid = Convert.ToInt32(cmbbxexamname.SelectedValue.ToString());
            //int courseid = Convert.ToInt32(cmbbxcoursename.SelectedValue.ToString());
            //int batchid = Convert.ToInt32(cmbbxbatchname.SelectedValue.ToString());
            string studcode= grdupdateresult.Rows[grdupdateresult.CurrentRow.Index].Cells[0].Value.ToString();
            int marks = Convert.ToInt32(grdupdateresult.Rows[grdupdateresult.CurrentRow.Index].Cells[1].Value.ToString());
            //int marks = Convert.ToInt32(txtbxmrks.Text.ToString());
            CoOrdinator obj = new CoOrdinator(testid,courseid,batchid,studcode,marks);
            obj.EditResult();
            MessageBox.Show("Your data is updated succefully");



        }

        private void frmEditResult_Load(object sender, EventArgs e)
        {


        }

        private void txtbxmrks_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < grdupdateresult.Rows.Count; i++)
            {
                int marks = Convert.ToInt32(grdupdateresult.Rows[i].Cells[1].Value);
                sum = sum + marks;
            }
            txtbxmrks.Text = sum.ToString();
        }
    }
}
