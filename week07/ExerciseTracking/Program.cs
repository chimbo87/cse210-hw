using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create one of each activity type
        Running running = new Running(
            date: new DateTime(2022, 11, 3),
            lengthInMinutes: 30,
            distance: 3.0);

        Cycling cycling = new Cycling(
            date: new DateTime(2022, 11, 4),
            lengthInMinutes: 45,
            speed: 15.0);

        Swimming swimming = new Swimming(
            date: new DateTime(2022, 11, 5),
            lengthInMinutes: 60,
            laps: 20);

        // Create a list to store all activities
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Display summary for each activity
        Console.WriteLine("Exercise Tracking:");
        Console.WriteLine("=================");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}