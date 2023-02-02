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
    private readonly IModelRepository repo;
    private ShortLink _link;
    private Longlink _longlink;

    public UrlShortenerController(IBuildshortLink build, IModelRepository repository, ShortLink link, Longlink longlink)
    {
        _build = build;
        repo = repository;
        _link = link;
        _longlink = longlink;
    }

    [HttpGet("{id}")]
    public void urlll(string id)
    {
        var rrr = _build.Ttt(id);
        string redirectingurl;
        redirectingurl = rrr.Result.StartsWith("http://") || rrr.Result.StartsWith("http://") ? rrr.Result: "https://" + rrr.Result;
        Response.Redirect(redirectingurl);
    }
    
}