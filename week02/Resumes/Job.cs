// Job.cs
using System;

public class Job
{
    // Member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Display method
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}