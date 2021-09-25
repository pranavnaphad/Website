﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatnaphadpr.Data;
using RecruitCatnaphadpr.Models;

namespace RecruitCatnaphadpr.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatnaphadpr.Data.RecruitCatnaphadprContext _context;

        public IndexModel(RecruitCatnaphadpr.Data.RecruitCatnaphadprContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
