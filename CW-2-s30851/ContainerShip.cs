namespace CW_2_s30851;

public class ContainerShip(double speed, int maxAmountOfContainers, double maxWeight)
{
    private List<Container> containers = new List<Container>();
    public double Speed { get; set; } = speed;
    public int MaxAmountOfContainers { get; set; } = maxAmountOfContainers;
    public double MaxWeight { get; set; } = maxWeight;

    public void AddContainer(Container container)
    {
        if (containers.Count < MaxAmountOfContainers)
        {
            containers.Add(container);
        }
    }

    public void AddContainers(List<Container> containers)
    {
        foreach (var t in containers)
        {
            this.AddContainer(t);
        }
    }

    public void RemoveContainer(Container container)
    {
        containers.Remove(container);
    }
    public Container RemoveContainer()
    {
        Container currentContainer = containers.Last();
        containers.Remove(currentContainer);
        return currentContainer;
    }

    public void ReplaceContainer(string serialNumber, Container newContainer)
    {
        int id = containers.FindIndex(delegate(Container container) { return container.SerialNumber == serialNumber; });
        containers[id] = newContainer;
    }

    public void MoveContainer(Container containerToMove, ContainerShip newContainerShip)
    {
        newContainerShip.AddContainer(containerToMove);
        RemoveContainer(containerToMove);
    }

    public void PrintContainerShip()
    {
        Console.WriteLine("Container ship: max weight {0}, max amount {1}, max speed {2}, containers:",MaxWeight,MaxAmountOfContainers,Speed);
        foreach (Container c in containers)
        {
            c.PrintInfo();
        }
    }
}