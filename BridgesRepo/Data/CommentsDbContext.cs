using BridgesDomain.Model;
using Microsoft.EntityFrameworkCore;

namespace BridgesRepo.Data
{
    public class CommentsDbContext : DbContext
    {
        public CommentsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Comment> Comments{ get; set; }
    }
}