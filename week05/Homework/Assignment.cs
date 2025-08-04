// The base class for all assignments.
public class Assignment
{
    // Private member variables for the common attributes.
    private string _studentName;
    private string _topic;

    // A constructor to initialize the common attributes.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // A public getter for the student's name, which is needed by derived classes.
    public string GetStudentName()
    {
        return _studentName;
    }

    // A method to return a summary of the assignment.
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}