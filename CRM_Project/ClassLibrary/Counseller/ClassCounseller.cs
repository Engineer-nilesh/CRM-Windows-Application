using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clsCounsellor
{
    public class Counsellor
    {
        SqlConnection con = new SqlConnection("Data Source=DHIRAJ\\SQLEXPRESS;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int StatusId { get; set; }
        public String Comments { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string TaskAssignId { get; set; }
        public string ULeaveType { get; set; }
        public DateTime UFromDate { get; set; }
        public DateTime UToDate { get; set; }
        public string UDescription { get; set; }
        public int UStatusId { get; set; }
        public string StaffCode { get; set; }
        public int CourseId { get; set; }
        public string StudCode { get; set; }
        public string note { get; set; }
        public int StudId { get; set; }
        public string StudFullName { get; set; }
        public string StudFirstName { get; set; }
        public string StudMiddleName { get; set; }
        public string StudLastName { get; set; }
        public string StudContactNo { get; set; }
        public string StudAlternateNo { get; set; }
        public string StudEmail { get; set; }
        public string StudGender { get; set; }
        public string StudLocalAddress { get; set; }
        public string StudPermanentAddress { get; set; }
        public int StudCity { get; set; }
        public string StudPin { get; set; }
        public DateTime StudEnquiryDate { get; set; }
        public DateTime StudRegistrationDate { get; set; }
        public int StudGraduation { get; set; }
        public int StudPG { get; set; }
        public string StudOtherQualification { get; set; }
        public string StudProfessionalStatus { get; set; }
        public string StudReferences { get; set; }
        public int StudEnquirySource { get; set; }
        public int StudCourseInterested { get; set; }
        public int StudCourseType { get; set; }
        public string StudTimePreferred { get; set; }
        public string StudPreviousExperience { get; set; }
        public string StudCompanyName { get; set; }
        public string StudDesignation { get; set; }
        public string StudPeriod { get; set; }
        public DateTime StudDOB { get; set; }
        public string StudFatherName { get; set; }
        public string StudMotherName { get; set; }
        public string StudFatherContactNo { get; set; }
        public string StudMotherContactNo { get; set; }
        public string StudCollageName { get; set; }
        public int StudStatusId { get; set; }
        public string StudRegistrationFees { get; set; }
        public int StudNumberOfInstallments { get; set; }
        public string StudPaymentMethod { get; set; }
        public string StudTransactionId { get; set; }
        public string StudRaiseDiscount { get; set; }
        public string StudEnquiryComment { get; set; }
        public string StudPhotoFile { get; set; }
        public string StudAdharCardFile { get; set; }
        public string StudPanCardFile { get; set; }
        public string StudUnderGraduationFile { get; set; }
        public string StudGraduationFile { get; set; }
        public string StudPGFile { get; set; }
        public int StudCenterId { get; set; }
        public DateTime ExpectedDate { get; set; }
        public string DemoStudCode { get; set; }

        // Prabhakar

        public int Id { get; set; } //for country state city graduation PG CourseType Course
        public string Email { get; set; }
        public string DOB { get; set; }
        public string FathersName { get; set; }
        public string FathersContact { get; set; }
        public string MothersName { get; set; }
        public string MothersContact { get; set; }
        public int StudCityId { get; set; }
        public string StudPinNo { get; set; }
        public int SSC { get; set; }
        public int SSCYear { get; set; }
        public int HSC { get; set; }
        public int HSCYear { get; set; }
        public int Diploma { get; set; }
        public int DiplomaYear { get; set; }
        public int GradId { get; set; }
        public int GraduationYear { get; set; }
        public int PGId { get; set; }
        public int PGYear { get; set; }
        public string StudOtherCourse { get; set; }
        public int OtherCourseYear { get; set; }
        public string CollegeName { get; set; }
        public int CourseType { get; set; }
        public int Course { get; set; }
        public string PreviousExperience { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string Period { get; set; }
        public string PhotoFile { get; set; }
        public string AadharFile { get; set; }
        public string PanFile { get; set; }
        public string UnderGradFile { get; set; }
        public string GradFile { get; set; }
        public string PGFile { get; set; }
        public int RegistrationFees { get; set; }
        public int NoOfInstallments { get; set; }
        public string PaymentMode { get; set; }
        public string TransactionId { get; set; }
        public string RaiseDiscount { get; set; }

        // different class
        public string CourseName { get; set; }
        public int courseId { get; set; }
        public DateTime IssueDate { get; set; }
        public string SyllabusName { get; set; }
        public string SyllabusFile { get; set; }
        public string SyllabusDescription { get; set; }
        public string StaffName { get; set; }



        public Counsellor(string studcode, string FullName, string ContactNumber, string AlternateNumber, string EmailId, string Gender, string LocalAddress,
           string PermanentAddress, int City, string Pin, DateTime EnquiryDate, DateTime RegistrationDate, int Graduation, int PG, string OtherQualification,
           string ProfessionalStatus, string References, int EnquirySource, int CourseInterested, int CourseType, string TimePreferred,
           string PreviousExperience, string CompanyName, string Designation, string Period, DateTime DOB, string FatherName, string MotherName,
           string FatherContactNo, string MotherContactNo, string CollageName, int StatusId, string RegistrationFees, int NumberOfInstallments,
           string PaymentMethod, string TransactionId, string RaiseDiscount, string EnquiryComment, string PhotoFile, string AdharCardFile,
           string PanCardFile, string UnderGraduationFile, string GraduationFile, string PGFile, int centreid,string staffname)
        {
            StudCode = studcode;
            StudFullName = FullName;
            StudContactNo = ContactNumber;
            StudAlternateNo = AlternateNumber;
            StudEmail = EmailId;
            StudGender = Gender;
            StudLocalAddress = LocalAddress;
            StudPermanentAddress = PermanentAddress;
            StudCity = City;
            StudPin = Pin;
            StudEnquiryDate = EnquiryDate;
            StudRegistrationDate = RegistrationDate;
            StudGraduation = Graduation;
            StudPG = PG;
            StudOtherQualification = OtherQualification;
            StudProfessionalStatus = ProfessionalStatus;
            StudReferences = References;
            StudEnquirySource = EnquirySource;
            StudCourseInterested = CourseInterested;
            StudCourseType = CourseType;
            StudTimePreferred = TimePreferred;
            StudPreviousExperience = PreviousExperience;
            StudCompanyName = CompanyName;
            StudDesignation = Designation;
            StudPeriod = Period;
            StudDOB = DOB;
            StudFatherName = FatherName;
            StudMotherName = MotherName;
            StudFatherContactNo = FatherContactNo;
            StudMotherContactNo = MotherContactNo;
            StudCollageName = CollageName;
            StudStatusId = StatusId;
            StudRegistrationFees = RegistrationFees;
            StudNumberOfInstallments = NumberOfInstallments;
            StudPaymentMethod = PaymentMethod;
            StudTransactionId = TransactionId;
            StudRaiseDiscount = RaiseDiscount;
            StudEnquiryComment = EnquiryComment;
            StudPhotoFile = PhotoFile;
            StudAdharCardFile = AdharCardFile;
            StudPanCardFile = PanCardFile;
            StudUnderGraduationFile = UnderGraduationFile;
            StudGraduationFile = GraduationFile;
            StudPGFile = PGFile;
            StudCenterId = centreid;
            StaffName = staffname;


        }


        public Counsellor(DateTime fd, DateTime td)
        {
            StartDate = fd;
            EndDate = td;

        }

        public Counsellor(string email, string pass)
        {
            StaffEmail = email;
            StaffPassword = pass;
        }
        public Counsellor(string pass1, string pass2, string pass3)
        {
            StaffPassword = pass1;
            NewPassword = pass2;
            ConfirmPassword = pass3;
        }
        public Counsellor(String LeaveType, DateTime FromDate, DateTime ToDate, DateTime applydate, String Description, int StatusId, string sc)
        {
            ULeaveType = LeaveType;
            UFromDate = FromDate;
            UToDate = ToDate;
            StartDate = applydate;
            UDescription = Description;
            UStatusId = StatusId;
            StaffCode = sc;
        }
        public Counsellor(DateTime NewStartDate, DateTime NewEndDate, DateTime NewStartTime, DateTime NewEndTime, int id, String Description, int Studid)
        {
            StartDate = NewStartDate;
            EndDate = NewEndDate;
            StartTime = NewStartTime;
            EndTime = NewEndTime;
            StatusId = id;
            Comments = Description;
            StudId = Studid;
        }
        public Counsellor(string StaffCode)
        {
            TaskAssignId = StaffCode;
        }

        
        public Counsellor()
        {

        }
        public Counsellor(int cid)
        {
            CourseId = cid;

        }
        public Counsellor(String staffCode, int SId)
        {
            TaskAssignId = staffCode;
            StatusId = SId;
        }
        public Counsellor(DateTime sd, DateTime ed, String Staffcode)
        {
            StartDate = sd;
            EndDate = ed;
            TaskAssignId = Staffcode;
        }

        public Counsellor(string studCode, string Note, DateTime fDate, DateTime Ndate, int sid,string staffname)
        {
            StudCode = studCode;
            note = Note;
            StartDate = fDate;
            EndDate = Ndate;
            UStatusId = sid;
            StaffName = staffname;
        }

        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Login");
            cmd.Parameters.AddWithValue("@StaffEmail", StaffEmail);
            cmd.Parameters.AddWithValue("@StaffPassword", StaffPassword);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader GetAllStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllStudent");
            cmd.Parameters.AddWithValue("@StudCode", TaskAssignId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public void UpdatePassword()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdatePassword");
            cmd.Parameters.AddWithValue("@ConfirmPassword", ConfirmPassword);
            cmd.Parameters.AddWithValue("@StaffPassword", StaffPassword);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader ForgotPassword()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ForgotPassword");
            cmd.Parameters.AddWithValue("@StaffEmail", TaskAssignId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InsertNewEnquiry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertCandidate");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@StudFullName", StudFullName);
            cmd.Parameters.AddWithValue("@StudContactNo", StudContactNo);
            cmd.Parameters.AddWithValue("@StudAlternateNo", StudAlternateNo);
            cmd.Parameters.AddWithValue("@StudEmail", StudEmail);
            cmd.Parameters.AddWithValue("@StudGender", StudGender);
            cmd.Parameters.AddWithValue("@StudLocalAddress", StudLocalAddress);
            cmd.Parameters.AddWithValue("@StudPermanentAddress", StudPermanentAddress);
            cmd.Parameters.AddWithValue("@StudCityId", StudCity);
            cmd.Parameters.AddWithValue("@StudPinNo", StudPin);
            cmd.Parameters.AddWithValue("@StudEnquiryDate", StudEnquiryDate);
            cmd.Parameters.AddWithValue("@StudRegistrationDate", StudRegistrationDate);
            cmd.Parameters.AddWithValue("@GradId", StudGraduation);
            cmd.Parameters.AddWithValue("@PGId", StudPG);
            cmd.Parameters.AddWithValue("@StudOtherQualification", StudOtherQualification);
            cmd.Parameters.AddWithValue("@StudProfessionalStatus", StudProfessionalStatus);
            cmd.Parameters.AddWithValue("@StudReferences", StudReferences);
            cmd.Parameters.AddWithValue("@EnquirySourceId", StudEnquirySource);
            cmd.Parameters.AddWithValue("@CourseId", StudCourseInterested);
            cmd.Parameters.AddWithValue("@CourseTypeId", StudCourseType);
            cmd.Parameters.AddWithValue("@StudTimePreferred", StudTimePreferred);
            cmd.Parameters.AddWithValue("@StudPreviousExperience", StudPreviousExperience);
            cmd.Parameters.AddWithValue("@StudCompanyName", StudCompanyName);
            cmd.Parameters.AddWithValue("@StudDesignation", StudDesignation);
            cmd.Parameters.AddWithValue("@StudPeriod", StudPeriod);
            cmd.Parameters.AddWithValue("@StudDOB", StudDOB);
            cmd.Parameters.AddWithValue("@StudFatherName", StudFatherName);
            cmd.Parameters.AddWithValue("@StudMotherName", StudMotherName);
            cmd.Parameters.AddWithValue("@StudFatherContactNo", StudFatherContactNo);
            cmd.Parameters.AddWithValue("@StudMotherContactNo", StudMotherContactNo);
            cmd.Parameters.AddWithValue("@StudCollageName", StudCollageName);
            cmd.Parameters.AddWithValue("@StatusId", StudStatusId);
            cmd.Parameters.AddWithValue("@StudResistrationFees", StudRegistrationFees);
            cmd.Parameters.AddWithValue("@StudNumberOfInstallments ", StudNumberOfInstallments);
            cmd.Parameters.AddWithValue("@StudPaymentMethod ", StudPaymentMethod);
            cmd.Parameters.AddWithValue("@StudTransactionId ", StudTransactionId);
            cmd.Parameters.AddWithValue("@StudRaiseDiscount ", StudRaiseDiscount);
            cmd.Parameters.AddWithValue("@EnquiryComment", StudEnquiryComment);
            cmd.Parameters.AddWithValue("@StudPhotoFile ", StudPhotoFile);
            cmd.Parameters.AddWithValue("@StudAdharCardFile", StudAdharCardFile);
            cmd.Parameters.AddWithValue("@StudPanCardFile", StudPanCardFile);
            cmd.Parameters.AddWithValue("@StudUnderGraduationFile", StudUnderGraduationFile);
            cmd.Parameters.AddWithValue("@StudGraduationFile", StudGraduationFile);
            cmd.Parameters.AddWithValue("@StudPGFile", StudPGFile);
            cmd.Parameters.AddWithValue("@CenterId", StudCenterId);
            cmd.Parameters.AddWithValue("@EnquiryStaffName", StaffName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string HSCFile { get; set; }
        public string SSCFile { get; set; }
        public string DiplomaFile { get; set; }
        public Counsellor(string studcode, string staffcode, int hsc, int hscyer, string hscfile, int ssc, int sscyear, string sscfile, int diploma, int diplomayear, string diplomafile,
           int gradid, int gradyear, string gradfile, int pgid, int pgyear, string pgfile, string other, int otheryear)
        {
            StudCode = studcode;
            StaffCode = staffcode;
            HSC = hsc;
            HSCYear = hscyer;
            HSCFile = hscfile;
            SSC = ssc;
            SSCYear = sscyear;
            SSCFile = sscfile;
            Diploma = diploma;
            DiplomaYear = diplomayear;
            DiplomaFile = diplomafile;
            GradId = gradid;
            GraduationYear = gradyear;
            GradFile = gradfile;
            PGId = pgid;
            PGYear = pgyear;
            PGFile = pgfile;
            StudOtherCourse = other;
            OtherCourseYear = otheryear;
        }
        public void InsertEnqueryQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertQualification");
            cmd.Parameters.AddWithValue("@CandidateCode", StudCode);
            cmd.Parameters.AddWithValue("@SSC", SSC);
            if (SSCYear > 0)
            {
                cmd.Parameters.AddWithValue("@SSCYear", SSCYear);
            }
            cmd.Parameters.AddWithValue("@HSC", HSC);
            if (HSCYear > 0)
            {
                cmd.Parameters.AddWithValue("@HSCYear", HSCYear);
            }
            cmd.Parameters.AddWithValue("@Diploma", Diploma);
            if (DiplomaYear > 0)
            {
                cmd.Parameters.AddWithValue("@DiplomaYear", DiplomaYear);
            }
            if (OtherCourseYear > 0)
            {
                cmd.Parameters.AddWithValue("@OtherCourseYear", OtherCourseYear);

            }
            cmd.Parameters.AddWithValue("@GradId", GradId);
            if(GraduationYear > 0)
            {
                cmd.Parameters.AddWithValue("@GradYear", GraduationYear);
            }
            cmd.Parameters.AddWithValue("@PGId", PGId);
            if (PGYear > 0)
            {
                cmd.Parameters.AddWithValue("@PGYear", PGYear);
            }
            cmd.Parameters.AddWithValue("@OtherCourse", StudOtherCourse);
            if (OtherCourseYear > 0)
            {
                cmd.Parameters.AddWithValue("@OtherCourseYear", OtherCourseYear);
            }
            
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Counsellor(int hsc, int ssc, int diploma, int gradid, int pgid, string studcode)
        {
            StudCode = studcode;
            HSC = hsc;
            SSC = ssc;
            Diploma = diploma;
            GradId = gradid;
            PGId = pgid;
        }

        public void updateEnqueryQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateEnquiryQualification");
            cmd.Parameters.AddWithValue("@SSC", SSC);
            cmd.Parameters.AddWithValue("@HSC", HSC);
            cmd.Parameters.AddWithValue("@Diploma", Diploma);
            cmd.Parameters.AddWithValue("@GradId", GradId);
            cmd.Parameters.AddWithValue("@PGId", PGId);
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetEnquiry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquiry");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable GetEnquirymore()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquirymore");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }


        public DataTable GetMoreAdmission()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetMoreAdmission");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable GetMonthEnquirymore()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetMonthEnquirymore");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable GetTaskStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTaskStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable ViewTask()
        {
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewTask");
            cmd.Parameters.AddWithValue("@TaskAssignId", TaskAssignId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FilterTaskGridviewDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterTaskDate");
            cmd.Parameters.AddWithValue("@Fromdate", StartDate);
            cmd.Parameters.AddWithValue("@ToDate", EndDate);
            cmd.Parameters.AddWithValue("@TaskAssignId", TaskAssignId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();

        }
        public void UpdateTask()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateTask");
            cmd.Parameters.AddWithValue("@TaskStartDate", StartDate);
            cmd.Parameters.AddWithValue("@TaskEndDate", EndDate);
            cmd.Parameters.AddWithValue("@TaskStartTime", StartTime);
            cmd.Parameters.AddWithValue("@TaskEndTime", EndTime);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@Description", Comments);
            cmd.Parameters.AddWithValue("@TaskId", StudId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable taskstatusFillter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewTaskAsStatus");
            cmd.Parameters.AddWithValue("@StateId", StatusId);
            cmd.Parameters.AddWithValue("@TaskAssignId", TaskAssignId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //public DataTable MonthlyLeaves()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "MonthlyLeaves");
        //    cmd.Parameters.AddWithValue("@StaffCode", TaskAssignId);
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //    con.Close();
        //}

        public SqlDataReader MonthlyLeaves()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "MonthlyLeaves");
            cmd.Parameters.AddWithValue("@StaffCode", TaskAssignId);
            // cmd.Parameters.AddWithValue("@StaffName", StaffPassword);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }



        public DataTable LeaveDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LeaveDetails");
            cmd.Parameters.AddWithValue("@StaffCode", TaskAssignId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtld = new DataTable();
            da.Fill(dtld);
            return dtld;
            con.Close();
        }


        public DataTable GetTotalEnquiry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTotalEnquiry");
            cmd.Parameters.AddWithValue("@StaffCode", TaskAssignId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();
        }




        public SqlDataReader YearlyLeaves()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "YearlyLeaves");
            cmd.Parameters.AddWithValue("@StaffCode", TaskAssignId);
            // cmd.Parameters.AddWithValue("@StaffName", StaffPassword);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }


        //public DataTable YearlyLeaves()

        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "YearlyLeaves");
        //    cmd.Parameters.AddWithValue("@StaffCode", TaskAssignId);
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    DataTable dtt = new DataTable();
        //    da.Fill(dtt);
        //    return dtt;
        //    con.Close();
        //}


        public void SaveLeave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveLeave");
            cmd.Parameters.AddWithValue("@LeaveType", ULeaveType);
            cmd.Parameters.AddWithValue("@FromDate", UFromDate);
            cmd.Parameters.AddWithValue("@ToDate", UToDate);
            cmd.Parameters.AddWithValue("@LeaveApplyDate", StartDate);
            cmd.Parameters.AddWithValue("@Description", UDescription);
            cmd.Parameters.AddWithValue("@StatusId", UStatusId);
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Counsellor(int cid, string syllabusname, string content, string description)
        {
            CourseId = cid;
            SyllabusName = syllabusname;
            SyllabusFile = content;
            SyllabusDescription = description;
        }


        public void InsertSyllabus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertSyllabus");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@SyllabusName", SyllabusName);
            cmd.Parameters.AddWithValue("@SyllabusFile", SyllabusFile);
            cmd.Parameters.AddWithValue("@SyllabusDescription", SyllabusDescription);
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
        public DataTable DailyEnquiries()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetDailyEnquiries");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetDailyAdmission()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetDailyAdmission");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt1 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt1);
            return dt1;
            con.Close();
        }
        public DataTable MonthlyEnquiries()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetMonthlyEnquiries");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt2);
            return dt2;
            con.Close();
        }
        public DataTable MonthlyAdmission()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetMonthlyAdmission");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt3 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt3);
            return dt3;
            con.Close();

        }
        public DataTable Getghrph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.Parameters.AddWithValue("@flag", "Getghrph");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt4 = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt4);
            return dt4;
            con.Close();
        }
        public DataTable GetLeadEnquiryStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetLeadEnquiryStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtEnquierySource = new DataTable();
            adpt.Fill(dtEnquierySource);
            return dtEnquierySource;
            con.Close();

        }

        public DataTable LeadReportFromDateToDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LeadReportFromDateToDate");
            cmd.Parameters.AddWithValue("@Fromdate", StartDate);
            cmd.Parameters.AddWithValue("@ToDate", EndDate);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();

        }
        //public DataTable Get_LeadReport()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "Get_LeadReport");
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    adpt.SelectCommand = cmd;
        //    DataTable dtLeadReports = new DataTable();
        //    adpt.Fill(dtLeadReports);
        //    return dtLeadReports;
        //    con.Close();

        //}
        public DataTable GetLeadReport()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetNewLeadReports");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtLeadReports = new DataTable();
            adpt.Fill(dtLeadReports);
            return dtLeadReports;
            con.Close();

        }

        public DataTable GetNewLeadReports()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetNewLeadReports");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtLeadReports = new DataTable();
            adpt.Fill(dtLeadReports);
            return dtLeadReports;
            con.Close();

        }

        public DataTable GetInterestedCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourse");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtCourse = new DataTable();
            adpt.Fill(dtCourse);
            return dtCourse;
            con.Close();

        }

        public DataTable GetEnquirySourceStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquirySourceStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dta = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dta);
            return dta;
            con.Close();

        }

        public DataTable GetEnquirySource()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquirySource");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtEnquierySource = new DataTable();
            adpt.Fill(dtEnquierySource);
            return dtEnquierySource;
            con.Close();

        }

        public SqlDataReader CheckExistingEnquirySource()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckExistingEnquirySource");
            cmd.Parameters.AddWithValue("@EnquirySourceName", TaskAssignId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }


        //public DataTable GetEnquiryStatus()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "GetEnquiryStatus");
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    adpt.SelectCommand = cmd;
        //    DataTable dtEnquieryStatus = new DataTable();
        //    adpt.Fill(dtEnquieryStatus);
        //    return dtEnquieryStatus;
        //    con.Close();

        //}

        public DataTable GetEnquiryFollowUpStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquiryStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtEnquieryStatus = new DataTable();
            adpt.Fill(dtEnquieryStatus);
            return dtEnquieryStatus;
            con.Close();

        }


        public DataTable GetEnquiryStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquiryStatus");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtEnquieryStatus = new DataTable();
            adpt.Fill(dtEnquieryStatus);
            return dtEnquieryStatus;
            con.Close();

        }





        public DataTable GetGraduation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetGraduation");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtGraduation = new DataTable();
            adpt.Fill(dtGraduation);
            return dtGraduation;
            con.Close();

        }

        public DataTable EnquiryStatusFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EnquiryStatusFilter");
            cmd.Parameters.AddWithValue("StatusId", CourseId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtEnquieryStatusview = new DataTable();
            adpt.Fill(dtEnquieryStatusview);
            return dtEnquieryStatusview;
            con.Close();

        }


        public DataTable InterestedCourseFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InterestedCourseFilter");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtCourseView = new DataTable();
            adpt.Fill(dtCourseView);
            return dtCourseView;
            con.Close();

        }

        public DataTable EnquirySourceFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EnquirySourceFilter");
            // cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@EnquirySourceId", CourseId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtSourceView = new DataTable();
            adpt.Fill(dtSourceView);
            return dtSourceView;
            con.Close();

        }
        public DataTable FilterEnquiryStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterEnquiryStatus");
            cmd.Parameters.AddWithValue("@StatusId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            return dtt;
            con.Close();


        }

        public DataTable QualificationFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "QualificationFilter");
            cmd.Parameters.AddWithValue("@GradId", CourseId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtQualificationView = new DataTable();
            adpt.Fill(dtQualificationView);
            return dtQualificationView;
            con.Close();

        }
        public DataTable Get_PlacedStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPlacedStudent");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtt);
            return dtt;
            con.Close();

        }

        public DataTable GetCourse()
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
        public DataTable Get_CourseType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseType");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcourse);
            return dtcourse;
            con.Close();
        }

        public DataTable PlacedCourseView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PlacedCourseView");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtCourseFiltter = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCourseFiltter);
            return dtCourseFiltter;
            con.Close();

        }

        public DataTable Get_Student()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Getstudent");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtname = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtname);
            return dtname;
            con.Close();


        }


        public DataTable PlacedNameView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PlacedNameView");
            //cmd.Parameters.AddWithValue("@StudId", "StudId");
            cmd.Parameters.AddWithValue("@StudId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtNameFilter = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtNameFilter);
            return dtNameFilter;
            con.Close();


        }



        public DataTable Get_Company()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCompany");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtcompany = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtcompany);
            return dtcompany;
            con.Close();


        }
        public DataTable PlacedCompanyView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PlacedCompanyView");
            cmd.Parameters.AddWithValue("@CompanyId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtCompanyFilter = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCompanyFilter);
            return dtCompanyFilter;
            con.Close();


        }




        public DataTable Get_Designation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetDesignation");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtdesignation = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtdesignation);
            return dtdesignation;
            con.Close();


        }


        public DataTable PlacedDesignationView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PlacedDesignationView");
            cmd.Parameters.AddWithValue("@DesignationId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtDesignation = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtDesignation);
            return dtDesignation;
            con.Close();


        }
        public DataTable GetFollowUp()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetFollowUp");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public Counsellor(int sid, string stud)
        {
            StatusId = sid;
            StudCode = stud;
        }

        public SqlDataReader Updateandidatebyfollowup()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Updateandidatebyfollowup");
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }


        public void InsertFollowUp()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertFollowUp");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@Note", note);
            cmd.Parameters.AddWithValue("@FollowUpDate", StartDate);
            cmd.Parameters.AddWithValue("@NextFollowUpDate", EndDate);
            cmd.Parameters.AddWithValue("@StatusId", UStatusId);
            cmd.Parameters.AddWithValue("@FollowUpStaffName", StaffName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ViewFollowUp()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewFollowUp");
            cmd.Parameters.AddWithValue("@StudCode", TaskAssignId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            return dtt;
            con.Close();
        }

        public DataTable FilterGridviewDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FilterGridviewDate");
            cmd.Parameters.AddWithValue("@FromDate", StartDate);
            cmd.Parameters.AddWithValue("@ToDate", EndDate);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            return dtt;
            con.Close();

        }

        public DataTable GetPlacedStudentbydate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPlacedStudentbydate");
            cmd.Parameters.AddWithValue("@Fromdate", StartDate);
            cmd.Parameters.AddWithValue("@ToDate", EndDate);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();

        }

        public SqlDataReader GetStaff()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStaff");
            cmd.Parameters.AddWithValue("@StaffCode", TaskAssignId);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public Counsellor(int cid, string scode, DateTime excepteddate)
        {
            CourseId = cid;
            StudCode = scode;
            ExpectedDate = excepteddate;

        }



        public DataTable GetDemoCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourse");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtCourse = new DataTable();
            adpt.Fill(dtCourse);
            return dtCourse;
            con.Close();

        }


        public DataTable GetDemoStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetDemoStudent");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetArrangeDemoDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetArrangeDemoDetails");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        //public DataTable GetArrangeDemoDetails()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "GetArrangeDemoDetails");
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    DataTable dtA = new DataTable();
        //    adpt.SelectCommand = cmd;
        //    adpt.Fill(dtA);
        //    return dtA;
        //    con.Close();
        //}



        public void SaveDemo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveDemo");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@DemoStudCode", StudCode);
            cmd.Parameters.AddWithValue("@ExpectedDate", ExpectedDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //**** Prabhakar

        public SqlDataReader GenStudCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GenerateStudCode");
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        //Country State and City
        public DataTable GetCountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCountry");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetState()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetState");
            cmd.Parameters.AddWithValue("@CountryId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetCity()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCity");
            cmd.Parameters.AddWithValue("@StateId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }


        public DataTable GetPG()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPG");
            cmd.Parameters.AddWithValue("@GradId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetCourseType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseType");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }


        public DataTable GetAllCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllCourse");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable Get_Course()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCoursefromCourseType");
            cmd.Parameters.AddWithValue("@CourseTypeId", Id);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public SqlDataReader GetCourseFees()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseFees");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public DataTable GetAdmission()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAdmission");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetRegularAdmission()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetRegularAdmission");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetAdmissionCoursefilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAdmissionCoursefilter");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dtCourseView = new DataTable();
            adpt.Fill(dtCourseView);
            return dtCourseView;
            con.Close();

        }


        public DataTable GetDiscountAdmission()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetDiscountAdmission");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetSearchedAdmission()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSearchedAdmission");
            cmd.Parameters.AddWithValue("@CourseName", StaffPassword);
            cmd.Parameters.AddWithValue("@AdmissionStartDate", NewPassword);
            cmd.Parameters.AddWithValue("@AdmissionEndDate", ConfirmPassword);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable GetStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAdmissionStatus");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
            con.Close();
        }

        public Counsellor(string studcode,
             string studfullname,
             string studcontactno,
             string studalternaterno,
             string email,
             string dob,
             string studgender,
             string fathersname,
             string fatherscontact,
             string mothersname,
             string motherscontact,
             string studlocaladdress,
             string studpermanentaddress,
             int studcityid,
             string studpinno,
             DateTime studenquirydate,
             DateTime studregistrationdate,
             int ssc,
             int sscyear,
             int hsc,
             int hscyear,
             int diploma,
             int diplomayear,
             int gradid,
             int gradyear,
             int pgid,
             int pgyear,
             string studothercourse,
             int studothercourseyear,
             string collegename,
             int coursetype,
             int course,
             int statusid,
             string previousexperience,
             string companyname,
             string designation,
             string period,
             string photofile,
             string aadharfile,
             string panfile,
             string undergradfile,
             string gradfile,
             string pgfile,
             int registrationfees,
             int noofinstallments,
             string paymentmode,
             string transactionid,
             string raisediscount
             )
        {
            StudCode = studcode;
            StudFullName = studfullname;
            StudContactNo = studcontactno;
            StudAlternateNo = studalternaterno;
            Email = email;
            DOB = dob;
            StudGender = studgender;
            FathersName = fathersname;
            FathersContact = fatherscontact;
            MothersName = mothersname;
            MothersContact = motherscontact;
            StudLocalAddress = studlocaladdress;
            StudPermanentAddress = studpermanentaddress;
            StudCityId = studcityid;
            StudPinNo = studpinno;
            StudEnquiryDate = studenquirydate;
            StudRegistrationDate = studregistrationdate;
            SSC = ssc;
            SSCYear = sscyear;
            HSC = hsc;
            HSCYear = hscyear;
            Diploma = diploma;
            DiplomaYear = diplomayear;
            GradId = gradid;
            GraduationYear = gradyear;
            PGId = pgid;
            PGYear = pgyear;
            StudOtherCourse = studothercourse;
            OtherCourseYear = studothercourseyear;
            CollegeName = collegename;
            CourseType = coursetype;
            Course = course;
            StatusId = statusid;
            PreviousExperience = previousexperience;
            CompanyName = companyname;
            Designation = designation;
            Period = period;
            PhotoFile = photofile;
            AadharFile = aadharfile;
            PanFile = panfile;
            UnderGradFile = undergradfile;
            GradFile = gradfile;
            PGFile = pgfile;
            RegistrationFees = registrationfees;
            NoOfInstallments = noofinstallments;
            PaymentMode = paymentmode;
            TransactionId = transactionid;
            RaiseDiscount = raisediscount;
        }

        public void InsertCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateAdmission");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@StudFullName", StudFullName);
            cmd.Parameters.AddWithValue("@StudContactNo", StudContactNo);
            cmd.Parameters.AddWithValue("@StudAlternateNo", StudAlternateNo);
            cmd.Parameters.AddWithValue("@StudEmail", Email);
            cmd.Parameters.AddWithValue("@StudDOB", DOB);
            cmd.Parameters.AddWithValue("@StudGender", StudGender);
            cmd.Parameters.AddWithValue("@StudFatherName", FathersName);
            cmd.Parameters.AddWithValue("@StudFatherContactNo", FathersContact);
            cmd.Parameters.AddWithValue("@StudMotherName", MothersName);
            cmd.Parameters.AddWithValue("@StudMotherContactNo", MothersContact);
            cmd.Parameters.AddWithValue("@StudLocalAddress", StudLocalAddress);
            cmd.Parameters.AddWithValue("@StudPermanentAddress", StudPermanentAddress);
            cmd.Parameters.AddWithValue("@StudCityId", StudCityId);
            cmd.Parameters.AddWithValue("@StudPinNo", StudPinNo);
            cmd.Parameters.AddWithValue("@StudEnquiryDate", StudEnquiryDate);
            cmd.Parameters.AddWithValue("@StudRegistrationDate", StudRegistrationDate);
            cmd.Parameters.AddWithValue("@GradId", GradId);
            cmd.Parameters.AddWithValue("@PGId", PGId);
            cmd.Parameters.AddWithValue("@StudOtherQualification", StudOtherCourse);
            cmd.Parameters.AddWithValue("@StudCollageName", CollegeName);
            cmd.Parameters.AddWithValue("@CourseTypeId", CourseType);
            cmd.Parameters.AddWithValue("@CourseId", Course);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@StudPreviousExperience", PreviousExperience);
            cmd.Parameters.AddWithValue("@StudCompanyName", CompanyName);
            cmd.Parameters.AddWithValue("@StudDesignation", Designation);
            cmd.Parameters.AddWithValue("@StudPeriod", Period);
            cmd.Parameters.AddWithValue("@StudPhotoFile", PhotoFile);
            cmd.Parameters.AddWithValue("@StudAdharCardFile", AadharFile);
            cmd.Parameters.AddWithValue("@StudPanCardFile", PanFile);
            cmd.Parameters.AddWithValue("@StudUnderGraduationFile", UnderGradFile);
            cmd.Parameters.AddWithValue("@StudGraduationFile", GradFile);
            cmd.Parameters.AddWithValue("@StudPGFile", PGFile);
            cmd.Parameters.AddWithValue("@StudResistrationFees", RegistrationFees);
            cmd.Parameters.AddWithValue("@StudNumberOfInstallments", NoOfInstallments);
            cmd.Parameters.AddWithValue("@StudPaymentMethod", PaymentMode);
            cmd.Parameters.AddWithValue("@StudTransactionId", TransactionId);
            cmd.Parameters.AddWithValue("@StudRaiseDiscount", RaiseDiscount);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InsertQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertQualification");
            cmd.Parameters.AddWithValue("@CandidateCode", StudCode);
            cmd.Parameters.AddWithValue("@SSC", SSC);
            if(SSCYear > 0)
            {
                cmd.Parameters.AddWithValue("@SSCYear", SSCYear);
            }
            cmd.Parameters.AddWithValue("@HSC", HSC);
            if (HSCYear > 0)
            {
                cmd.Parameters.AddWithValue("@HSCYear", HSCYear);
            }
            cmd.Parameters.AddWithValue("@Diploma", Diploma);
            if (DiplomaYear > 0)
            {
                cmd.Parameters.AddWithValue("@DiplomaYear", DiplomaYear);
            }
            cmd.Parameters.AddWithValue("@GradId", GradId);
            if (GraduationYear > 0)
            {
                cmd.Parameters.AddWithValue("@GradYear", GraduationYear);
            }
            cmd.Parameters.AddWithValue("@PGId", PGId);
            if (PGYear > 0)
            {
                cmd.Parameters.AddWithValue("@PGYear", PGYear);
            }
            cmd.Parameters.AddWithValue("@OtherCourse", StudOtherCourse);
            if (OtherCourseYear > 0)
            {
                cmd.Parameters.AddWithValue("@OtherCourseYear", OtherCourseYear);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateAdmission");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@StudFullName", StudFullName);
            cmd.Parameters.AddWithValue("@StudContactNo", StudContactNo);
            cmd.Parameters.AddWithValue("@StudAlternateNo", StudAlternateNo);
            cmd.Parameters.AddWithValue("@StudEmail", Email);
            cmd.Parameters.AddWithValue("@StudDOB", DOB);
            cmd.Parameters.AddWithValue("@StudGender", StudGender);
            cmd.Parameters.AddWithValue("@StudFatherName", FathersName);
            cmd.Parameters.AddWithValue("@StudFatherContactNo", FathersContact);
            cmd.Parameters.AddWithValue("@StudMotherName", MothersName);
            cmd.Parameters.AddWithValue("@StudMotherContactNo", MothersContact);
            cmd.Parameters.AddWithValue("@StudLocalAddress", StudLocalAddress);
            cmd.Parameters.AddWithValue("@StudPermanentAddress", StudPermanentAddress);
            cmd.Parameters.AddWithValue("@StudCityId", StudCityId);
            cmd.Parameters.AddWithValue("@StudPinNo", StudPinNo);
            cmd.Parameters.AddWithValue("@StudEnquiryDate", StudEnquiryDate);
            cmd.Parameters.AddWithValue("@StudRegistrationDate", StudRegistrationDate);
            cmd.Parameters.AddWithValue("@GradId", GradId);
            cmd.Parameters.AddWithValue("@PGId", PGId);
            cmd.Parameters.AddWithValue("@StudOtherQualification", StudOtherCourse);
            cmd.Parameters.AddWithValue("@StudCollageName", CollegeName);
            cmd.Parameters.AddWithValue("@CourseTypeId", CourseType);
            cmd.Parameters.AddWithValue("@CourseId", Course);
            cmd.Parameters.AddWithValue("@StatusId", StatusId);
            cmd.Parameters.AddWithValue("@StudPreviousExperience", PreviousExperience);
            cmd.Parameters.AddWithValue("@StudCompanyName", CompanyName);
            cmd.Parameters.AddWithValue("@StudDesignation", Designation);
            cmd.Parameters.AddWithValue("@StudPeriod", Period);
            cmd.Parameters.AddWithValue("@StudPhotoFile", PhotoFile);
            cmd.Parameters.AddWithValue("@StudAdharCardFile", AadharFile);
            cmd.Parameters.AddWithValue("@StudPanCardFile", PanFile);
            cmd.Parameters.AddWithValue("@StudUnderGraduationFile", UnderGradFile);
            cmd.Parameters.AddWithValue("@StudGraduationFile", GradFile);
            cmd.Parameters.AddWithValue("@StudPGFile", PGFile);
            cmd.Parameters.AddWithValue("@StudResistrationFees", RegistrationFees);
            cmd.Parameters.AddWithValue("@StudNumberOfInstallments", NoOfInstallments);
            cmd.Parameters.AddWithValue("@StudPaymentMethod", PaymentMode);
            cmd.Parameters.AddWithValue("@StudTransactionId", TransactionId);
            cmd.Parameters.AddWithValue("@StudRaiseDiscount", RaiseDiscount);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateQualification");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@SSC", SSC);
            if (SSCYear > 0)
            {
                cmd.Parameters.AddWithValue("@SSCYear", SSCYear);
            }
            cmd.Parameters.AddWithValue("@HSC", HSC);
            if (HSCYear > 0)
            {
                cmd.Parameters.AddWithValue("@HSCYear", HSCYear);
            }
            cmd.Parameters.AddWithValue("@Diploma", Diploma);
            if (DiplomaYear > 0)
            {
                cmd.Parameters.AddWithValue("@DiplomaYear", DiplomaYear);
            }
            if (OtherCourseYear > 0)
            {
                cmd.Parameters.AddWithValue("@OtherCourseYear", OtherCourseYear);

            }
            cmd.Parameters.AddWithValue("@GradId", GradId);
            if (GraduationYear > 0)
            {
                cmd.Parameters.AddWithValue("@GradYear", GraduationYear);
            }
            cmd.Parameters.AddWithValue("@PGId", PGId);
            if (PGYear > 0)
            {
                cmd.Parameters.AddWithValue("@PGYear", PGYear);
            }
            cmd.Parameters.AddWithValue("@OtherCourse", StudOtherCourse);
            if (OtherCourseYear > 0)
            {
                cmd.Parameters.AddWithValue("@OtherCourseYear", OtherCourseYear);
            }

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataReader GetStudentDetail()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStudentDetails");
            cmd.Parameters.AddWithValue("@StudCode", TaskAssignId);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader GetStudentDetailsForUpdate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStudentDetailsForUpdate");
            cmd.Parameters.AddWithValue("@StudCode", TaskAssignId);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        // Nayana (Tanmay)
        public Counsellor(DateTime idate)
        {
            IssueDate = idate;

        }

        public DataTable GetCourseId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCoursefromCourseType");
            cmd.Parameters.AddWithValue("@CourseTypeId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dtCourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCourse);
            return dtCourse;
            con.Close();
        }


        public DataTable GetStudentName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCoOrdinatorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Get_Student_Name");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtStudent = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtStudent);
            return dtStudent;
            con.Close();
        }
        public DataTable GetCourseIntrested()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCourseIntrested");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCourse);
            return dtCourse;
            con.Close();
        }

        public DataTable GetEnquiryCourseFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquiryCourseFilter");
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCourse);
            return dtCourse;
            con.Close();
        }

        public DataTable GetEnquiryQualificationFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquiryQualificationFilter");
            cmd.Parameters.AddWithValue("@GradId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCourse);
            return dtCourse;
            con.Close();
        }

        public DataTable GetEnquirySourceFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquirySourceFilter");
            cmd.Parameters.AddWithValue("@EnquirySourceId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCourse);
            return dtCourse;
            con.Close();
        }

        public DataTable GetEnquiryStatusFilter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetEnquiryStatusFilter");
            cmd.Parameters.AddWithValue("@StatusId", CourseId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCourse = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dtCourse);
            return dtCourse;
            con.Close();
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

        //********************************************AddCertificateDetails*************************//



        public string CertificateNo { get; set; }
        public string StudentCode { get; set; }

        public DateTime DurationFrom { get; set; }
        public DateTime DurationTo { get; set; }
        public string Grade { get; set; }

        public Counsellor(DateTime issuedate, string cno, int cid, string sc, DateTime dfrom, DateTime dto, string grade)
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
            cmd.Parameters.AddWithValue("@StudCode", StudentCode);
            cmd.Parameters.AddWithValue("@DurationFrom", DurationFrom);
            cmd.Parameters.AddWithValue("@DurationTo", DurationTo);
            cmd.Parameters.AddWithValue("@Grade", Grade);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Counsellor(string FullName, string ContactNumber, string EmailId,
           string PermanentAddress, int City, string Pin, DateTime RegistrationDate, 
           int Graduation, int PG,string ProfessionalStatus,int EnquirySource, 
           int CourseInterested, string TimePreferred, string studcode)
        {
            StudCode = studcode;
            StudFullName = FullName;
            StudContactNo = ContactNumber;
            StudEmail = EmailId;
            StudPermanentAddress = PermanentAddress;
            StudCity = City;
            StudPin = Pin;
            StudRegistrationDate = RegistrationDate;
            StudGraduation = Graduation;
            StudPG = PG;
            StudProfessionalStatus = ProfessionalStatus;
            StudEnquirySource = EnquirySource;
            StudCourseInterested = CourseInterested;
            StudTimePreferred = TimePreferred;
            
        }
        public void EditEnquiry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateEnquiry");
            cmd.Parameters.AddWithValue("@StudFullName", StudFullName);
            cmd.Parameters.AddWithValue("@StudContactNo", StudContactNo);
            cmd.Parameters.AddWithValue("@StudEmail", StudEmail);
            cmd.Parameters.AddWithValue("@StudPermanentAddress", StudPermanentAddress);
            cmd.Parameters.AddWithValue("@StudCityId", StudCity);
            cmd.Parameters.AddWithValue("@StudPinNo", StudPin);
            cmd.Parameters.AddWithValue("@StudRegistrationDate", StudRegistrationDate);
            cmd.Parameters.AddWithValue("@GradId", StudGraduation);
            cmd.Parameters.AddWithValue("@PGId", StudPG);
            cmd.Parameters.AddWithValue("@StudProfessionalStatus", StudProfessionalStatus);
            cmd.Parameters.AddWithValue("@CourseId", StudCourseType);
            cmd.Parameters.AddWithValue("@EnquirySourceId", StudEnquirySource);
            cmd.Parameters.AddWithValue("@StudTimePreferred", StudTimePreferred);
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // From Nayana

        public void InsertEnquirySource()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "InsertEnquirySource");
            cmd.Parameters.AddWithValue("@EnquirySourceName", TaskAssignId);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public SqlDataReader GetStaffName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStaffName");
            cmd.Parameters.AddWithValue("@StaffCode", TaskAssignId);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }


        public SqlDataReader CheckExistingCandidate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckExistingCandidate");
            cmd.Parameters.AddWithValue("@StudCode", StaffEmail);
            cmd.Parameters.AddWithValue("@StudEmail", StaffPassword);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader CheckExistingCandidatePhone()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckExistingCandidatePhone");
            cmd.Parameters.AddWithValue("@StudContactNo", TaskAssignId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }



        public SqlDataReader CheckExistingPhone()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckExistingPhone");
            cmd.Parameters.AddWithValue("@StudCode", StaffEmail);
            cmd.Parameters.AddWithValue("@StudContactNo", StaffPassword);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader CheckExistingCandidateEmail()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckExistingCandidateEmail");
            cmd.Parameters.AddWithValue("@StudEmail", TaskAssignId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public DataTable FilterManagementGridviewDate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EnquiryManagementDateFilter");
            cmd.Parameters.AddWithValue("@FromDate", StartDate);
            cmd.Parameters.AddWithValue("@ToDate", EndDate);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            con.Close();

        }



        public SqlDataReader FetchLocation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchLocation");
            cmd.Parameters.AddWithValue("@StudCode", TaskAssignId);
            cmd.Parameters.AddWithValue("@StudCityId", StatusId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }



        public SqlDataReader FetchCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchCourse");
            cmd.Parameters.AddWithValue("@StudCode", TaskAssignId);
            cmd.Parameters.AddWithValue("@CourseId", StatusId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader FetchQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchQualification");
            cmd.Parameters.AddWithValue("@StudCode", TaskAssignId);
            cmd.Parameters.AddWithValue("@GradId", StatusId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
    }
}
