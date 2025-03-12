public class Resume {
    // attributes
    public string _name = "";
    public List<Job> _jobs = [];

    // method
    public void DisplayResume()
    {
        // display name
        Console.WriteLine($"Name: {_name}");

        // display each job details
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}