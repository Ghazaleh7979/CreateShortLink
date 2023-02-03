using CreateShortLink.Models.Entity;

namespace CreateShortLink.Repository;

public interface IModelRepository
{


    public Longlink? GetId(string id);

    public Longlink? Getlonglink(string ll);

}