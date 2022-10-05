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
using System.IO;
using clsCounsellor;

namespace GSTEducationalCRMSoft
{
    public partial class frmbrochure : Form
    {
        
        public frmbrochure()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            
        }

        Image img;
        private void pictureBoxcSharp_Click(object sender, EventArgs e)
        {
            img = Image.FromFile("C:/Users/dhira/source/repos/CRM_Project/GSTEducationalCRMSoft/image/c#.jpg");
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                img.Save(sf.FileName);
            }
            MessageBox.Show("Download Successfully!");
        }
        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void pictureBoxAdo_Click(object sender, EventArgs e)
        {
            img = Image.FromFile("C:/Users/dhira/source/repos/CRM_Project/GSTEducationalCRMSoft/image/EntiyFramework1.jpg");
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                img.Save(sf.FileName);
            }
            MessageBox.Show("Download Successfully!");
        }

        private void pictureBoxEntity_Click(object sender, EventArgs e)
        {
            img = Image.FromFile("C:/Users/dhira/source/repos/CRM_Project/GSTEducationalCRMSoft/image/MasterPages.jpg");
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                img.Save(sf.FileName);
            }
            MessageBox.Show("Download Successfully!");
        }

        private void pictureBoxMasterpages_Click(object sender, EventArgs e)
        {
            img = Image.FromFile("C:/Users/dhira/source/repos/CRM_Project/GSTEducationalCRMSoft/image/s-l640.jpg");
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                img.Save(sf.FileName);
            }
            MessageBox.Show("Download Successfully!");
        }

        private void frmbrochure_Load(object sender, EventArgs e)
        {

        }
    }
}
