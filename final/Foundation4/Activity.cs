using System;
using System.Collections.Generic;

// Base Event class
public class Activity
{
    private DateTime date;
    protected int lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; //base class doesn't have a specific calculation
    }

    public virtual double GetSpeed()
    {
        return 0; //base class doesn't have a specific calculation
    }

    public virtual double GetPace()
    {
        return 0; //base class doesn't have a specific calculation
    }

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} - {GetType().Name} ({lengthInMinutes} min)";
    }
}