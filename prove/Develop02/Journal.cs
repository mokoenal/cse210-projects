using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries { get; }
    
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
        DateTime currentDate = DateTime.Now;
        string date = currentDate.ToString("yyyy-MM-dd");
        Prompt promptGenerator = new Prompt();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Enter your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournalToFile(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
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
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length; i += 4)
        {
            string date = lines[i].Substring(6).Trim();
            string prompt = lines[i + 1].Substring(8).Trim();
            string response = lines[i + 2].Substring(10).Trim();
            _entries.Add(new Entry(date, prompt, response));
        }
        Console.WriteLine("Journal loaded from file.");
    }
}