using System;
using System.Collections.Generic;


// Derived Lecture class
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Constructor for the Lecture class
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}