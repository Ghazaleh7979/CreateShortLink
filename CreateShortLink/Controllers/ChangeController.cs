using CreateShortLink.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreateShortLink.Controllers;

[ApiController]
[Route("{_random}")]
public class ChangeController : ControllerBase
{
    private readonly IBuildshortLink _rrr;

    public ChangeController(IBuildshortLink rrr)
    {
        _rrr = rrr;
    }

    // public BuildShortLink Set()
    // {
    //     return 
    // }
    
}