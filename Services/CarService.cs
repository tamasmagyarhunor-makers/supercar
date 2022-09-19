using SuperCar.Models;

namespace SuperCar.Services;

public static class CarService
{
    static List<Car> Cars { get; }
    static int nextId = 3;
    static CarService()
    {
        Cars = new List<Car>
        {
            new Car { 
                Id = 1, 
                Make = "Porsche", 
                Model = "911", 
                FuelType = "Petrol", 
                Engine = 4.0, 
                IsManual = true 
            },
            new Car { 
                Id = 2, 
                Make = "Aston Martin", 
                Model = "Vanquish Zagato", 
                FuelType = "Petrol", 
                Engine = 5.9, 
                IsManual = false 
            }
        };
    }

    public static List<Car> GetAll() => Cars;

    public static Car? Get(int id) => Cars.FirstOrDefault(c => c.Id == id);

    public static void Add(Car car)
    {
        car.Id = nextId++;
        Cars.Add(car);
    }

    public static void Delete(int id)
    {
        var car = Get(id);
        if(car is null)
            return;

        Cars.Remove(car);
    }

    public static void Update(Car car)
    {
        var index = Cars.FindIndex(c => c.Id == car.Id);
        if(index == -1)
            return;

        Cars[index] = car;
    }
}
