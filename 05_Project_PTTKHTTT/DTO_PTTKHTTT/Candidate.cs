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
        public string CandidateID { get; set; }
        public string CandidateName { get; set;}
        public int YearofBirth { get; set;}
        public string PhoneNumber { get; set;}
        public string Address { get; set;}
        public string Email { get; set;}

        public Candidate() { }
        public static bool AddCandidate(Candidate new_cdd)
        {
            return CandidateDAO.Instance.AddCandidate(new_cdd);
        }
    }
}
