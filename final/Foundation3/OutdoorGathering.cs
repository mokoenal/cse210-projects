using System;
using System.Collections.Generic;

// Derived OutdoorGathering class
public class OutdoorGathering : Event
{
    private string weatherStatement;

    // Constructor for the OutdoorGathering class
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        this.weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Statement: {weatherStatement}";
    }
}