using CreateShortLink.Models;
using CreateShortLink.Models.Dtos;
using CreateShortLink.Models.Entity;

namespace CreateShortLink.Application;

public interface IBuildshortLink
{
    public Resultss<string> Ttt(string id);
    public Resultss<string> Goo(Url body);
}