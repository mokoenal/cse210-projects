using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (lengthInMinutes / 60.0); // Speed in kilometers per hour
    }

    public override double GetPace()
    {
        return lengthInMinutes / GetDistance(); // Pace in minutes per kilometer
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}