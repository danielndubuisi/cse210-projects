// this class handles all of the menu system and its related functions, including the saving of points
using System.IO;

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

    // getter
    private int GetScore()
    {
        return _score;
    }

    // setter
    public void SetScore(int value)
    {
        _score = value;
    }

    // methods
    public void Start()
    {
        // runs the menu loop
        int userChoice = 0;

        while(userChoice != 6)
        {
            // show score
            DisplayPlayerInfo();

            // menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            // respond based on user choice
            switch (userChoice)
            {
                // create new goal
                case 1:
                    CreateGoal();
                    break;
                
                // list goal details
                case 2:
                    ListGoalDetails();
                    break;
                
                // save goals
                case 3:
                    SaveGoals();
                    break;
                
                // load goals
                case 4:
                    LoadGoals();
                    break;
                
                // record event
                case 5:
                    RecordEvent();
                    break;
                
                // break and end loop
                case 6:
                    break;
                
                default:
                    Console.WriteLine("Invalid choice! Select between 1 - 6");
                    break;
            }
        }

        Console.WriteLine("You quit the Eternal Quest program! Goodluck!\n");
    }

    // Displays the players current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {GetScore()} points.\n");
    }

    // list each goal name
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            goal.GetShortName();
        }
    }

    // list each goal details
    public void ListGoalDetails()
    {
        if (_goals.Count >  0)
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
        else
        {
            Console.WriteLine("No goals found in your list!");
        }
    }

    // get user info, create and add goal to list
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("\t1. Simple Goal\n\t2. Eternal Goal\n\t3. CheckList Goal");

        Console.Write("What type of goal would you like to create? ");
        string choice = Console.ReadLine();

        // get common user inputs
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        // use inputs to create goals
        switch (choice)
        {
            case "1":
                // Create a simple goal
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                // add to goals list
                _goals.Add(simpleGoal);
                break;

            case "2":
                // Create an eternal goal
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                // add to goals list
                _goals.Add(eternalGoal);
                break;

            case "3":
                // get more info from user
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                // Create a checklist goal
                CheckListGoal checkListGoal = new CheckListGoal(goalName, goalDescription, goalPoints, target, bonus);
                // add to goals list
                _goals.Add(checkListGoal);
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
        try
        {
            // check if goals added
            if (_goals.Count > 0)
            {
                // get file name
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
            
                // write goals to file
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Goal goal in _goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }                
                }
                Console.WriteLine($"Goals saved to {filename}");
            }            
            else
            {
                Console.WriteLine("No goals found! Please create goals to save.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    // load goals
    public void LoadGoals()
    {
        Console.WriteLine("Loading goals...");
    }
}