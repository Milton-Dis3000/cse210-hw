// This class inherits from Activity and contains the specific attributes and
// logic for a running activity.

public class Running : Activity
{
    private double _distance; // In miles

    // Constructor for the Running class. It calls the base class constructor.
    public Running(string date, int minutes, double distance) : base(date, minutes, "Running")
    {
        _distance = distance;
    }

    // Override the GetDistance method to return the stored distance.
    public override double GetDistance()
    {
        return _distance;
    }

    // Override the GetSpeed method to calculate the speed in mph.
    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Override the GetPace method to calculate the pace in min per mile.
    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return GetMinutes() / GetDistance();
    }
}
