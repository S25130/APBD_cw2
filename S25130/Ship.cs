namespace S25130;

class Ship
{
    public string Name { get; }
    public int MaxContainers { get; }
    public double MaxWeight { get; }
    public double Speed { get; }
    private List<Container> containers = new List<Container>();
    
    public Ship(string name, int maxContainers, double maxWeight, double speed)
    {
        Name = name;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
        Speed = speed;
    }
    
    public void LoadContainer(Container container)
    {
        if (containers.Count >= MaxContainers || GetTotalWeight() + container.MaxLoad > MaxWeight)
            throw new Exception("Cannot load container: Exceeds ship capacity");
        
        containers.Add(container);
    }
    
    public void UnloadContainer(string serialNumber)
    {
        containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }
    
    public double GetTotalWeight()
    {
        double weight = 0;
        foreach (var container in containers)
        {
            weight += container.MaxLoad;
        }
        return weight;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Ship {Name} (Speed: {Speed} knots, Max Containers: {MaxContainers}, Max Weight: {MaxWeight} tons)");
        Console.WriteLine("Loaded Containers:");
        foreach (var container in containers)
        {
            Console.WriteLine($"- {container.SerialNumber}, Load: {container.CurrentLoad}/{container.MaxLoad}");
        }
    }
}