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
    public partial class frmLabManagement : Form
    {
        public frmLabManagement()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void frmLabManagement_Load(object sender, EventArgs e)
        {
            //CoOrdinator obj = new CoOrdinator();
            //dt = obj.GetLab();
            //grdLabManagement.DataSource = dt;
            //grdLabManagement.Show();


            CoOrdinator objLab = new CoOrdinator();
            DataTable dtt = new DataTable();
            dtt = objLab.GetLabName();
            cmbbxLabName.DisplayMember = "LabName";
            cmbbxLabName.DataSource = dtt;

            CoOrdinator objGCA = new CoOrdinator();
            DataTable dtgca = new DataTable();
            dtgca = objGCA.GetCenterAddress();
            cmbbxCenterName.ValueMember = "LocationId";
            cmbbxCenterName.DisplayMember = "LocationName";
            cmbbxCenterName.DataSource = dtgca;


            CoOrdinator obj = new CoOrdinator();
            dt = obj.GetLab();
            grdLabManagement.DataSource = dt;
            grdLabManagement.Show();


            /**********Lab Management************/
            cmbbxLabName.Hide();
            cmbbxCenterName.Hide();
            lblCenterName.Hide();
            lblLabName.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LabName = cmbbxLabName.Text;
            CoOrdinator obj = new CoOrdinator(LabName);
            DataTable dtfln = new DataTable();
            dtfln = obj.FilterLabName();
            grdLabManagement.DataSource = dtfln;
            grdLabManagement.Show();

            if (cmbbxLabName.SelectedItem == "true")
            {

            }
            else
            {
                cmbbxCenterName.Text = "";
            }
        }

        private void grdLabManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
               bool select = grdLabManagement.Rows[grdLabManagement.CurrentRow.Index].Cells[0].Selected;
               string CenterName = grdLabManagement.Rows[grdLabManagement.CurrentRow.Index].Cells[3].Value.ToString();
               string LabName = grdLabManagement.Rows[grdLabManagement.CurrentRow.Index].Cells[4].Value.ToString();
               int CapacityOfLab = Convert.ToInt32(grdLabManagement.Rows[grdLabManagement.CurrentRow.Index].Cells[5].Value.ToString());
               int AvailableSystem = Convert.ToInt32(grdLabManagement.Rows[grdLabManagement.CurrentRow.Index].Cells[6].Value.ToString());
               string LabId= grdLabManagement.Rows[grdLabManagement.CurrentRow.Index].Cells[2].Value.ToString();
               frmLabInfo frm = new frmLabInfo(LabName,CapacityOfLab,AvailableSystem,LabId);
               frm.Show();

            }

        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            frmCreateNewLab objnewlab = new frmCreateNewLab();
            objnewlab.Show();
        }

        private void pictbxExcel_Click(object sender, EventArgs e)
        {
            if (grdLabManagement.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 2; i < grdLabManagement.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = grdLabManagement.Columns[i].HeaderText;
                }

                for (int i = 0; i < grdLabManagement.Rows.Count - 1; i++)
                {
                    for (int j = 2; j < grdLabManagement.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j] = grdLabManagement.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Visible = true;
                xcelApp.Columns.AutoFit();

            }
        }
        public void exportgridtopdf(DataGridView grd, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(5);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            for (int i = 2; i < grdLabManagement.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grdLabManagement.Columns[i].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //data row
            for (int k = 0; k < grdLabManagement.Rows.Count - 1; k++)
            {
                //foreach(DataGridViewCell cell in grdEnquiryFollowUp.Rows[i].Cells)
                for (int j = 2; j < grdLabManagement.Columns.Count; j++)
                {
                    pdftable.AddCell(new Phrase(grdLabManagement.Rows[k].Cells[j].Value.ToString()));
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
            exportgridtopdf(grdLabManagement, "Lab Management");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
           // dv.RowFilter = "LabCapacity Like '" + txtSearch.Text + "%'";
            //dv.RowFilter += " OR AvailableSystem Like '" + txtSearch.Text + "%'";
           dv.RowFilter = " LabName Like '" + txtSearch.Text + "%'";

            grdLabManagement.DataSource = dv;
        }

        private void pictRefresh_Click(object sender, EventArgs e)
        {
            CoOrdinator obj = new CoOrdinator();
            dt = obj.GetLab();
            grdLabManagement.DataSource = dt;
            grdLabManagement.Show();

            cmbbxCenterName.Refresh();
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            cmbbxLabName.Show();
            cmbbxCenterName.Show();
            lblCenterName.Show();
            lblLabName.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in grdLabManagement.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int lid = Convert.ToInt32(row.Cells[2].Value.ToString());
                    CoOrdinator objdelete = new CoOrdinator(lid);
                    objdelete.DeleteLab();
                    grdLabManagement.Rows.Remove(row);
                    i++;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string CenterAddress = cmbbxCenterName.Text;
            //CoOrdinator obj = new CoOrdinator(CenterAddress);
            //DataTable dtfln = new DataTable();
            //dtfln = obj.GetBaramatiLab();
            //grdLabManagement.DataSource = dtfln;
            //grdLabManagement.Show();
        }

        private void cmbbxCenterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CenterAddress= cmbbxCenterName.Text;
            CoOrdinator obj = new CoOrdinator(CenterAddress);
            DataTable dtfbc = new DataTable();
            dtfbc = obj.FilterByCenter();
            grdLabManagement.DataSource = dtfbc;
            grdLabManagement.Show();

            
            if (cmbbxCenterName.SelectedItem == "true")
            {

            }
            else
            {
                cmbbxLabName.Text = "";
            }



            //string CenterAddress = cmbbxCenterName.Text;
            //CoOrdinator obj = new CoOrdinator(CenterAddress);
            //DataTable dtfbc = new DataTable();
            //dtfbc = obj.FilterByCenter();
            //grdLabManagement.DataSource = dtfbc;
            //grdLabManagement.Show();

            // int cid = Convert.ToInt32(cmbbxCenterName.SelectedValue.ToString());
            //// string CenterAddress = cmbbxCenterName.Text;
            // CoOrdinator obj = new CoOrdinator(cid);
            // DataTable dtfbc = new DataTable();
            // dtfbc = obj.FilterByCenter();
            // grdLabManagement.DataSource = dtfbc;
            // grdLabManagement.Show();

        }

        private void picboxAddCenterName_Click(object sender, EventArgs e)
        {
            FrmAddCenterName objaddcenter = new FrmAddCenterName();
            objaddcenter.Show();
        }
    }
}

