using System;

public class Swimming : Activity
{
    // Private attribute specific to Swimming
    private int _laps;

    // Properties
    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    // Constructor
    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    // Override abstract methods
    public override double GetDistance()
    {
        // Distance in miles: laps * 50 / 1000 * 0.62
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }
}