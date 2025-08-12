using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Constructor for loading from a file
    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points += _bonus;
        }
    }

    public override string GetDetailsString()
    {
        return $"{GetStatusString()} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStatusString()
    {
        return _amountCompleted == _target ? "[x]" : "[ ]";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}