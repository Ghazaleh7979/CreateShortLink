using System.Runtime.InteropServices.ComTypes;
using CreateShortLink.Application;
using CreateShortLink.Models;
using CreateShortLink.Models.Dtos;
using CreateShortLink.Models.Entity;
using CreateShortLink.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CreateShortLink.Controllers;

[ApiController]
[Route("[controller]")]
public class LongToShortController : ControllerBase
{
    private readonly IBuildshortLink _build;

    public LongToShortController(IBuildshortLink build)
    {
        _build = build;
    }


    [HttpPost("GetShortenedUrl")]
    public Resultss<string> Show(Url body)
    {
        return _build.Goo(body);
    }
}
