using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage (0-100)? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter;
        string sign;

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        if (grade == 100)
        {
            // No A+ grade even for perfect score
            sign = "";
        }
        else if (grade % 10 >= 7)
        {
            // No A+ or F+ grade
            if (letter == "A" || letter == "F")
            {
                sign = "";
            }
            else 
            {
                sign = "+";
            }
        }
        else if (grade % 10 <= 3)
        {
            // No F- grade
            if (letter == "F")
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else
        {
            sign = "";
        }

        // Output the result
        Console.WriteLine($"Your grade is {letter}{sign}.");

        // Output message based on the grade
        if (grade >= 70)
        {
            Console.WriteLine("You passed! Congratulations!");
        }
        else
        {
            Console.WriteLine("You failed. Try harder next time!");
        }
    }
}