using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsCounsellor;
using clsAdmin;
using clsCoOrdinator;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace GSTEducationalCRMSoft
{
    public partial class frmEnquiryManagement : Form
    {
        string StaffName { get; set; }

        public frmEnquiryManagement(string sc)
        {
            InitializeComponent();
            StaffName = sc;
            Counsellor objs = new Counsellor(StaffName);
            SqlDataReader staffname = objs.GetStaffName();
            staffname.Read();
            if (staffname.HasRows)
            {
                lblstaff.Text = staffname["StaffName"].ToString();
            }
        }

        DataTable dtEnquiry = new DataTable();

        private void grdEnquiryManagementView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmEnquiryManagement_Load(object sender, EventArgs e)
        {
            Counsellor objcourse = new Counsellor();
            DataTable dtcourse = new DataTable();
            dtcourse = objcourse.GetCourseIntrested();
            cmbbxInterestedCourse.ValueMember = "CourseId";
            cmbbxInterestedCourse.DisplayMember = "CourseName";
            cmbbxInterestedCourse.DataSource = dtcourse;
            cmbbxInterestedCourse.Show();

            


            /********* Status *************************/

            Counsellor objStatus = new Counsellor();
            DataTable dtStatus = new DataTable();
            dtStatus = objStatus.GetEnquiryStatus();
            cmbbxEnquiryStatus.ValueMember = "StatusId";
            cmbbxEnquiryStatus.DisplayMember = "Status";
            cmbbxEnquiryStatus.DataSource = dtStatus;
           // cmbbxEnquiryStatus.Show();
            /********* EnquirySource *************************/

            Counsellor objEnquirySource = new Counsellor();
            DataTable dtEnquirySource = new DataTable();
            dtEnquirySource = objEnquirySource.GetEnquirySource();
            cmbbxEnquirySource.ValueMember = "EnquirySourceId";
            cmbbxEnquirySource.DisplayMember = "EnquirySourceName";
            cmbbxEnquirySource.DataSource = dtEnquirySource;
            //cmbbxEnquirySource.Show();


            /********* Qualification *************************/

            Counsellor objQualification = new Counsellor();
            DataTable dtQualification = new DataTable();
            dtQualification = objQualification.GetGraduation();
            cmbbxQualification.ValueMember = "GradId";
            cmbbxQualification.DisplayMember = "GradName";
            cmbbxQualification.DataSource = dtQualification;
            //cmbbxQualification.Show();

            ///********* FromDate *************************/


            //Counsellor objFromDate = new Counsellor();
            //DataTable dtFromDate = new DataTable();
            //dtFromDate = objFromDate.GetFromDate();
            ////DateTimePickerFromDate.ValueMember = FromDate;
            ////DateTimePickerFromDate.DisplayMember = FromDate;
            //DateTimePickerFromDate.DataSource = dtFromDate;
            //DateTimePickerFromDate.Show();

            /********* ToDate *************************/
            /********* gridview*************************/

            Counsellor objEnquiry = new Counsellor();
            
            dtEnquiry = objEnquiry.GetEnquiry();
            grdEnquiryManagementView.DataSource = dtEnquiry;
            grdEnquiryManagementView.Show();
            grdEnquiryManagementView.Rows[0].Selected = false;


            /***********Filter*************/
            lblInterestedCourse.Hide();
            lblQualification.Hide();
            lblEnquiryStatus.Hide();
            lblEnquirySource.Hide();
            lblToDate.Hide();
            lblFromDate.Hide();
            cmbbxInterestedCourse.Hide();
            cmbbxQualification.Hide();
            cmbbxEnquiryStatus.Hide();
            cmbbxEnquirySource.Hide();
            DateTimePickerFromDate.Hide();
            DateTimePickerToDate.Hide();
            pictbxSearch2.Hide();
            lblstaff.Hide();
        }


        

        public void exportgridtopdf(DataGridView grd,string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(11);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 3; i < grdEnquiryManagementView.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdEnquiryManagementView.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdEnquiryManagementView.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 3; j < grdEnquiryManagementView.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdEnquiryManagementView.Rows[k].Cells[j].Value.ToString()));
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

        

        private void cmbbxInterestedCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cmbbxInterestedCourse.SelectedValue.ToString());
            Counsellor objStatus = new Counsellor(cid);
            DataTable dtStatus = new DataTable();
            dtStatus = objStatus.GetEnquiryCourseFilter();
            grdEnquiryManagementView.DataSource = dtStatus;
            grdEnquiryManagementView.Show();
            if (cmbbxInterestedCourse.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxEnquiryStatus.Text = "";
                cmbbxEnquirySource.Text = "";
                cmbbxQualification.Text = "";
            }

        }

        private void grdEnquiryManagementView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string StudFullName = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[4].Value.ToString();
                String MobileNumber = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[5].Value.ToString();
                string email = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[6].Value.ToString();
                string StudCode = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[3].Value.ToString();
                frmEditNewEnquiry objEditEnquiry = new frmEditNewEnquiry(StudFullName, MobileNumber, email, StudCode);
                objEditEnquiry.Show();
            }
            if (e.ColumnIndex == 2)
            {
                string StudCode = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[3].Value.ToString();
                string StudFullName = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[4].Value.ToString();
                String MobileNumber = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[5].Value.ToString();
                string StaffName = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[8].Value.ToString();

                AddFollowUp objaddfolloup = new AddFollowUp(StudFullName, MobileNumber, StudCode,StaffName);
                objaddfolloup.Show();


            }
        }

        private void cmbbxEnquiryStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int Statusid = Convert.ToInt32(cmbbxEnquiryStatus.SelectedValue.ToString());
            Counsellor objStatus = new Counsellor(Statusid);
            DataTable dtStatus = new DataTable();
            dtStatus = objStatus.GetEnquiryStatusFilter();
            grdEnquiryManagementView.DataSource = dtStatus;
            grdEnquiryManagementView.Show();
            if (cmbbxEnquiryStatus.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxInterestedCourse.Text = "";
                cmbbxEnquirySource.Text = "";
                cmbbxQualification.Text = "";
            }
        }

        private void cmbbxQualification_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int Qid = Convert.ToInt32(cmbbxQualification.SelectedValue.ToString());
            Counsellor objStatus = new Counsellor(Qid);
            DataTable dtStatus = new DataTable();
            dtStatus = objStatus.GetEnquiryQualificationFilter();
            grdEnquiryManagementView.DataSource = dtStatus;
            grdEnquiryManagementView.Show();
            if (cmbbxQualification.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxEnquiryStatus.Text = "";
                cmbbxEnquirySource.Text = "";
                cmbbxInterestedCourse.Text = "";
            }
        }

        private void cmbbxEnquirySource_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int Eid = Convert.ToInt32(cmbbxEnquirySource.SelectedValue.ToString());
            Counsellor objStatus = new Counsellor(Eid);
            DataTable dtStatus = new DataTable();
            dtStatus = objStatus.GetEnquirySourceFilter();
            grdEnquiryManagementView.DataSource = dtStatus;
            grdEnquiryManagementView.Show();
            if (cmbbxEnquirySource.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxEnquiryStatus.Text = "";
                cmbbxInterestedCourse.Text = "";
                cmbbxQualification.Text = "";
            }
        }

        private void btnMoveToAdmission_Click_1(object sender, EventArgs e)
        {
            int temp = 0;
            string StudCode = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[3].Value.ToString();
            string EnquiryStatus = grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[11].Value.ToString();
            foreach (DataGridViewRow row in grdEnquiryManagementView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    temp++;
                }
            }

            if (grdEnquiryManagementView.Rows[grdEnquiryManagementView.CurrentRow.Index].Cells[0].Selected == true)
            { 
                if(temp>1)
                {
                    MessageBox.Show("Select Only One.....!!!");
                }
              else if (EnquiryStatus == "Own")
                 
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
        }

        private void btnApplyForLeave_Click_1(object sender, EventArgs e)
        {
            frmNewEnquiry objnewenquiry = new frmNewEnquiry(StaffName);
            objnewenquiry.Show();
        }

        private void btnFilters_Click_1(object sender, EventArgs e)
        {
            pictbxSearch2.Show();
            lblInterestedCourse.Show();
            lblEnquirySource.Show();
            lblQualification.Show();
            lblEnquiryStatus.Show();
            lblToDate.Show();
            lblFromDate.Show();
            cmbbxInterestedCourse.Show();
            cmbbxQualification.Show();
            cmbbxEnquiryStatus.Show();
            cmbbxEnquirySource.Show();
            DateTimePickerFromDate.Show();
            DateTimePickerToDate.Show();
        }

        private void pictbxRefresh2_Click_1(object sender, EventArgs e)
        {
            Counsellor objEnquiry = new Counsellor();
            dtEnquiry = objEnquiry.GetEnquiry();
            grdEnquiryManagementView.DataSource = dtEnquiry;
            grdEnquiryManagementView.Show();

        }

        private void pictbxExel_Click_1(object sender, EventArgs e)
        {
            if (grdEnquiryManagementView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 2; i < grdEnquiryManagementView.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdEnquiryManagementView.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdEnquiryManagementView.Rows.Count - 1; i++)
                {
                    for (int j = 2; j < grdEnquiryManagementView.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdEnquiryManagementView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();
            }
        }

        private void btnDelet_Click_1(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdEnquiryManagementView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    string studcode = (row.Cells[3].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(studcode);
                    objdelete.DeleteCandidate();
                    grdEnquiryManagementView.Rows.Remove(row);
                    i++;
                }
            }
            MessageBox.Show(i.ToString(), " Deleted Succesfully...!!!");

        }

        private void pictbxPdf_Click_1(object sender, EventArgs e)
        {
            exportgridtopdf(grdEnquiryManagementView, "Enquiry Management");

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = dtEnquiry.DefaultView;
            dv.RowFilter = " FullName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR MobileNo Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Email_Id Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR EnquiryId Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Qualification Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR IntrestedCourse Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR EnquirySource Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR EnquiryStatus Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Comments Like '" + txtSearch.Text + "%'";
            grdEnquiryManagementView.DataSource = dv;
        }

        private void pictbxSearch2_Click(object sender, EventArgs e)
        {
            DateTime FromDate = DateTimePickerFromDate.Value;
            DateTime ToDate = DateTimePickerToDate.Value;
            Counsellor objDate = new Counsellor(FromDate, ToDate);
            DataTable dtDate = new DataTable();
            dtDate = objDate.FilterManagementGridviewDate();
            grdEnquiryManagementView.DataSource = dtDate;
            grdEnquiryManagementView.Show();
        }
    }
}
