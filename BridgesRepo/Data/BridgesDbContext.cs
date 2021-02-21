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
    }
}
