using System;
using System.Collections.Generic;

public class Product
{
    private string Name;
    private string ProductId;
    private double Price;
    private int Quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return Price * Quantity;
    }

    public string GetProductDetails()
    {
        return $"Name: {Name}, Product ID: {ProductId}, Price: ${Price}, Quantity: {Quantity}";
    }
}