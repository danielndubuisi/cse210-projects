using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "y";
        int guessCount = 0;

        while (playAgain == "y")
        {
            Random randomNumber = new Random();
            int magicNmuber = randomNumber.Next(1, 101);
            Console.Write("A magic number between 1 and 100 is generated. Try to guess it!\n");

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            guessCount++;

            while (magicNmuber != guess)
            {
                if (magicNmuber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNmuber < guess)
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
            }
            
            Console.WriteLine($"Congrats! You guessed it in {guessCount} trial(s).");

            // reset count and ask if user wants to play again
            guessCount = 0;
            Console.Write("Do you want to play again? (y/n) ");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Goodbye!");
    }
}