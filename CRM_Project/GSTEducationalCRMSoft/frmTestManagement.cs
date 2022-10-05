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
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GSTEducationalCRMSoft
{
    public partial class frmTestManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SWAPNIL;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");

        public frmTestManagement()
        {
            InitializeComponent();
        }
 
        DataTable dtTest = new DataTable();
        private void cmbbxTestCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTestManagement_Load(object sender, EventArgs e)
        {
            CoOrdinator obj = new CoOrdinator();
            dtTest = obj.ViewTest();
            grdTestManagement.DataSource = dtTest;
            grdTestManagement.Show();

            btnExamResult.Hide();


            /************Filter************/
            cmbbxBatchName.Hide();
            cmbbxExamDate.Hide();
            cmbbxExamTitle.Hide();
            cmbbxLab.Hide();
            cmbbxTestCourse.Hide();
            cmbbxTestDuration.Hide();
            cmbbxTotalMarks.Hide();
            cmbbxTrainer.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
        }

        private void cmbbxExamTitle_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbbxExamTitle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int lid = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objid = new CoOrdinator(lid);
            DataTable dtid = new DataTable();
            dtid = objid.TestIdFilter();
            grdTestManagement.DataSource = dtid;
            grdTestManagement.Show();

            int id = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objCourse = new CoOrdinator(id);
            DataTable dtCourse = new DataTable();
            dtCourse = objCourse.GetExamCourse();
            cmbbxTestCourse.ValueMember = "CourseId";
            cmbbxTestCourse.DisplayMember = "CourseName";
            cmbbxTestCourse.DataSource = dtCourse;
            cmbbxTestCourse.Show();


            int id1 = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objBatch = new CoOrdinator(id1);
            DataTable dtBatch = new DataTable();
            dtBatch = objBatch.GetExamBatch();
            cmbbxBatchName.ValueMember = "BatchId";
            cmbbxBatchName.DisplayMember = "BatchName";
            cmbbxBatchName.DataSource = dtBatch;
            cmbbxBatchName.Show();

            int id2 = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objTrainer = new CoOrdinator(id2);
            DataTable dtTrainer = new DataTable();
            dtTrainer = objTrainer.GetExamTrainer();
            cmbbxTrainer.ValueMember = "Staffcode";
            cmbbxTrainer.DisplayMember = "StaffName";
            cmbbxTrainer.DataSource = dtTrainer;
            cmbbxTrainer.Show();

            int id3 = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objLab = new CoOrdinator(id3);
            DataTable dtLab = new DataTable();
            dtLab = objLab.GetExamLab();
            cmbbxLab.ValueMember = "LabId";
            cmbbxLab.DisplayMember = "LabName";
            cmbbxLab.DataSource = dtLab;
            cmbbxLab.Show();

            int id4 = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objDuration = new CoOrdinator(id4);
            DataTable dtDuration = new DataTable();
            dtDuration = objDuration.GetExamDuration();
            cmbbxTestDuration.ValueMember = "TestId";
            cmbbxTestDuration.DisplayMember = "Duration";
            cmbbxTestDuration.DataSource = dtDuration;
            cmbbxTestDuration.Show();

            int id5 = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objMarks = new CoOrdinator(id5);
            DataTable dtMarks = new DataTable();
            dtMarks = objMarks.GetExamMarks();
            cmbbxTotalMarks.ValueMember = "TestId";
            cmbbxTotalMarks.DisplayMember = "MaximumMarks";
            cmbbxTotalMarks.DataSource = dtMarks;
            cmbbxTotalMarks.Show();


            int idd = Convert.ToInt32(cmbbxExamTitle.SelectedValue.ToString());
            CoOrdinator objEDate = new CoOrdinator(idd);
            DataTable dtEDate = new DataTable();
            dtEDate = objEDate.GetExamViewDate();
            cmbbxExamDate.ValueMember = "TestId";
            cmbbxExamDate.DisplayMember = "TestDate";
            cmbbxExamDate.DataSource = dtEDate;
            cmbbxExamDate.Show();

        }

        private void grdTestManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool select = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[1].Selected;
                string testid = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[2].Value.ToString();
                string testname = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[3].Value.ToString();
                string cname = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[5].Value.ToString();
                string bname = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[6].Value.ToString();
                string tname = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[11].Value.ToString();
                string lname = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[10].Value.ToString();
                string sname = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[12].Value.ToString();
                string stime = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[8].Value.ToString();
                string duration = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[9].Value.ToString();
                string sfile = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[13].Value.ToString();
                string marks = grdTestManagement.Rows[grdTestManagement.CurrentRow.Index].Cells[7].Value.ToString();
                frmEditTest obj = new frmEditTest(testid, testname, cname, bname, tname,marks, lname, sname, stime, duration, sfile);
                obj.Show();

            }
        }

        private void pictbxPlus1_Click(object sender, EventArgs e)
        {
            frmAddNewTest objNewTest = new frmAddNewTest();
            objNewTest.Show();
        }

        private void btnApplyForLeave_Click(object sender, EventArgs e)
        {
            frmAddNewTest objnew = new frmAddNewTest();
            objnew.Show();
        }

        private void pictbxExel_Click(object sender, EventArgs e)
        {
            if (grdTestManagement.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < grdTestManagement.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdTestManagement.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdTestManagement.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < grdTestManagement.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdTestManagement.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();

            }
        }
        public void exportgridtopdf(DataGridView grd, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(11);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 1; i < grdTestManagement.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdTestManagement.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdTestManagement.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 1; j < grdTestManagement.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdTestManagement.Rows[k].Cells[j].Value.ToString()));
                }
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtTest.DefaultView;         
            dv.RowFilter = " ExamTitle Like '" + txtSearch.Text + "%'";            
            dv.RowFilter += " OR CourseName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR BatchName Like '" + txtSearch.Text + "%'";          
            dv.RowFilter += " OR Status Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR TrainerId Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR LabName Like '" + txtSearch.Text + "%'";           
            grdTestManagement.DataSource = dv;
        }

        private void pictbxPdf_Click(object sender, EventArgs e)
        {
            exportgridtopdf(grdTestManagement, "Test Management");
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxBatchName.Show();
            cmbbxExamDate.Show();
            cmbbxExamTitle.Show();
            cmbbxLab.Show();
            cmbbxTestCourse.Show();
            cmbbxTestDuration.Show();
            cmbbxTotalMarks.Show();
            cmbbxTrainer.Show();
            CoOrdinator objExam = new CoOrdinator();
            DataTable dtExam = new DataTable();
            dtExam = objExam.GetExamTitle();
            cmbbxExamTitle.ValueMember = "TestId";
            cmbbxExamTitle.DisplayMember = "TestName";
            cmbbxExamTitle.DataSource = dtExam;
            cmbbxExamTitle.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdTestManagement.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int testid = Convert.ToInt32(row.Cells[2].Value);
                    CoOrdinator objdelete = new CoOrdinator(testid);
                    objdelete.DeleteTest();
                    grdTestManagement.Rows.Remove(row);
                    i++;
                }
            }
            MessageBox.Show("Test Delete Succesfully...!!!");
        }

        private void pictbxRefresh2_Click(object sender, EventArgs e)
        {
            CoOrdinator obj = new CoOrdinator();
            dtTest = obj.ViewTest();
            grdTestManagement.DataSource = dtTest;
            grdTestManagement.Show();
        }

        private void btnMoveToAdmission_Click(object sender, EventArgs e)
        {
            frmExamResult objExam = new frmExamResult();
            objExam.Show();
        }
    }
}
