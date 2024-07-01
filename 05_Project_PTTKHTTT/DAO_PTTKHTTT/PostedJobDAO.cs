using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    public class PostedJobDAO
    {
        private static PostedJobDAO instance;
        public static PostedJobDAO Instance
        {
            get { if (instance == null) instance = new PostedJobDAO(); return PostedJobDAO.instance; }
            private set { PostedJobDAO.instance = value; }
        }
        private PostedJobDAO() { }
        public List<PostedJob> GetPostedjobList()
        {
            List<PostedJob> result = new List<PostedJob>();
            string query = "select * from dbo.DoanhNghiep d, dbo.PhieuDangKyQuangCao p, dbo.BaiDang b, dbo.ThongTinDangTuyen t where d. MaDoanhNghiep = p.MaDoanhNghiep and p.MaDangKy = b.MaDangKy and p.MaDangKy = t.MaDangKy and b.TrangThai = N'Đã đăng'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PostedJob pj = new PostedJob(row);
                result.Add(pj);
            }
            return result;
        }
        public List<PostedJob> SearchPostedJob(string compName, string jobname)
        {
            List<PostedJob> result = new List<PostedJob>();
            string query = string.Format("select * from dbo.DoanhNghiep d, dbo.PhieuDangKyQuangCao p, dbo.BaiDang b, dbo.ThongTinDangTuyen t where d. MaDoanhNghiep = p.MaDoanhNghiep and p.MaDangKy = b.MaDangKy and p.MaDangKy = t.MaDangKy and lower(d.TenDoanhNghiep) like lower(N'%{0}%') and lower(t.TenViTri) like lower(N'%{1}%') and b.TrangThai = N'Đã đăng'", compName, jobname);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PostedJob pj = new PostedJob(row);
                result.Add(pj);
            }
            return result;
        }
        public bool PostJob(PostedJob newJob)
        {
            string query = string.Format("insert into ThongTinDangTuyen values ('{0}', N'{1}', {2}, '{3}')", newJob.regID, newJob.jobName, newJob.quantity, newJob.criteria);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<PostedJob> GetPostedJobsByRegID(string id)
        {
            List<PostedJob> result = new List<PostedJob>();
            string query = string.Format("select * from dbo.DoanhNghiep d, dbo.PhieuDangKyQuangCao p, dbo.BaiDang b, dbo.ThongTinDangTuyen t where d. MaDoanhNghiep = p.MaDoanhNghiep and p.MaDangKy = b.MaDangKy and p.MaDangKy = t.MaDangKy and p.MaDangKy = '{0}'", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PostedJob pj = new PostedJob(row);
                result.Add(pj);
            }
            return result;
        }
    }
}
