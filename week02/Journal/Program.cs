using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Journal program to record daily entries with prompts.
        // Demonstrates abstraction using Journal, Entry, and PromptGenerator classes.
        //
        // Exceeding Requirements:
        // - Added more prompts to PromptGenerator.
        // - Basic error handling for file loading (file not found).
        // - Used a specific separator (~|~) for saving/loading to avoid conflicts.
        // - Added an option to display the total number of entries.

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string inputChoice = "";
        int choice = 0;

        // Main menu loop
        while (choice != 6) // 6 is the 'Quit' option
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Count Entries"); // New option
            Console.WriteLine("6. Quit"); // Quit option
            Console.Write("What would you like to do? ");

            inputChoice = Console.ReadLine();

            if (int.TryParse(inputChoice, out choice))
            {
                switch (choice)
                {
                    case 1: // Write a new entry
                        string randomPrompt = promptGenerator.GetRandomPrompt();
                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();

                        Console.WriteLine($"Prompt: {randomPrompt}");
                        Console.Write("Your response: ");
                        string userEntryText = Console.ReadLine();

                        Entry newEntry = new Entry();
                        newEntry._date = dateText;
                        newEntry._promptText = randomPrompt;
                        newEntry._entryText = userEntryText;

                        myJournal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully!");
                        break;

                    case 2: // Display the journal
                        myJournal.DisplayAll();
                        break;

                    case 3: // Load the journal
                        Console.Write("Enter filename to load from: ");
                        string loadFilename = Console.ReadLine();
                        myJournal.LoadFromFile(loadFilename);
                        break;

                    case 4: // Save the journal
                        Console.Write("Enter filename to save to: ");
                        string saveFilename = Console.ReadLine();
                        myJournal.SaveToFile(saveFilename);
                        break;

                    case 5: // Count Entries
                        int count = myJournal.GetEntryCount();
                        Console.WriteLine($"Total entries in your journal: {count}");
                        break;

                    case 6: // Quit
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    default: // Invalid choice
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
            else // Invalid input (not a number)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine(); // Blank line for readability
        }
    }
}