using Microsoft.EntityFrameworkCore;

namespace TwitterCloneApi.Models
{
    public class TwitterCloneContext : DbContext
    {
        public TwitterCloneContext(DbContextOptions<TwitterCloneContext> options)
            : base(options)
        {
        }

        public DbSet<User> TodoItems { get; set; }
    }
}