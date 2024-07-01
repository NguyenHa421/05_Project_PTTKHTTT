using _05_Project_PTTKHTTT.DTO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DAO_PTTKHTTT
{
    public class AdFormDAO
    {
        private static AdFormDAO instance;
        public static AdFormDAO Instance
        {
            get { if (instance == null) instance = new AdFormDAO(); return AdFormDAO.instance; }
            private set { AdFormDAO.instance = value; }
        }
        public List<AdForm> GetAdFormList()
        {
            List<AdForm> result = new List<AdForm>();
            string query = "select * from HinhThucDangTuyen";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AdForm adForm = new AdForm(row);
                result.Add(adForm);
            }
            return result;
        }
    }
}
