using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    public class CandidateDAO
    {
        private static CandidateDAO instance;
        public static CandidateDAO Instance
        {
            get { if (instance == null) instance = new CandidateDAO(); return CandidateDAO.instance; }
            private set { CandidateDAO.instance = value; }
        }
        public string GetNameByID(string id)
        {
            string query = string.Format("select HoTen from ThanhVien where MaThanhVien = '{0}'", id);
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();
        }
    }
}
