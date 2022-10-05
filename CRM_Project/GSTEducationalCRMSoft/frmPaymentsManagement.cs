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
using clsCounsellor;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;


namespace GSTEducationalCRMSoft
{
    public partial class frmPaymentsManagement : Form
    {
        public string StudTransactionId { get; set; }
        
        public frmPaymentsManagement()
        {
            InitializeComponent();
            
        }

        DataTable dtGetPayment = new DataTable();

        private void frmPaymentsManagement_Load(object sender, EventArgs e)

        {
                   
        // GenerateData();


        Counsellor objCourse = new Counsellor();
            DataTable dtcourse = new DataTable();
            dtcourse = objCourse.GetCourse();
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.DataSource = dtcourse;

            CoOrdinator objname = new CoOrdinator();
            DataTable dtname = new DataTable();
            dtname = objname.GetName(); 
            cmbbxName.ValueMember = "StudCode";
            cmbbxName.DisplayMember = "StudFullName";
            cmbbxName.DataSource = dtname;



            CoOrdinator objstatus = new CoOrdinator();
            DataTable dtstatus = new DataTable();
            dtstatus = objstatus.FetchPaymentStatus();
            cmbbxStatus.ValueMember = "StatusId"; 
            cmbbxStatus.DisplayMember = "Status";
            cmbbxStatus.DataSource = dtstatus;

            /**********GetPaymentDetails**************/
            CoOrdinator obj = new CoOrdinator();
            dtGetPayment = obj.GetPaymentDetail();
            grdPaymentManagement.DataSource = dtGetPayment;
            grdPaymentManagement.Show();



            //CoOrdinator objtan = new CoOrdinator();
            //SqlDataReader dr = objtan.GenInvoice();
            //if (dr.Read())
            //{
            //    string StudTransactionId = dr[0].ToString();
            //    int i = Convert.ToInt32(StudTransactionId);
            //    i += 1;
            //    StudTransactionId = 1 + 1000 + i.ToString();
            //}
            //////else
            ////{
            ////    StudTransactionId = 1 + 1000 + 1;
            ////}

            // MessageBox.Show("Updated.....");
            //  this.Close();



            //coordinators.Add(
            //    Coordinator

            //);


            /********Filter************/
            cmbbxCourse.Hide();
            cmbbxName.Hide();
            cmbbxStatus.Hide();
            lblCourse.Hide();
            lblName.Hide();
            lblStatus.Hide();
            cmbbxStatus.Text = "";
        }

        protected void grdPaymentManagement_RowDataBound(object sender, DataGridViewRowEventArgs e)
        {
            //if (e.Row.Cells[8].Text=="1")
            //{

            //}
        }

        private void cmbbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string CourseName = cmbbxCourse.Text;
            int Id = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            CoOrdinator obj = new CoOrdinator(Id);
            DataTable dtc = new DataTable();
            dtc = obj.FilterByCourse();
            grdPaymentManagement.DataSource = dtc;
            grdPaymentManagement.Show();
            if (cmbbxCourse.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxName.Text = "";
                cmbbxStatus.Text = "";
            }

            //for (int i = 0; i < cmbbxName.Items.Count; i++)
            //{
            //    if (cmbbxName.Items[i] == cmbbxCourse.SelectedItem)
            //    {
            //        cmbbxName.Items.Remove(cmbbxName.Items[i]);
            //        i--;
            //    }
            //}



        }

        private void cmbbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string StudFullNmae = cmbbxName.Text;
            CoOrdinator objname = new CoOrdinator(StudFullNmae);
            DataTable dtName = new DataTable();
            dtName = objname.FilterByName();
            grdPaymentManagement.DataSource = dtName;
            grdPaymentManagement.Show();

