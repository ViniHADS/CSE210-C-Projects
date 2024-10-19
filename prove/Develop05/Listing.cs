using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _usedPrompts = new List<string>();

    public ListingActivity(string activityName, string activityDescription, int duration)
        : base(activityName, activityDescription, duration)
    {
    }

    public override void ExecuteActivity()
    {
        Console.Clear();
        DisplayStartMessages();

        Random rand = new Random();

        if (_usedPrompts.Count >= _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;
        do
        {
            prompt = _prompts[rand.Next(_prompts.Count)];
        } while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        Console.WriteLine($"Prompt: {prompt}");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item (or type 'done' to finish): ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;

            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndMessages();
    }
}
