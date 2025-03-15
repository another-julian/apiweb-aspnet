using APIWeb.Models;
using APIWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers;

[ApiController]
[Route("[controller]")]

public class BurguerController : ControllerBase
{
    private readonly ILogger<BurguerController> _logger;

    public BurguerController(ILogger<BurguerController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<List<Burguer>> GetAll()
    {
        _logger.LogInformation("GET request on burguer");
        return BurguerService.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Burguer> Get(int id)
    {
        _logger.LogInformation("GET request on burguer");
        var burguer = BurguerService.Get(id);
        return burguer == null ? NotFound() : burguer;
    }
}
