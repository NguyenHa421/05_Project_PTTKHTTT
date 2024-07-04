using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    public class RecruitmentDAO
    {
        private static RecruitmentDAO instance;
        public static RecruitmentDAO Instance
        {
            get { if (instance == null) instance = new RecruitmentDAO(); return RecruitmentDAO.instance; }
            private set { RecruitmentDAO.instance = value; }
        }
        public bool AddRecruitmentPost(Recruitment newRec)
        {
            string query = string.Format("insert into BaiDang values ('{0}', '{1}', N'{2}', '{3}', N'Chưa đăng', '{4}')", newRec.regID, newRec.formID, newRec.content, newRec.postdate.ToString("MM/dd/yyyy"), newRec.staffID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Recruitment GetRecruitmentByID(string regID)
        {
            string query = string.Format("select * from BaiDang where MaDangKy = '{0}'", regID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Recruitment result = new Recruitment(data.Rows[0]);
            return result;
        }
        public bool UpdateRecruitment(PostedJob newRec, string newForm)
        {
            string query = string.Format("update BaiDang set MaHinhThuc = '{0}', NoiDung = N'{1}', NgayDang = '{2}', TrangThai = N'{3}' where MaDangKy = '{4}'", newForm, newRec.content, newRec.postdate.ToString("MM/dd/yyyy").Substring(0, 10), newRec.state, newRec.regID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
