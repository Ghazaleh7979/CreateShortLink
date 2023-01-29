using Microsoft.EntityFrameworkCore;

namespace CreateShortLink.Dtos
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options)
            : base(options)
        {
        }

        public DbSet<ShortLink> Products => Set<ShortLink>();
    }
}