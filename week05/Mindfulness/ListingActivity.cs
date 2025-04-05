// reflecting activity class
using System.Diagnostics;

public class ListingActivity : Activity
{
    // attributes
    private int _count;
    private List<string> _prompts;

    // constructor 
    public ListingActivity()
    {
        // set common attributes
        base.SetName("Listing");
        base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // initialize other member variables
        _count = 0;
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    // getter
    public int GetCount()
    {
        return _count;
    }

    // setter
    private void SetCount(int value)
    {
        _count = value;
    }

    // methods
    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        base.ShowCountDown(4);
        Console.WriteLine("");

        // get duration
        int duration = base.GetDuration();

        // use stopwatch to track how long it runs
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        List<string> items = [];
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            GetListFromUser(items);
        }
        // set count to length of user list
        SetCount(items.Count);

        // end stop watch after duration is elapsed
        stopwatch.Stop();

        Console.WriteLine($"You listed {GetCount()} items!");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);

        // choose a random prompt from list
        string prompt = _prompts[index];
        return prompt;        
    }

    public List<string> GetListFromUser(List<string> items)
    {
        Console.Write("> ");
        string listItem = Console.ReadLine();
        items.Add(listItem);

        return items;
    }
}