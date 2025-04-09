using System;

// Base class for all goals
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    // Getters and setters
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    // Abstract method that each derived class must implement
    public abstract int RecordEvent();

    // Virtual method that can be overridden by derived classes
    public virtual string GetDetailsString()
    {
        string completionStatus = _isComplete ? "[X]" : "[ ]";
        return $"{completionStatus} {_name} ({_description})";
    }

    // Virtual method to get string representation for saving to file
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_name},{_description},{_points},{_isComplete}";
    }
}