using System;

// Eternal goal that can never be completed
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        // Note: This class doesn't need any additional member variables
    }

    public override int RecordEvent()
    {
        // Eternal goals are never complete, just return points
        return GetPoints();
    }

    // Override GetDetailsString to always show unchecked
    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    // Override GetStringRepresentation since we don't care about _isComplete
    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetPoints()}";
    }
}