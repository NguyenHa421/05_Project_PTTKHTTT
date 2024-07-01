using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    public class ContractDAO
    {
        private static ContractDAO instance;
        public static ContractDAO Instance
        {
            get { if (instance == null) instance = new ContractDAO(); return ContractDAO.instance; }
            private set { ContractDAO.instance = value; }
        }
        private ContractDAO() { }
        public List<DTO_PTTKHTTT.Contract> GetContractList()
        {
            List<DTO_PTTKHTTT.Contract> list = new List<DTO_PTTKHTTT.Contract>();
            string query = "select * from DoanhNghiep d, PhieuDangKyQuangCao p where d.MaDoanhNghiep = p.MaDoanhNghiep";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Contract contract = new DTO_PTTKHTTT.Contract(row);
                list.Add(contract);
            }
            return list;
        }
        public List<DTO_PTTKHTTT.Contract> SearchContract(string compName)
        {
            List<DTO_PTTKHTTT.Contract> result = new List<DTO_PTTKHTTT.Contract>();
            string query = string.Format("select * from DoanhNghiep d, PhieuDangKyQuangCao p where d.MaDoanhNghiep = p.MaDoanhNghiep and d.TenDoanhNghiep like N'%{0}%' ", compName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO_PTTKHTTT.Contract contract = new DTO_PTTKHTTT.Contract(row);
                result.Add(contract);
            }
            return result;
        }
        public bool AddContract(DTO_PTTKHTTT.Contract newContract)
        {
            string query = string.Format("INSERT INTO dbo.DoanhNghiep VALUES ('{0}', '{1}', '{2}', '{3}')", newContract.registerID, newContract.compID, newContract.createdDate, newContract.employeeID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
