using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System;

public static class SaveLoad
{
    public static void Save(string filename)
    {
        string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "SavedFiles");
        Directory.CreateDirectory(directoryPath);
        string filePath = Path.Combine(directoryPath, filename + ".json");

        string json = JsonSerializer.Serialize(GoalManager.Goals); // Salva o GoalManager.Goals
        File.WriteAllText(filePath, json);
        Console.WriteLine("Goals saved successfully.");
    }

    public static void Load(string filename)
    {
        string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "SavedFiles");
        string filePath = Path.Combine(directoryPath, filename + ".json");

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            GoalManager.Goals = JsonSerializer.Deserialize<List<Goal>>(json);
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}