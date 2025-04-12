// this class handles all of the menu system and its related functions, including the saving of points
public class GoalManager
{
    // attributes
    private List<Goal> _goals;
    private int _score;

    // constructor
    public GoalManager()
    {
        // initialize and empty goals list
        _goals = [];

        // set player score to zero
        _score = 0;
    }

    // methods
    public void Start()
    {
        // runs the menu loop

    }

    // Displays the players current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("");
    }

    // list each goal
    public void ListGoalNames()
    {

    }

    // list each goal details
    public void ListGoalDetails()
    {

    }

    // get user info, create and add goal to list
    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. CheckList Goal");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                // Create a simple goal
                break;
            case "2":
                // Create an eternal goal
                break;
            case "3":
                // Create a checklist goal
                break;
            default:
                Console.WriteLine("Invalid choice! Select between 1 -3");
                break;
        }
    }

    // records completed goal
    public void RecordEvent()
    {
        // record an event for a goal
        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames();
        Console.Write("> ");
        string choice = Console.ReadLine();

        // check if the choice is valid and record the event
    }

    // save goals
    public void SaveGoals()
    {
        Console.WriteLine("Saving goals...");
    }

    // load goals
    public void LoadGoals()
    {
        Console.WriteLine("Loading goals...");
    }
}