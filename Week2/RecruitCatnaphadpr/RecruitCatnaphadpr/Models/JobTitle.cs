using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatnaphadpr.Models
{
    public class JobTitle
    {
        [DisplayName("JobTitle ID")]
        [Required]
        
        public int JobTitleId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(0.00, 100000000.00)]

        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(0.00, 100000000.00)]
        public decimal MaximumSalary { get; set; }
        [DisplayName("Work Experience")]
        [Required]
        [Range(0, 100000000)]
        public int Workexperience { get; set; }

        [Required]
        [StringLength(50)]
        public string Responsibilities { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
 
    }
}
