using System.ComponentModel.DataAnnotations;

namespace CreateShortLink.Models.Entity;

public class ShortLink
{
    public Guid ShortLinkId { get; set; }
    

    public string? Shortlink
    {
        get
        {
            var random = new Random();
            return $"{random.Next(0000,9999)}";
        }
    }
}