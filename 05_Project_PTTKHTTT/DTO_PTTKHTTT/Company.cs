using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    internal class Company
    {
        public string compID { get; set; }
        public string compName { get; set; }
        public string tax { get; set; }
        public string representative { get; set; }
        public string address {  get; set; }
        public string email { get; set; }
        public Company(string compID, string compName, string tax, string representative, string address, string email)
        {
            this.compID = compID;
            this.compName = compName;
            this.tax = tax;
            this.representative = representative;
            this.address = address;
            this.email = email;
        }

        public Company(DataRow row)
        {
            this.compID = row["MaDoanhNghiep"].ToString();
            this.compName = row["TenDoanhNghiep"].ToString();
            this.tax = row["MaSoThue"].ToString();
            this.representative = row["NguoiDaiDien"].ToString();
            this.address = row["DiaChi"].ToString();
            this.email = row["Email"].ToString();
        }

        /*public static bool AddCompany(Company newCompany)
        {
            return CompanyDAO.Instance.AddCompany(newCompany);
        }*/
        public static List<Company> GetCompanyList()
        {
            return CompanyDAO.Instance.GetCompanyList();
        }
        public static List<Company> SearchCompany(string compName)
        {
            return CompanyDAO.Instance.SearchCompany(compName);
        }
    }
}
