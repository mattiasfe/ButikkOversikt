namespace ButikkOversikt;

public class Temu : Shop, IStore
{
    private string _price; 
    
        List<Product> shopProducts = new List<Product>
        {
            new Product("Fountain", 20),
            new Product("ToothPick Gun", 50),
            new Product("Princes bottle opener", 74),
            new Product("Batman bottle opener", 47),
            
        };
    public Temu(string itemName, int itemPrice) 
        : base(shopType: "Everything", speciality: "Cheap crap", price: "Low", name: "Temu")
    {

    }

    public void PriceLvl()
    {
        double avragePrice = 0;
        avragePrice = shopProducts.Average(i => i.Price);
        PriceCheck(avragePrice);
        StoreSpeciality("Temu", "Cheap Crap");
        Console.WriteLine($"The average Price is: {avragePrice}Kr");
        
    }

    
    public void PriceMinMax()
    {
        var minPrice = shopProducts.MinBy(p => p.Price);
        var maxPrice = shopProducts.MaxBy(i => i.Price);
        Console.WriteLine($"""
                           The cheapest product is:{minPrice.Name} ({minPrice.Price}Kr)
                           The most expensive product is:{maxPrice.Name} ({maxPrice.Price}Kr)
                           """);
    }

    public void PriceCheck(double avragePrice)
    {
        
        if (avragePrice > 200)
        {
            _price = "High";
        }      
        if (avragePrice < 100)
        {
            _price = "Low";
        }     
        if (avragePrice > 100 && avragePrice < 200)
        {
            _price = "Medium";
        }
        
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