using System;

namespace EternalQuest
{
    class DeleteGoals
{
    public static void Delete()
    {
        if (GoalManager.Goals.Count == 0)
        {
            Console.WriteLine("No goals to delete.");
            return;
        }

        Console.WriteLine("\nGoals List:");
        for (int i = 0; i < GoalManager.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalManager.Goals[i].Name} - {GoalManager.Goals[i].Description}");
        }

        Console.Write("\nEnter the number of the goal you want to delete (or 0 to cancel): ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < GoalManager.Goals.Count)
        {
            Console.WriteLine($"Deleting goal: {GoalManager.Goals[choice].Name}");
            GoalManager.Goals.RemoveAt(choice);
        }
        else if (choice == -1)
        {
            Console.WriteLine("Returning to Main Menu...");
        }
        else
        {
            Console.WriteLine("Invalid option. Returning to Main Menu...");
        }
    }
}

}
