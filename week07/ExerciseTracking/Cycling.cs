// This class inherits from Activity and contains the specific attributes and
// logic for a cycling activity.

public class Cycling : Activity
{
    private double _speed; // In mph

    // Constructor for the Cycling class. It calls the base class constructor.
    public Cycling(string date, int minutes, double speed) : base(date, minutes, "Cycling")
    {
        _speed = speed;
    }

    // Override the GetDistance method to calculate the distance in miles.
    public override double GetDistance()
    {
        // Distance = (speed * minutes) / 60
        return (_speed * GetMinutes()) / 60;
    }

    // Override the GetSpeed method to return the stored speed.
    public override double GetSpeed()
    {
        return _speed;
    }

    // Override the GetPace method to calculate the pace in min per mile.
    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60 / _speed;
    }
}
