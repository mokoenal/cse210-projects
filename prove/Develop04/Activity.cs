using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

class Activity
{
    private string _name;
    private string _description;
    protected int Duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        Duration = 0;
    }

    // Make the RunActivity method virtual
    public virtual void RunActivity()
    {
        Console.WriteLine($"This activity ({_name}) is not implemented yet. Please override the RunActivity method in the derived class to define the specific behavior.");
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}!");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000);
    }

    private void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job! You've completed the activity.");
        Console.WriteLine($"{_name} took {Duration} seconds.");
        Thread.Sleep(3000);
    }
}