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
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!\nYou have completed another {GetDuration()} seconds of the {_name} Activity.");
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int second)
    {

    }
}