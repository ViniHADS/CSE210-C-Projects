using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa a biblioteca de escrituras
        ScriptureLibrary library = new ScriptureLibrary();

        // Adiciona escrituras à biblioteca
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

        // Obtém uma escritura aleatória da biblioteca
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            // Limpa o console e exibe a escritura atual
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedScripture());

            // Verifica se todas as palavras estão ocultas, se sim, encerra o programa
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nTodas as palavras foram ocultas! Programa encerrado.");
                break;
            }

            // Aguarda entrada do usuário
            Console.WriteLine("\nPressione 'Enter' para ocultar palavras ou digite 'quit' para sair.");
            string input = Console.ReadLine();

            // Se o usuário digitar 'quit', encerra o programa
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Se o usuário pressionar 'Enter' sem digitar 'quit', oculta palavras
            scripture.HideRandomWords();
        }
    }
}
