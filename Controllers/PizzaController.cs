using APIWeb.Models;
using APIWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers;

[ApiController]
[Route("[controller]")]

public class PizzaController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;
    public PizzaController(ILogger<PizzaController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<List<Pizza>> GetAll()
    {
        _logger.LogInformation("GET request on Pizza");
        return PizzaService.GetAll();

    }

    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }
}