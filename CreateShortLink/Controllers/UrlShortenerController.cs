using CreateShortLink.Application;
using CreateShortLink.Models;
using CreateShortLink.Models.Entity;
using CreateShortLink.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CreateShortLink.Controllers;

[ApiController]
[Route("/")]
public class UrlShortenerController : ControllerBase
{
    // GET
    private readonly IBuildshortLink _build;

    public UrlShortenerController(IBuildshortLink build)
    {
        _build = build;
    }

    [HttpGet("{id}")]
    public void Urlll (string id)
    {
        var rrr = _build.Ttt(id);
        string redirectingurl;
        redirectingurl = rrr.Result!.StartsWith("http://") || rrr.Result.StartsWith("http://") ? rrr.Result: "https://" + rrr.Result;
        Response.Redirect(redirectingurl);
    }
    
}