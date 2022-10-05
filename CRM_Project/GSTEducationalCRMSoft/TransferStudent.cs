using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsCoOrdinator;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GSTEducationalCRMSoft
{
    public partial class TransferStudent : Form
    {
        string sc { get; set; }
        public string BatchName { get; set; }
        public int BId { get; set; }
        public string StudCode { get; set; }
        public int no1 { get; set; }
        public string bname { get; set; }
        public string scmerge { get; set; }
        public string GetSCode { get; set; }
        public int tempdelete { get; set; }
        public string cname { get; set; }
        public int CidBatchmanagment { get; set; }
        public int CidViewBatch { get; set; }
        public TransferStudent()
        {
            InitializeComponent();
        }
       
        public TransferStudent(string name, int batchId, string studCode,int n,string c,int cid)
        {
            InitializeComponent();
            label1.Text = name;
            BId = batchId;
            StudCode = studCode;
            no1 = n;
            tempdelete++;
            cname= c;
            CidBatchmanagment = cid;
        }
        public TransferStudent(string code,string name,string getscode,int b,int c)
        {
            InitializeComponent();
            scmerge = code;
            label1.Text = name;
            GetSCode = getscode;
            BId=b;
            CidViewBatch = c;
        }

        private void TransferStudent_Load(object sender, EventArgs e)
        {
            //Add Batch
            if(tempdelete==1)
            {
                CoOrdinator obj2 = new CoOrdinator(CidBatchmanagment,BId);
                DataTable dt6 = new DataTable();
                dt6 = obj2.GetRemoveAddBatch();
                cmbbxAdd.ValueMember = "BatchId";
                cmbbxAdd.DisplayMember = "BatchName";
                cmbbxAdd.DataSource = dt6;
            }
            else
            {
                CoOrdinator obj2 = new CoOrdinator(CidViewBatch,BId);
                DataTable dtview = new DataTable();
                dtview = obj2.GetRemoveAddBatch();
                cmbbxAdd.ValueMember = "BatchId";
                cmbbxAdd.DisplayMember = "BatchName";
                cmbbxAdd.DataSource = dtview;
            }
         
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Addid is the batchid in which student will add
            int Addid = Convert.ToInt32(cmbbxAdd.SelectedValue.ToString());
            string NoOfStudent2 = null;
           
            string removeconcat=null;
            string AddStudCode = null;
            //objadd give the studcode and number of student from exiting batch
            CoOrdinator objadd = new CoOrdinator(Addid);
            SqlDataReader dr1 = objadd.AddBatchStudent();
            while (dr1.Read())
            {
               AddStudCode = dr1["StudCode"].ToString();
               NoOfStudent2 = dr1["NoOfStudent"].ToString();
            }
            //SingleMerge means when we click on ViewBatchDetails gridview and that single student will add in Addstudcod
            string SingleMerge =String.Concat (AddStudCode,",", scmerge);
            int no2 = Convert.ToInt32(NoOfStudent2);
            int Total = no1 + no2;
            int TotalSingleMerge = no2 + 1;
            int totalafterSingleMerge = 0;
            //this merging is happen when merge is click on BatchManagment gridview
            string StudCode1 = String.Concat(AddStudCode, ",", StudCode);
            string remove = null;
            //this code is for remove single student from his exiting batch
            string[] removestring;
            int viewbatchsinglestud = 0;
            if (tempdelete == 0)
            {
                removestring = GetSCode.Split(',');
                for (int i = 0; i < removestring.Length; i++)
                {
                    if (removestring[i] != scmerge)
                    {
                        viewbatchsinglestud=1;
                        string temp = removestring[i];
                        if (i == 0)
                        {
                            remove = String.Concat(temp, ",");
                            removeconcat = String.Concat(remove, removeconcat);
                            totalafterSingleMerge++;
                        }
                        else if (i != 0)
                        {
                            removeconcat = String.Concat(removeconcat, temp, ",");
                            totalafterSingleMerge++;
                        }
                    }
                }
            }
            //if(totalafterSingleMerge == 0)
            //{
            //    totalafterSingleMerge = 1;
            //}
            //label3.Text = removeconcat;
            // label5.Text = BId.ToString();
            //
            if (tempdelete == 1)
            {
                CoOrdinator objdelete = new CoOrdinator(BId);
                objdelete.DeleteExistingBatch();
                CoOrdinator obj = new CoOrdinator(StudCode1, Total, Addid);
                obj.UpdateBatch();
                MessageBox.Show("Update is successfully....!");
                this.Hide();
            }
            else if(viewbatchsinglestud==0)
            {
                CoOrdinator objdelete = new CoOrdinator(BId);
                objdelete.DeleteExistingBatch();
                CoOrdinator obj = new CoOrdinator(SingleMerge, TotalSingleMerge, Addid);
                obj.UpdateBatch();
                MessageBox.Show("Update is successfully....!");
                this.Hide();
            }
            else
            {
                CoOrdinator objSingleMerge = new CoOrdinator(SingleMerge, TotalSingleMerge, Addid);
                objSingleMerge.UpdateBatch();
                CoOrdinator objAfterSingleMerge = new CoOrdinator(removeconcat, totalafterSingleMerge, BId);
                objAfterSingleMerge.UpdateBatch();
                MessageBox.Show("Update is successfully....!");
                this.Close();
            }

            


        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e){}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
