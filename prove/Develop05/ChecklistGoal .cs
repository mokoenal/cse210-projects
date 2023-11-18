using System;
using System.Collections.Generic;
using System.IO;

public class ChecklistGoal : Goal
{
    private int requiredCount;
    private int completedCount;

    public ChecklistGoal(string name, int requiredCount, int bonus) : base(name)
    {
        this.requiredCount = requiredCount;
        this.completedCount = 0;
        this.points = bonus;
    }

    public override void RecordEvent()
    {
        completedCount++;

        if (completedCount < requiredCount)
        {
            Console.WriteLine($"Event recorded for '{name}'. {completedCount}/{requiredCount} completed.");
        }
        else if (completedCount == requiredCount)
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal '{name}' and earned {points} points.");
        }
        else
        {
            Console.WriteLine($"Error: The checklist goal '{name}' has already been completed the required {requiredCount} times.");
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{name} Completed: {completedCount}/{requiredCount}");
    }
}