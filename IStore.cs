namespace ButikkOversikt;

public interface IStore
{
    public string ItemName { get; set; }
    public int ItemPrice { get; set; }
    public void PriceLvl();
    public void StoreSpeciality(string name, string speciality, double avragePrice);
}