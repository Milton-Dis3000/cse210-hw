using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);

        string letter = ""; // Variable to store the letter grade

        // Core Requirement: Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge: Add '+' or '-' to the letter grade
        string sign = "";
        // Only apply sign for grades A, B, C, D
        if (gradePercentage % 10 >= 7 && letter != "F") // Last digit >= 7 for '+'
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3 && letter != "F") // Last digit < 3 for '-'
        {
            sign = "-";
        }

        // Stretch Challenge: Handle special cases for A+, F+, F-
        if (letter == "A" && sign == "+")
        {
            // There is no A+, just A. So, remove the '+'
            sign = "";
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            // There are no F+ or F- grades, just F. So, remove the sign.
            sign = "";
        }
        
        // Display the final letter grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Core Requirement: Determine if the user passed or not
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, you can do better next time!");
        }
    }
}