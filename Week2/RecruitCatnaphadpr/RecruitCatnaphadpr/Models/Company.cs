using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatnaphadpr.Models
{
    public class Company
    {
        [DisplayName("Company ID")]
        [Required]
        [Range(0, 100000000)]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayName("Position Name")]
        [Required]
        [StringLength(50)]
        public string PositionName { get; set; }

        [DisplayName("Minimum Salary")]
        [Required]
        [Range(0.00, 100000000.00)]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Required]
        [Range(0.00, 100000000.00)]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Optional Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Optionalstartdate { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }
        [DisplayName("CPT/OPT")]
        [Required]
        public bool CPTorOPT { get; set; }

        [DisplayName("Work From Home")]
        [Required]
        public bool Workfromhome { get; set; }
        public List<Candidate> Candidates { get; set; }

       
        public Industry Industry { get; set; }

        [Range(0, 100000000)]
        public int IndustryId { get; set; }
        public JobTitle JobTitle { get; set; }

        [Range(0, 100000000)]
        public int JobTitleId { get; set; }
        
    }
}
