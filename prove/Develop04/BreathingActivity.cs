using System;
using System.Threading;
using System.Timers;

class BreathingActivity : Activity
{
    private System.Timers.Timer timer;

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through deep breathing") { }

    public override void RunActivity()
    {
        DisplayStartingMessage();

        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i} seconds...");
            Thread.Sleep(1000);
        }

        // Set up a timer to stop the activity after the specified duration
        timer = new System.Timers.Timer(Duration * 1000);
        timer.Elapsed += (sender, e) => StopActivity();
        timer.AutoReset = false;
        timer.Start();

        while (!activityStopped)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);
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