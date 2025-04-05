using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"{Date}: {Prompt} > {Response}";
    }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
            return;
        }
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        string filename = "myFile.txt";
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile()
    {
        string filename = "myFile.txt";
        if (File.Exists(filename))
        {
            entries.Clear();
            foreach (var line in File.ReadAllLines(filename))
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string[] prompts =
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid option. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = prompts[new Random().Next(prompts.Length)];
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.LoadFromFile();
                    break;
                case 4:
                    journal.SaveToFile();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
