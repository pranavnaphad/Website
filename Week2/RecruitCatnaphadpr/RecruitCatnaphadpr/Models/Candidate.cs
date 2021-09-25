using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatnaphadpr.Models
{
    public class Candidate
    {
        [DisplayName("First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Range(0, 100000000)]
        public int CandidateId { get; set; }
        [DisplayName("Target Salary")]
        [Required]
        
        public decimal TargetSalary { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? OptionalStartdate { get; set; }
        public Company Company { get; set; }

        [Range(0, 100000000)]
        public int? CompanyId { get; set; }

        [DisplayName("Job Title")]
        [Required]
        [StringLength(20)]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Job Title ID")]
        [Required]
        
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }

        [DisplayName("Industry Id")]
        [Required]
        
        public int IndustryId { get; set; }

        [DisplayName("Valid Passport")]
        [Required]
        public bool Validpassport { get; set; }

        [DisplayName("Work Experience")]
        [Required]
        [Range(0, 100000000)]
        public int? Workexperience { get; set; }
        public string Education { get; set; }
        [Required]
        
        public bool Children { get; set; }

       
        
       

    }
}
