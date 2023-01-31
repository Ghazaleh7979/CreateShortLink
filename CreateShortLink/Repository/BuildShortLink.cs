using CreateShortLink.Database;
using CreateShortLink.Models.Entity;

namespace CreateShortLink.Repository;

public class BuildShortLink : IBuildshortLink
{
    public string BiulderMethod()
    {
        var random = new Random();
        int i = random.Next(0000,9999);
        string full = $"https://localhost:{i}";
        return full;
    }
    
    private readonly ModelDbContext _context;
    public BuildShortLink(ModelDbContext ctx) {
        _context = ctx;
    }
    public IQueryable<ShortLink> ShortLinks => _context.Links;
    public void SaveLink(ShortLink sh)
    {
        _context.Add(sh);
        _context.SaveChanges();
    }
}
