using System;

// Represents a single journal entry.
public class JournalEntry
{
  
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    // A method to display the entry in a formatted way.
    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine(EntryText);
        Console.WriteLine(); 
    }
}