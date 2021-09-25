using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatnaphadpr.Data;
using RecruitCatnaphadpr.Models;

namespace RecruitCatnaphadpr.Pages.JobTitles
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatnaphadpr.Data.RecruitCatnaphadprContext _context;

        public DetailsModel(RecruitCatnaphadpr.Data.RecruitCatnaphadprContext context)
        {
            _context = context;
        }

        public JobTitle JobTitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobTitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.JobTitleId == id);

            if (JobTitle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
