namespace CW_2_s30851;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight,
        double height,
        double depth,
        double maxWeightCapacity) 
        : base(cargoWeight,
        height,
        depth,
        "CON-L-"+1,
        maxWeightCapacity)
    {
    }
}