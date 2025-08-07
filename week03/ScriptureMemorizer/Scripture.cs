// Scripture.cs
public class Scripture
{
    public Reference ScriptureReference { get; }
    private List<Word> Words { get; }
    private Random _random = new Random(); // Create the Random object once

    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        // The ToString() overrides make this line simple and clean
        Console.WriteLine($"{ScriptureReference}\n{string.Join(" ", Words)}\n");
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Any())
        {
            // Use the single _random instance
            foreach (var word in visibleWords.OrderBy(_ => _random.Next()).Take(count))
            {
                word.Hide();
            }
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }
}