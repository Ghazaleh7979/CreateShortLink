using CreateShortLink.Database;
using CreateShortLink.Models.Entity;

namespace CreateShortLink.Repository;

public class ModelRepository:IModelRepository
{
    private ModelDbContext _dbContext;

    public ModelRepository(ModelDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<ShortLink> Links => _dbContext.Links;

    public IQueryable<Longlink> Linkssss => _dbContext.Linkssss;

    public void SaveLink(ShortLink sh)
    {
        _dbContext.Add(sh);
        _dbContext.SaveChanges();
    }
    public Longlink? GetById(string id)
    {
        var query = _dbContext.Linkssss
            .Find(id);

        return query;

    }
}