namespace ButikkOversikt;

public class Item
{
    private string _name;
    private int _price;
    private double _avragePrice;
    private int _minPrice;
    private int _maxPrice;
    public Item(string name, int price, double avragePrice, int maxPrice, int minPrice)
    {
        _name = name;
        _price = price;
        _avragePrice = avragePrice;
        _maxPrice = maxPrice;
        _minPrice = minPrice;
    }
    

    public void MainMenu()
    {
        
        Console.WriteLine("""
                          '1' For Temu
                          '2' For Gucci
                          '3' For ToyStore
                          """);
        var valg = Console.ReadLine();
        switch (valg)
        {
            case "1":
                var temu = new Temu("uggabugga", 40);
                temu.PriceLvl();
                temu.PriceMinMax();
                break;
            case "2":
                var gucci = new Gucci("uggabugga2", 40);
                gucci.PriceLvl();
                break;
            case "3":
                var toyStore = new ToyStore("uggabugga3", 40);
                toyStore.PriceLvl();
                break;
            default:
                Console.WriteLine("Try again");
                break;
        }
    }
}