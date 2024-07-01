using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) { instance = new AccountDAO(); } return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool login(string usrname, string pwd)
        {
            string query = string.Format("select * from Accounts where Username = '{0}' and Password = '{1}'", usrname, pwd);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public string GetName(string usrname, string role)
        {
            string query = "";
            if (role == "NhanVien")
            {
                query = string.Format("select TenNhanVien from NhanVien where MaNhanVien = '{0}'", usrname);
            }
            else
            {
                query = string.Format("select HoTen from ThanhVien where MaThanhVien = '{0}'", usrname);
            }
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { usrname });
            return result.ToString();
        }
        public string GetRole(string usrname)
        {
            string query = string.Format("select Role from Accounts where Username = '{0}'", usrname);
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { usrname });
            return result.ToString();
        }
        public string GetMaxID()
        {
            string query = string.Format("select MAX(MaThanhVien) from ThanhVien");
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();
        }
        public bool AddAccountTV(string usrname, string pwd)
        {
            string query = string.Format("insert into Accounts(Username, Password, Role) values ('{0}','{1}','{2}')", usrname, pwd, "ThanhVien");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
