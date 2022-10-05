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

namespace GSTEducationalCRMSoft
{
    public partial class frmInventoryManagment : Form
    {
        public frmInventoryManagment()
        {
            InitializeComponent();
        }

        DataTable dta = new DataTable();
        private void frmInventoryManagment_Load(object sender, EventArgs e)
        {
            /***********Fetch Inventory*************/
            CoOrdinator objInventoryManagment = new CoOrdinator();
            dta = objInventoryManagment.InventoryManagment();
            grdInventoryManagment.DataSource = dta;
            grdInventoryManagment.Show();

            //CoOrdinator objGetCategory = new CoOrdinator();
            //DataTable dt = new DataTable();
            //dt = objGetCategory.GetInventoryCategory();
            //cmbbxtype.ValueMember = "InventoryId";
            //cmbbxtype.DisplayMember = "Category";
            //cmbbxtype.DataSource = dt;

            cmbbxtype.Items.Add("Laptop");
            cmbbxtype.Items.Add("Mobile");
            cmbbxtype.Items.Add("Printer");
            cmbbxtype.Items.Add("Bag");
            cmbbxtype.Items.Add("Charger");
            cmbbxtype.Items.Add("Keyboard");
            cmbbxtype.Items.Add("Mouse");
            cmbbxtype.Items.Add("Screen Guard");
            cmbbxtype.Items.Add("Monitor");
            cmbbxtype.Items.Add("CPU");
            cmbbxtype.Items.Add("Hard Disc");
            cmbbxtype.Items.Add("Stationary");


            //Hide
            picbxSearch.Hide();
            dtpFromDate.Hide();
            dtpToDate.Hide();
            lblFromDate.Hide();
            lblToDate.Hide();
            cmbbxtype.Hide();
            lbltype.Hide();




        }

        private void grdInventoryManagment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                string Category = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[4].Value.ToString();
                string ItemName = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[5].Value.ToString();
                string Quantity = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[6].Value.ToString();
                string Price = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[7].Value.ToString();
                string TotalPrice = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[8].Value.ToString();
                string VendorName = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[9].Value.ToString();
                string VendorAddress = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[10].Value.ToString();
                string Bill = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[11].Value.ToString();
                string Remark = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[12].Value.ToString();
                string InventoryId = grdInventoryManagment.Rows[grdInventoryManagment.CurrentRow.Index].Cells[2].Value.ToString();
                frmEditInventory objUpdate = new frmEditInventory(Category, ItemName, Quantity, Price, TotalPrice, VendorName, VendorAddress, Bill, Remark, InventoryId);
                objUpdate.Show();

            }
        }

        private void cmbbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


            DataView dv = dta.DefaultView;
            dv.RowFilter = "Category Like'" + cmbbxtype.SelectedItem + "%'";
            grdInventoryManagment.DataSource = dv;
            
                //CoOrdinator objCategoryFilter = new CoOrdinator(Convert.ToInt32(cmbbxtype.SelectedValue.ToString()));
                //DataTable dt = new DataTable();
                //dt = objCategoryFilter.GetCategoryByFilter();
                //grdInventoryManagment.DataSource = dt;
                //grdInventoryManagment.Show();
           
            
        }

        private void pictbxExcel_Click(object sender, EventArgs e)
        {
            if (grdInventoryManagment.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 2; i < grdInventoryManagment.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdInventoryManagment.Columns[i].HeaderText;
                }
                
                for (int i = 0; i < grdInventoryManagment.Rows.Count-1; i++)
                {
                    for (int j = 2; j < grdInventoryManagment.Columns.Count; j++)
                    {
                        xcelApp.Cells[i+2 , j] = grdInventoryManagment.Rows[i].Cells[j].Value.ToString();
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
            for (int i = 2; i < grdInventoryManagment.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdInventoryManagment.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdInventoryManagment.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 2; j < grdInventoryManagment.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdInventoryManagment.Rows[k].Cells[j].Value.ToString()));
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
            exportgridtopdf(grdInventoryManagment, "Inventory Managment");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dta.DefaultView;
            dv.RowFilter = "ItemName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR VendorName Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Remark Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR Category Like '" + txtSearch.Text + "%'";
            dv.RowFilter += " OR VendorAddress Like '" + txtSearch.Text + "%'";
            grdInventoryManagment.DataSource = dv;

        }

        private void pictRefresh_Click(object sender, EventArgs e)
        {
            CoOrdinator objInventoryManagment = new CoOrdinator();
            dta = objInventoryManagment.InventoryManagment();
            grdInventoryManagment.DataSource = dta;
            grdInventoryManagment.Show();

        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmAddInventarycs objaddinven = new frmAddInventarycs();
            objaddinven.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdInventoryManagment.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int lid = Convert.ToInt32(row.Cells[4].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(lid);
                    objdelete.DeleteInventory();
                    grdInventoryManagment.Rows.Remove(row);
                    i++;
                }
            }
        }

        private void picbxSearch_Click(object sender, EventArgs e)
        {
            string StartDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
            string EndDate = dtpToDate.Value.ToString("yyyy-MM-dd");
            CoOrdinator objDate = new CoOrdinator(StartDate, EndDate);
            DataTable dt = new DataTable();
            dt = objDate.InventorydateFilter();
            grdInventoryManagment.DataSource = dt;
            grdInventoryManagment.Show();

        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            picbxSearch.Show();
            dtpFromDate.Show();
            dtpToDate.Show();
            lblFromDate.Show();
            lblToDate.Show();
            cmbbxtype.Show();
            lbltype.Show();
        }
    }
}

