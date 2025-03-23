namespace CW_2_s30851;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool IsDangerous {
        get;
        set;
    }
    private double LimitCapacity { get; set; }
    public LiquidContainer(double cargoWeight,
        double height,
        double depth,
        double maxWeightCapacity,
        bool isDangerous) 
        : base(cargoWeight,
        height,
        depth,
        "CON-L-"+Container.GetId(),
        maxWeightCapacity
)
    {
        IsDangerous = isDangerous;
        LimitCapacity = isDangerous ? maxWeightCapacity*0.5 : maxWeightCapacity*0.9;
        if (LimitCapacity < CargoWeight)
        {
            Console.WriteLine("Dangerous operation");
        }
    }

    public override void FillCargo(double cargoWeight)
    {
        if (LimitCapacity < CargoWeight)
        {
            Console.WriteLine("Dangerous operation");
        }
        base.FillCargo(cargoWeight);
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Container {0}, height {1}, depth {2}, cargo weight {3}," +
                          " capacity weight {4}, {5}",
            SerialNumber, Height, Depth, CargoWeight,
            MaxWeightCapacity, IsDangerous?"Dangerous":"Not Dangerous");
    }

    public string SendNotification()
    {
        if (IsDangerous)
        {
            return "Dangerous "+SerialNumber;
        }
        return "Not Dangerous";
    }
}