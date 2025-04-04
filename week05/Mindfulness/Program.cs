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

                    // activity core
                    Console.WriteLine(breathingActivity.GetDuration());

                    // display ending message once activity is completed
                    breathingActivity.DisplayEndingMessage();

                    // pause for 2 seconds
                    Thread.Sleep(2000);

                    // clear console
                    Console.Clear();
                    break;

                // reflecting activity
                case 2:
                    // instantiate activity
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    // display start message
                    reflectingActivity.DisplayStartingMessage();

                    // activity core
                    Console.Write(reflectingActivity.GetDuration());

                    // display ending message once activity is completed
                    reflectingActivity.DisplayEndingMessage();

                    // pause for 2 seconds
                    Thread.Sleep(2000);

                    // clear console
                    Console.Clear();
                    break;

                // listing activity
                case 3:
                    // instantiate activity
                    ListingActivity listingActivity = new ListingActivity(1);
                    // display start message
                    listingActivity.DisplayStartingMessage();

                    // activity core
                    Console.Write(listingActivity.GetDuration());

                    // display ending message once activity is completed
                    listingActivity.DisplayEndingMessage();

                    // pause for 2 seconds
                    Thread.Sleep(2000);

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
        Console.WriteLine("You Quit! Goodbye!");
    }
}