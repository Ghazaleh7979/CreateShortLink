using CreateShortLink.Models.Entity;

namespace CreateShortLink.Repository;

public interface IModelRepository
{
    IQueryable<ShortLink> Links { get; }
    
    void SaveLink(ShortLink sh);
    
    public Longlink? GetById(string id);

}