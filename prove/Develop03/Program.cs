using System;

public class Program
{
    public static void Main(string[] args)
    {
        Reference reference1 = new Reference("John 3:16");
        string text1 = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture1 = new Scripture(reference1, text1);

        Reference reference2 = new Reference("Matthew 5:8");
        string text2 = "Blessed are the pure in heart: for they shall see God.";
        Scripture scripture2 = new Scripture(reference2, text2);

        Reference reference3 = new Reference("Proverbs 31:10");
        string text3 = "Who can find a virtuous woman? for her price is far above rubies.";
        Scripture scripture3 = new Scripture(reference3, text3);

        Reference reference4 = new Reference("1 Corinthians 3:16-17");
        string text4 = "Know ye not that ye are the temple of God, and that the Spirit of God dwelleth in you. " +
                        "If any man defile the temple of God, him shall God destroy, for the temple of God is Holy, which temple ye are.";
        Scripture scripture4 = new Scripture(reference4, text4);

        Scripture[] scriptures = { scripture1, scripture2, scripture3, scripture4 };

        foreach (Scripture scripture in scriptures)
        {
            Console.Clear(); // Clear the console before displaying the scripture.
            scripture.Display();

            while (true)
            {
                Console.WriteLine("Press enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit" || scripture.AllWordsHidden())
                    break;

                scripture.HideRandomWord();
            }
        }
    }
}