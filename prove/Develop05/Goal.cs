using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected internal string name;
    protected internal int points;
    protected internal bool completed;

    public Goal(string name)
    {
        this.name = name;
        this.points = 0;
        this.completed = false;
    }

    public abstract void RecordEvent();

    public virtual void Display()
    {
        Console.WriteLine($"{name} {(completed ? "[X]" : "[]")}");
    }

    public virtual void Complete()
    {
        if (!completed)
        {
            points += 100;
            Console.WriteLine($"Goal '{name}' completed! +100 points");
            completed = true;
        }
        else
        {
            Console.WriteLine($"Goal '{name}' is already completed.");
        }
    }

    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{name}:{points}:{completed}";
    }

    public string GetName()
    {
        return name;
    }
}