using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clsCoOrdinator
{
    public class CoOrdinator
    {
        SqlConnection con = new SqlConnection("Data Source=DHIRAJ\\SQLEXPRESS;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");
        public int courseid { get; set; }
        public int batchid { get; set; }
        public string staffcode { get; set; }
        public string studcode { get; set; }
        public string feedback { get; set; }
        public int rate { get; set; }
        public string perform { get; set; }
        public int feedbackid { get; set; }
        public int TestId { get; set; }
        public string TestName { get; set; }
        public string CourseName { get; set; }
        public DateTime TestDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int StatusId { get; set; }
        public string TrainerId { get; set; }
        public int MaximumMarks { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        public int LabId { get; set; }
        public string SelectFile { get; set; }
        public int TestimonialId { get; set; }
        public string StudFullName { get; set; }
        public string Qualification { get; set; }
        public string DesignationId { get; set; }
        public string Designation { get; set; }
        public string CompanyId { get; set; }
        public string Company { get; set; }
        public string Package { get; set; }
        public string DateOfJoining { get; set; }
        public string CommentsForRTS { get; set; }
        public string UploadVideo { get; set; }
        public string UploadPDF { get; set; }
        public string StudCode { get; set; }
        public string CandidateName { get; set; }

        public string CenterAddress { get; set; }
        public int CenterId { get; set; }
        public string LabName { get; set; }
        public int LabCapacity { get; set; }
        public int AvailableSystem { get; set; }
        public string StudentName { get; set; }
        public string BatchName { get; set; }
        public string SelectCourseToChange { get; set; }

        // Dhiraj
        public string UserItemName { get; set; }
        public string UserCategory { get; set; }
        public int UserQuantity { get; set; }
        public int UserPrice { get; set; }
        public int UserTotalPrice { get; set; }
        public string UserVendorName { get; set; }
        public string UserVendorAddress { get; set; }
        public string UserBill { get; set; }
        public string UserRemark { get; set; }
        public DateTime UserInventoryDate { get; set; }
        public string UserStatusId { get; set; }
        public int InventoryId { get; set; }

        //Shilpa
        public int PaidAmount { get; set; }
        public int BalanceAmount { get; set; }
        public string  PaymentMode { get; set; }
        public DateTime PaidDate { get; set; }
        public CoOrdinator() { }
        public int courseId { get; set; }
        public DateTime IssueDate { get; set; }
        public int Marks { get; set; }
        public string SyllabusName { get; set; }
        public string SyllabusFile { get; set; }
        public string SyllabusDescription { get; set; }
        public CoOrdinator(int id)
        {
            courseid = id;
        }
        public CoOrdinator(int cid, int bid)
        {
            courseid = cid;
            batchid = bid;
        }
        public CoOrdinator(int rating,string per,string comment,int cid)
        {
            feedbackid = cid;
            rate = rating;
            perform = per;
            feedback = comment;
        }
        public CoOrdinator(int cid,int bid,string staffc, string studc, int rating, string per, string comment)
        {
            courseId = cid;
            batchid = bid;
            StaffCode = staffc;
            StudCode= studc;
            rate = rating;
            perform = per;
            feedback = comment;
            
        }
        public CoOrdinator(string sc)
        {
            studcode = sc;
        }


        public CoOrdinator(string tname, DateTime tdate, DateTime rdate, int cid, int bid, string trainerid, int mmarks, string stime, string duration, int labid, int statusid, string selectfile)
        {
            TestName = tname;
            TestDate = tdate;
            RegistrationDate = rdate;
            courseid = cid;
            batchid = bid;
            TrainerId = trainerid;
            MaximumMarks = mmarks;
            StartTime = stime;
            Duration = duration;
            LabId = labid;
            StatusId = statusid;
            SelectFile = selectfile;

        }

        public CoOrdinator(string tname, DateTime tdate, DateTime rdate, int mmarks, string stime, string duration, string selectfile, int testid)
        {
            TestName = tname;
            TestDate = tdate;
            RegistrationDate = rdate;
            MaximumMarks = mmarks;
            StartTime = stime;
            Duration = duration;
            SelectFile = selectfile;
            TestId = testid;
        }


        public CoOrdinator(string start , string end)
        {
            StudeCode = start;
            CourseName = end;

        }

        public DataTable Get_Course()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourse");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcourse);
            return dtcourse;
            con.Close();
        }

        public DataTable GetBatchByCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchByCourse");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcourse);
            return dtcourse;
            con.Close();
        }

        public DataTable GetBatchView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchView");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            cmd.Parameters.AddWithValue("@BatchId", batchid);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetTrainerByName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTrainerByName");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            cmd.Parameters.AddWithValue("@BatchId", batchid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcourse);
            return dtcourse;
            con.Close();
        }
        public SqlDataReader GetBatchStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchStudent");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }



        public DataTable FilterTrainerName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterTrainerName");
            cmd.Parameters.AddWithValue("@StaffCode", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtTrainer = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtTrainer);
            return dtTrainer;
            con.Close();
        }

        public DataTable GetCoursefromCourseType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCoursefromCourseType");
            cmd.Parameters.AddWithValue("@CourseTypeId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();

        }


        public SqlDataReader GetCourseTypeName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseTypeName");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader AddBatchStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddnewBatchStudent");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public CoOrdinator(int courseid, string studcode, string batchname,
         int noofstudents, string staffcode, string batchtime, int labid, DateTime startdate, DateTime enddate, int statusid)
        {
            CourseId = courseid;
            StudCode = studcode;
            BatchName = batchname;
            NoOfStudent = noofstudents;
            StaffCode = staffcode;
            BatchTime = batchtime;
            LabId = labid;
            StartDate = startdate;
            TentativeEndDate = enddate;
            StatusId = statusid;
        }
        public void CreateBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CreateBatch");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@BatchName", BatchName);
            cmd.Parameters.AddWithValue("@NoOfStudent", NoOfStudent);
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            cmd.Parameters.AddWithValue("@BatchTime", BatchTime);
            cmd.Parameters.AddWithValue("@TentativeEndDate", TentativeEndDate);
            cmd.Parameters.AddWithValue("@LabId", LabId);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
     
      
        public DataTable Syllabus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Syllabus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable Syllabusdownload()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Syllabusdownload");
            cmd.Parameters.AddWithValue("@SyllabusFile", studcode);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetStudentName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStudentName");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }
        
        public void SaveFeedback()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CreateFeedback");
            cmd.Parameters.AddWithValue("@CourseId", courseId);
            cmd.Parameters.AddWithValue("@BatchId", batchid);
            cmd.Parameters.AddWithValue("@FeedbackTo", StaffCode);
            cmd.Parameters.AddWithValue("@FeedbackFrom", StudCode);
            cmd.Parameters.AddWithValue("@Rating", rate);
            cmd.Parameters.AddWithValue("@Performance", perform);
            cmd.Parameters.AddWithValue("@Feedback", feedback);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetBatchLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchLab");
            cmd.Parameters.AddWithValue("@BatchTime", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable ViewFeedbackTrainerToStudent()
        {
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetFeedbackTrainerToStudent");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable ViewFeedbackStudentToTrainer()
        {
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetFeedbackStudentToTrainer");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetFeedbackStoTCourseFillter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetFeedbackStoTCourseFillter");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            cmd.Parameters.AddWithValue("@BatchId", batchid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetFeedbackbyCourseFillter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetFeedbackbyCourseFillter");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            cmd.Parameters.AddWithValue("@BatchId", batchid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void UpdateFeedback()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateFeedback");
            cmd.Parameters.AddWithValue("@Rating", rate);
            cmd.Parameters.AddWithValue("@Performance", perform);
            cmd.Parameters.AddWithValue("@Feedback", feedback);
            cmd.Parameters.AddWithValue("@FeedbackId", feedbackid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetTestLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestLab");
            // cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtCourse = new DataTable();
            adpt.Fill(dtCourse);
            return dtCourse;
            con.Close();

        }


        public DataTable GetTestStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestStatus");
            // cmd.Parameters.AddWithValue("@StatusId", CourseId);
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtCourse = new DataTable();
            adpt.Fill(dtCourse);
            return dtCourse;
            con.Close();

        }

        public void AddNewTest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddTest");
            cmd.Parameters.AddWithValue("@TestName", TestName);
            cmd.Parameters.AddWithValue("@TestDate", TestDate);
            cmd.Parameters.AddWithValue("@RegistrationDate", RegistrationDate);
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            cmd.Parameters.AddWithValue("@BatchId", batchid);
            cmd.Parameters.AddWithValue("@TrainerId", TrainerId);
            cmd.Parameters.AddWithValue("@MaximumMarks", MaximumMarks);
            cmd.Parameters.AddWithValue("@StartTime", StartTime);
            cmd.Parameters.AddWithValue("@Duration", Duration);
            cmd.Parameters.AddWithValue("@LabId", LabId);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@SelectFile", SelectFile);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable TestIdFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TestIdFilter");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtCourseView = new DataTable();
            adpt.Fill(dtCourseView);
            return dtCourseView;
            con.Close();

        }

        public DataTable UpdateTest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateTest");
            cmd.Parameters.AddWithValue("@TestName", TestName);
            cmd.Parameters.AddWithValue("@TestDate", TestDate);
            cmd.Parameters.AddWithValue("@RegistrationDate", RegistrationDate);
            cmd.Parameters.AddWithValue("@MaximumMarks", MaximumMarks);
            cmd.Parameters.AddWithValue("@StartTime", StartTime);
            cmd.Parameters.AddWithValue("@Duration", Duration);
            cmd.Parameters.AddWithValue("@SelectFile", SelectFile);
            cmd.Parameters.AddWithValue("@TestId", TestId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtt = new DataTable();
            adpt.Fill(dtt);
            return dtt;
            con.Close();
        }

        public DataTable ViewTest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewTest");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetExamTitle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExam");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public CoOrdinator(int tid, DateTime tdate)
        {
            TestId = tid;
            TestDate = tdate;
        }

        public DataTable GetExamDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExamDate");
            cmd.Parameters.AddWithValue("@TestId", TestId);
            cmd.Parameters.AddWithValue("@TestDate", TestDate);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        
        public DataTable GetExamView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExam");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetExamCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExamCourse");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetExamBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExamBatch");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetExamTrainer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExamTrainer");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetExamLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExamLab");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable GetExamDuration()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExamDuration");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetExamMarks()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExamMarks");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable GetExamViewDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetExamViewDate");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetEditTestStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEditTestStatus");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        /****************Hrihthik*******************/
        public DataTable FetchTestimonial()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchTestimonial");
            cmd.Parameters.AddWithValue("@TestimonialId", TestimonialId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtG = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtG);
            return dtG;
            con.Close();
        }

        /***************Get Testimonial Candidate*************/
        public DataTable GetTestimonialCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestimonialCandidate");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtgettesti = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtgettesti);
            return dtgettesti;
            con.Close();
        }

        /******************Get All Details Of Testimonial*******************/
        public SqlDataReader GetAllDetailsofTestimonial()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllDetailsofTestimonial");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        /******************Get Qualification****************/
        public DataTable GetQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetQualification");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtQ = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtQ);
            return dtQ;
            con.Close();
        }

        /******************Get Designation*****************/
        public DataTable GetDesignation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetDesignation");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtD = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtD);
            return dtD;
            con.Close();
        }

        /************************Get Company****************************/
        public DataTable GetCompany()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCompany");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtC = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtC);
            return dtC;
            con.Close();
        }

        /*****************Add Testimonial********************/

        public CoOrdinator(string code, string name, string qualif, string desigid, string desig, string companyid, string comp, string salary, string comment, string vid, string pdf)
        {
            StudCode = code;
            StudFullName = name;
            Qualification = qualif;
            DesignationId = desigid;
            Designation = desig;
            CompanyId = companyid;
            Company = comp;
            Package = salary;
            DateOfJoining = DateTime.Now.ToString();
            CommentsForRTS = comment;
            UploadVideo = vid;
            UploadPDF = pdf;
        }
        public void AddTestimonial()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddTestimonial");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@StudFullName", StudFullName);
            cmd.Parameters.AddWithValue("@Qualification", Qualification);
            cmd.Parameters.AddWithValue("@DesignationId", DesignationId);
            cmd.Parameters.AddWithValue("@Designation", Designation);
            cmd.Parameters.AddWithValue("@CompanyId", CompanyId);
            cmd.Parameters.AddWithValue("@Company", Company);
            cmd.Parameters.AddWithValue("@Package", Package);
            cmd.Parameters.AddWithValue("@DateOfJoining", DateOfJoining);
            cmd.Parameters.AddWithValue("@CommentsForRTS", CommentsForRTS);
            cmd.Parameters.AddWithValue("@UploadVideo", UploadVideo);
            cmd.Parameters.AddWithValue("@UploadPDF", UploadPDF);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /***************Update Testimonial*************************/

        public CoOrdinator(int id1, string name, string qualif, string desig, string company, string salary, string comment, string vid, string pdf)
        {

            TestimonialId = id1;
            StudFullName = name;
            Qualification = qualif;
            Designation = desig;
            Company = company;
            Package = salary;
            CommentsForRTS = comment;
            UploadVideo = vid;
            UploadPDF = pdf;
        }
        public void UpdateTestimonial()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateTestimonial");
            cmd.Parameters.AddWithValue("@StudFullName", StudFullName);
            cmd.Parameters.AddWithValue("@Qualification", Qualification);
            cmd.Parameters.AddWithValue("@Designation", Designation);
            cmd.Parameters.AddWithValue("@Company", Company);
            cmd.Parameters.AddWithValue("@Package", Package);
            cmd.Parameters.AddWithValue("@CommentsForRTS", CommentsForRTS);
            cmd.Parameters.AddWithValue("@UploadVideo", UploadVideo);
            cmd.Parameters.AddWithValue("@UploadPDF", UploadPDF);
            cmd.Parameters.AddWithValue("@TestimonialId", TestimonialId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /***************Filter Qualification****************/
        public DataTable FilterTestimonialQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterTestimonialQualification");
            cmd.Parameters.AddWithValue("@Qualification", studcode);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        /***************Filter Designation*******************/

        public DataTable FilterTestimonialDesignation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterTestimonialDesignation");
            cmd.Parameters.AddWithValue("@DesignationId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        /*******************Filter Company**********************/
        public DataTable FilterTestimonialCompany()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterTestimonialCompany");
            cmd.Parameters.AddWithValue("@CompanyId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        /****************************Hrithik's End*************************/

        public CoOrdinator(string centerName, string labName, int labCapacity, int availableSystem)
        {
            CenterAddress = centerName;
            LabName = labName;
            LabCapacity = labCapacity;
            AvailableSystem = availableSystem;
        }
        public DataTable GetLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetLab");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetLabName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetLabName");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            return dtt;
            con.Close();
        }



        public DataTable GetCenterAddress()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCenterAddress");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtgca = new DataTable();
            da.Fill(dtgca);
            return dtgca;
            con.Close();
        }



        public DataTable FilterByCenter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterByCenter");
            cmd.Parameters.AddWithValue("@CenterAddress", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtfbc = new DataTable();
            da.Fill(dtfbc);
            return dtfbc;
            con.Close();
        }





        public DataTable FilterLabName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterLabName");
            cmd.Parameters.AddWithValue("@LabName", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtfln = new DataTable();
            da.Fill(dtfln);
            return dtfln;
            con.Close();
        }

        public DataTable GetCenterName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCenterName");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtfcn = new DataTable();
            da.Fill(dtfcn);
            return dtfcn;
            con.Close();

        }
        public CoOrdinator(int centerId, string labName, int labCapacity, int availableSystem)
        {
            CenterId = centerId;
            LabName = labName;
            LabCapacity = labCapacity;
            AvailableSystem = availableSystem;
        }
        public void SaveLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveLab");
            cmd.Parameters.AddWithValue("@CenterId", CenterId);
            cmd.Parameters.AddWithValue("@LabName", LabName);
            cmd.Parameters.AddWithValue("@LabCapacity", LabCapacity);
            cmd.Parameters.AddWithValue("@AvailableSystem", AvailableSystem);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable UpadateLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpadateLab");
            cmd.Parameters.AddWithValue("@AvailableSystem", courseid);
            cmd.Parameters.AddWithValue("@LabId", batchid);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtul = new DataTable();
            da.Fill(dtul);
            return dtul;
            con.Close();
        }
        public DataTable GetCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourse");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable GetBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatch");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;



            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();
        }
        public CoOrdinator(string studentName, string courseName, string batchName, string selectCourseToChange)
        {
            StudentName = studentName;
            CourseName = courseName;
            BatchName = batchName;
            SelectCourseToChange = selectCourseToChange;

        }
        public DataTable UpdateCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateCourse");
            cmd.Parameters.AddWithValue("@StudentName", StudentName);
            cmd.Parameters.AddWithValue("@CourseName", CourseName);
            cmd.Parameters.AddWithValue("@BatchName", BatchName);
            cmd.Parameters.AddWithValue("@SelectCourseToChange", SelectCourseToChange);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtuc = new DataTable();
            da.Fill(dtuc);
            return dtuc;
            con.Close();
        }
        public DataTable TotalStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "TotalStudent");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable TotalCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "TotalCourse");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt1 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt1);
            return dt1;
            con.Close();
        }

        public DataTable ActiveBatches()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ActiveBatches");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt2);
            return dt2;
            con.Close();
        }

        public DataTable getghrph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.Parameters.AddWithValue("@Flag", "GetGraph");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt3 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt3);
            return dt3;
            con.Close();
        }

        public SqlDataReader GetBatchName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchName");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public DataTable GetBatchNameDr()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchNameDr");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable BatchGridview()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchDetails");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FilterTrainer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterTrainer");
            cmd.Parameters.AddWithValue("@StaffCode", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtF = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtF);
            return dtF;
            con.Close();
        }
        
        public DataTable FilterCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterCourse");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtC = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtC);
            return dtC;
            con.Close();
        }
        public DataTable FilterCourseName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterCourseName");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtCourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCourse);
            return dtCourse;
            con.Close();
        }
        public DataTable FilterBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterBatch");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtB = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtB);
            return dtB;
            con.Close();
        }
        public DataTable FilterBatchName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterBatchName");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtBatch = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtBatch);
            return dtBatch;
            con.Close();
        }
        public SqlDataReader GetBatchDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchDetails");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public DataTable GetgrdStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetgrdStudent");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtStud = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtStud);
            return dtStud;
            con.Close();
        }
        public int CourseId { get; set; }
        public int BatchId { get; set; }
        public String StudeCode { get; set; }
        public int NoOfStudent { get; set; }
        public String StaffCode { get; set; }
        public String BatchTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TentativeEndDate { get; set; }

        public string StaffName { get; set; }



        public DataTable GetTrainer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTrainer");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt1 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt1);
            return dt1;
            con.Close();
        }

        public DataTable GetBatchTimeColor()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchTimeColor");
            cmd.Parameters.AddWithValue("@StaffCode", studcode);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetStartDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetStartDate");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtStartDate = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtStartDate);
            return dtStartDate;
            con.Close();
        }
        public DataTable GetTentativeEndDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetTentativeEndDate");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtEndDate = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtEndDate);
            return dtEndDate;
            con.Close();
        }
        public DataTable GetStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchStatus");
            cmd.Parameters.AddWithValue("@StatusId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtStatus = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtStatus);
            return dtStatus;
            con.Close();
        }

        public DataTable GetBatchStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtStatus = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtStatus);
            return dtStatus;
            con.Close();
        }
        
        public DataTable GetStatusStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStatusStudent");
            cmd.Parameters.AddWithValue("@StatusId", courseid);
            cmd.Parameters.AddWithValue("@CourseId", batchid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dts = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dts);
            return dts;
            con.Close();
        }

        public DataTable GetFullName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetFullName");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dtstud = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dtstud);
            return dtstud;
            con.Close();
        }
        public DataTable GetRemoveAddBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetRemoveAddBatch");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            cmd.Parameters.AddWithValue("@BatchId",batchid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt5 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt5);
            return dt5;
            con.Close();
        }
        public CoOrdinator(string studcode, int id, int batchid)
        {
            StudCode = studcode;
            NoOfStudent = id;
            BatchId = batchid;
        }
        public void UpdateBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateBatch");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@NoOfStudent", NoOfStudent);
            cmd.Parameters.AddWithValue("@BatchId", BatchId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteExistingBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteExistingBatch");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// Surekha Teli

        public DataTable GetStudentsDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStudentsDetails");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetCourseName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseName");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FillterCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FillterCourse");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetTrainerName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTrainerName");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt1 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt1);
            return dt1;
            con.Close();
        }
        public DataTable FillterTrainer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FillterTrainer");
            cmd.Parameters.AddWithValue("@StaffCode", studcode);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable FillterBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FillterBatch");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public SqlDataReader GetBatchNameStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchNameStudent");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public SqlDataReader GetLableStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetLableStudent");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        // DhirajLohar

        public CoOrdinator(string Itemname, string category, int quantity, int price, int Totalprice, string Vendorname, string Vendoraddress, string bill, string remark, DateTime Inventorydate, string Statusid)
        {

            UserItemName = Itemname;
            UserCategory = category;
            UserQuantity = quantity;
            UserPrice = price;
            UserTotalPrice = Totalprice;
            UserVendorName = Vendorname;
            UserVendorAddress = Vendoraddress;
            UserBill = bill;
            UserRemark = remark;
            UserInventoryDate = Inventorydate;
            UserStatusId = Statusid;
        }
        public CoOrdinator(string Itemname, string category, int quantity, int price, int Totalprice, string Vendorname, string Vendoraddress, string bill, string remark, DateTime Inventorydate, string Statusid, int inveid)
        {

            UserItemName = Itemname;
            UserCategory = category;
            UserQuantity = quantity;
            UserPrice = price;
            UserTotalPrice = Totalprice;
            UserVendorName = Vendorname;
            UserVendorAddress = Vendoraddress;
            UserBill = bill;
            UserRemark = remark;
            UserInventoryDate = Inventorydate;
            UserStatusId = Statusid;
            InventoryId = inveid;
        }
       
        public DataTable InventoryManagment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Inventory");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }


        public DataTable InventorydateFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InventoryDateFilter");
            cmd.Parameters.AddWithValue("@Fromdate", StudeCode);
            cmd.Parameters.AddWithValue("@ToDate", CourseName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }




        public void AddInventory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "CreateInventory");
            cmd.Parameters.AddWithValue("@ItemName", UserItemName);
            cmd.Parameters.AddWithValue("@Category", UserCategory);
            cmd.Parameters.AddWithValue("@Quantity", UserQuantity);
            cmd.Parameters.AddWithValue("@Price", UserPrice);
            cmd.Parameters.AddWithValue("@TotalPrice", UserTotalPrice);
            cmd.Parameters.AddWithValue("@VendorName", UserVendorName);
            cmd.Parameters.AddWithValue("@VendorAddress", UserVendorAddress);
            cmd.Parameters.AddWithValue("@Bill", UserBill);
            cmd.Parameters.AddWithValue("@Remark", UserRemark);
            cmd.Parameters.AddWithValue("@InventoryDate", UserInventoryDate);
            cmd.Parameters.AddWithValue("@StatusId", UserStatusId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetInventoryStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetInventoryStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public void UpdateInventory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateInventory");
            cmd.Parameters.AddWithValue("@ItemName", UserItemName);
            cmd.Parameters.AddWithValue("@Category", UserCategory);
            cmd.Parameters.AddWithValue("@Quantity", UserQuantity);
            cmd.Parameters.AddWithValue("@Price", UserPrice);
            cmd.Parameters.AddWithValue("@TotalPrice", UserTotalPrice);
            cmd.Parameters.AddWithValue("@VendorName", UserVendorName);
            cmd.Parameters.AddWithValue("@VendorAddress", UserVendorAddress);
            cmd.Parameters.AddWithValue("@Bill", UserBill);
            cmd.Parameters.AddWithValue("@Remark", UserRemark);
            cmd.Parameters.AddWithValue("@InventoryDate", UserInventoryDate);
            cmd.Parameters.AddWithValue("@StatusId", UserStatusId);
            cmd.Parameters.AddWithValue("@InventoryId", InventoryId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetInventoryCategory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetInventoryCategory");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }


        public DataTable GetCategoryByFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetCategoryByFilter");
            cmd.Parameters.AddWithValue("@InventoryId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public SqlDataReader GenInventoryCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GenerateInventoryCode");
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        /**************Payment(Shilpa)***********/
        public DataTable GetName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetName");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtName = new DataTable();
            da.Fill(dtName);
            return dtName;
            con.Close();
        }

        public DataTable FetchPaymentStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchPaymentStatus");
            cmd.Parameters.AddWithValue("@StatusId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtstatus = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtstatus);
            return dtstatus;
            con.Close();
        }

        //public Coordinator(string sc, int pamount, int bamount, string pmode, DateTime pdate, int statusid)
        //{
        //    studcode = sc;
        //    PaidAmount = pamount;
        //    Balance = bamount;
        //    paymentMode = pmode;
        //    paiddate = pdate;
        //    StatusId = statusid;
        //}
        public DataTable UpdatePayment()
        {
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertPayment");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            cmd.Parameters.AddWithValue("@BalanceAmount", BalanceAmount);
            cmd.Parameters.AddWithValue("@PaymentMode", PaymentMode);
            cmd.Parameters.AddWithValue("@PaidDate", PaidDate);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtn = new DataTable();
            da.Fill(dtn);
            return dtn;
            con.Close();
        }
        public CoOrdinator(string sc, int pamount, int bamount, string pmode, DateTime pdate, int statusid)
        {
            studcode = sc;
            PaidAmount = pamount;
            BalanceAmount = bamount;
            PaymentMode = pmode;
            PaidDate = pdate;
            StatusId = statusid;
        }

        public DataTable GetPaymentDetail()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPaymentDetails");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable ViewPaymentDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewPaymentDetails");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            return dtt;
            con.Close();
        }

        public DataTable GetPendingPayment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPendingPayment");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetCompletePaymentDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCompletePaymentDetails");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();
        }





        /****************Change Course*******************/
        public SqlDataReader GetCourseBySname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseBySname");
            cmd.Parameters.AddWithValue("@StudFullName", studcode);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }


        public DataTable GetBatchForCourseChange()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchForCourseChange");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public CoOrdinator(int id, string sc)
        {
            courseid = id;
            StudCode = sc;
        }
        public void UpdateCandidateByChangeCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateCandidateByChangeCourse");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataReader GetCourseFees()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCoursefees");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public DataTable FilterByCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterByCourse");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dts = new DataTable();
            da.Fill(dts);
            return dts;
            con.Close();
        }

        public DataTable FilterByName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterByName");
            cmd.Parameters.AddWithValue("@StudFullName", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtn = new DataTable();
            da.Fill(dtn);
            return dtn;
            con.Close();
        }

        public DataTable FilterByStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterByStatus");
            cmd.Parameters.AddWithValue("@StatusId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtc = new DataTable();
            da.Fill(dtc);
            return dtc;
            con.Close();
        }

        /************Delete**************/
        public void DeleteTest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteTest");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteTestimonial()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteTestimonial");
            cmd.Parameters.AddWithValue("@TestimonialId", courseid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteResult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteResult");
            cmd.Parameters.AddWithValue("@ResultId", courseid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteFeedback()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteFeedback");
            cmd.Parameters.AddWithValue("@FeedbackId", courseid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteCandidate");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCertificate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteCertificate");
            cmd.Parameters.AddWithValue("@CertificateNo", studcode);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteBatch");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteLab()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteLab");
            cmd.Parameters.AddWithValue("@LabId", courseid);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteInventory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteInventory");
            cmd.Parameters.AddWithValue("@InventoryId", courseid);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Nayana


        //string CertificateNo { get; set; }
        //string StudentCode { get; set; }
        DateTime AdmissionDate { get; set; }
        DateTime CertificateDate { get; set; }
        //string Grade { get; set; }
        //string StudEmail { get; set; }

        public CoOrdinator(DateTime idate, string cno, int cid, string sn, string sc, DateTime ad, DateTime cd, string grade)
        {
            IssueDate = idate;
            CertificateNo = cno;
            courseId = cid;
            StudFullName = sn;
            StudentCode = sc;
            AdmissionDate = ad;
            CertificateDate = cd;
            Grade = grade;
        }

        public DataTable Get_Student_Name()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Get_Student_Name");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtStudent = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtStudent);
            return dtStudent;
            con.Close();
        }

        public SqlDataReader GetCertificateStudDetail()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCertificateStudDetail");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }


        public DataTable GetCertificationView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCertificationView");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCertification = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCertification);
            return dtCertification;
            con.Close();
        }

        public DataTable GetCertificationCourseFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCertificationViewfilterbycourse");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCertification = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCertification);
            return dtCertification;
            con.Close();
        }

        public DataTable GetCertificationNameFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCertificationViewfilterbyname");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCertification = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCertification);
            return dtCertification;
            con.Close();
        }


        //********************************************AddCertificateDetails*************************//



        public string CertificateNo { get; set; }
        public string StudentCode { get; set; }

        public DateTime DurationFrom { get; set; }
        public DateTime DurationTo { get; set; }
        public string Grade { get; set; }
        public CoOrdinator(DateTime id)
        {
            IssueDate = id;
        }

        public DataTable CertificationFilterDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CertificationFilterDate");
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtdate = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtdate);
            return dtdate;
            con.Close();
        }
        public CoOrdinator(DateTime issuedate, string cno, int cid, string sc, DateTime dfrom, DateTime dto, string grade)
        {
            IssueDate = issuedate;
            CertificateNo = cno;
            courseId = cid;
            StudentCode = sc;
            DurationFrom = dfrom;
            DurationTo = dto;
            Grade = grade;
        }
        public void InsertCertificationDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertCertificationDetails");
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@CertificateNo", CertificateNo);
            cmd.Parameters.AddWithValue("@CourseId", courseId);
            cmd.Parameters.AddWithValue("@StudFullName", StudFullName);
            cmd.Parameters.AddWithValue("@StudCode", StudentCode);
            cmd.Parameters.AddWithValue("@AdmissionDate", AdmissionDate);
            cmd.Parameters.AddWithValue("@CertificateDate", CertificateDate);
            cmd.Parameters.AddWithValue("@Grade", Grade);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Pranali Tembhurne

        public DataTable Get_Test()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTestExam");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtt);
            return dtt;
            con.Close();
        }



        public DataTable GetCourseExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseExam");
            cmd.Parameters.AddWithValue("@CourseId", courseid);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcourse);
            return dtcourse;
            con.Close();
        }

        public DataTable Get_ResultCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetResultCourse");
            cmd.Parameters.AddWithValue("@TestId", courseid);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcourse);
            return dtcourse;
            con.Close();
        }

        public DataTable GetBatchExam()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetBatchExam");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcourse);
            return dtcourse;
            con.Close();
        }


        public DataTable Get_ResultBatch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetResultBatch");
            // cmd.Parameters.AddWithValue("@TestId",TestId);
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtBatch = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtBatch);
            return dtBatch;
            con.Close();
        }
        public DataTable ResultTitleView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ResultTitleView");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable ResultCourseView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ResultCourseView");
            cmd.Parameters.AddWithValue("@CourseId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcourse);
            return dtcourse;
            con.Close();
        }

        public DataTable ResultBatchView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ResultBatchView");
            cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtBatch = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtBatch);
            return dtBatch;
            con.Close();
        }



        public DataTable FetchResult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchResultExam");
            // cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtt);
            return dtt;
            con.Close();
        }

        public DataTable ViewStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewStudentExam");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable ViewMore()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewMoreExam");
            cmd.Parameters.AddWithValue("@StudCode", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }
        public CoOrdinator(int id1, int id2, int id3, string studcode, int mark)
        {
            TestId = id1;
            CourseId = id2;
            BatchId = id3;
            StudCode = studcode;
            Marks = mark;
        }
        public void AddResult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddResult");
            cmd.Parameters.AddWithValue("@TestId", TestId);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@BatchId", BatchId);
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@Marks", Marks);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EditResult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateResult");
            cmd.Parameters.AddWithValue("@TestId", TestId);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@BatchId", BatchId);
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@Marks", Marks);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable fetchvalue()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "fetchvalue");
            // cmd.Parameters.AddWithValue("@BatchId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }


        //public DataTable GetStudentName()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "GetStudentName");
        //    cmd.Parameters.AddWithValue("@StudCode", studcode);
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    da.SelectCommand = cmd;
        //    da.Fill(dt);
        //    return dt;
        //    con.Close();
        //}
        public DataTable getResult()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getResult");
            cmd.Parameters.AddWithValue("@TestId", courseid);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable LeaveDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LeaveDetails");
            cmd.Parameters.AddWithValue("@StaffCode", studcode);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtld = new DataTable();
            da.Fill(dtld);
            return dtld;
            con.Close();
        }
        //Pranali Jagtap

        public void InsertCenterAddress()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertCenterAddress");
            cmd.Parameters.AddWithValue("@CenterAddress", studcode);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}