namespace ButikkOversikt;

public class Shop
{
    private string _shopType;
    private string _speciality;
    private string _price;

    public Shop(string shopType, string speciality, string price)
    {
        _shopType = shopType;
        _speciality = speciality;
        _price = price;
    }
    
}