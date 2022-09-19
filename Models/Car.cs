namespace SuperCar.Models;

public class Car
{
    public int Id { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public string? FuelType { get; set; }
    public double? Engine { get; set; }
    public bool IsManual { get; set; }
}
