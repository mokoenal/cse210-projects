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
    points += 100;
    Console.WriteLine($"Congratulations! You earned 100 points for completing the goal: {name}");
    completed = true;
}

public override void Display()
{
    Console.WriteLine($"Simple Goal: {name} {(completed ? $", Points: {points}" : "")} {(completed ? "[X]" : "[]")}");
}
}