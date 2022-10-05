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
using clsCounsellor;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GSTEducationalCRMSoft

{
    public partial class frmInternalPlacementReports : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SWAPNIL;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");
        public frmInternalPlacementReports()
        {
            InitializeComponent();
        }

        DataTable dtt = new DataTable();

        private void frmInternalPlacementReports_Load(object sender, EventArgs e)
        {
            Counsellor objcourse = new Counsellor();
            DataTable dt = new DataTable();
            dt = objcourse.GetCourse();
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.DataSource = dt;


            
            Counsellor objname = new Counsellor();
            DataTable dtname = new DataTable();
            dtname = objname.Get_Student();
            cmbbxName.ValueMember = "StudId";
            cmbbxName.DisplayMember = "StudFullName";
            cmbbxName.DataSource = dtname;


            
            Counsellor objcompany = new Counsellor();
            DataTable dtcompany = new DataTable();
            dtcompany = objcompany.Get_Company();
            cmbbxPlacedCompany.ValueMember = "CompanyId";
            cmbbxPlacedCompany.DisplayMember = "CompanyName";
            cmbbxPlacedCompany.DataSource = dtcompany;


            Counsellor objdesignation = new Counsellor();
            DataTable dtdesignation = new DataTable();
            dtdesignation = objdesignation.Get_Designation();
            cmbbxDesignation.ValueMember = "DesignationId";
            cmbbxDesignation.DisplayMember = "DesignationName";
            cmbbxDesignation.DataSource = dtdesignation;

            /*************GridView******************/

            Counsellor obj = new Counsellor();
            dtt = obj.Get_PlacedStudent();
            grdInternalPlacementreport.DataSource = dtt;
            grdInternalPlacementreport.Show();

            /**********Filter***********/
            cmbbxCourse.Hide();
            cmbbxDesignation.Hide();
            cmbbxName.Hide();
            cmbbxPlacedCompany.Hide();
            datePickerFromDate.Hide();
            datePickerToDate.Hide();
            lblCourse.Hide();
            lblDesignation.Hide();
            lblStartDate.Hide();
            lblName.Hide();
            lblPlacedCompany.Hide();
            lblEndDate.Hide();
            pictbxCalender1.Hide();
            pictbxCalender2.Hide();
            picbxSearch.Hide();
            
        }
        


        private void cmbbxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdInternalPlacementreport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                
              string candidate = grdInternalPlacementreport.Rows[grdInternalPlacementreport.CurrentRow.Index].Cells[3].Value.ToString();
                string qualification = grdInternalPlacementreport.Rows[grdInternalPlacementreport.CurrentRow.Index].Cells[4].Value.ToString();
              string companyname = grdInternalPlacementreport.Rows[grdInternalPlacementreport.CurrentRow.Index].Cells[6].Value.ToString();

              string designation = grdInternalPlacementreport.Rows[grdInternalPlacementreport.CurrentRow.Index].Cells[7].Value.ToString();
              string package= grdInternalPlacementreport.Rows[grdInternalPlacementreport.CurrentRow.Index].Cells[8].Value.ToString();
                string  dateOfJoining = grdInternalPlacementreport.Rows[grdInternalPlacementreport.CurrentRow.Index].Cells[5].Value.ToString();
                string Comments = grdInternalPlacementreport.Rows[grdInternalPlacementreport.CurrentRow.Index].Cells[9].Value.ToString();

                frmDetails obj = new frmDetails(candidate,qualification,companyname,designation,package,dateOfJoining,Comments);
                obj.Show();
            }

        }

        private void cmbbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
        int cid=Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            Counsellor objCourseFillter = new Counsellor(cid);
            DataTable dtCourseFiltter=new DataTable();
            dtCourseFiltter = objCourseFillter.PlacedCourseView();
            grdInternalPlacementreport.DataSource=dtCourseFiltter;
            grdInternalPlacementreport.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cmbbxName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int nameid = Convert.ToInt32(cmbbxName.SelectedValue.ToString());
            Counsellor objNameFilter = new Counsellor(nameid);
            DataTable dtNameFilter = new DataTable();
            dtNameFilter = objNameFilter.PlacedNameView();
            grdInternalPlacementreport.DataSource = dtNameFilter;
            grdInternalPlacementreport.Show();
            if (cmbbxName.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxDesignation.Text = "";
                cmbbxCourse.Text = "";
                cmbbxPlacedCompany.Text = "";
            }
        }

        private void cmbbxPlacedCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyid = Convert.ToInt32(cmbbxPlacedCompany.SelectedValue.ToString());
           // string name = cmbbxName.Text;
            Counsellor objCompanyFilter = new Counsellor(companyid);
            DataTable dtCompanyFilter = new DataTable();
            dtCompanyFilter = objCompanyFilter.PlacedCompanyView();
            grdInternalPlacementreport.DataSource = dtCompanyFilter;
            grdInternalPlacementreport.Show();
            if (cmbbxPlacedCompany.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxDesignation.Text = "";
                cmbbxCourse.Text = "";
                cmbbxName.Text = "";
            }

        }

        private void cmbbxDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int designationid = Convert.ToInt32(cmbbxDesignation.SelectedValue.ToString());
            
            Counsellor objDesignation = new Counsellor(designationid);
            DataTable dtDesignation = new DataTable();
            dtDesignation = objDesignation.PlacedDesignationView();
            grdInternalPlacementreport.DataSource = dtDesignation;
            grdInternalPlacementreport.Show();
            if (cmbbxDesignation.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxName.Text = "";
                cmbbxCourse.Text = "";
                cmbbxPlacedCompany.Text = "";
            }
        }

        private void picbxSearch_Click(object sender, EventArgs e)
        {
            DateTime StartDate = datePickerFromDate.Value;
            DateTime EndDate = datePickerToDate.Value;
            Counsellor objDate = new Counsellor(StartDate, EndDate, this.Text);
            DataTable dt = new DataTable();
            dt = objDate.GetPlacedStudentbydate();
            grdInternalPlacementreport.DataSource = dt;
            grdInternalPlacementreport.Show();
        }

        private void pictRefresh_Click(object sender, EventArgs e)
        {
            Counsellor obj = new Counsellor();
            dtt = obj.Get_PlacedStudent();
            grdInternalPlacementreport.DataSource = dtt;
            grdInternalPlacementreport.Show();
        }

        private void pictbxExcel_Click(object sender, EventArgs e)
        {
            if (grdInternalPlacementreport.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < grdInternalPlacementreport.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdInternalPlacementreport.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdInternalPlacementreport.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < grdInternalPlacementreport.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdInternalPlacementreport.Rows[i].Cells[j].Value.ToString();
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
            for (int i = 2; i < grdInternalPlacementreport.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdInternalPlacementreport.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdInternalPlacementreport.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 2; j < grdInternalPlacementreport.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdInternalPlacementreport.Rows[k].Cells[j].Value.ToString()));
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
            exportgridtopdf(grdInternalPlacementreport, "Internal Placement Report");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtt.DefaultView;
            dv.RowFilter = "Qualification Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Package Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Course Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR StudentName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR PlacedCompany Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Designation Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Comments Like '" + txtSearch.Text + "%'";
            grdInternalPlacementreport.DataSource = dv;
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            
            cmbbxCourse.Show();
            cmbbxDesignation.Show();
            cmbbxName.Show();
            cmbbxPlacedCompany.Show();
            datePickerFromDate.Show();
            datePickerToDate.Show();
            lblCourse.Show();
            lblDesignation.Show();
            lblStartDate.Show();
            lblName.Show();
            lblPlacedCompany.Show();
            lblEndDate.Show();
            pictbxCalender1.Show();
            pictbxCalender2.Show();
            picbxSearch.Show();
        }
    }
}
