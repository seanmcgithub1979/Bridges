using BridgesDomain.Model;
using Microsoft.EntityFrameworkCore;

namespace BridgesRepo.Interfaces
{
    public interface IBridgesDbContext
    {
        public DbSet<Bridge> Bridges { get; set; }
    }
}