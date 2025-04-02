// ListingActivity.cs
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random;
    
    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _random = new Random();
        
        // Initialize prompts
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    
    public override void Run()
    {
        DisplayStartingMessage();
        
        // Display a random prompt
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        // Count the number of items
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        
        Console.WriteLine($"You listed {items.Count} items!");
        
        DisplayEndingMessage();
    }
}