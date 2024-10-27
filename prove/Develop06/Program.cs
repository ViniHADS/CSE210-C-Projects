using System;
namespace EternalQuest
{
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal Tracker!");

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Create Goals");
            Console.WriteLine("2) Delete Goals");
            Console.WriteLine("3) Save Goals");
            Console.WriteLine("4) Load Goals");
            Console.WriteLine("5) Exit Game");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoals();
                    break;
                case "2":
                    DeleteGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void CreateGoals()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1) Simple Goal");
        Console.WriteLine("2) Eternal Goal");
        Console.WriteLine("3) Back to Main Menu");

        string choice = Console.ReadLine();

        if (choice == "3") return;

        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the goal:");
        string description = Console.ReadLine();

        Goal goal = new Goal(name, description);
        GoalManager.AddGoal(goal);
        Console.WriteLine("Goal created successfully!");
    }

    private static void DeleteGoals()
    {
        if (GoalManager.Goals.Count == 0)
        {
            Console.WriteLine("No goals to delete.");
            return;
        }

        Console.WriteLine("Select a goal to delete:");
        for (int i = 0; i < GoalManager.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {GoalManager.Goals[i].Name}");
        }
        Console.WriteLine("0) Back to Main Menu");

        if (int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            if (goalIndex > 0 && goalIndex <= GoalManager.Goals.Count)
            {
                GoalManager.DeleteGoal(goalIndex - 1);
                Console.WriteLine("Goal deleted successfully.");
            }
            else if (goalIndex == 0)
            {
                return; // Volta ao menu principal
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    private static void SaveGoals()
    {
        Console.WriteLine("Enter filename to save:");
        string fileName = Console.ReadLine();
        SaveLoad.Save(fileName);  // Passa o filename como argumento
    }

    private static void LoadGoals()
    {
        Console.WriteLine("Enter filename to load:");
        string fileName = Console.ReadLine();
        SaveLoad.Load(fileName);  // Passa o filename como argumento
    }
}

}
