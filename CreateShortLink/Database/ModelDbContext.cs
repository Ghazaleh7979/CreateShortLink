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
        

        public DbSet<ShortLink> Links
        {
            get { return Set<ShortLink>(); }
        }

        public DbSet<Longlink> Linkssss
        {
            get { return Set<Longlink>(); }
        }
    }
}