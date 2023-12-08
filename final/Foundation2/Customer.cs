using System;
using System.Collections.Generic;

public class Customer
{
    private string _name;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _name = name;
        _customerAddress = address;
    }

    public bool IsInUSA()
    {
        return _customerAddress.IsInUSA();
    }

    public string GetCustomerDetails()
    {
        return $"Name: {_name}, Address: {_customerAddress.GetFullAddress()}";
    }
}