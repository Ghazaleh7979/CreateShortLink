using System.ComponentModel.DataAnnotations;

namespace CreateShortLink.Models.Entity;

public class ShortLink
{
    public Guid ShortLinkId { get; set; }
    
    [Required(ErrorMessage = "Please enter your long link")]
    public string? Longlink { get; set; }

    public string? Shortlink { get; set; }

}