            if (cmbbxName.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxCourse.Text = "";
                cmbbxStatus.Text = "";
            }


        }

        private void grdPayMan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdPaymentManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ////   if (e.ColumnIndex == 0)

            //      bool select = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[0].Selected;
            //       string StudCode = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[2].Value.ToString();
            //       string FullName = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[3].Value.ToString();
            //      string CourseName= grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[4].Value.ToString();
            //      string TotalFee= grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[7].Value.ToString();
            //       string Status= grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[10].Value.ToString();
            //       //   string PaidAmount= grdPayMan.Rows[grdPayMan.CurrentRow.Index].Cells[6].Value.ToString();
            //       int BalanceAmount= Convert.ToInt32(grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[9].Value.ToString());
            //   if (select == true)
            //   {
            //        if (Status == "Complete")
            //           {
            //               MessageBox.Show("Your Payment is Completed..!");
            //           }
            //           else if(select == true)

            //           {
            //               frmAddPayment frm = new frmAddPayment(StudCode, FullName, CourseName, TotalFee, BalanceAmount);
            //               frm.Show();
            //           }

            //       else 
            //       {
            //           ViewPaymentDetails frm = new ViewPaymentDetails(StudCode, FullName);
            //           frm.Show();
            //       }

            //   }

            if (e.ColumnIndex == 0)
            {
                bool select = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[0].Selected;
                string StudCode = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[2].Value.ToString();
                string FullName = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[3].Value.ToString();
                string CourseName = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[4].Value.ToString();
                string TotalFee = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[6].Value.ToString();
                string Status = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[11].Value.ToString();
                //   string PaidAmount= grdPayMan.Rows[grdPayMan.CurrentRow.Index].Cells[6].Value.ToString();
                int BalanceAmount = Convert.ToInt32(grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[8].Value.ToString());
              //  string InvoiceNo = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[10].Value.ToString();
                if(Status=="Complete")
                {
                    MessageBox.Show("Your Payment Completed.....!!!");
                }
                else if(select==true)
                {
                    AddPayment frm = new AddPayment(StudCode, FullName, CourseName, TotalFee, BalanceAmount);
                    frm.Show();
                }
                
            }
            if(e.ColumnIndex == 1)
            {
                bool select = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[1].Selected;
                string StudCode = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[2].Value.ToString();
                string FullName = grdPaymentManagement.Rows[grdPaymentManagement.CurrentRow.Index].Cells[3].Value.ToString();

                ViewPaymentDetails frm = new ViewPaymentDetails(StudCode, FullName);
                frm.Show();
            }

            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void grdPaymentManagement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10 & e.Value != null)
            {
                int sum1 = Convert.ToInt32(e.Value);
                if (sum1 < 2)
                    e.CellStyle.BackColor = Color.Red;
                else if (sum1 > 1 & sum1 < 3)
                    e.CellStyle.BackColor = Color.Yellow;
                else if (sum1 > 2 & sum1 < 4)
                    e.CellStyle.BackColor = Color.Orange;
                else if (sum1 > 3 & sum1 < 5)
                    e.CellStyle.BackColor = Color.Green;
              //  else if (sum1 > 4 & sum1 < 6)
              //      e.CellStyle.BackColor = Color.Green;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (e.ColumnIndex == 9 & e.Value != null)
            //{
            //    int sum1 = Convert.ToInt32(e.Value);
            //    if (sum1 < 2)
            //        e.CellStyle.BackColor = Color.Red;
            //    else if (sum1 > 1 & sum1 < 3)
            //        e.CellStyle.BackColor = Color.Yellow;
            //    else if (sum1 > 2 & sum1 < 4)
            //        e.CellStyle.BackColor = Color.Orange;
            //    else if (sum1 > 3 & sum1 < 5)
            //        e.CellStyle.BackColor = Color.Blue;
            //    else if (sum1 > 4 & sum1 < 6)
            //        e.CellStyle.BackColor = Color.Green;
        
           // }

        }

        private void cmbbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string StatusName = cmbbxStatus.Text;
            int Id = Convert.ToInt32(cmbbxStatus.SelectedValue.ToString());
            CoOrdinator obj = new CoOrdinator(Id);
            DataTable dts = new DataTable();
            dts = obj.FilterByStatus();
            grdPaymentManagement.DataSource = dts;
            grdPaymentManagement.Show();


            if (cmbbxStatus.SelectedItem == "true")
            {
            }
            else
            {
                cmbbxCourse.Text = "";
                cmbbxName.Text = "";
            }
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxCourse.Show();
            cmbbxName.Show();
            cmbbxStatus.Show();
            lblCourse.Show();
            lblName.Show();
            lblStatus.Show();
        }

        private void pictRefresh_Click(object sender, EventArgs e)
        {
            CoOrdinator obj = new CoOrdinator();
            dtGetPayment = obj.GetPaymentDetail();
            grdPaymentManagement.DataSource = dtGetPayment;
            grdPaymentManagement.Show();
        }

        private void pictbxExcel_Click(object sender, EventArgs e)
        {
            if (grdPaymentManagement.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < grdPaymentManagement.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdPaymentManagement.Columns[i].HeaderText;
                }

                for (int i = 0; i <grdPaymentManagement.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < grdPaymentManagement.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdPaymentManagement.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();

            }
        }
        public void exportgridtopdf(DataGridView grd, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(14);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 2; i < grdPaymentManagement.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdPaymentManagement.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdPaymentManagement.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 2; j < grdPaymentManagement.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdPaymentManagement.Rows[k].Cells[j].Value.ToString()));
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
            exportgridtopdf(grdPaymentManagement, "Payment Management");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtGetPayment.DefaultView;
            dv.RowFilter = " FullName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR PaymentMode Like '" + txtSearch.Text + "%'";
            //dv.RowFilter = "TotalFees Like '" + txtSearch.Text + "%'";
           // dv.RowFilter = "PaidAmount Like '" + txtSearch.Text + "%'";
            //dv.RowFilter = "BalanceAmount Like '" + txtSearch.Text + "%'";
            //dv.RowFilter += " OR InvoiceNo Like '" + txtSearch.Text + "%'";
            //dv.RowFilter += " OR CustId Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR CourseName Like '" + txtSearch.Text + "%'";


            grdPaymentManagement.DataSource = dv;
        }

        private void btnpp_Click(object sender, EventArgs e)
        {
            
            CoOrdinator obj = new CoOrdinator();
            DataTable dtGetPending = new DataTable();
            dtGetPending = obj.GetPendingPayment();
            grdPaymentManagement.DataSource = dtGetPending;
            grdPaymentManagement.Show();

        }

        private void btnpc_Click(object sender, EventArgs e)
        {

            CoOrdinator obj = new CoOrdinator();
            DataTable dtGetcpd = new DataTable();
            dtGetcpd = obj.GetCompletePaymentDetails();
            grdPaymentManagement.DataSource = dtGetcpd;
            grdPaymentManagement.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
        //    cmbbxCourse.Text = "";
        //    cmbbxName.Text = "";
        //    cmbbxStatus.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}



