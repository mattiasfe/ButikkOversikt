namespace ButikkOversikt;

public class Temu : Shop, IStore
{
    public string ItemName { get; set; }
    public int ItemPrice { get; set; }
    
    public Temu(string itemName, int itemPrice) 
        : base(shopType: "Everything", speciality: "Cheap crap", price: "Low", name: "Temu")
    {
        ItemName = itemName;
        ItemPrice = itemPrice;
    }

    public void PriceLvl()
    {
        List<IStore> shopProduct = new List<IStore>
        {
            new Temu(ItemName = "Fountain", ItemPrice = 20),
            new Temu(ItemName = "ToothPick Gun", ItemPrice = 50),
            new Temu(ItemName = "Princes bottle opener", ItemPrice = 74),
            
        };
        double avragePrice = shopProduct.Average(i => i.ItemPrice);
        Console.WriteLine($"{avragePrice}");}

    public void StoreSpeciality(string name, string speciality, double avragePrice)
    {
             PriceLvl();
            Console.WriteLine($"""
                                 {name}'s speciality is {speciality}
                                 {name}'s pricerange is {avragePrice}
                                 """);
    }
    
}