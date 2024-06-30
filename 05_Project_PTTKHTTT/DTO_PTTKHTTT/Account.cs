using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    public class Account
    {
        private string _username;
        public string Username
        {
            get => _username;
            set => _username = value;
        }
        private string _password;
        private string _role;
        public string Role 
        {
            get => _role;
            set => _role = value;
        }
        public Account() { }
        public Account(string usrname, string pwd, string role)
        {
            _username = usrname;
            _password = pwd;
            _role = role;
        }
        
        public static bool Login(string usrname, string pwd)
        {
            return AccountDAO.Instance.login(usrname, pwd);
        }
        public static string GetName(string usrname, string role)
        {
            return AccountDAO.Instance.GetName(usrname, role);
        }
        public static string GetRole(string usrname)
        {
            return AccountDAO.Instance.GetRole(usrname);
        }
        public static string GetMaxID()
        {
            return AccountDAO.Instance.GetMaxID();
        }
        public static bool AddAccountTV(string pwd)
        {
            string usrname = GetMaxID();
            return AccountDAO.Instance.AddAccountTV(usrname, pwd);
        }
    }
}
