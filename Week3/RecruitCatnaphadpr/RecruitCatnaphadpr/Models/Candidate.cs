using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatnaphadpr.Models
{
    public class Candidate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CandidateId { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? OptionalStartdate { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public bool Validpassport { get; set; }
        public int? Workexperience { get; set; }
        public string Education { get; set; }
        public bool Children { get; set; }
        public string Gender { get; set; }
    }
}
