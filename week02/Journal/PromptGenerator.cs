using System;


public class PromptGenerator
{

    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "What is something I learned today?",
        "What thing could I do better today?",
        "Who did I interacted with most today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the most delicious food I ate today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return $"{_prompts[i]}";
    }
}