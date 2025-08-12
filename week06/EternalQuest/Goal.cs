using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    
    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetStatusString()
    {
        return "[ ]"; // Default status for incomplete goals
    }

    public abstract void RecordEvent();
    
    public virtual string GetDetailsString()
    {
        return $"{GetStatusString()} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
