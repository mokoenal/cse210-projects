
using System;
using System.Collections.Generic;

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create instances of each type of event
        Address address1 = new Address("123 Main St", "Cityville", "USA");
        Address address2 = new Address("456 Oak St", "Townsville", "USA");
        Address address3 = new Address("789 Pine St", "Villageland", "USA");

        Lecture lectureEvent = new Lecture("Tech Talk", "Exciting tech presentation", DateTime.Now.AddDays(7), new TimeSpan(14, 30, 0), address1, "Lindy Turner", 100);

        Reception receptionEvent = new Reception("Networking Night", "Social networking event", DateTime.Now.AddDays(14), new TimeSpan(18, 0, 0), address2, "rsvp@example.com");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Picnic", "Fun outdoor gathering", DateTime.Now.AddDays(21), new TimeSpan(12, 0, 0), address3, "Weather permitting");

        // Generate and display marketing messages for each event
        DisplayEventMarketingMessage("Lecture Event", lectureEvent);
        DisplayEventMarketingMessage("Reception Event", receptionEvent);
        DisplayEventMarketingMessage("Outdoor Gathering Event", outdoorEvent);
    }

    static void DisplayEventMarketingMessage(string eventType, Event eventObj)
    {
        Console.WriteLine($"{eventType} Marketing Messages:");
        Console.WriteLine("Full Details:");
        Console.WriteLine(eventObj.GetFullDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(eventObj.GetShortDescription());
        Console.WriteLine();
    }
}