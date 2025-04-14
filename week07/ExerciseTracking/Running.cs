using System;

public class Running : Activity
{
    // Private attribute specific to Running
    private double _distance;

    // Properties
    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    // Constructor
    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    // Override abstract methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / _distance;
    }
}