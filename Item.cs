namespace ButikkOversikt;

public class Item
{
    private string _name;
    private int _price;
    private double _avragePrice;
    private int _minPrice;
    private int _maxPrice;
    private string _orderList;
    public Item(string name, int price, double avragePrice, int maxPrice, int minPrice, string orderList)
    {
        _name = name;
        _price = price;
        _avragePrice = avragePrice;
        _maxPrice = maxPrice;
        _minPrice = minPrice;
        _orderList = orderList;
    }
    

    public void MainMenu()
    {
        Console.Clear();
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
                ReturnToMenu();
                break;
            case "2":
                var gucci = new Gucci("uggabugga2", 40);
                gucci.PriceLvl();
                gucci.PriceMinMax();
                ReturnToMenu();
                break;
            case "3":
                var toyStore = new ToyStore("uggabugga3", 40);
                toyStore.PriceLvl();
                toyStore.PriceMinMax();
                ReturnToMenu();
                break;
            default:
                Console.WriteLine("Try again");
                break;
            
        }
    }

    private void ReturnToMenu()
    {
        Console.ReadKey();
        MainMenu();
    }
}