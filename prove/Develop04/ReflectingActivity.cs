using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

class ReflectionActivity : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private System.Timers.Timer timer;

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times when you've shown strength and resilience") { }

    public override void RunActivity()
    {
        DisplayStartingMessage();

        var prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);

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

        foreach (var question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000);
        }

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine($"Ending in {i} seconds...");
            Thread.Sleep(1000);
        }

        DisplayEndingMessage();
    }
    private bool activityStopped = false;

    private void StopActivity()
    {
        activityStopped = true;
        timer.Stop();
    }
}
