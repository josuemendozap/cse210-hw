using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
          )
    {
    }

    public void Run()
    {
        StartActivity();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            ShowCountdownWithText("Breathe in", 4);
            elapsed += 4;

            if (elapsed >= _duration)
                break;

            ShowCountdownWithText("Breathe out", 6);
            elapsed += 6;
        }

        EndActivity();
    }
}
