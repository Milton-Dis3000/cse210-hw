using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    
    // Constructor for loading from a file
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStatusString()
    {
        return _isComplete ? "[x]" : "[ ]";
    }

    public override string GetDetailsString()
    {
        return $"{GetStatusString()} {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{_points},{_isComplete}";
    }
}