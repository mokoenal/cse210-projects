using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        EternalQuestTracker eternalQuestTracker = new EternalQuestTracker();

        while (true)
        {
            Console.WriteLine($"You have {eternalQuestTracker.GetTotalPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(eternalQuestTracker);
                    break;
                case "2":
                    eternalQuestTracker.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter the filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    eternalQuestTracker.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter the filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    eternalQuestTracker.LoadFromFile(loadFilename);
                    break;
                case "5":
                    Console.Write("Enter the goal name to record an event: ");
                    string recordGoalName = Console.ReadLine();
                    eternalQuestTracker.RecordEvent(recordGoalName);

                    // Display points only after recording an event
                    Console.WriteLine($"You have {eternalQuestTracker.GetTotalPoints()} points.");
                    break;
                case "6":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }

    private static void CreateNewGoal(EternalQuestTracker eternalQuestTracker)
    {
        Console.WriteLine("The Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which Type of Goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        if (int.TryParse(Console.ReadLine(), out int goalPoints))
        {
            switch (goalType)
            {
                case "1":
                    eternalQuestTracker.AddGoal(new SimpleGoal(goalName, goalPoints));
                    break;
                case "2":
                    eternalQuestTracker.AddGoal(new EternalGoal(goalName, goalDescription, goalPoints));
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    if (int.TryParse(Console.ReadLine(), out int requiredCount))
                    {
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        if (int.TryParse(Console.ReadLine(), out int bonus))
                        {
                            eternalQuestTracker.AddGoal(new ChecklistGoal(goalName, requiredCount, bonus));
                        }
                        else
                        {
                            Console.WriteLine("Invalid bonus. Please enter a valid integer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid required count. Please enter a valid integer.");
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid points. Please enter a valid integer.");
        }
    }
}