using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * (_lengthInMinutes / 60.0); // Distance in miles
    }

    public override double GetPace()
    {
        return 60 / _speed; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} miles, Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
}
