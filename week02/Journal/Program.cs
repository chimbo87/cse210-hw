// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        bool running = true;
        
        while (running)
        {
            // Display menu
            Console.WriteLine("\nJournal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    // Write a new entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                    
                    journal.AddEntry(newEntry);
                    break;
                
                case "2":
                    // Display journal
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayAll();
                    break;
                
                case "3":
                    // Save to file
                    Console.Write("Enter filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved successfully!");
                    break;
                
                case "4":
                    // Load from file
                    Console.Write("Enter filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded successfully!");
                    break;
                
                case "5":
                    // Exit
                    running = false;
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        
        Console.WriteLine("Thank you for using the Journal Program!");
    }
}