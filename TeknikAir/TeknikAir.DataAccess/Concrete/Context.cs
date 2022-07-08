using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikAir.Entity.Entity;

namespace TeknikAir.DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SVP5E2K;Database=TeknikAirDB;Trusted_Connection=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Partner> Partners { get; set; }
    }
}
