using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1; // Initialize with a value to enter the loop

        Console.WriteLine("Enter a list of numbers, type 0 when finish.");
        
        // Use a while loop
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();

            // Validate input
            if (int.TryParse(userInput, out userNumber))
            {
                if (userNumber != 0)
                {
                    numbers.Add(userNumber); // Add non-zero number to the list
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Check if the list is empty
        if (numbers.Count > 0)
        {
            // Calculate the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            // Calculate the average
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find the maximum number
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
