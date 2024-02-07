using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMVCProjectRainbow.Models;

namespace WebAppMVCProjectRainbow.Data
{
    public class SubjectDbContext : DbContext
    {
        public SubjectDbContext (DbContextOptions<SubjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMVCProjectRainbow.Models.Subject> Subject { get; set; } = default!;
    }
}
