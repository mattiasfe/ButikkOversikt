namespace ButikkOversikt;

public class Gucci : Shop, IStore
{
    public Gucci(string shopType, string speciality, string price) 
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