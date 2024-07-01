using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    public class Recruitment
    {
        public string regID { get; set; }
        public string formID { get; set; }
        public string content { get; set; }
        public DateTime postdate { get; set; }
        public string state { get; set; }
        public string staffID { get; set; }
        public Recruitment(string regID,string formID, string content, DateTime postdate, string state = null, string staffID = null)
        {
            this.regID = regID;
            this.formID = formID;
            this.content = content;
            this.postdate = postdate;
            this.state = state;
            this.staffID = staffID;
        }
        public Recruitment(DataRow row)
        {
            this.content = row["NoiDung"].ToString();
            this.postdate = (DateTime)row["NgayDang"];
            this.state = row["TrangThai"].ToString();
            this.regID = row["MaDangKy"].ToString();
            this.formID = row["MaHinhThuc"].ToString();
            this.staffID = row["NhanVienThucHien"].ToString();
        }
        public static bool AddRecruitmentPost(Recruitment newRec)
        {
            newRec.staffID = Login.loggedInAcc.Username;
            return RecruitmentDAO.Instance.AddRecruitmentPost(newRec);
        }
        public static Recruitment GetRecruitmentByID(string regID)
        {
            return RecruitmentDAO.Instance.GetRecruitmentByID(regID);
        }
        public static void UpdateRecruitment(PostedJob newJob, string oldJobName, string newForm)
        {
            RecruitmentDAO.Instance.UpdateRecruitment(newJob, newForm);
            if (newJob.jobName == oldJobName)
            {
                PostedJobDAO.Instance.UpdatePostedJob(newJob);
            }
            else
            {
                PostedJobDAO.Instance.DeletePostedJob(newJob.regID, oldJobName);
                PostedJobDAO.Instance.PostJob(newJob);
            }
        }
    }
}
