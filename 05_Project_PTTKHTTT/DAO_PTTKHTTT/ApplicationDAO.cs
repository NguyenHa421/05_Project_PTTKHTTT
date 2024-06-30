using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    public class ApplicationDAO
    {
        private static ApplicationDAO instance;
        public static ApplicationDAO Instance
        {
            get { if (instance == null) instance = new ApplicationDAO(); return ApplicationDAO.instance; }
            private set { ApplicationDAO.instance = value; }
        }
        private ApplicationDAO() { }
        public List<DTO_PTTKHTTT.Application> GetApplicationList()
        {
            List<DTO_PTTKHTTT.Application> list = new List<DTO_PTTKHTTT.Application>();
            string query = "select hs.MaHoSo, hs.MaDangKy, dn.TenDoanhNghiep, hs.MaThanhVien, tv.HoTen, hs.TenViTri, hs.TrangThai from HoSo hs, PhieuDangKyQuangCao pdk, DoanhNghiep dn, ThanhVien tv where hs.MaDangKy = pdk.MaDangKy and pdk.MaDoanhNghiep = dn.MaDoanhNghiep and hs.MaThanhVien = tv.MaThanhVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Application cv = new DTO_PTTKHTTT.Application(row);
                list.Add(cv);
            }
            return list;
        }
        public List<DTO_PTTKHTTT.Application> CandidateGetApplicationList(string ID)
        {
            List<DTO_PTTKHTTT.Application> list = new List<DTO_PTTKHTTT.Application>();
            string query = string.Format("select hs.MaHoSo, hs.MaDangKy, dn.TenDoanhNghiep, hs.MaThanhVien, tv.HoTen, hs.TenViTri, hs.TrangThai from HoSo hs, PhieuDangKyQuangCao pdk, DoanhNghiep dn, ThanhVien tv where hs.MaDangKy = pdk.MaDangKy and pdk.MaDoanhNghiep = dn.MaDoanhNghiep and hs.MaThanhVien = tv.MaThanhVien and hs.MaThanhVien = '{0}'", ID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Application cv = new DTO_PTTKHTTT.Application(row);
                list.Add(cv);
            }
            return list;
        }
        public List<DTO_PTTKHTTT.Application> SearchApplicationn(string compName, string vacancyName, string candidateName)
        {
            List<DTO_PTTKHTTT.Application> result = new List<DTO_PTTKHTTT.Application>();
            string query = "select hs.MaHoSo, hs.MaDangKy, dn.TenDoanhNghiep, hs.MaThanhVien, tv.HoTen, hs.TenViTri, hs.TrangThai from HoSo hs, PhieuDangKyQuangCao pdk, DoanhNghiep dn, ThanhVien tv where hs.MaDangKy = pdk.MaDangKy and pdk.MaDoanhNghiep = dn.MaDoanhNghiep and hs.MaThanhVien = tv.MaThanhVien";
            if(compName != "All")
                query += string.Format(" and lower(dn.TenDoanhNghiep) like lower(N'%{0}%')", compName);
            if (vacancyName != null)
                query += string.Format(" and lower(hs.TenViTri) like lower(N'%{0}%')", vacancyName);
            if (candidateName != null)
                query += string.Format(" and lower(tv.HoTen) like lower(N'%{0}%')", candidateName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Application cv = new DTO_PTTKHTTT.Application(row);
                result.Add(cv);
            }
            return result;
        }
        public List<DTO_PTTKHTTT.Application> CandidateSearchApplicationn(string ID, string compName, string vacancyName)
        {
            List<DTO_PTTKHTTT.Application> result = new List<DTO_PTTKHTTT.Application>();
            string query = string.Format("select hs.MaHoSo, hs.MaDangKy, dn.TenDoanhNghiep, hs.MaThanhVien, tv.HoTen, hs.TenViTri, hs.TrangThai from HoSo hs, PhieuDangKyQuangCao pdk, DoanhNghiep dn, ThanhVien tv where hs.MaDangKy = pdk.MaDangKy and pdk.MaDoanhNghiep = dn.MaDoanhNghiep and hs.MaThanhVien = tv.MaThanhVien and hs.MaThanhVien = '{0}'", ID);
            if (compName != null)
                query += string.Format(" and lower(dn.TenDoanhNghiep) like lower(N'%{0}%')", compName);
            if (vacancyName != null)
                query += string.Format(" and lower(hs.TenViTri) like lower(N'%{0}%')", vacancyName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Application cv = new DTO_PTTKHTTT.Application(row);
                result.Add(cv);
            }
            return result;
        }
        public bool UpdateState(string newState, string idCV) 
        {
            string query = string.Format("update dbo.HoSo set TrangThai = N'{0}' where MaHoSo = '{1}'", newState, idCV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddApplication(DTO_PTTKHTTT.Application newApply)
        {
            string query = string.Format("insert into dbo.HoSo values ('{0}', '{1}', '{2}', N'{3}', N'Chưa duyệt')", newApply.applicationID, newApply.candidateID, newApply.registerID, newApply.vancancyName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
