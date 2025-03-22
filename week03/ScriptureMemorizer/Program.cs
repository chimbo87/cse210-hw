// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture with John 3:16
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);

        
        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // string text = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        // Scripture scripture = new Scripture(reference, text);
        
        bool isQuit = false;
        
       
        while (!isQuit && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                isQuit = true;
            }
            else
            {
                // Hide some random words
                scripture.HideRandomWords(3);
            }
        }

        // Show the final state if not quitting early
        if (!isQuit)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("All words have been hidden. Program complete.");
            Console.ReadLine();
        }
        
        /* 
         * STRETCH CHALLENGE EXPLANATION
         * 
         * This program exceeds the core requirements in the following ways:
         * 
         * 1. Enhanced Word Selection Algorithm: The HideRandomWords method in the Scripture class 
         *    specifically targets only visible words, ensuring each word is hidden exactly once 
         *    before the program terminates.
         *    
         * 2. Scripture Library Implementation: The ScriptureLibrary class (in ScriptureLibrary.cs) 
         *    allows for a collection of scriptures rather than just one. It includes methods
         *    to retrieve random scriptures which enhances the memorization experience.
         *    
         * 3. Support for complex reference formats: The Reference class handles both single verse
         *    and verse range formats correctly, improving the usability for different scriptures.
         */
    }
}