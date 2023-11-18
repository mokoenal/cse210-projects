using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name)
    {
        this.points = points;
    }

    public override void RecordEvent()
    {
        if (!completed)
        {
            points += 100;
            completed = true;
            Console.WriteLine($"Congratulations! You earned {points} points for completing the goal: {name}");
        }
        else
        {
            Console.WriteLine($"Goal '{name}' is already completed.");
        }
    }
}