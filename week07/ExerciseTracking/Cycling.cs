using System;

public class Cycling : Activity
{
    // Private attribute specific to Cycling
    private double _speed;

    // Properties
    public double Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    // Constructor
    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    // Override abstract methods
    public override double GetDistance()
    {
        return (_speed * LengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}