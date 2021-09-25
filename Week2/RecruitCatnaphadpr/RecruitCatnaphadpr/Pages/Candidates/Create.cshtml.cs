using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatnaphadpr.Data;
using RecruitCatnaphadpr.Models;

namespace RecruitCatnaphadpr.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatnaphadpr.Data.RecruitCatnaphadprContext _context;

        public CreateModel(RecruitCatnaphadpr.Data.RecruitCatnaphadprContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Name");
        ViewData["IndustryId"] = new SelectList(_context.Industry, "IndustryId", "Name");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "JobTitleId", "Name");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
