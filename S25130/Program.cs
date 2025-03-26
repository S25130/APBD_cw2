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
        Liquid milk = new Liquid(hazard);
        Gas helium = new Gas(25);
        Refrigerated banana = new Refrigerated("Fruit", -9.6);

        try
        {
            milk.Load(850);
            helium.Load(1000);
            banana.Load(1500);

            ship.LoadContainer(milk);
            ship.LoadContainer(helium);
            ship.LoadContainer(banana);

            ship.PrintInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
