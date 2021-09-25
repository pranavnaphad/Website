using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatnaphadpr.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        public string Name { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
        public string Founder { get; set; }
    }
}
