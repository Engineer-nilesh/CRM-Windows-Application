using clsCounsellor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using clsCoOrdinator;

namespace GSTEducationalCRMSoft
{
    public partial class frmAdmission : Form
    { 
        public string studcode;

        private Action<object> LoadForm;
        public frmAdmission()
        {
            InitializeComponent();
        }

        DataTable dtSearchBox = new DataTable();

        private void frmAdmission_Load(object sender, EventArgs e)
        {
            /************Get Admission**********/
            Counsellor objAdmssion = new Counsellor();
            dtSearchBox = objAdmssion.GetAdmission();
            grdAdmission.DataSource = dtSearchBox;
            grdAdmission.Show();

            

            /***********Get All Course***********/
            Counsellor objCourse = new Counsellor();
            DataTable CourseDt = new DataTable();
            CourseDt = objCourse.GetAllCourse();
            cmbbxAllCourse.ValueMember = "CourseId";
            cmbbxAllCourse.DisplayMember = "CourseName";
            cmbbxAllCourse.DataSource = CourseDt;

            /************Filter*************/
            cmbbxAllCourse.Hide();
            dtStart.Hide();
            dtEnd.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            pictbxSearch2.Hide();
        }

        private void btnFetchRegular_Click(object sender, EventArgs e)
        {
            Counsellor objRegularAdmssion = new Counsellor();
            DataTable dt = new DataTable();
            dt = objRegularAdmssion.GetRegularAdmission();

            grdAdmission.DataSource = dt;
            grdAdmission.Show();
        }

        private void btnFetchDiscount_Click(object sender, EventArgs e)
        {
            Counsellor objDiscountAdmssion = new Counsellor();
            DataTable dt = new DataTable();
            dt = objDiscountAdmssion.GetDiscountAdmission();

            grdAdmission.DataSource = dt;
            grdAdmission.Show();
        }

        private void grdAdmission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                studcode = grdAdmission.Rows[grdAdmission.CurrentRow.Index].Cells[2].Value.ToString();
               
                frmUpdateAdmission objupdate = new frmUpdateAdmission(studcode);
                objupdate.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void pictbxPlus1_Click(object sender, EventArgs e)
        {
            frmNewAdmission objfrmnewadmission = new frmNewAdmission();
            objfrmnewadmission.Show();
        }

        private void btnApplyForLeave_Click(object sender, EventArgs e)
        {
            //LoadForm(new frmNewAdmission());
            frmNewAdmission objnewaddmission = new frmNewAdmission();
            objnewaddmission.Show();
        }

        private void pictbxRefresh2_Click(object sender, EventArgs e)
        {
            Counsellor objAdmssion = new Counsellor();
            dtSearchBox = objAdmssion.GetAdmission();
            grdAdmission.DataSource = dtSearchBox;
            txtSearch.Text = "";
            grdAdmission.Show();
        }

        private void pictbxExel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 2; i < grdAdmission.Columns.Count; i++)
            {
                xcelApp.Cells[1, i] = grdAdmission.Columns[i].HeaderText;
            }

            for (int i = 0; i < grdAdmission.Rows.Count - 1; i++)
            {
                for (int j = 2; j < grdAdmission.Columns.Count; j++)
                {
                    xcelApp.Cells[i + 2, j] = grdAdmission.Rows[i].Cells[j].Value.ToString();
                }
            }
            xcelApp.Visible = true;
            xcelApp.Columns.AutoFit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtSearchBox.DefaultView;
            
            dv.RowFilter = "FullName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR MobileNo Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR EmailId Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Qualification Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR PaymentMode Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR TransactionId Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR CourseIntrested Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR RegistrationFee Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR CourseFees Like '" + txtSearch.Text + "%'";
           
            dv.RowFilter += " OR RegistrationId Like '" + txtSearch.Text + "%'";
            grdAdmission.DataSource = dv;
        }

        public void exportgridtopdf(DataGridView grd, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(12);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 2; i < grdAdmission.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdAdmission.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdAdmission.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 2; j < grdAdmission.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdAdmission.Rows[k].Cells[j].Value.ToString()));
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
            exportgridtopdf(grdAdmission, "Admission");
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxAllCourse.Show();
            dtStart.Show();
            dtEnd.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            pictbxSearch2.Show();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdAdmission.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    string studcode = (row.Cells[2].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(studcode);
                    objdelete.DeleteCandidate();
                    grdAdmission.Rows.Remove(row);
                    i++;
                }
            }
            MessageBox.Show("Deleted Succesfully...!!!");
        }

        private void pictbxSearch2_Click(object sender, EventArgs e)
        {
            string dtSt = dtStart.Value.ToString("yyyy-MM-dd");
            string dtEd = dtEnd.Value.ToString("yyyy-MM-dd");

            Counsellor objSearchAdmission = new Counsellor(cmbbxAllCourse.Text, dtSt, dtEd);
            DataTable dt = new DataTable();
            dt = objSearchAdmission.GetSearchedAdmission();

            grdAdmission.DataSource = dt;
            grdAdmission.Show();
        }

        private void cmbbxAllCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxAllCourse.SelectedValue.ToString());
            Counsellor objCourseView = new Counsellor(cid);
            DataTable dtCourseView = new DataTable();
            dtCourseView = objCourseView.GetAdmissionCoursefilter();
            grdAdmission.DataSource = dtCourseView;
            grdAdmission.Show();
        }
    }
}
