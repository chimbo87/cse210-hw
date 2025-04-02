// Activity.cs
using System;
using System.Threading;

public class Activity
{
    // Protected member variables (accessible to derived classes)
    protected string _name;
    protected string _description;
    protected int _duration;
    
    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    // Shared methods for all activities
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
    
    public void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string> { "|", "/", "-", "\\" };
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the character
            
            i++;
            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the character
            
         
            if (i >= 10)
            {
                Console.Write("\b \b"); // Erase the second digit
            }
        }
    }
    
    // Method to be overridden by derived classes
    public virtual void Run()
    {
        DisplayStartingMessage();
        
        DisplayEndingMessage();
    }
}