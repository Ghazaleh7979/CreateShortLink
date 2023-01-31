using CreateShortLink.Models.Entity;

namespace CreateShortLink.Repository;

public interface IBuildshortLink
{
    string BiulderMethod();

    void SaveLink(ShortLink sh);
    
}