using System.Numerics;

namespace CW_2_s30851;

public abstract class Container(
    double cargoWeight,
    double height,
    double depth,
    string? serialNumber,
    double maxWeightCapacity)
{
    private static int id = 0;

    public static int GetId()
    {
        return id++;
    }
    public double CargoWeight { get; set; } = cargoWeight;
    public double Height { get; set; } = height;
    public double Weight { get; set; }
    public double Depth { get; set; } = depth;
    public string? SerialNumber { get; set; } = serialNumber;
    public double MaxWeightCapacity { get; set; } = maxWeightCapacity;

    public virtual void SetEmpty()
    {
        CargoWeight = 0;
    }

    public virtual void FillCargo(double cargoWeight)
    {
        CargoWeight += cargoWeight;
        try
        {
            CheckCapacity();
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e);
            CargoWeight-=cargoWeight;
        }
    }

    public void CheckCapacity()
    {
        if (CargoWeight > MaxWeightCapacity)
        {
            throw new OverfillException();
        }
    }

    public abstract void PrintInfo();

}