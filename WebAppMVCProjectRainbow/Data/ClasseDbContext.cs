﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMVCProjectRainbow.Models;

namespace WebAppMVCProjectRainbow.Data
{
    public class ClasseDbContext : DbContext
    {
        public ClasseDbContext (DbContextOptions<ClasseDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMVCProjectRainbow.Models.Classe> Classe { get; set; } = default!;
    }
}
