using System;

class Program
{
    static void Main(string[] args)
    {
       List <double> numbers = new List <double>();
       Console.WriteLine("Enter a list of numbers, type 0 when finished.");

       while(true)
       {
        Console.Write("Enter number: ");
        double input = Convert.ToDouble(Console.ReadLine());

        if (input == 0)
        break;

        numbers.Add(input);

       }

        if (numbers.Count > 0)

        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
        }
        double average = sum / numbers.Count;
        double max = FindMax(numbers);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        }

        else
        
        {
            Console.WriteLine("No numbers entered.");
        }
    }

    static double FindMax(List<double> numbers)
    {
        double max = double.MinValue;
        foreach (double number in numbers)
        {
            if (number > max)
                max = number;
        }
        return max;
    }
}







