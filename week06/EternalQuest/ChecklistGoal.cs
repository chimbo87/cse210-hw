using System;

// Checklist goal that must be completed a specific number of times
public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
    }

    // Constructor for loading from file
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) 
        : base(name, description, points)
    {
        _target = target;
        _amountCompleted = amountCompleted;
        _bonus = bonus;
        _isComplete = _amountCompleted >= _target;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        
        if (_amountCompleted == _target)
        {
            _isComplete = true;
            return GetPoints() + _bonus; // Return points plus bonus
        }
        
        return GetPoints();
    }

    // Override GetDetailsString to show progress
    public override string GetDetailsString()
    {
        string completionStatus = _isComplete ? "[X]" : "[ ]";
        return $"{completionStatus} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    // Override GetStringRepresentation to include checklist-specific data
    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetPoints()},{_isComplete},{_target},{_bonus},{_amountCompleted}";
    }
}