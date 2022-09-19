namespace SuperCar.Models;

public class SuperCar
{
    public int Id { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public string? FuelType { get; set; }
    public float? Engine { get; set; }
    public bool IsManual { get; set; }
}
