using System;

// Address class to encapsulate address details
public class Address
{
    private string Street;
    private string City;
    private string Country;

    public Address(string street, string city, string country)
    {
        Street = street;
        City = city;
        Country = country;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {Country}";
    }
}