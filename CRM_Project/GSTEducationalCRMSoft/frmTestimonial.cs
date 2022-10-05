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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Configuration;

namespace GSTEducationalCRMSoft
{
    public partial class frmTestimonial : Form
    {
        public frmTestimonial()
        {
            InitializeComponent();
        }
        DataTable dtgrid = new DataTable();

        public string Qualification { get; set; }

        public int DesignationId { get; set; }

        public int CompanyId { get; set; }

        public string Package { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string CommentsForRTS { get; set; }

        public string UploadVideo { get; set; }

        public string UploadPDF { get; set; }

        private void frmTestimonial_Load(object sender, EventArgs e)
        {
            /***************GetQualification*********************/
            CoOrdinator objget = new CoOrdinator();
            DataTable dtQ = new DataTable();
            dtQ = objget.GetQualification();
            cmbbxQualification.ValueMember = "TestimonialId";
            cmbbxQualification.DisplayMember = "Qualification";
            cmbbxQualification.DataSource = dtQ;


            /****************GetDesignation**********************/
            CoOrdinator objD = new CoOrdinator();
            DataTable dtD = new DataTable();
            dtD = objD.GetDesignation();
            cmbbxDesignation.ValueMember = "DesignationId";
            cmbbxDesignation.DisplayMember = "DesignationName";
            cmbbxDesignation.DataSource = dtD;


            /****************GetCompany***************************/
            CoOrdinator objC = new CoOrdinator();
            DataTable dtC = new DataTable();
            dtC = objC.GetCompany();
            cmbbxCompany.ValueMember = "CompanyId";
            cmbbxCompany.DisplayMember = "CompanyName";
            cmbbxCompany.DataSource = dtC;

            /*************Fetch Testimonial***************/
            CoOrdinator objtestimonial = new CoOrdinator();
            dtgrid = objtestimonial.FetchTestimonial();
            grdTestimonial.DataSource = dtgrid;
            grdTestimonial.Show();

            //grdTestimonial.Columns["PlacedStudCode"].Visible = false;
            grdTestimonial.Columns["StudCode"].Visible = false;

            cmbbxQualification.Hide();
            cmbbxDesignation.Hide();
            cmbbxCompany.Hide();
            lblCompany.Hide();
            lblDesignation.Hide();
            lblQualification.Hide();
        }

        private void btnNewTestimonial_Click(object sender, EventArgs e)
        {
            frmAddNewTestimonial objnew = new frmAddNewTestimonial();
            objnew.Show();
        }

        private void grdTestimonial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int id1 = Convert.ToInt32(grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[2].Value.ToString());
                string name = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[4].Value.ToString();
                string qualif = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[5].Value.ToString();
                string desig = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[6].Value.ToString();
                string company = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[7].Value.ToString();
                string salary = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[8].Value.ToString();
                string comment = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[10].Value.ToString();
                string vid = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[11].Value.ToString();
                string pdf = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[12].Value.ToString();
                

                frmEditTestimonial objedit = new frmEditTestimonial(id1,name, qualif, desig, company, salary, comment, vid, pdf);
                objedit.Show();
            }

            if(e.ColumnIndex == 11)
            {
                string vid1 = grdTestimonial.Rows[grdTestimonial.CurrentRow.Index].Cells[11].Value.ToString();

                frmVideo objvideo = new frmVideo(vid1);
                objvideo.Show();
            }
        }
        private void cmbbxQualification_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string qualif = cmbbxQualification.Text;
            CoOrdinator objqualif = new CoOrdinator(qualif);
            DataTable dt = new DataTable();
            dt = objqualif.FilterTestimonialQualification();
            grdTestimonial.DataSource = dt;
            grdTestimonial.Show();

            if(cmbbxQualification.SelectedItem == "true")
            {

            }
            else
            {
                cmbbxDesignation.Text = "";
                cmbbxCompany.Text = "";
            }
        }

        private void cmbbxDesignation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int desigid = Convert.ToInt32(cmbbxDesignation.SelectedValue.ToString());
            CoOrdinator objdesig = new CoOrdinator(desigid);
            DataTable dt = new DataTable();
            dt = objdesig.FilterTestimonialDesignation();
            grdTestimonial.DataSource = dt;
            grdTestimonial.Show();

            if(cmbbxDesignation.SelectedItem == "true")
            {

            }
            else
            {
                cmbbxQualification.Text = "";
                cmbbxCompany.Text = "";
            }
        }

        private void cmbbxCompany_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int companyid = Convert.ToInt32(cmbbxCompany.SelectedValue.ToString());
            CoOrdinator objcomp = new CoOrdinator(companyid);
            DataTable dt = new DataTable();
            dt = objcomp.FilterTestimonialCompany();
            grdTestimonial.DataSource = dt;
            grdTestimonial.Show();

            if(cmbbxCompany.SelectedItem == "true")
            {

            }
            else
            {
                cmbbxQualification.Text = "";
                cmbbxDesignation.Text = "";
            }
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxQualification.Show();
            cmbbxDesignation.Show();
            cmbbxCompany.Show();
            lblCompany.Show();
            lblDesignation.Show();
            lblQualification.Show();
        }

        private void pictRefresh_Click(object sender, EventArgs e)
        {
            CoOrdinator objtestimonial = new CoOrdinator();
            DataTable dtgrid = new DataTable();
            dtgrid = objtestimonial.FetchTestimonial();
            grdTestimonial.DataSource = dtgrid;
            grdTestimonial.Show();
        }

        private void pictbxExcel_Click(object sender, EventArgs e)
        {
            if (grdTestimonial.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 2; i < grdTestimonial.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdTestimonial.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdTestimonial.Rows.Count - 1; i++)
                {
                    for (int j = 2; j < grdTestimonial.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdTestimonial.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtgrid.DefaultView;
            dv.RowFilter = "StudentName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Package Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Qualification Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Designation Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Company Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR CommentsForRTS Like '" + txtSearch.Text + "%'";
            grdTestimonial.DataSource = dv;
        }
        public void exportgridtopdf(DataGridView grd, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(10);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth =1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 2; i < grdTestimonial.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdTestimonial.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdTestimonial.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 2; j < grdTestimonial.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdTestimonial.Rows[k].Cells[j].Value.ToString()));
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

        private void pictbxPDF_Click(object sender, EventArgs e)
        {
            exportgridtopdf(grdTestimonial, "test");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdTestimonial.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    string studcode = (row.Cells[2].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(studcode);
                    objdelete.DeleteTestimonial();
                    grdTestimonial.Rows.Remove(row);
                    i++;
                }
            }
            MessageBox.Show(i.ToString(), " Deleted Succesfully...!!!");
        }
    }
}
