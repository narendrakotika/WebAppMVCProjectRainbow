using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMVCProjectRainbow.Models;

namespace WebAppMVCProjectRainbow.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext (DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMVCProjectRainbow.Models.Student> Student { get; set; } = default!;
    }
}
