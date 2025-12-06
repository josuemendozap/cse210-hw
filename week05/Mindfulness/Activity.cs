using System;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin:");
        ShowCountdownWithText("Starting in", 5);
        Console.WriteLine();
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowCountdownWithText("Finishing in", 5);
        Console.WriteLine();
    }

    protected void ShowCountdownWithText(string text, int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\r{text}... {i}   ");
            Thread.Sleep(1000);
        }

        Console.Write("\r" + new string(' ', 40) + "\r");

    }
}

