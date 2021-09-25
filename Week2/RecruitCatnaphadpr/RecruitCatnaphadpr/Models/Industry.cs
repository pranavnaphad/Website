using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatnaphadpr.Models
{
    public class Industry
    {
        [DisplayName("Industry ID")]
        [Required]
        
        public int IndustryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }

        [Required]
        [StringLength(50)]
        public string Founder { get; set; }
    }
}
