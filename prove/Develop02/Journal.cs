using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    // List the options of the journal
    public List<Entry> Entries { get; set; } = new List<Entry>();

    // Add new entry in the journal
    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!\n");
    }

    // Show all the entries add in the journal
    public void DisplayAll()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.\n");
        }
        else
        {
            foreach (var entry in Entries)
            {
                entry.Display();
            }
        }
    }

    // Save the journal in archives type .txt and .csv(types I've tried)
   public void SaveToFile(string filename)
{
    // Verify the name of archieve, if have doesn't put extension .csv in the end, if doesn't he add automatically
    if (!filename.Contains('.'))
    {
        filename += ".csv"; 
    }

    using (StreamWriter writer = new StreamWriter(filename))
    {
        writer.WriteLine("Date,Prompt,Response");

        foreach (var entry in Entries)
        {
            writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }
    }
    Console.WriteLine("Journal saved successfully!\n");
}

    // Load the journal
    public void LoadFromFile(string filename)
{
    if (File.Exists(filename))
    {
        // Don't clean the entries.
        string[] lines = File.ReadAllLines(filename);

        foreach (var line in lines.Skip(1)) 
        {
            var parts = line.Split(',');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                Entries.Add(entry); // Add new entries without cleaning the old entries
            }
        }
        Console.WriteLine("Journal loaded successfully!\n");
    }
    else
    {
        Console.WriteLine("File not found.\n");
    }
    }
}
