public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int interval = 5; // seconds per inhale/exhale

        while (duration > 0)
        {
            Console.Write("Breathe in...");
            ShowCountdown(interval);
            Console.Write("Breathe out...");
            ShowCountdown(interval);
            duration -= interval * 2;
        }

        DisplayEndingMessage();
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
