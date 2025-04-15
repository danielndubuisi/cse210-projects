using System;

class Program
{
    static void Main(string[] args)
    {
        // list of activities
        List<Activity> activities = [];

        // set date
        DateTime today = DateTime.Now;

        // running activity
        Running running = new Running(today, 30, 4.8);

        // cycling activity
        Cycling cycling = new Cycling(today, 30, 45.13);

        // swimming activity
        Swimming swimming = new Swimming(today, 30, 20);

        // add activities to list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // show summary for all activity
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
        
    }
}