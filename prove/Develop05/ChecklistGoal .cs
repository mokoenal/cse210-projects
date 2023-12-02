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
        if (completedCount <= requiredCount)
        {
            Console.WriteLine($"Congratulations! You earned {points} points for completing the goal: {name}");
            points = 0; // Reset bonus points after achieving the required count
            completed = (completedCount == requiredCount); // Set completed to true when required count is achieved
        }
        else
        {
            Console.WriteLine($"Congratulations! You earned 50 points for completing the goal: {name}");
            points += 50; // Example points for simplicity
            completed = true;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"Goal: {name}, Progress: {completedCount}/{requiredCount}, Points: {points} {(completed ? "[X]" : "[]")}");
    }
}