using System;
using System.Collections.Generic;

// Derived Reception class
public class Reception : Event
{
    private string rsvpEmail;

    // Constructor for the Reception class
    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP Email: {rsvpEmail}";
    }
}