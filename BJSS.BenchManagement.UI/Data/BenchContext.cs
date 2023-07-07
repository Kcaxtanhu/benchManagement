using Microsoft.EntityFrameworkCore;
using BJSS.BenchManagement.UI.Models;

namespace BJSS.BenchManagement.UI.Data
{
    public class BenchContext : DbContext
    {
        public DbSet<BenchPlayer>? BenchPlayer { get; set; }

        public BenchContext(DbContextOptions<BenchContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring a many-to-many special -> topping relationship that is friendly for serialization
            modelBuilder.Entity<BenchPlayer>().HasKey(bp => new { bp.BenchPlayerId, bp.FullName, bp.Role });
        }
    }
}