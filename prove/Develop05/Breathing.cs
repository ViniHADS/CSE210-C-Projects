using System;
using System.Threading;

public class BreathingActivity : Activity
{
    
    public BreathingActivity(string activityName, string activityDescription, int duration)
        : base(activityName, activityDescription, duration) // Pass duration to base class
    {
    }

    public override void ExecuteActivity()
    {
        Console.Clear();
        DisplayStartMessages();

        // Breathing instructions
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Spinner();
            Console.WriteLine("Breathe out...");
            Spinner();
        }

        DisplayEndMessages();
    }
}
