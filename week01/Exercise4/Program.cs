using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int newNumber;
        int sum = 0;
        int i;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string numberInText = Console.ReadLine();
            newNumber = int.Parse(numberInText);

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while (newNumber != 0);

        for (i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        float average = ((float)sum) / i;

        int largestNumber = 0;

        foreach (int number in numbers)
        {
            if (largestNumber < number)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}