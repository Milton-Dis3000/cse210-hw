using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Extra: Ask the user for their age
        Console.Write("What is your age? ");
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput);

        // Display the name in the format "Your name is last-name, first-name last-name."
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        // Extra: Display a personalized message including age
        Console.WriteLine($"Nice to meet you, {firstName}! You are {age} years old.");
    }
}