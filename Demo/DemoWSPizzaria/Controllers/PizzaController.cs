using Microsoft.AspNetCore.Mvc;

namespace DemoWSPizzaria.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;

    public PizzaController(ILogger<PizzaController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet()]
    public IEnumerable<Pizza> GetAll()
    {
        return PizzasService.GetAll();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public ActionResult<Pizza> GetById(int id)
    {
        _logger.LogInformation($"Get pizza with Id {id}");
        var pizza = PizzasService.Get(id);
        if (pizza is null) return NotFound();
        return pizza;
    }

    [HttpPut()] //.../pizza
    public ActionResult<Pizza> Create(Pizza pizza)
    {
        _logger.LogInformation($"Create pizza:\n {pizza}");
        PizzasService.Add(pizza);
        return CreatedAtAction(nameof(GetById), new {id=pizza.Id}, pizza);
    }
    [HttpDelete("{id}")] //..pizza/1
    public IActionResult Delete(int id)
    {
        var pizza = PizzasService.Get(id);
        if(pizza is null) return NotFound();
        PizzasService.Delete(id);
        return NoContent();
    }
}
