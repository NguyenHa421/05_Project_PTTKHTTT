﻿using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
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
        public string expireID { get; set; }
        public string registerID { get; set; }
        public string compID { get; set; }
        public string compName { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime expireDate { get; set; }
        public string preferential { get; set; }
        public string employeeID { get; set; }
        public Company(string expireID, string registerID, string compID, string compName, DateTime createdDate, DateTime expireDate, string preferential, string employeeID)
        {
            this.expireID = expireID;
            this.registerID = registerID;
            this.compID = compID;
            this.compName = compName;
            this.createdDate = createdDate;
            this.expireDate = expireDate;
            this.preferential = preferential;
            this.employeeID = employeeID;
        }
        public Company(DataRow row)
        {
            this.expireID = row["MaDanhSach"].ToString();
            this.registerID = row["MaDangKy"].ToString();
            this.compID = row["MaDoanhNghiep"].ToString();
            this.compName = row["TenDoanhNghiep"].ToString();
            this.createdDate = (DateTime)row["NgayLap"];
            this.expireDate = (DateTime)row["NgayHetHan"];
            this.preferential = row["ThongTinUuDai"].ToString();
            this.employeeID = row["NhanVienLap"].ToString();
        }

        public static bool AddCompany(Company newCompany)
        {
            return CompanyDAO.Instance.AddCompany(newCompany);
        }
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
