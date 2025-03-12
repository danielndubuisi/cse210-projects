using System;

class Program
{
    static void Main(string[] args)
    {
        // new instances of Job class
        Job job1 = new Job();
        Job job2 = new Job();

        // set attributes for first job
        job1._jobTitle = "Software Developer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // set attributes for second job
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // new instance of Resume class
        Resume myResume = new Resume();

        // set Resume name
        myResume._name = "Daniel Ndubuisi";

        // add both jobs to the list of jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // display result
        myResume.DisplayResume();
    }
}