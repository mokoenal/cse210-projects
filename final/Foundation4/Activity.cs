using System;
using System.Collections.Generic;

// Base Event class
public class Activity
{
    private DateTime _date;
    protected int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base class does not have a specific distance calculation
    }

    public virtual double GetSpeed()
    {
        return 0; // Base class does not have a specific speed calculation
    }

    public virtual double GetPace()
    {
        return 0; // Base class does not have a specific pace calculation
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} - {GetType().Name} ({_lengthInMinutes} min)";
    }
}