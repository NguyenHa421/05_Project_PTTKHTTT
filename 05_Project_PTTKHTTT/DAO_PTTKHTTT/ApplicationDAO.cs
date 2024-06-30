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
        public List<ApplicationDTO> GetApplicationList()
        {
            List<ApplicationDTO> list = new List<ApplicationDTO>();
            string query = "select hs.MaHoSo, hs.MaDangKy, dn.TenDoanhNghiep, hs.MaThanhVien, tv.HoTen, hs.TenViTri, hs.TrangThai from HoSo hs, PhieuDangKyQuangCao pdk, DoanhNghiep dn, ThanhVien tv where hs.MaDangKy = pdk.MaDangKy and pdk.MaDoanhNghiep = dn.MaDoanhNghiep and hs.MaThanhVien = tv.MaThanhVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ApplicationDTO cv = new ApplicationDTO(row);
                list.Add(cv);
            }
            return list;
        }
        public List<ApplicationDTO> CandidateGetApplicationList(string ID)
        {
            List<ApplicationDTO> list = new List<ApplicationDTO>();
            string query = string.Format("select hs.MaHoSo, hs.MaDangKy, dn.TenDoanhNghiep, hs.TenViTri, hs.TrangThai from HoSo hs, PhieuDangKyQuangCao pdk, DoanhNghiep dn, ThanhVien tv where hs.MaDangKy = pdk.MaDangKy and pdk.MaDoanhNghiep = dn.MaDoanhNghiep and hs.MaThanhVien = tv.MaThanhVien and hs.MaThanhVien = '{0}'", ID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ApplicationDTO cv = new ApplicationDTO(row);
                list.Add(cv);
            }
            return list;
        }
        public List<ApplicationDTO> SearchApplicationn(string searchKey)
        {
            List<ApplicationDTO> result = new List<ApplicationDTO>();
            string query = string.Format("select hs.MaHoSo, hs.MaDangKy, dn.TenDoanhNghiep, hs.MaThanhVien, tv.HoTen, hs.TenViTri, hs.TrangThai from HoSo hs, PhieuDangKyQuangCao pdk, DoanhNghiep dn, ThanhVien tv where hs.MaDangKy = pdk.MaDangKy and pdk.MaDoanhNghiep = dn.MaDoanhNghiep and hs.MaThanhVien = tv.MaThanhVien and lower(dn.TenDoanhNghiep) like lower(N'%{0}%')", searchKey);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ApplicationDTO cv = new ApplicationDTO(row);
                result.Add(cv);
            }
            return result;
        }
        public List<ApplicationDTO> CandidateSearchApplicationn(string searchKey, string ID)
        {
            List<ApplicationDTO> result = new List<ApplicationDTO>();
            string query = string.Format("select hs.MaHoSo, hs.MaDangKy, dn.TenDoanhNghiep, hs.TenViTri, hs.TrangThai from HoSo hs, PhieuDangKyQuangCao pdk, DoanhNghiep dn, ThanhVien tv where hs.MaDangKy = pdk.MaDangKy and pdk.MaDoanhNghiep = dn.MaDoanhNghiep and hs.MaThanhVien = tv.MaThanhVien and lower(dn.TenDoanhNghiep) like lower(N'%{0}%') and hs.MaThanhVien = '{1}'", searchKey, ID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ApplicationDTO cv = new ApplicationDTO(row);
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
        public bool AddApplication(string idCV, string idCandidate, string idReg, string nameVacancy, string state = "Chưa duyệt")
        {
            string query = string.Format("insert into dbo.HoSo values ('{0}', '{1}', '{2}', N'{3}', N'{4}')", idCV, idCandidate, idReg, nameVacancy, state);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
