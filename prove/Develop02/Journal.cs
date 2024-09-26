using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    // Lista de todas as entradas no Journal
    public List<Entry> Entries { get; set; } = new List<Entry>();

    // Adiciona uma nova entrada ao Journal
    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!\n");
    }

    // Exibe todas as entradas
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

    // Salva o Journal em um arquivo
   public void SaveToFile(string filename)
{
    // Verifica se o nome do arquivo contém um ponto para indicar uma extensão
    if (!filename.Contains('.'))
    {
        filename += ".csv"; // Adiciona .csv apenas se não houver um ponto
    }

    using (StreamWriter writer = new StreamWriter(filename))
    {
        // Escreve a linha de cabeçalho no arquivo CSV
        writer.WriteLine("Date,Prompt,Response");

        // Escreve cada entrada no arquivo
        foreach (var entry in Entries)
        {
            writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }
    }
    Console.WriteLine("Journal saved successfully!\n");
}

    // Carrega o Journal de um arquivo
    public void LoadFromFile(string filename)
{
    if (File.Exists(filename))
    {
        // Não limpar as entradas existentes
        string[] lines = File.ReadAllLines(filename);

        foreach (var line in lines.Skip(1)) // Skip(1) para pular a linha de cabeçalho
        {
            var parts = line.Split(',');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                Entries.Add(entry); // Adiciona novas entradas sem limpar as antigas
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
