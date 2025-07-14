using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes"; // Variable to control the outer game loop

        // Stretch Challenge: Loop back and play the whole game again
        while (playAgain == "yes")
        {
            // Core Requirement: Generate a random number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1; // Initialize guess to ensure the inner loop runs
            int guessCount = 0; // Stretch Challenge: Keep track of how many guesses

            // Core Requirement: Loop as long as the guess does not match the magic number.
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                guessCount++; // Increment guess count with each attempt

                if (guess > magicNumber) // If the guess is higher than the magic number
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber) // If the guess is lower than the magic number (CORREGIDO AQUÍ)
                {
                    Console.WriteLine("Higher");
                }
                // The "You guessed it!" message is printed after the loop
            }

            Console.WriteLine("You guessed it!");
            // Stretch Challenge: Inform the user of how many guesses they made
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Stretch Challenge: Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower(); // Convert to lowercase for easier comparison
        }

        Console.WriteLine("Thanks for playing!"); // Message after user decides not to play again
    }
}