// Program.cs
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool quit = false;
        while (!quit)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    // Write a new entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.WriteLine("Your response (type on multiple lines, enter 'done' on a new line when finished):");
                    
                    string response = "";
                    string line;
                    while (true)
                    {
                        line = Console.ReadLine();
                        if (line.ToLower() == "done")
                            break;
                        response += line + "\n";
                    }
                    
                    Entry newEntry = new Entry
                    {
                        Date = DateTime.Now.ToShortDateString(),
                        Prompt = prompt,
                        Response = response.Trim()
                    };
                    
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!\n");
                    break;
                
                case "2":
                    // Display the journal
                    journal.DisplayAll();
                    break;
                
                case "3":
                    // Save the journal to a file
                    Console.Write("Enter filename to save journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                
                case "4":
                    // Load the journal from a file
                    Console.Write("Enter filename to load journal: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                
                case "5":
                    // Quit
                    quit = true;
                    break;
                
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n===== Journal App =====");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Quit");
        Console.Write("Select an option (1-5): ");
    }
}