namespace CW_2_s30851;

public class CoolingContainer: Container
{
    private Dictionary<string,double> productToTemperature = new Dictionary<string, double>
    {
        {"Bananas",13.3},
        {"Chocolate",18},
        {"Fish",2},
        {"Meat",-15},
        {"Ice cream",-18},
        {"Frozen pizza",-30},
        {"Cheese",7.2},
        {"Sausages",5},
        {"Butter",20.5},
        {"Eggs",19},
    };

    public string Product { get; set; }
    public double Temperature { get; set; }
    
    public CoolingContainer(double cargoWeight,
        double height,
        double depth,
        double maxWeightCapacity,
        string product,
        double temperature) 
        : base(cargoWeight,
            height,
            depth,
            "CON-C-"+Container.GetId(),
            maxWeightCapacity)
    {
        Product = product;
        if (productToTemperature.ContainsKey(product))
        {
            Temperature = productToTemperature[product] < temperature ? productToTemperature[product] : temperature;
        }
        else
        {
            Temperature = temperature;
        }
    }
    
    public override void PrintInfo()
    {
        Console.WriteLine("Container {0}, height {1}, depth {2}, cargo weight {3}," +
                          " capacity weight {4}, product {5}, temperature {6}",
            SerialNumber, Height, Depth, CargoWeight,
            MaxWeightCapacity, Product, Temperature);
    }
}