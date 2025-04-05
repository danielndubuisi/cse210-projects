// breathing activity class
using System.Diagnostics;

public class BreathingActivity : Activity
{
    // constructor
    public BreathingActivity()
    {
        // set common attributes
        base.SetName("Breathing");
        base.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    // method
    public void Run()
    {
        Console.WriteLine($"\n\n");

        // get duration to run for
        int duration = base.GetDuration();

        // use stopwatch to track how long it runs
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {  
            Console.Write("Breathe in...");
            base.ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            base.ShowCountDown(6);
            Console.WriteLine("\n");
        }

        // end stop watch after duration is elapsed
        stopwatch.Stop();
    }
}