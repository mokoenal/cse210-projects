using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a grade percentage? ");
        string answerFromUser= Console.ReadLine();
        int percent = int.Parse(answerFromUser);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60) 
       {
            letter = "D";
       }
        else 
       {
            letter = "F";
       }
       Console.WriteLine($"Your grade is: {letter}");
        if (percent >= 70)
       {
        Console.WriteLine("Congratulation, you have Passed!");
       }
        else
       {
        Console.WriteLine("Keep trying, you will make it next time!");
       }
    }
}