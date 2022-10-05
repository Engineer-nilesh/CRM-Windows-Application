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
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GSTEducationalCRMSoft
{
    public partial class Batchmangement : Form
    {
        public Batchmangement()
        {
            InitializeComponent();
        }

        DataTable dtgrid = new DataTable();

        private void Bachmangement_Load(object sender, EventArgs e)
        {
            CoOrdinator obj1 = new CoOrdinator();
            DataTable dtF = new DataTable();
            dtF = obj1.FilterTrainer();
            cmbbxtrainername.ValueMember = "StaffCode";
            cmbbxtrainername.DisplayMember = "StaffName";
            cmbbxtrainername.DataSource = dtF;

            CoOrdinator obj2 = new CoOrdinator();
            DataTable dtC = new DataTable();
            dtC = obj2.FilterCourse();
            cmbbxcourse.ValueMember = "CourseId";
            cmbbxcourse.DisplayMember = "CourseName";
            cmbbxcourse.DataSource = dtC;

            CoOrdinator obj3 = new CoOrdinator();
            DataTable dtB = new DataTable();
            dtB = obj3.FilterBatch();
            cmbbxbatchname.ValueMember = "BatchId";
            cmbbxbatchname.DisplayMember = "BatchName";
            cmbbxbatchname.DataSource = dtB;
            CoOrdinator objgridview = new CoOrdinator();
            dtgrid = objgridview.BatchGridview();
            grdBatchManagement.Show();
            grdBatchManagement.Columns[8].Visible=false;
            grdBatchManagement.Columns[12].Visible = false;


            /******************Filter********************/
            cmbbxbatchname.Hide();
            cmbbxcourse.Hide();
            cmbbxtrainername.Hide();
            lblbatchname.Hide();
            lblcourse.Hide();
            lbltrainername.Hide();
        }

        private void cmbbxtrainername_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tid = (cmbbxtrainername.SelectedValue.ToString());
            CoOrdinator objT = new CoOrdinator(Tid);
            DataTable dtTrainer = new DataTable();
            dtTrainer = objT.FilterTrainerName();
            grdBatchManagement.DataSource = dtTrainer;
            grdBatchManagement.Show();

            if (cmbbxtrainername.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxbatchname.Text = "";
                cmbbxcourse.Text = "";
            }


        }

        private void cmbbxcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Cid = Convert.ToInt32(cmbbxcourse.SelectedValue.ToString());
            CoOrdinator objC = new CoOrdinator(Cid);
            DataTable dtCourse = new DataTable();
            dtCourse = objC.FilterCourseName();
            grdBatchManagement.DataSource = dtCourse;
            grdBatchManagement.Show();

            if (cmbbxcourse.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxbatchname.Text = "";
                cmbbxtrainername.Text = "";
            }

        }

        private void cmbbxbatchname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Bid = Convert.ToInt32(cmbbxbatchname.SelectedValue.ToString());
            CoOrdinator objB = new CoOrdinator(Bid);
            DataTable dtBatch = new DataTable();
            dtBatch = objB.FilterBatchName();
            grdBatchManagement.DataSource = dtBatch;
            grdBatchManagement.Show();

            if (cmbbxbatchname.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxcourse.Text = "";
                cmbbxtrainername.Text = "";
            }

        }

        private void grdBatchManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == 1)
            {
                string BatchName = grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[4].Value.ToString();
                int Batchid =Convert.ToInt32( grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[8].Value.ToString());
                int c = Convert.ToInt32(grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[12].Value.ToString());
                string cname = (grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[3].Value.ToString());

                SqlDataReader dr;
                string StudCode = null;
                CoOrdinator objStudCode = new CoOrdinator(Batchid);
                dr = objStudCode.GetBatchName();
                string NoOfStudent1 = null ;
                if (dr.Read())
                {
                    StudCode = dr["StudCode"].ToString();
                    NoOfStudent1 = dr["NoOfStudent"].ToString();
                }
                int no1 = Convert.ToInt32(NoOfStudent1);

                TransferStudent objtransferstudent = new TransferStudent(BatchName, Batchid,StudCode,no1,cname,c);
                objtransferstudent.Show();
            }
            else if (e.ColumnIndex == 2)
            {

                CoOrdinator obj = new CoOrdinator();
                SqlDataReader dr;
                dr = obj.GetBatchDetails();

                int Batchid =Convert.ToInt32(grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[8].Value.ToString());
                string Tname = grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[7].Value.ToString();
                string cname = grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[3].Value.ToString();
                string BName = grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[4].Value.ToString();
               int cid =Convert.ToInt32(grdBatchManagement.Rows[grdBatchManagement.CurrentRow.Index].Cells[12].Value.ToString());

                ViewBatchDetails objView = new ViewBatchDetails(Tname, cname, BName, Batchid,cid);
                objView.Show();
            }
        }

        private void grdBatchManagement_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void pictbxExcel_Click(object sender, EventArgs e)
        {

        }

        private void pictbxPDF_Click(object sender, EventArgs e)
        {

        }

        private void pictRefresh_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTestimonial_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBatch_Click(object sender, EventArgs e)
        {
            FormNewBatch objnewbatch = new FormNewBatch();
            objnewbatch.Show();
        }

        private void btnFilters_Click_1(object sender, EventArgs e)
        {
          



            cmbbxbatchname.Show();
            cmbbxcourse.Show();
            cmbbxtrainername.Show();
            lblbatchname.Show();
            lblcourse.Show();
            lbltrainername.Show();
        }

        private void pictRefresh_Click_1(object sender, EventArgs e)
        {
            CoOrdinator objgridview = new CoOrdinator();
            dtgrid = objgridview.BatchGridview();
            grdBatchManagement.DataSource = dtgrid;
            grdBatchManagement.Show();
        }

        private void pictbxExcel_Click_1(object sender, EventArgs e)
        {
            if (grdBatchManagement.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 3; i < grdBatchManagement.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdBatchManagement.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdBatchManagement.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < grdBatchManagement.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdBatchManagement.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();
            }
        }
        public void exportgridtopdf(DataGridView grd, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(9);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 3; i < grdBatchManagement.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdBatchManagement.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdBatchManagement.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 3; j < grdBatchManagement.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdBatchManagement.Rows[k].Cells[j].Value.ToString()));
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

        private void pictbxPDF_Click_1(object sender, EventArgs e)
        {
            exportgridtopdf(grdBatchManagement, "Batch Management");
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = dtgrid.DefaultView;
            dv.RowFilter = "LabName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Status Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR CourseName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR BatchName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR BatchTime Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR StaffName Like '" + txtSearch.Text + "%'";

            grdBatchManagement.DataSource = dv;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdBatchManagement.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int bid = Convert.ToInt32(row.Cells[8].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(bid);
                    objdelete.DeleteBatch();
                    grdBatchManagement.Rows.Remove(row);
                    i++;
                }
            }
            MessageBox.Show(i.ToString(), " Deleted Succesfully...!!!");
        }
    }
}
