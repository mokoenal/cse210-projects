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
        points += 100;
        Console.WriteLine($"Congratulations! You earned 100 points for completing the goal: {name}");
        completed = true;
    }

    public override void Display()
    {
        Console.WriteLine($"Simple Goal: {name} {(completed ? $", Points: {points}" : "")} {(completed ? "[X]" : "[]")}");
    }
}