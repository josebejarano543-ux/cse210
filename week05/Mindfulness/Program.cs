// Creativity: I exceeded requirements by organizing the program using inheritance,
// creating reusable methods like spinner and countdown, and building a menu system
// that allows the user to run multiple activities in one session.

using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nGoodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid option.");
            }

            if (choice != "4")
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}