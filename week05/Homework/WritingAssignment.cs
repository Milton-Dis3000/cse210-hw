// WritingAssignment is a derived class that inherits from the Assignment base class.
public class WritingAssignment : Assignment
{
    // Private member variable for the WritingAssignment specific attribute.
    private string _title;

    // Constructor for WritingAssignment. It receives all three parameters
    // and uses the `base` keyword to pass the common ones to the parent constructor.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // Set the attribute specific to this class.
        _title = title;
    }

    // Method to get the writing information for the assignment.
    public string GetWritingInformation()
    {
        // Get the student's name from the base class using the public getter method.
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}
