namespace ButikkOversikt;

public class ToyStore : Shop, IStore
{
    private string _price; 
    
        List<Product> shopProducts = new List<Product>
        {
            new Product("Batman",  97),
            new Product("Barbie", 120),
            new Product("Bow&Arrow", 340),
            new Product("Lego", 220),
            
        };
    public ToyStore(string itemName, int itemPrice) 
        : base(shopType: "Toy", speciality: "Toys", price: "Medium", name: "ToyStore")
    {

    
    }


    public void PriceLvl()
    {
        double avragePrice = 0;
        avragePrice = shopProducts.Average(i => i.Price);
        PriceCheck(avragePrice);
        StoreSpeciality("ToyStore", "Toys");
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