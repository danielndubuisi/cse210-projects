// reflecting activity class
public class ListingActivity : Activity
{
    // attributes
    private int _count;
    private List<string> _prompts;

    // constructor 
    public ListingActivity(int count)
    {
        // set common attributes
        base.SetName("Listing");
        base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // set other member variables
        _count = count;
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    // methods
    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public List<string> GetListFromUser()
    {
        return [];
    }
}