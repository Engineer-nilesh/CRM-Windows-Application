using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using clsCounsellor;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;
using clsCoOrdinator;
using System.Diagnostics;

namespace GSTEducationalCRMSoft
{
    public partial class frmSyllabus : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DHIRAJ\\SQLEXPRESS;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");

        WebClient client;
        public frmSyllabus()
        {
            InitializeComponent();
        }
        DataTable dtshow = new DataTable();
        private void frmSyllabus_Load(object sender, EventArgs e)
        {
            CoOrdinator objcourse = new CoOrdinator();
            DataTable dtCourse = new DataTable();
            dtCourse = objcourse.Get_Course();
            cmbbxCourse.ValueMember = "CourseId";
            cmbbxCourse.DisplayMember = "CourseName";
            cmbbxCourse.DataSource = dtCourse;

            Counsellor objSyllabus = new Counsellor();
            dtshow = objSyllabus.Syllabus();
            grdSyllabusView.DataSource = dtshow;
            grdSyllabusView.Show();
            client = new WebClient();
            client.DownloadFileCompleted += FileDownloadComplete;
            grdSyllabusView.Columns["SyllabusFile"].Visible = false;
            grdSyllabusView.Columns["SrNo"].DisplayIndex = 0;
            grdSyllabusView.Columns["CourseName"].DisplayIndex = 1;
            grdSyllabusView.Columns["Description"].DisplayIndex = 2;


        }
       
        private void grdSyllabusView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = grdSyllabusView.Rows[grdSyllabusView.CurrentRow.Index].Cells[3].Value.ToString();
            if (!string.IsNullOrEmpty(url))
            {
                Thread thread = new Thread(() =>
                {
                    Uri uri = new Uri(url);
                    string FileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client.DownloadFileAsync(uri, "C:/Users/dhira/Downloads" + "/" + FileName);

                });
                thread.Start();
            }
        }
       

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            string path = grdSyllabusView.Rows[grdSyllabusView.CurrentRow.Index].Cells[3].Value.ToString();
            string syllabusname=txtSyllabusName.Text;
            string description=rtbxDescription.Text;
            SaveFileDialog fDilog=new SaveFileDialog();
            fDilog.Title = "Select File to be Upload";
            fDilog.Filter = "PDF Files|*.pdf|All Files|*.*";
            if(fDilog.ShowDialog() == DialogResult.OK)
            {
                path = fDilog.FileName.ToString();
            }
            int cid = Convert.ToInt32(cmbbxCourse.SelectedValue.ToString());
            Counsellor syllabusinsert=new Counsellor(cid, syllabusname, path, description);
            syllabusinsert.InsertSyllabus();
            MessageBox.Show("Update Sucessfully");
            

        }
        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Sucessfully");
        }

        private void pictbxRefresh2_Click(object sender, EventArgs e)
        {
            Counsellor objSyllabus = new Counsellor();
            dtshow = objSyllabus.Syllabus();
            grdSyllabusView.DataSource = dtshow;
            grdSyllabusView.Show();
        }
    }
}
