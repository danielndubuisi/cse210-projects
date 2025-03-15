using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        // initialize class objects
        Journal myJournal = new Journal();
        PromptGenerator randomPrompt = new PromptGenerator();
        Entry entry = new Entry();
        
        // loop based on user choice
        int choice =  0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry\n2. Display the journal\n3. Load journal from file\n4. Save journal to file\n5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            // action based on user choice
            switch (choice)
            {
                case 1:
                    // generate random prompt
                    string prompt = randomPrompt.GetRandomPrompt();
                    Console.WriteLine(prompt);

                    // get user entry
                    string userEntry = Console.ReadLine();

                    // store new entry 
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = userEntry;

                    // add entry to journal
                    myJournal.AddEntry(entry);
                    break;

                case 2:
                    // check if entry available and display all entries in journal
                    if (myJournal._entries.Count > 0)
                    {
                        myJournal.DisplayAll();                        
                    }
                    else
                    {
                        Console.WriteLine("No entries found!");
                    }
                    break;

                case 3:
                    Console.WriteLine("choice is 3");
                    break;

                case 4:
                    Console.WriteLine("choice is 4");
                    break;

                default:
                    break;
            }
        }

        Console.WriteLine("You quit! See you next time.");
    }
}