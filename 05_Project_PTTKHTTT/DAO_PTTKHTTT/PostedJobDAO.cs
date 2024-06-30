﻿using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
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
            string query = "select * from dbo.DoanhNghiep d, dbo.PhieuDangKyQuangCao p, dbo.BaiDang b, dbo.ThongTinDangTuyen t where d. MaDoanhNghiep = p.MaDoanhNghiep and p.MaDangKy = b.MaDangKy and p.MaDangKy = t.MaDangKy";
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
