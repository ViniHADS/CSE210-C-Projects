using System;

class Program
{
    static void Main()
    {
        //  Console.Write("Enter the magic number: ");
        //  int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 10);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}