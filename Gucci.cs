namespace ButikkOversikt;

public class Gucci : Shop, IStore
{
    private string _price; 
    
        List<Product> shopProducts = new List<Product>
        {
            new Product("Lepoard Bag", 50000),
            new Product("SunGlasses", 12000),
            new Product("Hoodie", 15000),
            new Product("Pants", 11000),
            
        };
    public Gucci(string itemName, int itemPrice) 
        : base(shopType: "Clothing", speciality: "High prices for shit clothing", price: "High", name: "Gucci")
    {

    }


    public void PriceLvl()
    {
        double avragePrice = 0;
        avragePrice = shopProducts.Average(i => i.Price);
        PriceCheck(avragePrice);
        StoreSpeciality("Gucci", "High prices for shit clothing");
        Console.WriteLine($"The average Price pr product is: {avragePrice}Kr");
    }

    public void PriceMinMax()
    {
        var minPrice = shopProducts.MinBy(p => p.Price);
        var maxPrice = shopProducts.MaxBy(i => i.Price);
        var orderList = shopProducts.OrderBy(p => p.Name);
        foreach (var order in orderList)
        {
            Console.WriteLine($"{order}");
        }
        Console.WriteLine($"""
                           The cheapest product is:{minPrice.Name} ({minPrice.Price}Kr)
                           The most expensive product is:{maxPrice.Name} ({maxPrice.Price}Kr)
                           """);
    }

    public void PriceCheck(double avragePrice)
    {
        _price = avragePrice switch
        {
            > 200 => "High",
            < 100 => "Low",
            > 100 and < 200 => "Medium",
            _ => _price
        };
    }
    public void StoreSpeciality(string name, string speciality)
    {
        Console.Clear();
        Console.WriteLine($"""
                           {name}'s speciality is {speciality}
                           {name}'s pricerange is: 
                           """);
        Console.WriteLine($"The price lvl is: {_price}");
    
    }
}