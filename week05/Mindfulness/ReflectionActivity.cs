using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something really difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you apply this experience in the future?"
    };

    private int _promptIndex = 0;
    private int _questionIndex = 0;

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity helps you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
          )
    {
        Shuffle(_prompts);
        Shuffle(_questions);
    }

    public void Run()
    {
        StartActivity();

        string prompt = _prompts[_promptIndex];
        _promptIndex++;


        Console.WriteLine($"\nConsider the following prompt:\n{prompt}");

        Console.WriteLine("\nPress ENTER when you are ready to continue...");
        Console.ReadLine();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            if (_questionIndex >= _questions.Count)
            {
                Shuffle(_questions);
                _questionIndex = 0;
            }

            string question = _questions[_questionIndex];
            _questionIndex++;

            Console.WriteLine($"\n{question}");
            ShowCountdownWithText("Reflecting", 10);
            elapsed += 10;
        }

        EndActivity();
    }

    private void Shuffle(List<string> list)
    {
        Random rand = new Random();

        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);

            string temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
