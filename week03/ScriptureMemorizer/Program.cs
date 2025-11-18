using System;

// To exceed requirements I added a new Library and class called ScriptureLibrary. It has the prupose of giving us a different scripture to memorize each time that we start running our program.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        ScriptureLibrary library = new ScriptureLibrary();

        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to Hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}