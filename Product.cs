namespace ButikkOversikt;

public class Product
{
    public string Name;
    public int Price;
    public bool minPrice;
    public bool maxPrice;

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}