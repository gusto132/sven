using Microsoft.EntityFrameworkCore;
using sven.models.data;

namespace sven.models.access
{
    public class SvenDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SvenDbContext(DbContextOptions<SvenDbContext> options) : base(options)
        {

        }
    }
}