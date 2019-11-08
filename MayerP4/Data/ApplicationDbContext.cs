using System;
using System.Collections.Generic;
using System.Text;
using MayerP4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MayerP4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}
