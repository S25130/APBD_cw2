using S25130;

static void Main()
{
    Ship ship = new Ship("Neptun", 10, 100000, 20);
    Liquid milk = new Liquid(false);
    Gas helium = new Gas(25);
    Refrigerated banana = new Refrigerated("Fruit", -9.6);

    try
    {
        milk.Load(500);
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