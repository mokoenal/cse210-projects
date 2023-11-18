using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class EternalQuestTracker
{
    private List<Goal> goals;

    public EternalQuestTracker()
    {
        this.goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = goals.FirstOrDefault(g => string.Equals(g.GetName(), goalName, StringComparison.OrdinalIgnoreCase));

        if (goal != null && !goal.completed)
        {
            int previousPoints = goal.points; // Store previous points for display
            goal.RecordEvent();
            int addedPoints = goal.points - previousPoints; // Calculate added points

            Console.WriteLine($"Event recorded for the goal: {goalName}");
            Console.WriteLine($"You have {addedPoints} points. Total points: {GetTotalPoints()}");
        }
        else if (goal != null && goal.completed)
        {
            Console.WriteLine($"Goal '{goalName}' has already been completed.");
        }
        else
        {
            Console.WriteLine($"Goal not found with the name: {goalName}");
        }
    }

    public void DisplayGoals()
    {
        int goalIndex = 1;
        foreach (var goal in goals)
        {
            goal.Display();
            goalIndex++;
        }
    }

    public void SaveToFile(string saveFilename)
    {
        using (StreamWriter outputFile = new StreamWriter(saveFilename))
        {
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadFromFile(string loadFilename)
    {
        try
        {
            string[] lines = File.ReadAllLines(loadFilename);

            foreach (var line in lines)
            {
                string[] parts = line.Split(':');

                if (parts.Length < 3)
                {
                    Console.WriteLine($"Invalid format in the file: {loadFilename}");
                    continue;
                }

                string type = parts[0];
                string name = parts[1];
                int points = 0;

                if (int.TryParse(parts[2], out int parsedPoints))
                {
                    points = parsedPoints;
                }
                else
                {
                    Console.WriteLine($"Invalid points format in the file: {loadFilename}");
                    continue;
                }

                switch (type)
                {
                    case nameof(SimpleGoal):
                        goals.Add(new SimpleGoal(name, points));
                        break;
                    case nameof(EternalGoal):
                        goals.Add(new EternalGoal(name, "", points));
                        break;
                    case nameof(ChecklistGoal):
                        if (parts.Length < 5)
                        {
                            Console.WriteLine($"Invalid format for ChecklistGoal in the file: {loadFilename}");
                            continue;
                        }

                        int requiredCount = 0;
                        int bonus = 0;

                        if (int.TryParse(parts[3], out int parsedRequiredCount))
                        {
                            requiredCount = parsedRequiredCount;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid required count format in the file: {loadFilename}");
                            continue;
                        }

                        if (int.TryParse(parts[4], out int parsedBonus))
                        {
                            bonus = parsedBonus;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid bonus format in the file: {loadFilename}");
                            continue;
                        }

                        var checklistGoal = new ChecklistGoal(name, requiredCount, bonus);
                        goals.Add(checklistGoal);
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type in the file: {loadFilename}");
                        break;
                        // Add more cases for other goal types if needed
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
        }
    }

    public int GetTotalPoints()
    {
        int totalPoints = 0;
        foreach (var goal in goals)
        {
            totalPoints += goal.points;
        }
        return totalPoints;
    }
}