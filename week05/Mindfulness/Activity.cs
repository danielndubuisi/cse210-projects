// this is the base activity class that contains all shared functionality
using System;

public class Activity
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;

    // constructor
    public Activity()
    {
        // initialize default values
        _name = "";
        _description = "";
        _duration = 0;
    }

    // getters
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // setters
    protected void SetName(string value)
    {
        _name = value;
    }

    protected void SetDescription(string value)
    {
        _description = value;
    }

    protected void SetDuration(int value)
    {
        _duration = value;
    }

    // methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");
        ShowSpinner(4);
        Console.WriteLine($"\nYou have completed another {GetDuration()} seconds of the {_name} Activity.");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        // get how long spinner should run
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        // spinner characters
        List<string> animationStrings = ["|", "/", "-", "\\"];

        int i = 0;

        // spin for a set period
        while (DateTime.Now < endTime)
        {

            // erase & replace previous character to simulate spinner effect
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            //reset if out of characters
            if (i >= animationStrings.Count)
            {
                i = 0;
            }  
        }
    }

    public void ShowCountDown(int second)
    {
        // count down
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}