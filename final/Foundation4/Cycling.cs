using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (lengthInMinutes / 60.0); // Distance in miles
    }

    public override double GetPace()
    {
        return 60 / speed; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} miles, Speed: {speed} mph, Pace: {GetPace()} min per mile";
    }
}
