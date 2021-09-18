using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatnaphadpr.Models;

namespace RecruitCatnaphadpr.Data
{
    public class RecruitCatnaphadprContext : DbContext
    {
        public RecruitCatnaphadprContext (DbContextOptions<RecruitCatnaphadprContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatnaphadpr.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatnaphadpr.Models.Company> Company { get; set; }

        public DbSet<RecruitCatnaphadpr.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatnaphadpr.Models.JobTitle> JobTitle { get; set; }
    }
}
