using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    public class AdForm
    {
        public string formID { get; set; }
        public string formName { get; set; }
        public string unit {  get; set; }
        public double cost { get; set; }
        public AdForm(string formID, string formName, string unit, double cost)
        {
            this.formID = formID;
            this.formName = formName;
            this.unit = unit;
            this.cost = cost;
        }
        public AdForm(DataRow row)
        {
            this.formID = row["MaHinhThuc"].ToString();
            this.formName = row["TenHinhThuc"].ToString();
            this.unit = row["DonViTinh"].ToString();
            this.cost = Convert.ToDouble(row["DonGia"]);
        }
        public static List<AdForm> GetAdFormList()
        {
            return AdFormDAO.Instance.GetAdFormList();
        }
        public static string GetAdFormNameByID(string id)
        {
            return AdFormDAO.Instance.GetAdFormNameByID(id);
        }
        public static string GetAdFormIDByName(string name)
        {
            return AdFormDAO.Instance.GetAdFormIDByName(name);
        }
    }
}
