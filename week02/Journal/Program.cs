using System;
using System.Collections.Generic;

// Main class to run the Journal Program.
class Program
{
    static void Main(string[] args)
    {
        
        // Create an instance of the Journal.
        Journal myJournal = new Journal();
        
        // A list of prompts for the user.
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "What am I grateful for today?"
        };

        Console.WriteLine("Welcome to the Journal Program!");
        string userChoice = "";

        // Main menu loop. Continues until the user chooses to quit.
        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Load the Journal from a File");
            Console.WriteLine("4. Save the Journal to a File");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            Console.WriteLine(); // Add a blank line for spacing.

            switch (userChoice)
            {
                case "1": // Write a New Entry
                    Random randomGenerator = new Random();
                    int index = randomGenerator.Next(prompts.Count);
                    string randomPrompt = prompts[index];
                    
                    Console.WriteLine(randomPrompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    string dateText = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry
                    {
                        Date = dateText,
                        PromptText = randomPrompt,
                        EntryText = response
                    };
                    
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry recorded.");
                    break;
                case "2": // Display the Journal
                    myJournal.DisplayAll();
                    break;
                case "3": // Load the Journal
                    Console.Write("What is the filename to load? ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;
                case "4": // Save the Journal
                    Console.Write("What is the filename to save? ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;
                case "5": // Quit
                    Console.WriteLine("Goodbye!");
                    break;
                default: // Invalid Choice
                    Console.WriteLine("Sorry, that's not a valid option. Please try again.");
                    break;
            }
            Console.WriteLine(); // Add a blank line after an action.
        }
    }
}