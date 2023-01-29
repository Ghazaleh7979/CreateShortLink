namespace CreateShortLink.Models;

public class BuildShortLink : IBuildshortLink
{
    public string BiulderMethod()
    {
        var random = new Random();
        int _random = random.Next(0000,9999);
        string full = $"https://localhost:{_random}";
        return full;
    }

    public void ChangeLinks(string longlink, string shortlink)
    {
        throw new NotImplementedException();
    }
    
}
