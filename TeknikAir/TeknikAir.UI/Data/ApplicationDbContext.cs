using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeknikAir.Entity.Entity;

namespace TeknikAir.UI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Product> Products { get; set; }
        //public DbSet<About> Abouts { get; set; }
        //public DbSet<Reference> References { get; set; }
        //public DbSet<Partner> Partners { get; set; }
    }
}