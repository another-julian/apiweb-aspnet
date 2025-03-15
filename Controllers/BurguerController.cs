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

    [HttpPost]
    public IActionResult Create(Burguer burguer)
    {
        _logger.LogInformation("POST request on burguer");

        BurguerService.Add(burguer);
        return CreatedAtAction(nameof(Get), new { id = burguer.Id }, burguer);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Burguer burguer)
    {
        _logger.LogInformation("PUT request on Burguer");

        if (id != burguer.Id)
            return BadRequest();

        var existingBurguer = BurguerService.Get(id);
        if (existingBurguer == null)
            return NotFound();

        BurguerService.Update(burguer);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _logger.LogInformation("DELETE request on Burguer");

        var burguer = BurguerService.Get(id);
        if (burguer is null) return NotFound();

        BurguerService.Delete(id);
        return NoContent();
    }
}
