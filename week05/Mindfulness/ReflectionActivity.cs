// ReflectionActivity.cs
using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;
    
    public ReflectionActivity() : base("Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _random = new Random();
        
        // Initialize prompts
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        
        // Initialize questions
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    
    public override void Run()
    {
        DisplayStartingMessage();
        
        // Display a random prompt
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        // Display random questions until time is up
        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.Write($"> {question} ");
            ShowSpinner(10);
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}