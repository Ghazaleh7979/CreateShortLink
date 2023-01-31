using CreateShortLink.Models;
using CreateShortLink.Models.Entity;
using CreateShortLink.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CreateShortLink.Controllers;

[ApiController]
[Route("EnterLink")]
public class LongToShortController : ControllerBase
{
    private readonly IBuildshortLink _rrr;
    private readonly ShortLink _link;

    public LongToShortController(IBuildshortLink rrr, ShortLink link)
    {
        _rrr = rrr;
        _link = link;
    }

    
    [HttpGet]
    // GET
    public RedirectToPageResult Get()
    {
        string shortUrl = _rrr.BiulderMethod();
        return new (shortUrl);
    }
    
    [HttpGet]
    public RedirectResult Index()
    {
        return Redirect("");
    }
    
}