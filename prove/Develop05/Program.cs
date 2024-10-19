using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");
        
        while (true)
        {
            Console.WriteLine("Please, select one of the activity below to start:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose one ");
            
            string option = Console.ReadLine();

            if (option == "4") break;

            Console.Write("Enter the duration for the activity in seconds: ");
            if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
            {
                Console.WriteLine("Please enter a valid positive number for duration.");
                continue;
            }

            switch (option)
            {
                case "1":
                    var breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.", duration);
                    breathingActivity.ExecuteActivity();
                    break;
                
                case "2":
                    var reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", duration);
                    reflectionActivity.ExecuteActivity();
                    break;

                case "3":
                    var listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);
                    listingActivity.ExecuteActivity();
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
