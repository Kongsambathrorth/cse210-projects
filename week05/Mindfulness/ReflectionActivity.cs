public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Recall a moment when you helped someone in need.",
        "Reflect on a time when you overcame a fear."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you feel afterward?",
        "What could you apply from this experience to future challenges?"
    };

    public ReflectionActivity() 
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider the following prompt:\n--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int questionIndex = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {questions[questionIndex % questions.Count]}");
            ShowSpinner(5);
            questionIndex++;
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }

    private void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
