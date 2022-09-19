using SuperCar.Models;

namespace SuperCar.Services;

public static class SuperCarService
{
    static List<SuperCar> Supercars { get; }
    static int nextId = 3;
    static SuperCarService()
    {
        SuperCars = new List<SuperCar>
        {
            new SuperCar { 
                Id = 1, 
                Make = "Porsche", 
                Model = "911", 
                FuelType = "Petrol", 
                Engine = "4.0", 
                IsManual = true 
            },
            new SuperCar { 
                Id = 2, 
                Make = "Aston Martin", 
                Model = "Vanquish Zagato", 
                FuelType = "Petrol", 
                Engine = "5.9", 
                IsManual = false 
            }
       }
    }

    public static List<SuperCar> GetAll() => SuperCars;

    public static SuperCar? Get(int id) => SuperCars.FirstOrDefault(s => s.Id == id);

    public static void Add(SuperCar supercar)
    {
        supercar.Id = nextId++;
        SuperCars.Add(supercar);
    }

    public static void Delete(int id)
    {
        var supercar = Get(id);
        if(supercar is null)
            return;

        SuperCars.Remove(supercar);
    }

    public static void Update(SuperCar supercar)
    {
        var index = SuperCars.FindIndex(s => s.Id == supercar.Id);
        if(index == -1)
            return;

        SuperCars[index] = supercar;
    }
}
