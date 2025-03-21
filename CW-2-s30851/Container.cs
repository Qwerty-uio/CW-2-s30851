using System.Numerics;

namespace CW_2_s30851;

public abstract class Container(
    double cargoWeight,
    double height,
    double depth,
    string? serialNumber,
    double maxWeightCapacity)
{
    public double CargoWeight { get; set; } = cargoWeight;
    public double Height { get; set; } = height;
    public double Weight { get; set; }
    public double Depth { get; set; } = depth;
    public string? SerialNumber { get; set; } = serialNumber;
    public double MaxWeightCapacity { get; set; } = maxWeightCapacity;

    public void SetEmpty()
    {
        CargoWeight = 0;
    }

    public void CheckCapacity()
    {
        if (CargoWeight > MaxWeightCapacity)
        {
            throw new OverfillException();
        }
    }
}