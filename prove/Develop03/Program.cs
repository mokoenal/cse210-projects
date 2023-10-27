using System;
using System.Collections.Generic;

class Program
{
    private List<Scripture> _scriptures;

    public Program()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new ScriptureReference("John 3:16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new ScriptureReference("Matthew 5:8-9"), "Blessed are the pure in heart: for they shall see God. Blessed are the peacemakers: for they shall be called the children of God."),
            new Scripture(new ScriptureReference("Proverbs 31:10"), "Who can find a virtuous woman? for her price is far above rubies."),
            new Scripture(new ScriptureReference("1 Corinthians 3:16-17"), "Know ye not that ye are the temple of God, and that the Spirit of God dwelleth in you. If any man defile the temple of God, him shall God destroy, for the temple of God is Holy, which temple ye are.")
        };
    }

    public void Run()
    {
        foreach (var scripture in _scriptures)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture);

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words are hidden. Press Enter to continue with the next scripture or type 'quit' to exit.");
                    string userInput = Console.ReadLine().Trim();

                    if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                        return;

                    // Pressing Enter will continue to the next scripture.
                    if (string.IsNullOrWhiteSpace(userInput))
                        break;
                }
                else
                {
                    Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                    string userInput = Console.ReadLine().Trim();

                    if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                        return;

                    // Pressing Enter will hide more words.
                    if (string.IsNullOrWhiteSpace(userInput))
                        scripture.HideRandomWords(2); // You can change the number of words to hide at a time.
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}