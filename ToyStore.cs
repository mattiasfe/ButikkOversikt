namespace ButikkOversikt;

public class ToyStore : Shop, IStore
{
    public ToyStore(string shopType, string speciality, string price) 
        : base(shopType, speciality, price)
    {
    }

    public void PriceLvl()
    {
        throw new NotImplementedException();
    }

    public void StoreSpeciality()
    {
        throw new NotImplementedException();
    }
}