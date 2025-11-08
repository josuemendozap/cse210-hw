using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int answer;

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string answerText = Console.ReadLine();
            answer = int.Parse(answerText);


            if (answer == 1)
            {
                Entry anEntry = new Entry();
                anEntry._date = dateText;
                anEntry._promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine(anEntry._promptText);
                Console.Write("> ");
                anEntry._entryText = Console.ReadLine();

                theJournal.AddEntry(anEntry);
            }

            else if (answer == 2)
            {
                theJournal.DisplayAll();
            }

            else if (answer == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }

            else if (answer == 4)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }

        } while (answer != 5);

    }
}