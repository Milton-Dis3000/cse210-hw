using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the DisplayWelcome function
        DisplayWelcome();

        // Call PromptUserName and store the returned name
        string userName = PromptUserName();

        // Call PromptUserNumber and store the returned number
        int userNumber = PromptUserNumber();

        // Call SquareNumber, passing the user's number, and store the squared result
        int squaredResult = SquareNumber(userNumber);

        // Call DisplayResult, passing the user's name and the squared number
        DisplayResult(userName, squaredResult);

        // Extra: Call a new function to cube the user's number and display it
        int cubedResult = CubeNumber(userNumber);
        Console.WriteLine($"And, {userName}, the cube of your number is {cubedResult}.");
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to prompt for and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberInput = Console.ReadLine();
        int number = int.Parse(numberInput);
        return number;
    }

    // Function to accept an integer and return its square
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    // Extra Function: To accept an integer and return its cube
    static int CubeNumber(int number)
    {
        int cubedNumber = number * number * number;
        return cubedNumber;
    }

    // Function to accept name and squared number, then display them
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}