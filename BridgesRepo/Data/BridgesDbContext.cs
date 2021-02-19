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

        public DbSet<Bridge> Bridges { get; set; }
    }
}
