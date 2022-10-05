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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace GSTEducationalCRMSoft
{
    public partial class frmFeedbackStudenttoTrainer : Form
    {
        public frmFeedbackStudenttoTrainer()
        {
            InitializeComponent();
        }

        DataTable dtFeedback = new DataTable();

        private void frmFeedbackStudenttoTrainer_Load(object sender, EventArgs e)
        {
            CoOrdinator objcourse = new CoOrdinator();
            DataTable dt = new DataTable();
            dt = objcourse.Get_Course();
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.DataSource = dt;

            /***********Fetch Feedback***************/
            CoOrdinator objFeedback = new CoOrdinator();
            dtFeedback = objFeedback.ViewFeedbackStudentToTrainer();
            grdfeedbackStudtoTrainerView.DataSource = dtFeedback;
            grdfeedbackStudtoTrainerView.Show();

            /*************Filter**************/
            cmbbxBatch.Hide();
            cmbbxCourse.Hide();
            lblBatch.Hide();
            lblCourse.Hide();
        }

        private void cmbbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int courseid = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            CoOrdinator objBatch = new CoOrdinator(courseid);
            DataTable dtBatch = new DataTable();
            dtBatch = objBatch.GetBatchByCourse();
            cmbbxBatch.ValueMember = "BatchId";
            cmbbxBatch.DisplayMember = "BatchName";
            cmbbxBatch.DataSource = dtBatch;
          
        }

        private void cmbbxBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            int bid = Convert.ToInt32(cmbbxBatch.SelectedValue.ToString());
            CoOrdinator objTask = new CoOrdinator(cid, bid);
            DataTable dtt = new DataTable();
            dtt = objTask.GetFeedbackStoTCourseFillter();
            grdfeedbackStudtoTrainerView.DataSource = dtt;
            grdfeedbackStudtoTrainerView.Show();
          
        }

       

        private void grdfeedbackStudtoTrainerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int id = Convert.ToInt32(grdfeedbackStudtoTrainerView.Rows[grdfeedbackStudtoTrainerView.CurrentRow.Index].Cells[2].Value.ToString());
                string studname = grdfeedbackStudtoTrainerView.Rows[grdfeedbackStudtoTrainerView.CurrentRow.Index].Cells[3].Value.ToString();
                string BatchName= grdfeedbackStudtoTrainerView.Rows[grdfeedbackStudtoTrainerView.CurrentRow.Index].Cells[4].Value.ToString();
                string coursename= grdfeedbackStudtoTrainerView.Rows[grdfeedbackStudtoTrainerView.CurrentRow.Index].Cells[5].Value.ToString();
                string tname= grdfeedbackStudtoTrainerView.Rows[grdfeedbackStudtoTrainerView.CurrentRow.Index].Cells[6].Value.ToString();
                frmEditFeedback objfrmEditfeedback = new frmEditFeedback(id,studname,BatchName,coursename,tname);
                objfrmEditfeedback.Show();
            }
        }

        private void pictbxRefresh2_Click(object sender, EventArgs e)
        {
            CoOrdinator objFeedback = new CoOrdinator();
            dtFeedback = objFeedback.ViewFeedbackStudentToTrainer();
            grdfeedbackStudtoTrainerView.DataSource = dtFeedback;
            grdfeedbackStudtoTrainerView.Show();
        }

        private void pictbxExel_Click(object sender, EventArgs e)
        {
            if (grdfeedbackStudtoTrainerView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 2; i < grdfeedbackStudtoTrainerView.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdfeedbackStudtoTrainerView.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdfeedbackStudtoTrainerView.Rows.Count - 1; i++)
                {
                    for (int j = 2; j < grdfeedbackStudtoTrainerView.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdfeedbackStudtoTrainerView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;         
                xcelApp.Columns.AutoFit();         
            }                                       
        }

        public void exportgridtopdf(DataGridView grd, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(8);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 2; i < grdfeedbackStudtoTrainerView.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdfeedbackStudtoTrainerView.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdfeedbackStudtoTrainerView.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 2; j < grdfeedbackStudtoTrainerView.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdfeedbackStudtoTrainerView.Rows[k].Cells[j].Value.ToString()));
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

        private void pictbxPdf_Click(object sender, EventArgs e)
        {
            exportgridtopdf(grdfeedbackStudtoTrainerView, "Feedback Student To Trainer");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtFeedback.DefaultView;
            dv.RowFilter = "StudentName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR TrainerName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Performance Like '" + txtSearch.Text + "%'";
            grdfeedbackStudtoTrainerView.DataSource = dv;
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxBatch.Show();
            cmbbxCourse.Show();
            lblBatch.Show();
            lblCourse.Show();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdfeedbackStudtoTrainerView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int fid = Convert.ToInt32(row.Cells[2].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(fid);
                    objdelete.DeleteFeedback();
                    grdfeedbackStudtoTrainerView.Rows.Remove(row);
                    i++;
                }
            }
            MessageBox.Show(i.ToString(), " Deleted Succesfully...!!!");
        }

        private void btnNewfeedback_Click(object sender, EventArgs e)
        {
            frmAddFeedback objaddfeedback = new frmAddFeedback();
            objaddfeedback.Show();
        }
    }
}
