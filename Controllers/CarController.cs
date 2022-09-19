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

    [HttpGet]
    public ActionResult<List<Car>> GetAll() => CarService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Car> Get(int id)
    {
        var car = CarService.Get(id);

        if(car == null)
            return NotFound();

        return car;
    }

    // POST action

    // PUT action

    // DELETE action
}
