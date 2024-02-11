using System;
using System.IO;

class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        while (true)
        {
            DisplayPLayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 6)
            {
                break;
            }

            switch (option)
            {
                case 1:
                    CreateGoal();

                    break;
                case 2:
                    ListGoalDetails();

                    break;
                case 3:
                    SaveGoals();

                    break;
                case 4:
                    LoadGoals();

                    break;
                case 5:
                    RecordEvent();

                    break;
            }
        }
    }

    public void DisplayPLayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    void ListGoalNames()
    {

    }
    void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");

        for (int i = 0; i < _goals.Count(); i++)
        {
            Goal goal = _goals[i];

            Console.WriteLine($"{i + 1}. " + goal.GetDetailsString());

        }

    }
    void CreateGoal()
    {
        int option;

        while (true) // Exceed repeat menu options when option typed is not expected
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            option = int.Parse(Console.ReadLine());

            int[] validOptions = { 1, 2, 3 };

            if (validOptions.Contains(option))
            {
                break;
            }

        }


        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        Goal goal = new SimpleGoal(name, description, points);

        switch (option)
        {
            case 1:
                break;
            case 2:
                goal = new EternalGoal(name, description, points);

                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);

                break;
            default:
                Console.WriteLine("By Default we are going to use SimpleGoal type");
                break;
        }

        _goals.Add(goal);
    }

    void RecordEvent()
    {

    }
    void SaveGoals()
    {

        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }
    void LoadGoals()
    {
        _goals = new List<Goal>();

        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];

            if (i == 0)
            {
                _score = int.Parse(line);
                continue;
            }

            string[] typeXData = line.Split(":");
            string[] data = typeXData[1].Split(",");

            Console.WriteLine(data);
            Console.WriteLine(typeXData);

            string goalType = typeXData[0];
            string shortName = data[0];
            string description = data[1];
            string points = data[2];

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(data[3]);

                    if (isComplete) break;

                    Goal goal = new SimpleGoal(shortName, description, points);
                    _goals.Add(goal);

                    break;
                case "ChecklistGoal":
                    int target = int.Parse(data[4]);
                    int bonus = int.Parse(data[3]);

                    goal = new ChecklistGoal(shortName, description, points, target, bonus);
                    _goals.Add(goal);

                    break;
                case "EternalGoal":

                    goal = new EternalGoal(shortName, description, points);
                    _goals.Add(goal);

                    break;
            }

        }

    }

}