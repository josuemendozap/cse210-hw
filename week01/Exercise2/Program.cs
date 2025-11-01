using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade porcentage? ");
        string valueInText = Console.ReadLine();
        int value = int.Parse(valueInText);

        string letter;

        if (value >= 90)
        {
            letter = "A";
        }
        else if (value >= 80)
        {
            letter = "B";
        }
        else if (value >= 70)
        {
            letter = "C";
        }
        else if (value >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (value >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Don't give up, continue studying to pass the class the next time!");
        }
    }
}