using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    internal class ExpiredContractDAO
    {
        private static ExpiredContractDAO instance;
        public static ExpiredContractDAO Instance
        {
            get { if (instance == null) instance = new ExpiredContractDAO(); return ExpiredContractDAO.instance; }
            private set { ExpiredContractDAO.instance = value; }
        }
        private ExpiredContractDAO() { }
        public List<ExpiredContractDTO> GetExpiredContracList()
        {
            List<ExpiredContractDTO> result = new List<ExpiredContractDTO>();
            string query = "select * from dbo.DanhSachGiaHan DS join dbo.ChiTietGiaHan CT on DS.MaDanhSach = CT.MaDanhSach join dbo.PhieuDangKyQuangCao PDK on CT.MaDangKy = PDK.MaDangKy join dbo.DoanhNghiep DN on PDK.MaDoanhNghiep = DN.MaDoanhNghiep";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ExpiredContractDTO program = new ExpiredContractDTO(row);
                result.Add(program);
            }
            return result;
        }
        public List<ExpiredContractDTO> SearchxpiredContracList(string searchKey, string listDelete)
        {
            List<ExpiredContractDTO> result = new List<ExpiredContractDTO>();
            string query = string.Format("select * from dbo.DanhSachGiaHan DS join dbo.ChiTietGiaHan CT on DS.MaDanhSach = CT.MaDanhSach join dbo.PhieuDangKyQuangCao PDK on CT.MaDangKy = PDK.MaDangKy join dbo.DoanhNghiep DN on PDK.MaDoanhNghiep = DN.MaDoanhNghiep where DN.TenDoanhNghiep LIKE N'%{0}%' AND NOT EXISTS ( SELECT 1 FROM (VALUES {1}) AS Excl(MaDanhSach, MaDangKy)WHERE Excl.MaDanhSach = CT.MaDanhSach AND Excl.MaDangKy = CT.MaDangKy);", searchKey, listDelete);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ExpiredContractDTO program = new ExpiredContractDTO(row);
                result.Add(program);
            }
            return result;
        }
    }
}
