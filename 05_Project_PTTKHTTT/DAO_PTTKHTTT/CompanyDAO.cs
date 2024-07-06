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
        public string GetCurrentCounter()
        {
            string query = "select MaDoanhNghiep from DoanhNghiep order by MaDoanhNghiep desc";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();
        }
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
        public bool AddCompany(DTO_PTTKHTTT.Company newCompany)
        {
            string query = string.Format("insert into dbo.DoanhNghiep values ('{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}')", newCompany.compID, newCompany.compName, newCompany.tax, newCompany.manager, newCompany.address, newCompany.email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCompany(string ID, string newName, string newManager, string newAddress, string newEmail)
        {
            string query = string.Format("update dbo.DoanhNghiep set TenDoanhNghiep = N'{0}', NguoiDaiDien = N'{1}', DiaChi = N'{2}', Email = N'{3}' where MaDoanhNghiep = '{4}'", newName, newManager, newAddress, newEmail, ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
