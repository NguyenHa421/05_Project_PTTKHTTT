using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    public class PostedJob
    {
        public string compName { get; set; }
        public string jobName { get; set; }
        public int quantity { get; set; }
        public string criteria { get; set; }
        public string content { get; set; }
        public DateTime postdate { get; set; }
        public string state { get; set; }
        public PostedJob(string compName, string jobName, int quantity, string criteria, string content, DateTime postdate, string state)
        {
            this.compName = compName;
            this.jobName = jobName;
            this.quantity = quantity;
            this.criteria = criteria;
            this.content = content;
            this.postdate = postdate;
            this.state = state;
        }
        public PostedJob(DataRow row)
        {
            this.compName = row["TenDoanhNghiep"].ToString();
            this.jobName = row["TenViTri"].ToString();
            this.quantity = (int)row["SoLuong"];
            this.criteria = row["TieuChi"].ToString();
            this.content = row["NoiDung"].ToString();
            this.postdate = (DateTime)row["NgayDang"];
            this.state = row["TrangThai"].ToString();
        }
        public static List<PostedJob> GetPostedJobList()
        {
            return PostedJobDAO.Instance.GetPostedjobList();
        }
        public static List<PostedJob> SearchPostedJob(string compName, string jobName)
        {
            return PostedJobDAO.Instance.SearchPostedJob(compName, jobName);
        }
    }
}
