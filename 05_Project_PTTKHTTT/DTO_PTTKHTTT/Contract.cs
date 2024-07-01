using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    public class Contract
    {
        public string registerID { get; set; }
        public string compID { get; set; }
        public string compName { get; set; }
        public DateTime createdDate { get; set; }
        public string employeeID { get; set; }
        public string state { get; set; }
        public Contract(string registerID, string compID, string compName, DateTime createdDate, string employeeID)
        {
            this.registerID = registerID;
            this.compID = compID;
            this.compName = compName;
            this.createdDate = createdDate;
            this.employeeID = employeeID;
        }
        public Contract(DataRow row)
        {
            this.registerID = row["MaDangKy"].ToString();
            this.compID = row["MaDoanhNghiep"].ToString();
            this.compName = row["TenDoanhNghiep"].ToString();
            this.createdDate = (DateTime)row["ThoiGianDangKy"];
            this.employeeID = row["NhanVienTiepNhan"].ToString();
            this.state = row["TrangThai"].ToString();
        }
        public static List<DTO_PTTKHTTT.Contract> GetContractList()
        {
            return ContractDAO.Instance.GetContractList();
        }
        public static List<DTO_PTTKHTTT.Contract> SearchContract(string compName)
        {
            return ContractDAO.Instance.SearchContract(compName);
        }
        public static bool AddContract(DTO_PTTKHTTT.Contract newContract)
        {
            newContract.employeeID = Login.loggedInAcc.Username;
            return ContractDAO.Instance.AddContract(newContract);
        }
        public static string CreateNewID(string curCounter)
        {
            string counter = curCounter.Substring(3);
            int newCounter = int.Parse(counter) + 1;
            string result = "PDK";
            if (newCounter < 100)
            {
                result += "0";
                if (newCounter < 10)
                    result += "0";
            }
            result += newCounter.ToString();
            return result;
        }
        
    }
}
