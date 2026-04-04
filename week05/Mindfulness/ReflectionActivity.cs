using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something hard.",
        "Think of a time you helped someone.",
        "Think of a time you were strong."
    };

    private List<string> _questions = new List<string>
    {
        "Why was it meaningful?",
        "How did you feel?",
        "What did you learn?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection", "This activity helps you reflect on your strengths.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.Write($"\n{question} ");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }
}