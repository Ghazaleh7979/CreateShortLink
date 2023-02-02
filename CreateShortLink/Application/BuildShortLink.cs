using CreateShortLink.Database;
using CreateShortLink.Models;
using CreateShortLink.Models.Entity;
using CreateShortLink.Repository;

namespace CreateShortLink.Application;

public class BuildShortLink : IBuildshortLink
{
    private IModelRepository _repoo;

    public BuildShortLink(IModelRepository repoo)
    {
        _repoo = repoo;
    }

    public Resultss<string> Ttt(string id)
    {
        Longlink? Resultss = _repoo.GetById(id);
        if (Resultss == null)
        {
            throw new Exception();
        }
        else
            return Resultss<string>.SetResult(Resultss.LongLink);

    }
}
