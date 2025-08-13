// This class inherits from Activity and contains the specific attributes and
// logic for a swimming activity.

public class Swimming : Activity
{
    private int _laps;

    // Constructor for the Swimming class. It calls the base class constructor.
    public Swimming(string date, int minutes, int laps) : base(date, minutes, "Swimming")
    {
        _laps = laps;
    }

    // Override the GetDistance method to calculate the distance in miles.
    // Length of a lap is 50 meters.
    public override double GetDistance()
    {
        // Distance (miles) = laps * 50 / 1000 * 0.62
        return (double)_laps * 50 / 1000 * 0.62;
    }

    // Override the GetSpeed method to calculate the speed in mph.
    public override double GetSpeed()
    {
        // Speed = (distance / minutes) * 60
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Override the GetPace method to calculate the pace in min per mile.
    public override double GetPace()
    {
        // Pace = minutes / distance
        return GetMinutes() / GetDistance();
    }
}