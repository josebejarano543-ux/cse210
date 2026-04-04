using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who did you help this week?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing", "This activity helps you list positive things.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");

        ShowCountdown(3);

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");
        DisplayEndingMessage();
    }
}