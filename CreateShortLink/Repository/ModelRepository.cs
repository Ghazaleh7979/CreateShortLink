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
    
    

    public Longlink Getlonglink(string ll)
    {
        Longlink loli = new Longlink();
        
        Guid g = Guid.NewGuid();
        
        string guidString = Convert.ToBase64String(g.ToByteArray());
        guidString = guidString.Replace("=", "");
        guidString = guidString.Replace("+", "");
        guidString = guidString.Replace("/", "");

        loli.Id = guidString;
        loli.LongLink = ll;

        var query1 = _dbContext.Urlss
            .Add(loli);
        
        _dbContext.SaveChanges();
        
        return loli;
    }
    
    public Longlink? GetId(string id)
    {
        var query = _dbContext.Urlss
            .Find(id);

        return query;

    }
}