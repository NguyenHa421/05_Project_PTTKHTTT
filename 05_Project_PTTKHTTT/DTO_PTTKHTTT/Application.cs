using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    public class Application
    {
        public string applicationID {  get; set; }
        public string registerID { get; set; }
        public string compName {  get; set; } = string.Empty;
        public string candidateID { get; set; }
        public string candidateName { get; set; } = string.Empty;
        public string vancancyName {  get; set; }
        public string stateNow { get; set; }
        public Application(string applicationID, string regID, string candID, string vancancyName, string candName = null, string compName = null, string state = null)
        {
            this.applicationID = applicationID;
            this.registerID = regID;
            this.compName = compName;
            this.candidateID = candID;
            this.candidateName = candName;
            this.vancancyName = vancancyName;
            this.stateNow = state;
        }
        public Application(DataRow row)
        {
            this.applicationID = row["MaHoSo"].ToString();
            this.registerID = row["MaDangKy"].ToString();
            this.compName = row["TenDoanhNghiep"].ToString();
            this.candidateID = row["MaThanhVien"].ToString();
            this.candidateName = row["HoTen"].ToString();
            this.vancancyName = row["TenViTri"].ToString();
            this.stateNow = row["TrangThai"].ToString();
        }
        public static List<Application> GetApplicationList()
        {
            return ApplicationDAO.Instance.GetApplicationList();
        }
        public static List<Application> CandidateGetApplicationList(string ID)
        {
            return ApplicationDAO.Instance.CandidateGetApplicationList(ID);
        }
        public static List<Application> SearchApplicationn(string compName, string vacancyName, string candidateName)
        {
            return ApplicationDAO.Instance.SearchApplicationn(compName, vacancyName, candidateName);
        }
        public static List<Application> CandidateSearchApplicationn(string ID, string searchKey, string vacancy)
        {
            return ApplicationDAO.Instance.CandidateSearchApplicationn(ID, searchKey, vacancy);
        }
        public static bool UpdateStatte(string newState, string idCV)
        {
            return ApplicationDAO.Instance.UpdateState(newState, idCV);
        }
        public static bool AddApplication(Application newApply)
        {
            string curAppCounter = ApplicationDAO.Instance.GetCurrentCounter();
            string newID = CreateNewID(curAppCounter);
            newApply.applicationID = newID;
            return ApplicationDAO.Instance.AddApplication(newApply);
        }
        private static string CreateNewID(string curCounter)
        {
            string counter = curCounter.Substring(2);
            int newCounter = int.Parse(counter) + 1;
            string result = "HS";
            if (newCounter < 100)
            {
                result += "0";
                if (newCounter < 10)
                    result += "0";
            }
            result += newCounter.ToString();
            return result;
        }
    }
}
