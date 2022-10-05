using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCounsellor;
using iTextSharp.text;
using iTextSharp.text.pdf;
using clsCoOrdinator;
namespace GSTEducationalCRMSoft
{
    public partial class frmEnquiryFollowUp : Form
    {
        private FileStream fileStream;

        public frmEnquiryFollowUp()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void frmEnquiryFollowUp_Load(object sender, EventArgs e)
        {
            Counsellor objStatus = new Counsellor();
            DataTable dtt = new DataTable();
            dtt = objStatus.GetEnquiryFollowUpStatus();
            cmbbxEnquiryStatus.ValueMember = "StatusId";
            cmbbxEnquiryStatus.DisplayMember = "Status";
            cmbbxEnquiryStatus.DataSource = dtt;

            Counsellor obj = new Counsellor();
            dt = obj.GetEnquiry();
            grdEnquiryFollowUp.DataSource = dt;
            grdEnquiryFollowUp.Show();

            lblEnquiryStatus.Hide();
            lblFromDate.Hide();
            lblToDate.Hide();
            cmbbxEnquiryStatus.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            pictbxCalender1.Hide();
            pictbxCalender2.Hide();
            pictbxSearch2.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string StudCode = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[2].Value.ToString();
            if (e.ColumnIndex == 1)
            {

                bool select = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[1].Selected;


                string StudFullName = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[4].Value.ToString();
                String MobileNumber = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[5].Value.ToString();
                string StaffName = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[8].Value.ToString();

                AddFollowUp objaddfolloup = new AddFollowUp(StudFullName, MobileNumber, StudCode, StaffName);
                objaddfolloup.Show();



                //AddFollowUp obj = new AddFollowUp(StudFullName, MobileNumber, StudCode, EnquiryStaffName);
                //obj.Show();
            }


            //string EnquiryStatus = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[6].Value.ToString();
            //if (Select == true)
            //{
            //    if (EnquiryStatus == "Own")
            //    {
            //        MessageBox.Show("Only Own Student Process Ahead....!! ");
            //    }

            //else
            //{

            //    AddFollowUp obj = new AddFollowUp(StudFullName, MobileNumber, StudCode, EnquiryStaffName);
            //    obj.Show();
            //}


            //else if (e.ColumnIndex == 2)
            //{
            //    bool select = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[2].Selected;
            //    string StudFullName = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[3].Value.ToString();
            //    frmViewFollowUp objView = new frmViewFollowUp(StudFullName, StudCode);
            //    objView.Show();
            //}

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SId = Convert.ToInt32(cmbbxEnquiryStatus.SelectedValue.ToString());
            Counsellor obj = new Counsellor(SId);
            DataTable dtstatus = new DataTable();
            dtstatus = obj.FilterEnquiryStatus();
            grdEnquiryFollowUp.DataSource = dtstatus;
            grdEnquiryFollowUp.Show();


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFromDate_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblEnquiryStatus_Click(object sender, EventArgs e)
        {

        }

        private void pictbxMenu_Click(object sender, EventArgs e)
        {

        }

        private void pictbxDelete_Click(object sender, EventArgs e)
        {

        }

        private void pictbxPdf_Click(object sender, EventArgs e)
        {

        }




        private void lblToDate_Click(object sender, EventArgs e)
        {

        }

        private void pictbxSearch2_Click(object sender, EventArgs e)
        {
            DateTime StartDate = dateTimePicker1.Value;
            DateTime EndDate = dateTimePicker2.Value;
            Counsellor objDate = new Counsellor(StartDate, EndDate);
            DataTable dtDate = new DataTable();
            dtDate = objDate.FilterGridviewDate();
            grdEnquiryFollowUp.DataSource = dtDate;
            grdEnquiryFollowUp.Show();
        }

        private void pictbxRefresh2_Click(object sender, EventArgs e)
        {
            //this.Update();

            Counsellor obj = new Counsellor();

            dt = obj.GetEnquiry();
            grdEnquiryFollowUp.DataSource = dt;
            grdEnquiryFollowUp.Show();
        }

        private void pictbxExel_Click(object sender, EventArgs e)
        {

            if (grdEnquiryFollowUp.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 3; i < grdEnquiryFollowUp.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdEnquiryFollowUp.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdEnquiryFollowUp.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < grdEnquiryFollowUp.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdEnquiryFollowUp.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = " FullName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR MobileNo Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Email_Id Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR EnquiryId Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Qualification Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR IntrestedCourse Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR EnquirySource Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR EnquiryStatus Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Comments Like '" + txtSearch.Text + "%'";
            grdEnquiryFollowUp.DataSource = dv;
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
            for (int i = 2; i < grdEnquiryFollowUp.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdEnquiryFollowUp.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdEnquiryFollowUp.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 2; j < grdEnquiryFollowUp.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdEnquiryFollowUp.Rows[k].Cells[j].Value.ToString()));
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

        private void pictureBoxpdff_Click(object sender, EventArgs e)
        {
            //exportgridtopdf(grdEnquiryFollowUp, "test");
        }

        private void btnConvertToPDF_Click(object sender, EventArgs e)
        {
            //exportgridtopdf(grdEnquiryFollowUp, "test");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            exportgridtopdf(grdEnquiryFollowUp, "test");
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Show();
            dateTimePicker2.Show();
            cmbbxEnquiryStatus.Show();
            pictbxCalender1.Show();
            pictbxCalender2.Show();
            lblEnquiryStatus.Show();
            lblFromDate.Show();
            lblToDate.Show();
            pictbxSearch2.Show();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdEnquiryFollowUp.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    string studcode = (row.Cells[3].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(studcode);
                    objdelete.DeleteCandidate();
                    grdEnquiryFollowUp.Rows.Remove(row);
                    i++;
                }
            }
            MessageBox.Show("Deleted Succesfully...!!!");
        }

        private void btnMoveToAdmission_Click(object sender, EventArgs e)
        {
            int temp = 0;
            string StudCode = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[2].Value.ToString();
            string Status = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[10].Value.ToString();

            foreach (DataGridViewRow row in grdEnquiryFollowUp.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    temp++;
                }
            }

            if (grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[0].Selected == true)
            {
                if (temp > 1)
                {
                    MessageBox.Show("Select Only One.....!!!");
                }
                else if (Status == "Own")
                {

                    frmNewAdmission objNewAdmission = new frmNewAdmission(StudCode);
                    objNewAdmission.Show();

                }
                else
                {

                    MessageBox.Show("Candidate Status is not Own....!!");
                }
            }

            else
            {
                MessageBox.Show("Please Select Candidate");
            }


            //if (grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[0].Selected == true)
            //{
            //    string StudCode = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[8].Value.ToString();
            //    string EnquiryStatus = grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[6].Value.ToString();
            //    if (EnquiryStatus=="Own")
            //    {
            //        MessageBox.Show("Only Own Student Process Ahead....!! ");
            //    }
            //    else if(grdEnquiryFollowUp.Rows[grdEnquiryFollowUp.CurrentRow.Index].Cells[0].Selected == true)
            //    {
            //        frmNewAdmission objNewAdmission = new frmNewAdmission(StudCode);
            //       objNewAdmission.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Select Candidate");
            //    }
        }
    }
}

