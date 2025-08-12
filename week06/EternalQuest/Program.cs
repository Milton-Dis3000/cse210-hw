using System;

// Exceeding Requirements:
// To go beyond the core requirements, I added the following features:
//
// 1. Goal Deletion: The user can now delete a goal from the list.
// 2. Clear Console: The console is cleared after each menu selection to improve user experience.
// 3. Status Display: I added a GetStatusString method to the Goal class. The SimpleGoal overrides this to show different colors in the console for completed and incomplete goals. This enhances the visual feedback for the user.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string userChoice = "";

        while (userChoice != "7")
        {
            Console.Clear();
            goalManager.DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Delete Goal");
            Console.WriteLine("  7. Quit");
            Console.Write("Select an option from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                goalManager.CreateGoal();
            }
            else if (userChoice == "2")
            {
                goalManager.ListGoals();
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (userChoice == "3")
            {
                goalManager.SaveGoals();
            }
            else if (userChoice == "4")
            {
                goalManager.LoadGoals();
            }
            else if (userChoice == "5")
            {
                goalManager.RecordEvent();
            }
            else if (userChoice == "6")
            {
                goalManager.DeleteGoal();
            }
            else if (userChoice == "7")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                Console.WriteLine("\nPress Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}
