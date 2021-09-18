using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatnaphadpr.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime Optionalstartdate { get; set; }
        public string Location { get; set; }
        public List<Candidate> Candidate { get; set; }
        public int CandidateId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public bool CPTorOPT { get; set; }
        public bool Workfromhome { get; set; }
    }
}
