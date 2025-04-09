using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a goal manager to handle all goal-related operations
        GoalManager goalManager = new GoalManager();
        
        // Flag to control when to exit the program
        bool quit = false;
        
        // Main program loop
        while (!quit)
        {
            // Display current score
            goalManager.DisplayPlayerInfo();
            
            // Display menu options
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            // Get user choice
            string input = Console.ReadLine();
            
            // Process user choice
            switch (input)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    quit = true;
                    Console.WriteLine("Thank you for using the Eternal Quest Program!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

/* 
EXCEEDING REQUIREMENTS:
To exceed the requirements of this assignment, I have added the following features:

1. Level System: The player can level up as they earn points, providing additional motivation.
   Every 1000 points earns a new level, with encouraging messages displayed.

2. Goal Categories: Goals can be organized into categories like "Spiritual", "Physical", 
   "Mental", etc. allowing users to track different areas of personal development.

3. Goal Streaks: For eternal goals, the system tracks consecutive completions and
   provides bonus points for maintaining streaks.

4. Goal Difficulty: Users can set goals with different difficulty levels, which
   affect the points earned.

5. Goal Reminders: The system can show goals that haven't been worked on recently
   to help users stay focused on all their goals.

These features enhance the gamification aspect of the program and provide additional
tools for users to track and be motivated by their progress.
*/