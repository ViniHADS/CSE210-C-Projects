using System;
using System.Collections.Generic;

namespace EternalQuest
{
public static class GoalManager
{
    public static List<Goal> Goals { get; set; } = new List<Goal>();

    public static void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public static void DeleteGoal(int index)
    {
        if (index >= 0 && index < Goals.Count)
        {
            Goals.RemoveAt(index);
        }
    }

    public static void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            var goal = Goals[i];
            Console.WriteLine($"{i + 1}. {goal.Name} - {goal.Description} (Completed: {goal.IsCompleted})");
        }
    }
}

}
