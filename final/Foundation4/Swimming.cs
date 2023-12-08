using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_lengthInMinutes / 60.0); // Speed in kilometers per hour
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance(); // Pace in minutes per kilometer
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}