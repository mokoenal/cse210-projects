using System;
using System.Collections.Generic;


// Derived Lecture class
public class Lecture : Event
{
    private string speaker;
    private int capacity;

    // Constructor for the Lecture class
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}