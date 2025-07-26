// Program.cs
class Program
{
    static void Main()
    {
       
       var reference = new Reference("1 Nephi", 3, 7);
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        var scripture = new Scripture(reference, text);
        scripture.Display();

        while (!scripture.AllWordsHidden())
        {
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit")
                break;

            scripture.HideRandomWords();
            scripture.Display();
        }

        Console.WriteLine("Scripture memorized! 🎉");
    }
}