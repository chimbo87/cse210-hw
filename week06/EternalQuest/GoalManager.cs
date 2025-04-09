using System;
using System.Collections.Generic;
using System.IO;

// Class to manage all goals and program operations
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record events for.");
            return;
        }

        Console.WriteLine("\nThe goals are:");
        ListGoals();

        Console.Write("\nWhich goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            int pointsEarned = _goals[goalIndex - 1].RecordEvent();
            _score += pointsEarned;

            Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        if (int.TryParse(Console.ReadLine(), out int goalType) && goalType >= 1 && goalType <= 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = null;

            switch (goalType)
            {
                case 1: // Simple Goal
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                case 2: // Eternal Goal
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case 3: // Checklist Goal
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    break;
            }

            if (newGoal != null)
            {
                _goals.Add(newGoal);
                Console.WriteLine("\nGoal created successfully!");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // First line is the score
            outputFile.WriteLine(_score);

            // Then each goal
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear(); // Clear existing goals

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            // First line is the score
            _score = int.Parse(lines[0]);

            // Read each goal
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                
                if (parts.Length == 2)
                {
                    string goalType = parts[0];
                    string[] goalData = parts[1].Split(',');

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            if (goalData.Length >= 4)
                            {
                                _goals.Add(new SimpleGoal(
                                    goalData[0], 
                                    goalData[1], 
                                    int.Parse(goalData[2]), 
                                    bool.Parse(goalData[3])
                                ));
                            }
                            break;
                        case "EternalGoal":
                            if (goalData.Length >= 3)
                            {
                                _goals.Add(new EternalGoal(
                                    goalData[0], 
                                    goalData[1], 
                                    int.Parse(goalData[2])
                                ));
                            }
                            break;
                        case "ChecklistGoal":
                            if (goalData.Length >= 7)
                            {
                                _goals.Add(new ChecklistGoal(
                                    goalData[0], 
                                    goalData[1], 
                                    int.Parse(goalData[2]), 
                                    int.Parse(goalData[4]), 
                                    int.Parse(goalData[5]), 
                                    int.Parse(goalData[6])
                                ));
                            }
                            break;
                    }
                }
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

    public int GetScore()
    {
        return _score;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }
}