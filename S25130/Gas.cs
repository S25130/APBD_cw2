using System.ComponentModel;

namespace S25130;

class Gas : Container, IHazardNotifier
{
    public double Pressure { get; }

    public Gas(double pressure) : base("G")
    {
        Pressure = pressure;
        MaxLoad = 2000;
    }

    public override void Unload()
    {
        CurrentLoad *= 0.05;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Hazard Alert [{SerialNumber}]: {message}");
    }
}