namespace S25130;

abstract class Container
{
    private static Dictionary<string, int> counters = new Dictionary<string, int>()
    {
        { "L", 1 }, { "G", 1 }, { "R", 1 }
    };
    
    public string SerialNumber { get; }
    public double MaxLoad { get; protected set; }
    public double CurrentLoad { get; protected set; }
    
    protected Container(string type)
    {
        SerialNumber = $"KON-{type}-{counters[type]++}";
    }
    
    public virtual void Load(double weight)
    {
        if (CurrentLoad + weight > MaxLoad)
        {
            Console.WriteLine("Warning: Load exceeds maximum capacity. Adjusting to maximum load.");
            CurrentLoad = MaxLoad;
        }
        else
        {
            CurrentLoad += weight;
        }
    }
    
    public virtual void Unload()
    {
        CurrentLoad = 0;
    }
}