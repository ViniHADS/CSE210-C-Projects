using System;

class Program
{
    static void Main(string[] args)
    {
        // Initializes the script library
        ScriptureLibrary library = new ScriptureLibrary();

        // Add scriptures to the library
        library.AddScripture(new Scripture("Proverbs", 3, 5, 6,
            "Trust in the Lord with all your heart and lean not on your own understanding; " +
            "in all your ways submit to him, and he will make your paths straight."));

        library.AddScripture(new Scripture("James", 1, 5, 6,
            "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, " +
            "and upbraideth not; and it shall be given him; But let him ask in faith, nothing wavering." +
            "For he that wavereth is like a wave of the sea driven with the wind and tossed."));

        library.AddScripture(new Scripture("3 Nephi", 5, 13,
            "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare, " +
            "his word among his people, that they might have everlasting life."));

        // Get a random deed from the library
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            // Clears the console and displays the current deed
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedScripture());

            // Checks if all words are hidden, if so, closes the program
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll the words have been hidden! Program closed.");
                break;
            }

            // Waiting for user input
            Console.WriteLine("\nPress 'Enter' to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            // If the user types 'quit', it terminates the program
            if (input.ToLower() == "quit")
            {
                break;
            }

            // If the user presses 'Enter' without typing 'quit', it hides words
            scripture.HideRandomWords();
        }
    }
}
