using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // I have exceeded the core requirements by adding a feature that tracks
        // how many times the user has completed each mindfulness activity.
        // When the user quits the program, it displays a summary of the sessions
        // they have completed. This provides a simple way to track usage
        // without adding complex logging or file management.

        string choice = "";
        Dictionary<string, int> activityCount = new Dictionary<string, int>
        {
            {"Breathing", 0},
            {"Reflecting", 0},
            {"Listing", 0}
        };

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    activityCount["Breathing"]++;
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    activityCount["Reflecting"]++;
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    activityCount["Listing"]++;
                    break;
                case "4":
                    // The program will exit the loop.
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Thank you for participating! Here is a summary of your activities:");
        Console.WriteLine($"  - Breathing Activity: {activityCount["Breathing"]} sessions");
        Console.WriteLine($"  - Reflecting Activity: {activityCount["Reflecting"]} sessions");
        Console.WriteLine($"  - Listing Activity: {activityCount["Listing"]} sessions");
        Console.WriteLine();
    }
}
