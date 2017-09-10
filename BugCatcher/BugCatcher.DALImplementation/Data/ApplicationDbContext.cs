using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BugCatcher.DAL.Models;
using Microsoft.AspNetCore.Identity;
using BugCatcher.DAL.Models.Identity;

namespace BugCatcher.DALImplementation.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid
        //, 
        //IdentityUserClaim<Guid>, IdentityUserRole<Guid>, 
        //IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>,
        //IdentityUserToken<Guid>
        >
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Build> Buids { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}