using S25130;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj nazwę statku: ");
        string shipName = Console.ReadLine();
        Console.WriteLine("Podaj maksymalną liczbę kontenerów: ");
        int maxConNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj maksymalny załadunek w kg: ");
        int maxWeight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj prędkość statku: ");
        int maxSpeed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Czy kontener jest niebezpieczny (T/F):");
        string hazardious = Console.ReadLine();
        Console.WriteLine("Podaj nazwę płynu:");
        string liquidName = Console.ReadLine();
        Console.WriteLine("Podaj wagę kontenera (liquid):");
        int liquidWeight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj nazwę gazu:");
        string gasName = Console.ReadLine();
        Console.WriteLine("Podaj ciśnienie gazu:");
        int gasPressure = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj wagę kontenera (gas):");
        int gasWeight = Convert.ToInt32(Console.ReadLine());
        
        bool hazard;
        if (hazardious == "T" || hazardious == "t")
        {
            hazard = true;
        }
        else if (hazardious == "F" || hazardious == "f")
        {
            hazard = false;
        }
        else
        {
            Console.WriteLine("Błąd wyboru - wybrano domyślnie - T");
            hazard = true;
        }
    
        Ship ship = new Ship(shipName, maxConNum, maxWeight, maxSpeed);
        Liquid liquid = new Liquid(liquidName, hazard);
        Gas gas = new Gas(gasName,gasPressure);
        Refrigerated banana = new Refrigerated("Fruit", -9.6);

        try
        {
            liquid.Load(liquidWeight);
            gas.Load(gasWeight);
            banana.Load(1500);

            ship.LoadContainer(liquid);
            ship.LoadContainer(gas);
            ship.LoadContainer(banana);

            ship.PrintInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
