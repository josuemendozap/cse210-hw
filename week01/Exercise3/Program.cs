using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicValue = randomGenerator.Next(1, 101);

        int guessValue;

        do
        {
            Console.Write("What is your guess? ");
            string valueInText2 = Console.ReadLine();
            guessValue = int.Parse(valueInText2);

            if (guessValue > magicValue)
            {
                Console.WriteLine("Lower");
            }
            else if (guessValue < magicValue)
            {
                Console.WriteLine("Higher");
            }
        } while (guessValue != magicValue);

        Console.WriteLine("You guessed it!");
    }
}