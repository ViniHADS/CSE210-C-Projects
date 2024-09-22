using System;

class Program
{
    static void Main(string[] args)
    {
Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        // Determining the value of each letter.
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Here I am determining how the + and - signs work
        if (letter != "F") // Signs don't apply to F
        {
            int lastDigit = percent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            // If the last number is between numbers 3 and 6, no sign applies.
        }
         // Giving the answer to the user.
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Approval and disapproval message.
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you was approved at course.");
        }
        else
        {
            Console.WriteLine("Try little harder in the next time, but for now you didn't passed.");
        }
    }
}