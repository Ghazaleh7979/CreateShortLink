namespace CreateShortLink.Models;

public interface IBuildshortLink
{
    string BiulderMethod();
    
    void ChangeLinks(string longlink, string shortlink);
}