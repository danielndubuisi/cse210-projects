using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        while(userChoice != 4)
        {
            // prompt menu for activity choice
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            // clear console to start activity
            Console.Clear();

            // response based on user choice
            switch (userChoice)
            {
                // breathing activity
                case 1:
                    // instantiate activity
                    BreathingActivity breathingActivity = new BreathingActivity();
                    // display start message
                    breathingActivity.DisplayStartingMessage();

                    // show spinner
                    breathingActivity.ShowSpinner(5);
                    
                    // run activity
                    breathingActivity.Run();

                    // display ending message once activity is completed
                    breathingActivity.DisplayEndingMessage();

                    // clear console
                    Console.Clear();
                    break;

                // reflecting activity
                case 2:
                    // instantiate activity
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    // display start message
                    reflectingActivity.DisplayStartingMessage();

                    // show spinner
                    reflectingActivity.ShowSpinner(5);

                    // display prompt
                    reflectingActivity.DisplayPrompt();

                    // run activity
                    reflectingActivity.Run();

                    // display ending message once activity is completed
                    reflectingActivity.DisplayEndingMessage();

                    // clear console
                    Console.Clear();
                    break;

                // listing activity
                case 3:
                    // instantiate activity
                    ListingActivity listingActivity = new ListingActivity();
                    // display start message
                    listingActivity.DisplayStartingMessage();

                    // show spinner
                    listingActivity.ShowSpinner(5);

                    // run activity
                    listingActivity.Run();

                    // display ending message once activity is completed
                    listingActivity.DisplayEndingMessage();

                    // clear console
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Choose between 1 and 4 ...");
                    break;
            }
        }

        // clear console
        Console.Clear();
        Console.WriteLine("You Quit!");
    }
}