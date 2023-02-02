using CreateShortLink.Models;
using CreateShortLink.Models.Entity;

namespace CreateShortLink.Application;

public interface IBuildshortLink
{
    public Resultss<string> Ttt(string id);
}