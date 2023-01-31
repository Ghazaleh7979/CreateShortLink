using CreateShortLink.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CreateShortLink.Database
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options)
            : base(options)
        {
        }

        public DbSet<ShortLink> Links => Set<ShortLink>();
        
    }
}