// DisplayWelcome - Displays the message, "Welcome to the Program!"
//PromptUserName - Asks for and returns the user's name (as a string)
//PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
//SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
//DisplayResult - Accepts the user's name and the squared number and displays them.

using System;


class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
      Console.WriteLine("Welcome to the program!!");
    }
    
    static string PromptUserName()
    {
      Console.WriteLine("Please enter your name here:");
      string name = Console.ReadLine();
      return name;
    }

    static int PromptUserNumber()
    {
      Console.Write("Please enter your favourit number: ");
      int number = int.Parse(Console.ReadLine());
      return number;
    }

    static int SquareNumber(int number)
    {
      int square = number * number;
      return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
