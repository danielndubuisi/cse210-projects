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
        // initialize numbering based on index
        int i = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetShortName()}"); 
        }
    }

    // list each goal details
    public void ListGoalDetails()
    {
        // initialize numbering based on index
        int i = 0;

        if (_goals.Count >  0)
        {
            foreach (Goal goal in _goals)
            {
                i++;
                Console.WriteLine($"{i}. {goal.GetDetailsString()}");
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
        int choice = int.Parse(Console.ReadLine());

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
            case 1:
                // Create a simple goal
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                // add to goals list
                _goals.Add(simpleGoal);
                break;

            case 2:
                // Create an eternal goal
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                // add to goals list
                _goals.Add(eternalGoal);
                break;

            case 3:
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
        // check if goals are available
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found! Please create goals to record an event.");
            return;
        }

        // record an event for a goal
        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames();

        // get goal to complete
        Console.Write("> ");
        int choice = int.Parse(Console.ReadLine());

        // get goal index from user choice
        int index = choice - 1;
        Goal completedGoal = _goals[index];

        // check if goal is complete
        if (completedGoal.IsComplete())
        {
            Console.WriteLine("This goal is already completed!");
            return;
        }

        // check goal type
        if (completedGoal is CheckListGoal)
        {
            CheckListGoal checkListGoal = (CheckListGoal)completedGoal;

            // record event
            completedGoal.RecordEvent();

            // add points only if completed matches target
            if (checkListGoal.IsComplete())
            {
                // add bonus and points to score
                SetScore(GetScore() + checkListGoal.GetPoints() + checkListGoal.GetBonus());

                Console.WriteLine($"Wow! You stayed consistent and earned {checkListGoal.GetBonus()} bonus points.");
            }
            else
            {
                // add points to score
                SetScore(GetScore() + completedGoal.GetPoints());
                                
                Console.WriteLine($"Congratulations! You have earned {completedGoal.GetPoints()} points.");
            }
        }
        else if (completedGoal is EternalGoal || completedGoal is SimpleGoal)
        {
            // record event and add points to score
            completedGoal.RecordEvent();
            SetScore(GetScore() + completedGoal.GetPoints());
            Console.WriteLine($"Congratulations! You have earned {completedGoal.GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("Something went wrong! Please try again.");
        }
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
                    // save points
                    outputFile.WriteLine($"{GetScore()}");

                    // save goals
                    foreach (Goal goal in _goals)
                    {
                        outputFile.WriteLine($"{goal.GetStringRepresentation()}");
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
        // get file name
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        // read all file lines into a list
        string[] lines = File.ReadAllLines(filename);

        // ensure file is not empty
        if (lines.Length == 0)
        {
            Console.WriteLine("Error: File is empty");
            return;
        }

        // store first line as score
        _score = int.Parse(lines[0]);

        // clear current list
        _goals.Clear();

        // assign remaining values
        for (int i=1; i<lines.Length; i++)
        {
            string line = lines[i];

            // split goal type from other details
            string[] parts = line.Split(":");

            // store separately
            string goalType = parts[0];
            string details = parts[1];

            // get details info
            string[] goalDetails = details.Split(",");

            string name = goalDetails[0];
            string description = goalDetails[1];
            int points = int.Parse(goalDetails[2]);

            // create goal based on type and details
            if (goalType == "SimpleGoal")
            {
                // get true or false value for isComplete
                bool completedStatus = bool.Parse(goalDetails[3]);

                // Create a simple goal
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                // check completed status
                if (completedStatus)
                {
                    simpleGoal.SetIsComplete();
                }
                // add to goals list
                _goals.Add(simpleGoal);
            }
            else if(goalType == "EternalGoal")
            {
                // Create an eternal goal
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                // add to goals list
                _goals.Add(eternalGoal);
            }
            else
            {
                // get more info from user
                int bonus = int.Parse(goalDetails[3]);
                int target = int.Parse(goalDetails[4]);
                int amountCompleted = int.Parse(goalDetails[5]);

                // Create a checklist goal
                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);

                // set amount completed
                for (int j=0; j<amountCompleted; j++)
                {
                    checkListGoal.SetAmountCompleted();
                }
                
                // check if goal is complete                
                if (amountCompleted == target)
                {
                    checkListGoal.IsComplete();
                }
                
                // add to goals list
                _goals.Add(checkListGoal);
            }
        
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}
