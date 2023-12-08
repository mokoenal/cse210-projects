using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (lengthInMinutes / 60.0); // Speed in miles per hour
    }

    public override double GetPace()
    {
        return lengthInMinutes / distance; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

