using BridgesDomain.Model;
using Microsoft.EntityFrameworkCore;

namespace BridgesRepo.Data
{
   public class BridgesDbContext : DbContext
    {
        public BridgesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bridge> Bridges { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bridge>().Ignore("FileBytes");
            //modelBuilder.Entity<Bridge>().Ignore("DistanceToMouthKm");
            //modelBuilder.Entity<Bridge>().Ignore("DistanceToSourceKm");
            //modelBuilder.Entity<Bridge>().Property(x => x.Lat).HasPrecision(28, 10);
            //modelBuilder.Entity<Bridge>().Property(x => x.Lng).HasPrecision(28, 10);
            //modelBuilder.Entity<Bridge>().Property(x => x.Zoom).HasPrecision(28, 10);
            //modelBuilder.Entity<Bridge>().Property(x => x.Height).HasPrecision(28, 10);
        }
    }
}
