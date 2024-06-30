using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    internal class CompanyDAO
    {
        private static CompanyDAO instance;
        public static CompanyDAO Instance
        {
            get { if (instance == null) instance = new CompanyDAO(); return CompanyDAO.instance; }
            private set { CompanyDAO.instance = value; }
        }
        private CompanyDAO() { }
        public List<CompanyDTO> GetExpiredCompanyList()
        {
            List<CompanyDTO> result = new List<CompanyDTO>();
            string query = "select * from dbo.DanhSachGiaHan DS join dbo.ChiTietGiaHan CT on DS.MaDanhSach = CT.MaDanhSach join dbo.PhieuDangKyQuangCao PDK on CT.MaDangKy = PDK.MaDangKy join dbo.DoanhNghiep DN on PDK.MaDoanhNghiep = DN.MaDoanhNghiep";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                CompanyDTO program = new CompanyDTO(row);
                result.Add(program);
            }
            return result;
        }
        public List<CompanyDTO> SearchExpiredCompany(string searchKey, string listDelete)
        {
            List<CompanyDTO> result = new List<CompanyDTO>();
            string query = string.Format("select * from dbo.DanhSachGiaHan DS join dbo.ChiTietGiaHan CT on DS.MaDanhSach = CT.MaDanhSach join dbo.PhieuDangKyQuangCao PDK on CT.MaDangKy = PDK.MaDangKy join dbo.DoanhNghiep DN on PDK.MaDoanhNghiep = DN.MaDoanhNghiep where DN.TenDoanhNghiep LIKE N'%{0}%' AND NOT EXISTS ( SELECT 1 FROM (VALUES {1}) AS Excl(MaDanhSach, MaDangKy)WHERE Excl.MaDanhSach = CT.MaDanhSach AND Excl.MaDangKy = CT.MaDangKy);", searchKey, listDelete);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                CompanyDTO program = new CompanyDTO(row);
                result.Add(program);
            }
            return result;
        }
    }
}
