using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:
        // The HideRandomWords method in the Scripture class has been enhanced
        // to only select and hide words that are not already hidden.
        // This provides a more effective memorization experience as the user
        // is always challenged with new words to hide.

        // Define the scripture reference.
        // You can choose between a single verse or a verse range.
        Reference reference = new Reference("John", 3, 16);
        // Example for a verse range: Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Define the scripture text.
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        // Example for Proverbs 3:5-6: string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        // Create a Scripture object with the reference and text.
        Scripture scripture = new Scripture(reference, scriptureText);

        string userInput = "";

        // Main program loop: continues until user quits or scripture is fully hidden.
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            // Clear the console screen before each display.
            Console.Clear();

            // Display the scripture (with some words hidden).
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(); // Add a blank line for readability

            // Prompt the user for input.
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            // If user presses Enter, hide a few more random words.
            if (userInput.ToLower() != "quit")
            {
                // Hide 3 random words in each iteration. You can adjust this number.
                scripture.HideRandomWords(3);
            }
        }

        // Final clear and display when the loop ends (either by quit or fully hidden).
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended. Goodbye!");
    }
}