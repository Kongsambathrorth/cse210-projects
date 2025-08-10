public class Activity
{
    // Shared attributes
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Set duration
    public void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    // Shared behaviors
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public int GetDuration() => _duration;
}
