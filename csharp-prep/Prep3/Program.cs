using System;

class Program
{
    static void Main(string[] args)


    {   //Generate a random magic number between 1 to 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        
        int userGuesse;

        //part One & two
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        //Ask the user to guesse the number & add a loop that keeps looping until they guesse it right

        while(true)
        {
        
        Console.Write("What is your guesse? ");
        userGuesse = int.Parse(Console.ReadLine());

        //check if the user needs to guesse higher or lower or if they guessed it corrently
        if (userGuesse < magicNumber)
    
        {
            Console.WriteLine("Higher");
        }
        else if (userGuesse > magicNumber)

        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("You guessed it!");
            break;//Exit the loop when they guesse it correnty
        }
        
        }


    }
    
}
