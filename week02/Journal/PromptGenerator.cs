using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Attribute: A list of prompts
    public List<string> _prompts = new List<string>()
    {
        // At least five different prompts as required by the rubric
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?",
        "What challenge did I overcome today?"
    };

    // Method: Get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, _prompts.Count); // Get a random index
        string randomPrompt = _prompts[index]; // Get the prompt at the random index
        return randomPrompt; // Return the selected prompt
    }
}