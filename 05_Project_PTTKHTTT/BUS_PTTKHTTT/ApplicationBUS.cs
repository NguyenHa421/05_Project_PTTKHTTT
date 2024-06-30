using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.BUS_PTTKHTTT
{
    public class ApplicationBUS
    {
        private static ApplicationBUS instance;
        public static ApplicationBUS Instance
        {
            get { if(instance == null) instance = new ApplicationBUS(); return instance; }
        set { instance = value; }
        }
        public List<ApplicationDTO> GetApplicationList()
        {
            return ApplicationDAO.Instance.GetApplicationList();
        }
        public List<ApplicationDTO> CandidateGetApplicationList(string ID)
        {
            return ApplicationDAO.Instance.CandidateGetApplicationList(ID);
        }
        public List<ApplicationDTO> SearchApplicationn(string searchKey)
        {
            return ApplicationDAO.Instance.SearchApplicationn(searchKey);
        }
        public List<ApplicationDTO> CandidateSearchApplicationn(string searchKey, string ID)
        {
            return ApplicationDAO.Instance.CandidateSearchApplicationn(searchKey, ID);
        }
        public bool UpdateStatte(string newState, string idCV)
        {
            return ApplicationDAO.Instance.UpdateState(newState, idCV);
        }
        public bool AddApplication(string idCV, string idCandidate, string idReg, string nameVacancy, string state = "Chưa duyệt")
        {
            return ApplicationDAO.Instance.AddApplication(idCV, idCandidate, idReg, nameVacancy, state = "Chưa duyệt");
        }
    }
}
