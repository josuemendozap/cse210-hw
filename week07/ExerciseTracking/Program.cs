using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("08 Dic 2025", 30, 3.0));
        activities.Add(new Cycling("09 Dic 2025", 45, 12.0));
        activities.Add(new Swimming("10 Dic 2025", 40, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}