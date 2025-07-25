// Reference.cs
public class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; } // Allows for a single verse or a range

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    // Override ToString to handle display logic automatically
    public override string ToString()
    {
        return EndVerse.HasValue 
            ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" 
            : $"{Book} {Chapter}:{StartVerse}";
    }
}