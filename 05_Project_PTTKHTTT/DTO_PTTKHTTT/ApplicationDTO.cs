using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    public class ApplicationDTO
    {
        public string applicationID {  get; set; }
        public string registerID { get; set; }
        public string compName {  get; set; } = string.Empty;
        public string candID { get; set; }
        public string candName { get; set; } = string.Empty;
        public string vancancyName {  get; set; }
        public string state { get; set; }
        public ApplicationDTO(string applicationID, string regID, string compName, string candID, string candName, string vancancyName, string state)
        {
            this.applicationID = applicationID;
            this.registerID = regID;
            this.compName = compName;
            this.candID = candID;
            this.candName = candName;
            this.vancancyName = vancancyName;
            this.state = state;
        }
        public ApplicationDTO(DataRow row)
        {
            this.applicationID = row["MaHoSo"].ToString();
            this.registerID = row["MaDangKy"].ToString();
            this.compName = row["TenDoanhNghiep"].ToString();
            this.candID = row["MaThanhVien"].ToString();
            this.candName = row["HoTen"].ToString();
            this.vancancyName = row["TenViTri"].ToString();
            this.state = row["TrangThai"].ToString();
        }
    }
}
