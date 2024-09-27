using System;

class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Show the entry
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}\nResponse: {_entryText}\n");
    }
}
