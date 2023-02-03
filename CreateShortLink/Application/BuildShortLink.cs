
using CreateShortLink.Models;
using CreateShortLink.Models.Dtos;
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
        try
        {
            Longlink resultss = _repoo.GetId(id);
            if (resultss != null && resultss.LongLink != null)
            {
                return Resultss<string>.SetResult(resultss.LongLink);
            }

            return Resultss<string>.SetResult("google.com");

        }
        catch (Exception)
        {
            return Resultss<string>.SetResult("google.com");
        }
        
    }

    public Resultss<string> Goo(Url body)
    {
        try
        {
            Longlink resultss = _repoo.Getlonglink(body.Full);
            if (resultss == null)
            {
                throw new Exception();
            }

            return Resultss<string>.SetResult("https://localhost:7222/" + resultss.Id);

        }
        catch (Exception)
        {
            return Resultss<string>.SetResult("https://localhost:7222");
        }
        
        
    }
}

