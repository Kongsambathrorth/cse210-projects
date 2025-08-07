using System;
using System.Collections.Generic;
using System.IO;

// Represents a single journal entry.
public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Date} - {PromptText}: {EntryText}");
    }
}

// Represents the entire collection of journal entries.
public class Journal
{
        private List<Entry> _entries = new List<Entry>();

    // Adds a new Entry object to the journal's list.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays all entries currently in the journal.
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves the current list of entries to a file specified by the user.
    public void SaveToFile(string filename)
    {
        // 'using' ensures the file is properly closed even if errors occur.
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Create a specially formatted string using a separator ('|').
                outputFile.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    // Loads a list of entries from a file, replacing any entries in memory.
    public void LoadFromFile(string filename)
    {
        // Clear the existing list before loading.
        _entries.Clear();

        // Read all lines from the specified file into an array of strings.
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Split the line into parts based on the separator character.
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                // Create a new Entry object and populate it with the parts.
                Entry loadedEntry = new Entry
                {
                    Date = parts[0],
                    PromptText = parts[1],
                    EntryText = parts[2]
                };
                // Add the newly created entry to the journal's list.
                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}