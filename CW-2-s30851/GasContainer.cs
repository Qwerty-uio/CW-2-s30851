namespace CW_2_s30851;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }
    public GasContainer(double cargoWeight,
        double height,
        double depth,
        double maxWeightCapacity,
        double pressure) 
        : base(cargoWeight,
            height,
            depth,
            "CON-G-"+Container.GetId(),
            maxWeightCapacity)
    {
        Pressure = pressure;
        CheckCapacity();
    }

    public string SendNotification()
    {
        return "Dangerous gas "+SerialNumber;
    }

    public override void SetEmpty()
    {
        CargoWeight *= 0.05;
    }
    
    public override void PrintInfo()
    {
        Console.WriteLine("Container {0}, height {1}, depth {2}, cargo weight {3}," +
                          " capacity weight {4}, pressure {5}, Dangerous",
            SerialNumber, Height, Depth, CargoWeight,
            MaxWeightCapacity, Pressure);
    }
}