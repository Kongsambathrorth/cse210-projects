
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>();

        // Create one activity of each type
        activities.Add(new Running(new DateTime(2025, 08, 13), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2025, 08, 13), 45, 25.0));
        activities.Add(new Swimming(new DateTime(2025, 08, 13), 60, 40));

        Console.WriteLine("--- Fitness Activity Log ---");
        
        // Iterate through the list and display the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}