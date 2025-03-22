using System;

class Program
{
    static void Main(string[] args)
    {
        // scripture reference
        Reference reference = new Reference("John", 3, 16);

        // scripture text
        string scriptureText = "For God so loved the world that He gave His only begotten son and whosoever believes in Him shall not perish but have everlasting life.";

        // create a new scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // pressing enter returns empty string
        string userChoice;

        // loop to display the scripture text
        do
        {
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("\nPress enter to hide text or type 'quit' to finish: ");
            userChoice = Console.ReadLine();

            // clear console
            Console.Clear();

            if (userChoice == "")
            {
                scripture.HideRandomWords(1);
                Console.WriteLine(scripture.GetDisplayText());
            }
            
        } while (userChoice != "quit" && !scripture.IsCompletelyHidden());

        Console.WriteLine("Goodbye!");
    }
}