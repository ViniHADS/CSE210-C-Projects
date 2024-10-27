public static class Rewards
{
    public static int Points { get; private set; } = 0;

    public static void RewardUser(bool isComplete, bool isEternalGoal)
    {
        if (isComplete)
        {
            if (isEternalGoal)
            {
                Points += 300;
                Console.WriteLine("You have completed an eternal goal! You earned 300 points.");
            }
            else
            {
                Points += 100;
                Console.WriteLine("You have completed a simple goal! You earned 100 points.");
            }
        }
        else
        {
            Points += 50;
            Console.WriteLine("You did not complete a goal this time. You earned 50 points.");
        }

        Console.WriteLine($"Total Points: {Points}");
    }
}
