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
        public string manager { get; set; }
        public string address {  get; set; }
        public string email { get; set; }
        public Company(string compID, string compName, string tax, string manager, string address, string email)
        {
            this.compID = compID;
            this.compName = compName;
            this.tax = tax;
            this.manager = manager;
            this.address = address;
            this.email = email;
        }

        public Company(DataRow row)
        {
            this.compID = row["MaDoanhNghiep"].ToString();
            this.compName = row["TenDoanhNghiep"].ToString();
            this.tax = row["MaSoThue"].ToString();
            this.manager = row["NguoiDaiDien"].ToString();
            this.address = row["DiaChi"].ToString();
            this.email = row["Email"].ToString();
        }
        private static string CreateNewID(string curCounter)
        {
            string counter = curCounter.Substring(2);
            int newCounter = int.Parse(counter) + 1;
            string result = "DN";
            if (newCounter < 100)
            {
                result += "0";
                if (newCounter < 10)
                    result += "0";
            }
            result += newCounter.ToString();
            return result;
        }
        public static bool AddCompany(Company newComp)
        {
            string curCounter = CompanyDAO.Instance.GetCurrentCounter();
            string newID = CreateNewID(curCounter);
            newComp.compID = newID;
            return CompanyDAO.Instance.AddCompany(newComp);
        }
        public static List<Company> GetCompanyList()
        {
            return CompanyDAO.Instance.GetCompanyList();
        }
        public static List<Company> SearchCompany(string compName)
        {
            return CompanyDAO.Instance.SearchCompany(compName);
        }
        public static bool UpdateCompany(string ID, string newName, string newManager, string newAddress, string newEmail)
        {
            return CompanyDAO.Instance.UpdateCompany(ID, newName, newManager, newAddress, newEmail);
        }
    }
}
