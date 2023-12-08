using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        if (_customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"{product.GetProductDetails()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetCustomerDetails()}";
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine($"Total Price: ${CalculateTotalPrice()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(GetShippingLabel());
    }
}