using System;

class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    // Construtor para inicializar uma nova entrada
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Exibe a entrada formatada
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}\nResponse: {_entryText}\n");
    }
}
