using System;
using System.Collections.Generic;

public class Customer
{
    private string Name;
    private Address CustomerAddress;

    public Customer(string name, Address address)
    {
        Name = name;
        CustomerAddress = address;
    }

    public bool IsInUSA()
    {
        return CustomerAddress.IsInUSA();
    }

    public string GetCustomerDetails()
    {
        return $"Name: {Name}, Address: {CustomerAddress.GetFullAddress()}";
    }
}
