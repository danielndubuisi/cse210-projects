using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        // instantiate journal class
        Journal myJournal = new Journal();
        
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
                    // instantiate promptGenerator class
                    PromptGenerator randomPrompt = new PromptGenerator();

                    // generate random prompt
                    string prompt = randomPrompt.GetRandomPrompt();
                    Console.WriteLine(prompt);

                    // get user entry
                    string userEntry = Console.ReadLine();

                    // instantiate entry class object
                    Entry entry = new Entry();

                    // store entry data
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
                    Console.WriteLine("What is the filename (eg. jornal.txt)? ");
                    string file = Console.ReadLine();
                    myJournal.LoadFromFile(file);
                    break;

                case 4:
                    Console.Write("What is the filename (eg. journal.txt)? ");
                    string filename = Console.ReadLine();
                    myJournal.SaveToFile(filename);
                    break;

                default:
                    break;
            }
        }

        Console.WriteLine("You quit! See you next time.");
    }
}