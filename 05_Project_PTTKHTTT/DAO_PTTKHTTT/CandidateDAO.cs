using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
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

        private CandidateDAO() { }
        public bool AddCandidate(DTO_PTTKHTTT.Candidate new_cdd)
        {
            string query = string.Format("insert into ThanhVien(HoTen,NamSinh,SoDienThoai,DiaChi,Email) values (N'{0}','{1}','{2}',N'{3}','{4}')", new_cdd.CandidateName, new_cdd.YearofBirth, new_cdd.PhoneNumber, new_cdd.Address, new_cdd.Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string GetNameByID(string id)
        {
            string query = string.Format("select HoTen from ThanhVien where MaThanhVien = '{0}'", id);
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();

        }
    }
}
