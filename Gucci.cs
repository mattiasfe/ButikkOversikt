namespace ButikkOversikt;

public class Gucci : Shop, IStore
{
    private string _price;

    private List<Product> shopProducts = new List<Product>();

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
        // var orderList = shopProducts.OrderBy(p => p.Name);
        // foreach (var order in orderList)
        // {
        //     Console.WriteLine($"{order}");
        // }
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
    public void AddItem()
    {
        while (true)
        {
            Console.WriteLine("Add a product to the list (Write 'done' to exit):");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            if(name.ToLower() == "done")
                break;
            Console.WriteLine("Price: ");
            int price = int.Parse(Console.ReadLine());
            
            shopProducts.Add(new Product(name, price));
        }
        shopProducts.ForEach(i => Console.WriteLine($"{i.Name} ({i.Price} Kr)"));
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