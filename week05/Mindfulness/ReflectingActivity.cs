using System.Diagnostics;
// reflecting activity class
public class ReflectingActivity : Activity
{
    // attributes
    private List<string> _prompts;
    private List<string> _questions;

    // constructor
    public ReflectingActivity()
    {
        // set common attributes
        base.SetName("Reflecting");
        base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        // set other member variables
        _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }


    // methods
    public void Run()
    {
        // get duration to run for
        int duration = base.GetDuration();

        Console.WriteLine("\n Now ponder on each of the following questions as related to your experience.");
        Console.Write($"You may begin in: ");
        base.ShowCountDown(4);

        // clear console
        Console.Clear();

        // use stopwatch to track how long it runs
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {  
            DisplayQuestions();
        }

        // end stop watch after duration is elapsed
        stopwatch.Stop();

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);

        // choose a random prompt from list
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);

        // choose a random question from list
        string question = _questions[index];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\n Consider the following prompt:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");

        // wait for user to hit enter to continue
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        base.ShowSpinner(7);
        Console.WriteLine();
    }
}