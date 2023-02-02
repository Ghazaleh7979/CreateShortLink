using System.Runtime.InteropServices.ComTypes;
using CreateShortLink.Application;
using CreateShortLink.Models;
using CreateShortLink.Models.Entity;
using CreateShortLink.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CreateShortLink.Controllers;

[ApiController]
[Route("[controller]")]
public class LongToShortController : ControllerBase
{
    private readonly IBuildshortLink _build;
    private readonly IModelRepository repo;
    private ShortLink _link;
    private Longlink _longlink;

    public LongToShortController(IBuildshortLink build, IModelRepository repository, ShortLink link, Longlink longlink)
    {
        _build = build;
        repo = repository;
        _link = link;
        _longlink = longlink;
    }
    
    [HttpGet]
    public IActionResult Show(string s)
    {
        string? newlink = _link.Shortlink;
        return new JsonResult(newlink);

    }
}