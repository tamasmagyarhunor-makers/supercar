using SuperCar.Models;
using SuperCar.Services;
using Microsoft.AspNetCore.Mvc;

namespace SuperCar.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    public CarController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Car>> GetAll() => CarService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Car> Get(int id)
    {
        var car = CarService.Get(id);

        if(car == null)
            return NotFound();

        return car;
    }

    // POST action 
    [HttpPost]
    public IActionResult Create(Car car)
    {
        CarService.Add(car);
        return CreatedAtAction(nameof(Create), new {
            id = car.Id
        }, 
            car
        );
    }

    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Car car)
    {
        if (id != car.Id)
            return BadRequest();

        var existingCar = CarService.Get(id);
        if(existingCar is null)
            return NotFound();

        CarService.Update(car);

        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var car = CarService.Get(id);

        if(car is null)
            return NotFound();

        CarService.Delete(id);

        return NoContent();
    }
}
