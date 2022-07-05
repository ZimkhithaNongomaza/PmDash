using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace PmDash.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            : base(options) { }
        
        public DbSet<Investor> Investors { get; set; }
        public DbSet<AquaDevelopment> AquaDevelopments { get; set; }
        public DbSet<Desalination> Desalinations { get; set; }
        public DbSet<Other> Others { get; set; }
        public DbSet<WildCoast> WildCoasts { get; set; }
        public DbSet<Document> Documents { get; set; }

    }
}
