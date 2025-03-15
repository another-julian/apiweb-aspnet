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
        _logger.LogInformation("GET request on Pizza");
        var pizza = PizzaService.Get(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }

    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        _logger.LogInformation("POST request on Pizza");
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);

    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        _logger.LogInformation("PUT request on Pizza");

        if (id != pizza.Id)
            return BadRequest();

        var existingPizza = PizzaService.Get(id);

        if (existingPizza is null)
            return NotFound();

        PizzaService.Update(pizza);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _logger.LogInformation("DELETE request on Pizza");

        var pizza = PizzaService.Get(id);

        if (pizza is null)
            return NotFound();

        PizzaService.Delete(id);
        return NoContent();
    }
}