using System;

public abstract class Activity
{
    // Member variables
    private string _activityName;
    private string _activityDescription;
    public int Duration { get; private set; } // Duration property

    // Constructor
    protected Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        Duration = duration; // Set the duration
    }

    // Display start messages
    protected void DisplayStartMessages()
    {
        Console.WriteLine($"Starting {_activityName}");
        Console.WriteLine(_activityDescription);
        Console.WriteLine($"Duration: {Duration} seconds.");
        Console.WriteLine("Get ready to begin...");
        Spinner(); // Optional spinner during the preparation
    }

    // Display end messages
    protected void DisplayEndMessages()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"Activity: {_activityName}");
        Console.WriteLine($"Duration: {Duration} seconds.");
        Spinner(); // Optional spinner during completion
    }

    // Abstract method to execute activity
    public abstract void ExecuteActivity();

    // Spinner method for visual feedback
    protected void Spinner()
    {
        Console.Write("Loading");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine();
    }
}
