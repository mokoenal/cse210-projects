using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> Entries { get; set; }
    private List<string> Prompts { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
        Prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How can I better serve others?",
            "Was I kind to others today?",
        };
    }

   public void WriteNewEntry()
{
    DateTime currentDate = DateTime.Now; // Capture the current date and time
    string date = currentDate.ToString("yyyy-MM-dd"); // Format the date as YYYY-MM-DD
    string prompt = GetRandomPrompt();
    Console.WriteLine($"Prompt: {prompt}");
    Console.WriteLine("Enter your response: ");
    string response = Console.ReadLine();

    Entry entry = new Entry(date, prompt, response);
    Entries.Add(entry);
    Console.WriteLine("Entry added successfully!");
}

    public void DisplayJournal()
    {
        foreach (var entry in Entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournalToFile(string filename)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                file.WriteLine($"Date: {entry.Date}");
                file.WriteLine($"Prompt: {entry.Prompt}");
                file.WriteLine($"Response: {entry.Response}");
                file.WriteLine();
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    public void LoadJournalFromFile(string filename)
    {
        Entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length; i += 4)
        {
            string date = lines[i].Substring(6).Trim();
            string prompt = lines[i + 1].Substring(8).Trim();
            string response = lines[i + 2].Substring(10).Trim();
            Entries.Add(new Entry(date, prompt, response));
        }
        Console.WriteLine("Journal loaded from file.");
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(Prompts.Count);
        return Prompts[index];
    }
}
