﻿namespace ButikkOversikt;

public class Shop
{
    private string _name;
    private string _shopType;
    private string _speciality;
    private string _price;
    
    public Shop(string shopType, string speciality, string price, string name)
    {
        _name = name;
        _shopType = shopType;
        _speciality = speciality;
        _price = price;
    }

}