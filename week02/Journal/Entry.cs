using System;

public class Entry
{
    // Attributes: Date, prompt text, and entry text
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    // Method: Display the entry details
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(); // Add an empty line for better readability between entries
    }
}
