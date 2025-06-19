namespace ButikkOversikt;

public class Temu : Shop, IStore
{
    public Temu(string shopType, string speciality, string price) 
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