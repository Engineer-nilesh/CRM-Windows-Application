using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace clsAdmin
{
    public class AdminClass
    {
        SqlConnection con = new SqlConnection("Data Source=DHIRAJ\\SQLEXPRESS;Initial Catalog=GSTEducationalCRMSoftware;Integrated Security=True");
        public string StaffCode { get; set; }
        public string CandidateCode { get; set; }
        public string StaffName { get; set; }
        public string StaffContact { get; set; }
        public string StaffAlternateContact { get; set; }
        public string StaffAddress { get; set; }
        public int CityId { get; set; }
        public string StaffAdhar { get; set; }
        public string StaffPan { get; set; }
        public string StaffEmail { get; set; }
        public string StaffGender { get; set; }
        public DateTime StaffDOB { get; set; }
        public int GradId { get; set; }
        public int PGId { get; set; }
        public string StaffBank { get; set; }
        public string StaffIFSC { get; set; }
        public string StaffAccount { get; set; }
        public string StaffBranch { get; set; }
        public string SSCPercentage { get; set; }
        public string HSCPercentage { get; set; }
        public string DiplomaPercentage { get; set; }
        public string GraduationPercentage { get; set; }
        public string PostGraduationPercentage { get; set; }
        public int SSC { get; set; }
        public int HSC { get; set; }
        public int Diploma { get; set; }
        public int SSCYear { get; set; }
        public int HSCYear { get; set; }
        public int DiplomaYear { get; set; }
        public int GraduationYear { get; set; }
        public int PostGraduationYear { get; set; }
        public string SSCFile { get; set; }
        public string HSCFile { get; set; }
        public string DiplomaFile { get; set; }
        public string GradautionFile { get; set; }
        public string PGFile { get; set; }
        public int ReportingPersonId { get; set; }
        public int CenterId { get; set; }
        public int StaffPositionId { get; set; }
        public int CourseId { get; set; }
        public string StaffPassword { get; set; }
        public DateTime StaffJoiningDate { get; set; }
        public int StaffStatus { get; set; }
        public string OtherCourse { get; set; }
        public int OtherCourseYear { get; set; }
        public int OtherCoursePecentage { get; set; }
        public AdminClass() { }

        // Save Staff Constructor
        public AdminClass(string staffCode, string staffName, string staffContact, string staffAlternateContact,
            string staffAddress, int cityId, string staffAdhar, string staffPan, string staffEmail, string staffGender,
            DateTime staffDOB, int gradId, int pGId, string staffBank, string staffIFSC, string staffAccount, string staffBranch,
            int reportingPersonId, int centerId, int staffPositionId, int courseId, string staffPassword, DateTime staffJoiningDate, int staffStatus)
        {
            StaffCode = staffCode;
            StaffName = staffName;
            StaffContact = staffContact;
            StaffAlternateContact = staffAlternateContact;
            StaffAddress = staffAddress;
            CityId = cityId;
            StaffAdhar = staffAdhar;
            StaffPan = staffPan;
            StaffEmail = staffEmail;
            StaffGender = staffGender;
            StaffDOB = staffDOB;
            GradId = gradId;
            PGId = pGId;
            StaffBank = staffBank;
            StaffIFSC = staffIFSC;
            StaffAccount = staffAccount;
            StaffBranch = staffBranch;
            ReportingPersonId = reportingPersonId;
            CenterId = centerId;
            StaffPositionId = staffPositionId;
            CourseId = courseId;
            StaffPassword = staffPassword;
            StaffJoiningDate = staffJoiningDate;
            StaffStatus = staffStatus;
        }

        // Staff Save Qualification
        public AdminClass(string staffCode, int sscyear, string sSCFile, int hscyear, string hSCFile, int gradId,
            int gradyear, string gradautionFile, int pGId, int pgyear, string pGFile)
        {
            StaffCode = staffCode;
            SSCYear = sscyear;
            SSCFile = sSCFile;
            HSCYear = hscyear;
            HSCFile = hSCFile;
            GradId = gradId;
            GraduationYear = gradyear;
            GradautionFile = gradautionFile;
            PGId = pGId;
            PostGraduationYear = pgyear;
            PGFile = pGFile;
        }
        // Update Staff
        public AdminClass(string staffName, string staffContact, string staffAddress, int cityId, string staffAdhar, string staffPan, string staffEmail,
            string staffGender, DateTime staffDOB, string staffBank, string staffIFSC, string staffAccount, string staffBranch, string staffCode)
        {
            StaffName = staffName;
            StaffContact = staffContact;
            StaffAddress = staffAddress;
            CityId = cityId;
            StaffAdhar = staffAdhar;
            StaffPan = staffPan;
            StaffEmail = staffEmail;
            StaffGender = staffGender;
            StaffDOB = staffDOB;
            StaffBank = staffBank;
            StaffIFSC = staffIFSC;
            StaffAccount = staffAccount;
            StaffBranch = staffBranch;
            StaffCode = staffCode;
        }

        // Update Qualification
        public AdminClass (int sscyear, string sSCFile, int hscyear, string hSCFile, int gradId, int gradyear, string gradautionFile, int pGId,
            int pgyear, string pGFile, string staffCode)
        {
            SSCYear = sscyear;
            SSCFile = sSCFile;
            HSCYear = hscyear;
            HSCFile = hSCFile;
            GradId = gradId;
            GraduationYear = gradyear;
            GradautionFile = gradautionFile;
            PGId = pGId;
            PostGraduationYear = pgyear;
            PGFile = pGFile;
            StaffCode = staffCode;
        }
        public void SaveStaff()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveStaff");
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            cmd.Parameters.AddWithValue("@StaffName", StaffName);
            cmd.Parameters.AddWithValue("@StaffContact", StaffContact);
            cmd.Parameters.AddWithValue("@StaffAlternateContact", StaffAlternateContact);
            cmd.Parameters.AddWithValue("@StaffAddress", StaffAddress);
            cmd.Parameters.AddWithValue("@CityId", CityId);
            cmd.Parameters.AddWithValue("@StaffAdhar", StaffAdhar);
            cmd.Parameters.AddWithValue("@StaffPan", StaffPan);
            cmd.Parameters.AddWithValue("@StaffEmail", StaffEmail);
            cmd.Parameters.AddWithValue("@StaffGender", StaffGender);
            cmd.Parameters.AddWithValue("@StaffDOB", StaffDOB);
            cmd.Parameters.AddWithValue("@GradId", GradId);
            cmd.Parameters.AddWithValue("@PgId", PGId);
            cmd.Parameters.AddWithValue("@StaffBank", StaffBank);
            cmd.Parameters.AddWithValue("@StaffIFSC", StaffIFSC);
            cmd.Parameters.AddWithValue("@StaffAccount", StaffAccount);
            cmd.Parameters.AddWithValue("@StaffBranch", StaffBranch);
            cmd.Parameters.AddWithValue("@ReportingPersonId", ReportingPersonId);
            cmd.Parameters.AddWithValue("@CenterId", CenterId);
            cmd.Parameters.AddWithValue("@StaffPositionId", StaffPositionId);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@StaffPassWord", StaffPassword);
            cmd.Parameters.AddWithValue("@StaffJoiningDate", StaffJoiningDate);
            cmd.Parameters.AddWithValue("@StaffStatusId", StaffStatus);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable FetchCountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "getCountry");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public int CountryId { get; set; }
        public int StateID { get; set; }
        public string StateName { get; set; }
        public AdminClass(int countrydi)
        {
            CountryId = countrydi;

        }
        public AdminClass(int stateid, string staffName)
        {
            StateID = stateid;
            StateName = staffName;
        }

        public DataTable FetchState()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getState");
            cmd.Parameters.AddWithValue("@CountryId", CountryId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FetchCity()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCity");
            cmd.Parameters.AddWithValue("@StateId", CountryId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //public DataTable getspecificqualifiction()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", " getspecificqualifiction");
        //    cmd.Parameters.AddWithValue("StaffCode", StaffCode);
        //    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    return dt;
        //    con.Close();
        //}

       

        public DataTable FetchGraduation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetGraduation");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FetchPostGraduation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetPG");
            cmd.Parameters.AddWithValue("@GradId", CountryId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FetchReportingPerson()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetReportingPerson");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FetchStaffPositionIdforadmin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetStaffPositionforAdmin");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FetchCourse()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetCoursefromCourseType");
            cmd.Parameters.AddWithValue("@CourseTypeId", CountryId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FetchCenter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetCenter");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FetchStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetStaffStatus");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable FetchPassword()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetPassword");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void SaveQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "SaveQualification");
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            cmd.Parameters.AddWithValue("@SSCYear", SSCYear);
            cmd.Parameters.AddWithValue("@SSCFile", SSCFile);
            cmd.Parameters.AddWithValue("@HSCYear", HSCYear);
            cmd.Parameters.AddWithValue("@HSCFile", HSCFile);
            cmd.Parameters.AddWithValue("@GradID", GradId);
            cmd.Parameters.AddWithValue("@GradYear", GraduationYear);
            cmd.Parameters.AddWithValue("@GraduationFile", GradautionFile);
            cmd.Parameters.AddWithValue("@PGId", PGId);
            cmd.Parameters.AddWithValue("@PGYear", PostGraduationYear);
            cmd.Parameters.AddWithValue("@PGFile", PGFile);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateStaff()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "UpdateStaff");
            cmd.Parameters.AddWithValue("@StaffName", StaffName);
            cmd.Parameters.AddWithValue("@StaffContact", StaffContact);
            cmd.Parameters.AddWithValue("@StaffDOB", StaffDOB);
            cmd.Parameters.AddWithValue("@StaffAddress", StaffAddress);
            cmd.Parameters.AddWithValue("@CityId", CityId);
            cmd.Parameters.AddWithValue("@StaffAdhar", StaffAdhar);
            cmd.Parameters.AddWithValue("@StaffPan", StaffPan);
            cmd.Parameters.AddWithValue("@StaffEmail", StaffEmail);
            cmd.Parameters.AddWithValue("@StaffGender", StaffGender);
            cmd.Parameters.AddWithValue("@StaffBank", StaffBank);
            cmd.Parameters.AddWithValue("@StaffIFSC", StaffIFSC);
            cmd.Parameters.AddWithValue("@StaffAccount", StaffAccount);
            cmd.Parameters.AddWithValue("@StaffBranch", StaffBranch);
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateQualification");
            cmd.Parameters.AddWithValue("@SSCYear", SSCYear);
            cmd.Parameters.AddWithValue("@SSCFile", SSCFile);
            cmd.Parameters.AddWithValue("@HSCYear", HSCYear);
            cmd.Parameters.AddWithValue("@HSCFile", HSCFile);
            cmd.Parameters.AddWithValue("@GradID", GradId);
            cmd.Parameters.AddWithValue("@GradYear", GraduationYear);
            cmd.Parameters.AddWithValue("@GraduationFile", GradautionFile);
            cmd.Parameters.AddWithValue("@PGId", PGId);
            cmd.Parameters.AddWithValue("@PGYear", PostGraduationYear);
            cmd.Parameters.AddWithValue("@PGFile", PGFile);
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader GenStaffCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GenerateStaffCode");
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
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

        public AdminClass(string staffcode)
        {
            StaffCode = staffcode;
        }
        public SqlDataReader GetStaff()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStaff");
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public SqlDataReader GetQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGSTCounsellorHub", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetQualification");
            cmd.Parameters.AddWithValue("@StaffCode", StaffCode);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
    }
}
