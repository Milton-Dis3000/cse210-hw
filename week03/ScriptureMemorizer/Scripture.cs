using System;
using System.Collections.Generic; // Required for List<T>
using System.Linq; // Required for LINQ methods like Where, Count, ToList

public class Scripture
{
    // Private attributes to store the scripture's reference and its words.
    private Reference _reference;
    private List<Word> _words;
    private Random _random; // To select random words to hide

    // Constructor: Initializes a new Scripture object.
    // It takes a Reference object and the full text of the scripture as a string.
    // It is responsible for parsing the text into individual Word objects.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random(); // Initialize Random instance

        // Split the scripture text into words and create Word objects.
        // This encapsulates the word parsing logic within the Scripture class.
        string[] wordArray = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Hides a specified number of random words that are not already hidden.
    public void HideRandomWords(int numberToHide)
    {
        // Get a list of words that are currently not hidden.
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        // If there are no visible words left, there's nothing more to hide.
        if (visibleWords.Count == 0)
        {
            return;
        }

        // Determine how many words to hide, not exceeding the number of visible words.
        int actualWordsToHide = Math.Min(numberToHide, visibleWords.Count);

        // Hide words randomly from the visible words list.
        for (int i = 0; i < actualWordsToHide; i++)
        {
            int indexToHide = _random.Next(0, visibleWords.Count);
            visibleWords[indexToHide].Hide();
            // Remove the word from the temporary list to avoid hiding it again in the same round.
            visibleWords.RemoveAt(indexToHide);
        }
    }

    // Returns the full display text of the scripture, including the reference
    // and the text with some words replaced by underscores.
    public string GetDisplayText()
    {
        // Get the display text for the reference (e.g., "John 3:16").
        string referenceText = _reference.GetDisplayText();

        // Build the scripture text with hidden words as underscores.
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        // Combine reference and scripture text.
        return $"{referenceText} {scriptureText.Trim()}"; // Trim to remove trailing space
    }

    // Checks if all words in the scripture are completely hidden.
    public bool IsCompletelyHidden()
    {
        // Returns true if there are no words that are not hidden.
        return _words.All(word => word.IsHidden());
    }
}