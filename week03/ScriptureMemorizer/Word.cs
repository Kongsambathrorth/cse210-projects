// Word.cs
public class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; } // Can only be changed from within this class

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    // This handles displaying either the word or underscores
    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}