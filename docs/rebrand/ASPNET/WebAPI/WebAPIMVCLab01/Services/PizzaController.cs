using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
        PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza == null)
            return NotFound();

        return pizza;
    }
    // POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {            
        /*
CreatedAtAction 201 = The pizza was added to the in-memory cache.
The pizza is included in the response body in the media type, as defined in the accept HTTP request header (JSON by default).
BadRequest is implied 400 = The request body's pizza object is invalid.
        */
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        /*
NoContent 204 = The pizza was updated in the in-memory cache.
BadRequest 400 = The request body's Id value doesn't match the route's id value.
BadRequest is implied 400 = The request body's Pizza object is invalid.
NotFound 404=A pizza that matches the provided id parameter doesn't exist in the in-memory cache.
        */
        if (id != pizza.Id)
            return BadRequest();
            
        var existingPizza = PizzaService.Get(id);
        if(existingPizza is null)
            return NotFound();
    
        PizzaService.Update(pizza);           
    
        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        /*
        NoContent 204=The pizza was deleted from the in-memory cache.
        NotFound 404=A pizza that matches the provided id parameter doesn't exist in the in-memory cache.
        */
        var pizza = PizzaService.Get(id);
    
        if (pizza is null)
            return NotFound();
        
        PizzaService.Delete(id);
    
        return NoContent();
    }
}