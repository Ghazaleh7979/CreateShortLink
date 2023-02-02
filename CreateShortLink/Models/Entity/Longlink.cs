using System.ComponentModel.DataAnnotations;

namespace CreateShortLink.Models.Entity;

public class Longlink
{
    public Guid Longlinkid { get; set; }
    
    [Required(ErrorMessage = "Please enter your long link")]
    public string? LongLink { get; set; }
}