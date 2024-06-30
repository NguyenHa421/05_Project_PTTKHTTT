using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
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
        public List<DTO_PTTKHTTT.Company> GetCompanyList()
        {
            List<DTO_PTTKHTTT.Company> list = new List<DTO_PTTKHTTT.Company>();
            string query = "select * from dbo.DoanhNghiep";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Company company = new DTO_PTTKHTTT.Company(row);
                list.Add(company);
            }
            return list;
        }
        public List<DTO_PTTKHTTT.Company> SearchCompany(string searchKey)
        {
            List<DTO_PTTKHTTT.Company> result = new List<DTO_PTTKHTTT.Company>();
            string query = string.Format("select * from dbo.DoanhNghiep where TenDoanhNghiep LIKE N'%{0}%' ", searchKey);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Company company = new DTO_PTTKHTTT.Company(row);
                result.Add(company);
            }
            return result;
        }
        public List<DTO_PTTKHTTT.Company> GetExpiredCompanyList()
        {
            List<DTO_PTTKHTTT.Company> result = new List<DTO_PTTKHTTT.Company>();
            string query = "select * from dbo.DanhSachGiaHan DS join dbo.ChiTietGiaHan CT on DS.MaDanhSach = CT.MaDanhSach join dbo.PhieuDangKyQuangCao PDK on CT.MaDangKy = PDK.MaDangKy join dbo.DoanhNghiep DN on PDK.MaDoanhNghiep = DN.MaDoanhNghiep";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Company program = new DTO_PTTKHTTT.Company(row);
                result.Add(program);
            }
            return result;
        }
        public List<DTO_PTTKHTTT.Company> SearchExpiredCompany(string searchKey, string listDelete)
        {
            List<DTO_PTTKHTTT.Company> result = new List<DTO_PTTKHTTT.Company>();
            string query = string.Format("select * from dbo.DanhSachGiaHan DS join dbo.ChiTietGiaHan CT on DS.MaDanhSach = CT.MaDanhSach join dbo.PhieuDangKyQuangCao PDK on CT.MaDangKy = PDK.MaDangKy join dbo.DoanhNghiep DN on PDK.MaDoanhNghiep = DN.MaDoanhNghiep where DN.TenDoanhNghiep LIKE N'%{0}%' AND NOT EXISTS ( SELECT 1 FROM (VALUES {1}) AS Excl(MaDanhSach, MaDangKy)WHERE Excl.MaDanhSach = CT.MaDanhSach AND Excl.MaDangKy = CT.MaDangKy);", searchKey, listDelete);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Company program = new DTO_PTTKHTTT.Company(row);
                result.Add(program);
            }
            return result;
        }
        public bool AddCompany(DTO_PTTKHTTT.Company newCompany)
        {
            string query = string.Format("INSERT INTO dbo.DoanhNghiep VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", newCompany.compID, newCompany.compName, newCompany.createdDate, newCompany.expireDate, newCompany.preferential, newCompany.employeeID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
