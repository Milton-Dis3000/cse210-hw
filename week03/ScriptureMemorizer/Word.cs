using System;

public class Word
{
    // Private attributes to store the word's text and its hidden state.
    private string _text;
    private bool _isHidden;

    // Constructor: Initializes a new Word object with its text.
    // By default, a new word is not hidden.
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words are visible by default
    }

    // Hides the word by setting its hidden state to true.
    public void Hide()
    {
        _isHidden = true;
    }

    // Shows the word by setting its hidden state to false.
    public void Show()
    {
        _isHidden = false;
    }

    // Returns true if the word is currently hidden, false otherwise.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the display text of the word.
    // If hidden, it returns underscores matching the word's length.
    // If not hidden, it returns the actual word text.
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Create a string of underscores with the same length as the word.
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}