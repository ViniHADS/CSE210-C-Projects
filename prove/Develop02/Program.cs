using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Add new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            var option = Console.ReadLine();

            if (option == "1")
            {
                // Get a random prompt and ask the user for a response
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                // Create a new Entry
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                Entry newEntry = new Entry(date, prompt, response);
                
                // Add the entry to the journal
                myJournal.AddEntry(newEntry);
            }
            else if (option == "2")
            {
                myJournal.DisplayAll();
            }
            else if (option == "3")
            {
                Console.WriteLine("Enter filename to save the journal:");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (option == "4")
            {
                Console.WriteLine("Enter filename to load the journal:");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (option == "5")
            {
                break;
            }
        }
    }
}
