using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> Products;
    private Customer Customer;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in Products)
        {
            totalPrice += product.GetTotalPrice();
        }

        if (Customer.IsInUSA())
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
        foreach (var product in Products)
        {
            label += $"{product.GetProductDetails()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {Customer.GetCustomerDetails()}";
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