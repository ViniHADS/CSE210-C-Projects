using System;

public class ChecklistGoals
{
    public static void ShowChecklist()
    {
        GoalManager.DisplayGoals();
        
        Console.WriteLine("Please enter the number of the goal you want to mark as completed, or 0 to return:");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= GoalManager.Goals.Count)
        {
            var goal = GoalManager.Goals[goalIndex - 1];
            goal.IsCompleted = true;

            // Verifica se é uma goal eterna ou simples
            bool isEternalGoal = goal.Description.Contains("eternal", StringComparison.OrdinalIgnoreCase);
            Rewards.RewardUser(true, isEternalGoal); // Chama Rewards
            Console.WriteLine($"Goal '{goal.Name}' marked as completed!");
        }
        else if (goalIndex == 0)
        {
            Console.WriteLine("Returning to main menu...");
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
}
