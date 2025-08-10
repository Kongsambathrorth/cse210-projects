public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "List as many things as you can that make you smile.",
        "List the people who have influenced you positively.",
        "List activities that help you relax."
    };

    public ListingActivity() 
        : base("Listing", "This activity will help you reflect on the good things in your life by listing items related to a prompt.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nList responses to the following prompt:\n--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        ShowCountdown(3);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
