using System;
using System.Collections.Generic;

class PromptGenerator
{
    // List of prompts
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Write one miracle that you have seen today.",
        "If you are in a relationship with someone tell your feelings about her(him)."
    };

    // Return a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
