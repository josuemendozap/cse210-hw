using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
        }

        Console.WriteLine("\nThank you for using the program!");
    }
}