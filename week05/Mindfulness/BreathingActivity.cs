using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
: base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}