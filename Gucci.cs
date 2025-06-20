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
        Console.WriteLine($"{avragePrice}Kr");
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
                           {_price}
                           """);
    
    }
}