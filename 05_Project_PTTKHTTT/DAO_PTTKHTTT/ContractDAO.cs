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
            string query = string.Format("INSERT INTO PhieuDangKyQuangCao VALUES ('{0}', '{1}', '{2}', '{3}')", newContract.registerID, newContract.createdDate.ToString("dd/MM/yyyy"), newContract.compID, newContract.employeeID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string GetCurrentCounter()
        {
            string query = "select MaDangKy from PhieuDangKyQuangCao order by MaDangKy desc";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();
        }
        public bool AddRecruitmentPost(string regId, string formId, string content, DateTime postDate, string staffId)
        {
            string query = string.Format("insert into BaiDang values ('{0}', '{1}', N'{2}', '{3}', N'Chưa đăng', '{4}')", regId, formId, content, postDate.ToString(), staffId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
