namespace S25130;

class Refrigerated : Container, IHazardNotifier
{
    public string ProductType { get; }
    public double Temperature { get; }

    public Refrigerated(string productType, double temperature) : base("R")
    {
        ProductType = productType;
        Temperature = temperature;
        MaxLoad = 3000;
    }
}