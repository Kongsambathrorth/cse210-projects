using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();
        int GradePercent  = int.Parse(valueFromUser);

        string letter = "";

        if (GradePercent >= 90)
        {
           letter = "A";
          
        }
        else if (GradePercent>=80)
        {
            letter = "B";
        }

        else if (GradePercent>=70)
        {
            letter = "C";
        }

        else if (GradePercent>=60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (GradePercent>= 70)
        {
            Console.WriteLine("Congratulation! You passed");
        }

        else
        {
            Console.WriteLine("Wish you good luck for next time");
        }

    }
}