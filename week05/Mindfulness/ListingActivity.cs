using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
          )
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many you can to the following prompt:\n --- {prompt} --- ");

        ShowCountdownWithText("Starting", 5);

        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        EndActivity();
    }
}
