namespace S25130;

class Liquid : Container, IHazardNotifier
{
    public bool IsHazardous { get; }

    public Liquid(string name, bool isHazardous) : base("L")
    {
        IsHazardous = isHazardous;
        MaxLoad = 1000;
    }
    
    public override void Load(double weight)
    {
        double maxAllowedLoad = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (weight > maxAllowedLoad)
        {
            NotifyHazard("Attempted to overload hazardous liquid container");
            weight = maxAllowedLoad;
        }
            
        base.Load(weight);
    }
    
    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Hazard Alert [{SerialNumber}]: {message}");
    }
}