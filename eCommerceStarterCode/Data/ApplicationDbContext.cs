using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
        // Creating a new table for Merch
        public DbSet<Merch> Merches { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         //   modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}
