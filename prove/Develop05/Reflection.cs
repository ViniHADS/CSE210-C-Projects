using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private readonly List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> _questions = new List<string>
    {
        "What surprised you the most about this experience?",
        "What did you expect going into it, and how did reality compare?",
        "What part of the experience challenged you the most?",
        "What do you think would have happened if you hadn't gone through this experience?",
        "What advice would you give to someone else going through a similar experience?"
        // The program will start repeating the questions after completing the cycle of displaying all the questions.
    };

    private List<string> _usedQuestions = new List<string>();

    public ReflectionActivity(string activityName, string activityDescription, int duration)
        : base(activityName, activityDescription, duration)
    {
    }

    public override void ExecuteActivity()
    {
        Console.Clear();
        DisplayStartMessages();

        Random rand = new Random();
        string prompt = _reflectionPrompts[rand.Next(_reflectionPrompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        
        while (DateTime.Now < endTime)
        {
            if (_usedQuestions.Count >= _questions.Count)
            {
                _usedQuestions.Clear();
            }

            string question;
            do
            {
                question = _questions[rand.Next(_questions.Count)];
            } while (_usedQuestions.Contains(question));

            _usedQuestions.Add(question);
            Console.WriteLine(question);
            Spinner(); // Display spinner during pause
        }

        DisplayEndMessages();
    }

private void Spinner()
{
    Console.Write("Thinking");
    for (int i = 0; i < 3; i++)
    {
        Console.Write(".");
        Thread.Sleep(1000);
    }
    Console.WriteLine();
    
    }
}
