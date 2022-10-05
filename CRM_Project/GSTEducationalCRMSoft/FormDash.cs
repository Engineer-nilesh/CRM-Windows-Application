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
    public partial class FormDash : Form
    {
        public FormDash()
        {
            InitializeComponent();
        }

        private void FormDash_Load(object sender, EventArgs e)
        {
            //Total Student
            CoOrdinator obj = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = obj.TotalStudent();
            lblStudentsCount.Text = dt.Rows[0][0].ToString(); 

            //Total Course
            CoOrdinator obj1 = new CoOrdinator();
            DataTable dt1 = new DataTable();
            dt1 = obj1.TotalCourse();
            lblCoursesCount.Text = dt1.Rows[0][0].ToString();
            
            //Active Batches
            CoOrdinator obj2 = new CoOrdinator();
            DataTable dt2 = new DataTable();
            dt2 = obj2.ActiveBatches();
            lblBatchesCount.Text = dt2.Rows[0][0].ToString();

            CoOrdinator obj3 = new CoOrdinator();
            DataTable dt3 = new DataTable();
            dt3 = obj3.getghrph();
            chart1.DataSource = dt3;
            chart1.Series["No. Of Students"].XValueMember = "BatchName";
            chart1.Series["No. Of Students"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series["No. Of Students"].YValueMembers = "TotalStudent";
            chart1.Series["No. Of Students"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void lblTotalStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
