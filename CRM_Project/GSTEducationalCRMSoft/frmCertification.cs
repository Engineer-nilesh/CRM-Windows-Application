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


namespace GSTEducationalCRMSoft
{
    public partial class frmCertification : Form
    {
        public frmCertification()
        {
            InitializeComponent();
            
        }

        DataTable dtCertification = new DataTable();

        private void frmCertification_Load(object sender, EventArgs e)
        {
            CoOrdinator objcourse = new CoOrdinator();
            DataTable dtcourse = new DataTable();
            dtcourse = objcourse.GetCourse();
            cmbbxCourseName.ValueMember = "CourseId";
            cmbbxCourseName.DisplayMember = "CourseName";
            cmbbxCourseName.DataSource = dtcourse;
            cmbbxCourseName.Show();


            /********* gridview*************************/

            CoOrdinator objCertification = new CoOrdinator();
            dtCertification = objCertification.GetCertificationView();
            grdCertificationView.DataSource = dtCertification;
            grdCertificationView.Show();


            /*********Filter**************/

            cmbbxCourseName.Hide();
            cmbbxStudentName.Hide();
            dateTimePickerDate.Hide();
            lblCourseName.Hide();
            lblDate.Hide();
            lblStudentName.Hide();
            pictureBox2.Hide();
            picbxSearch.Hide();
        }

        private void cmbbxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxCourseName.SelectedValue.ToString());
            CoOrdinator objStudent = new CoOrdinator(cid);
            DataTable dtStudent = new DataTable();
            dtStudent = objStudent.Get_Student_Name();
            cmbbxStudentName.ValueMember = "StudCode";
            cmbbxStudentName.DisplayMember = "StudFullName";
            cmbbxStudentName.DataSource = dtStudent;
            cmbbxStudentName.Show();
           

            CoOrdinator objfilter = new CoOrdinator(cid);
            DataTable dtfilter=new DataTable();
            dtfilter = objfilter.GetCertificationCourseFilter();
            grdCertificationView.DataSource = dtfilter;
            grdCertificationView.Show();
            if (cmbbxCourseName.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxStudentName.Text = "";

            }

        }


        



        private void grdCertificationView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string sc=grdCertificationView.Rows[grdCertificationView.CurrentRow.Index].Cells[5].Value.ToString();
            //frmAddCertificateDetails objaddcertificate=new frmAddCertificateDetails(sc);
            //objaddcertificate.Show();
        }

        private void btnCertificateDetails_Click(object sender, EventArgs e)
        {
            string sc = grdCertificationView.Rows[grdCertificationView.CurrentRow.Index].Cells[5].Value.ToString();
            frmAddCertificateDetailss objAddCertificateDetails = new frmAddCertificateDetailss();
           
            objAddCertificateDetails.Show();
        }

        private void pictbxExcel_Click(object sender, EventArgs e)
        {
            if (grdCertificationView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < grdCertificationView.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdCertificationView.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdCertificationView.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < grdCertificationView.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdCertificationView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();
            }
        }

        private void btnNewTestimonial_Click(object sender, EventArgs e)
        {
            frmAddCertificateDetailss objaddcertificate = new frmAddCertificateDetailss();
            objaddcertificate.Show();
        }

        public void exportgridtopdf(DataGridView grd, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(6);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 0; i < grdCertificationView.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdCertificationView.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdCertificationView.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 0; j < grdCertificationView.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdCertificationView.Rows[k].Cells[j].Value.ToString()));
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
            exportgridtopdf(grdCertificationView, "Certificate");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtCertification.DefaultView;
            dv.RowFilter = " CertificateNo Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR CourseName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR StudentName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR StudCode Like '" + txtSearch.Text + "%'";
            grdCertificationView.DataSource = dv;
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxCourseName.Show();
            cmbbxStudentName.Show();
            dateTimePickerDate.Show();
            lblCourseName.Show();
            lblDate.Show();
            lblStudentName.Show();
            pictureBox2.Show();
            picbxSearch.Show();
        }

        private void cmbbxStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sc = cmbbxStudentName.SelectedValue.ToString();
            CoOrdinator objfiltername = new CoOrdinator(sc);
            DataTable dtfiltername = new DataTable();
            dtfiltername = objfiltername.GetCertificationNameFilter();
            grdCertificationView.DataSource = dtfiltername;
            grdCertificationView.Show();
            if (cmbbxStudentName.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxCourseName.Text = "";

            }
        }

        private void picbxSearch_Click(object sender, EventArgs e)
        {
            DateTime issuedate = dateTimePickerDate.Value;
            CoOrdinator objdate = new CoOrdinator(issuedate);
            DataTable dtdate = new DataTable();
            dtdate = objdate.CertificationFilterDate();
            grdCertificationView.DataSource = dtdate;
            grdCertificationView.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdCertificationView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    string studcode = (row.Cells[5].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(studcode);
                    objdelete.DeleteCertificate();
                    grdCertificationView.Rows.Remove(row);
                    i++;
                }
            }
            MessageBox.Show(i.ToString(), " Deleted Succesfully...!!!");
        }
    }
}
