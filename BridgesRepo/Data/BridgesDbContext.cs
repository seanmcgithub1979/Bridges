using BridgesDomain.Model;
using BridgesRepo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BridgesRepo.Data
{
   public class BridgesDbContext : DbContext, IBridgesDbContext
    {
        public BridgesDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=DESKTOP-HOUOIUP;Database=Bridges;Trusted_Connection=True;");
        }

        public DbSet<Bridge> Bridges { get; set; }
    }
}
