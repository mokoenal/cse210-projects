using System;

// Address class to encapsulate address details
public class Address
{
    private string _street;
    private string _city;
    private string _country;

    public Address(string street, string city, string country)
    {
        _street = street;
        _city = city;
        _country = country;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_country}";
    }
}