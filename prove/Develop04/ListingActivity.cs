using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

class ListingActivity : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private System.Timers.Timer timer;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many as you can in a certain area") { }

    public override void RunActivity()
    {
        DisplayStartingMessage();

        var prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine($"Think about: {prompt}");

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i} seconds...");
            Thread.Sleep(1000);
        }

        // Set up a timer to stop the activity after the specified duration
        timer = new System.Timers.Timer(Duration * 1000);
        timer.Elapsed += (sender, e) => StopActivity();
        timer.AutoReset = false;
        timer.Start();

        var items = new List<string>();
        while (!activityStopped)
        {
            Console.Write("You may begin in: ");
            var item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine($"Ending in {i} seconds...");
            Thread.Sleep(1000);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }
    private bool activityStopped = false;
    private void StopActivity()
    {
        activityStopped = true;
        timer.Stop();
    }
}