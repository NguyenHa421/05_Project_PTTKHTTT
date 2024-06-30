using _05_Project_PTTKHTTT.DAO_PTTKHTTT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Project_PTTKHTTT.DTO_PTTKHTTT
{
    public class Candidate
    {
        public static string GetNameByID(string id)
        {
            return CandidateDAO.Instance.GetNameByID(id);
        }
    }
}
