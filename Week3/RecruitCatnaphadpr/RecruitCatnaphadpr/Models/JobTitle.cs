using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatnaphadpr.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string Name { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
        public int Workexperience { get; set; }
        public string Responsibilities { get; set; }
    }
}
