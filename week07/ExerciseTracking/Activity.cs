using System;

public abstract class Activity
{
    // Private attributes
    private DateTime _date;
    private int _lengthInMinutes;

    // Properties
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int LengthInMinutes
    {
        get { return _lengthInMinutes; }
        set { _lengthInMinutes = value; }
    }

    // Constructor
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method that can be overridden if needed
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_lengthInMinutes} min) - " +
               $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}