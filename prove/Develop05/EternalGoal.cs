using System;
using System.Collections.Generic;
using System.IO;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name)
    {
        // Eternal goal, no points awarded initially
    }

    public override void RecordEvent()
    {
        // Eternal goal, no points awarded
        Console.WriteLine($"Eternal Goal '{name}': No points are awarded for recording events.");
    }
}