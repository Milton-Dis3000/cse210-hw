// This is the base class for all activities. It contains shared attributes
// and defines the virtual methods that will be overridden by the derived classes.

public abstract class Activity
{
    private string _date;
    private int _minutes;
    private string _activityType;

    // Constructor to initialize the shared attributes
    public Activity(string date, int minutes, string activityType)
    {
        _date = date;
        _minutes = minutes;
        _activityType = activityType;
    }

    // Getters for the private member variables
    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetActivityType()
    {
        return _activityType;
    }

    // Virtual methods for calculations. These will be overridden by derived classes.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // This method is in the base class to provide a consistent way to get the summary
    // for all activities. It uses the virtual methods, which is a key part of polymorphism.
    public virtual string GetSummary()
    {
        // Use string interpolation to format the output string
        return $"{_date} {_activityType} ({_minutes} min): " +
               $"Distance: {GetDistance():F2} miles, " +
               $"Speed: {GetSpeed():F2} mph, " +
               $"Pace: {GetPace():F2} min per mile";
    }
}