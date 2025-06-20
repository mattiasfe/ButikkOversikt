namespace ButikkOversikt;

public class ToyStore : Shop, IStore
{
    public ToyStore(string shopType, string speciality, string price, string name) 
        : base(shopType, speciality, price, name)
    {
    }

    public string ItemName { get; set; }
    public int ItemPrice { get; set; }

    public void PriceLvl()
    {
        throw new NotImplementedException();
    }

    public void StoreSpeciality(string name, string speciality, double avragePrice)
    {
        throw new NotImplementedException();
    }
}