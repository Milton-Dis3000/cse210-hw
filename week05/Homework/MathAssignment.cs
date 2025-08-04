// MathAssignment is a derived class that inherits from the Assignment base class.
public class MathAssignment : Assignment
{
    // Private member variables for the MathAssignment specific attributes.
    private string _textbookSection;
    private string _problems;

    // Constructor for MathAssignment. It receives all four parameters
    // and uses the `base` keyword to pass the common ones to the parent constructor.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Set the attributes specific to this class.
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to get the homework list for the math assignment.
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}