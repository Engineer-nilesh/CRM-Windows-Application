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
    public partial class frmViewStudents : Form
    {
       public string sc { get; set; }
        public int testid { get; set; }
        public frmViewStudents(string ExamTitle, string Course, string Batch,int id)
        {
            InitializeComponent();

            lbltitle.Text = ExamTitle;
            lblCourse.Text = Course;
            lblBatch.Text = Batch;
            testid = id;
            
        }

        private void frmViewStudents_Load(object sender, EventArgs e)
        {
           
            
            CoOrdinator objgrd = new CoOrdinator(testid);
            DataTable dt = new DataTable();
            dt = objgrd.ViewStudent();
            grdViewStudent.DataSource = dt;
            grdViewStudent.Show();
        }

        private void grdViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
               string sc = (grdViewStudent.Rows[grdViewStudent.CurrentRow.Index].Cells[4].Value.ToString());
                frmViewMore obj = new frmViewMore(sc);
                obj.Show();
            }


        }
    }
}
