using System;

public class Reference
{
    // Private attributes to store the components of the scripture reference.
    // Encapsulation ensures these are accessed only via public methods.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse; // Used for scripture ranges (e.g., Proverbs 3:5-6)

    // Constructor 1: For a single verse scripture (e.g., "John 3:16").
    // Initializes the book, chapter, and a single verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0; // Set to 0 to indicate no end verse
    }

    // Constructor 2: For a scripture range (e.g., "Proverbs 3:5-6").
    // Initializes the book, chapter, and a range of verses.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Returns the formatted string representation of the scripture reference.
    // Handles both single verse and verse range formats.
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            // Format for a single verse: "Book Chapter:Verse"
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Format for a verse range: "Book Chapter:StartVerse-EndVerse"
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}