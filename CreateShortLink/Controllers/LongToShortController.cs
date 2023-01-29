using CreateShortLink.Dtos;
using CreateShortLink.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreateShortLink.Controllers;
[ApiController]
[Route("EnterLink")]
public class LongToShortController : ControllerBase
{
    private ILogger<LongToShortController> _logger;
    private readonly IBuildshortLink _rrr;

    public LongToShortController(ILogger<LongToShortController> logger, IBuildshortLink rrr)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _rrr = rrr;
    }

    [HttpGet]
    // GET
    public JsonResult Get(string longlink)
    {
        return new JsonResult(_rrr.BiulderMethod());
        
    }
    


}