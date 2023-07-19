using System.IO;
public class GoalManager {

    private List<Goal> _goalsList = new List<Goal>();
    private int _score = 0;

    public GoalManager (){

    }

    public void Start (){
        
        int option = 0;
        String[] menuList = {"1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event","6. quit"};

        while (option != 6){

            DisplayPlayerInfo();
            
            Console.WriteLine("Menu Options:");
            
            foreach (String menuItem in menuList){
                Console.WriteLine(menuItem);
            }
            
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

        
            switch (option){
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

    public void DisplayPlayerInfo (){
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void CreateGoal (){

        Console.WriteLine();
        ListGoalNames();

        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the name of your goal? ");
        String name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        String description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);
                _goalsList.Add(simpleGoal);
            break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goalsList.Add(eternalGoal);
            break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int times = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for acomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, times, bonus, 0);
                _goalsList.Add(checklistGoal);
            break;
        }
        }

    public void ListGoalNames (){

        String[] goalsList = {"1. Simple Goal", "2. Eternal Goal", "3. Checklist Goal"};

        foreach (String item in goalsList){
            Console.WriteLine(item);
        }
    }

    public void ListGoalDetails (){
        Console.WriteLine();
        Console.WriteLine("Goals List:");
        for (int i = 0; i < _goalsList.Count; i++){
            
            Console.WriteLine($"{i+1}. {_goalsList[i].GetDetailsString()}");
        }
    }

    public void RecordEvent (){
        Console.WriteLine();
        for (int i = 0; i < _goalsList.Count; i++){
            Console.WriteLine($"{i+1}. {_goalsList[i].getName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int  goalToRecord=  int.Parse(Console.ReadLine());
        int goalNum = goalToRecord - 1;

        _goalsList[goalNum].RecordEvent();
        int points = _goalsList[goalNum].getPoints();

        Console.WriteLine($"\nCongratulations! you have earned {points} points !");
        _score =  _score + points;
        Console.WriteLine($"You now have {_score}");
    }

    public void SaveGoals (){

        Console.Write("What is the file name for the goal file? ");
        String fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goalsList){
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            
        }
        Console.WriteLine($"\nGoals saved successfully into {fileName}");
    }

    public void LoadGoals (){

        Console.Write("What is the file name for the goal file? ");
        String fileName = Console.ReadLine();

        String[] lines = System.IO.File.ReadAllLines(fileName);

        bool skipLine = true;

        foreach (String line in lines)
        {   
            if (skipLine){
                skipLine = false;
                Console.WriteLine($"\nThis is the new score {line}");
                _score = int.Parse(line);
                continue;
            }
            String[] parts = line.Split(":");
            String className = parts[0];
            String values = parts[1];

            String[] valueParts = values.Split(",");

            switch (className)
        {
            case "SimpleGoal":
                SimpleGoal simpleGoal = new SimpleGoal(valueParts[0], valueParts[1], int.Parse(valueParts[2]), bool.Parse(valueParts[3]));
                _goalsList.Add(simpleGoal);
            break;
            case "EternalGoal":
                EternalGoal eternalGoal = new EternalGoal(valueParts[0], valueParts[1], int.Parse(valueParts[2]));
                _goalsList.Add(eternalGoal);
            break;
            case "ChecklistGoal":
                ChecklistGoal checklistGoal = new ChecklistGoal(valueParts[0], valueParts[1], int.Parse(valueParts[2]), int.Parse(valueParts[3]), int.Parse(valueParts[4]), int.Parse(valueParts[5]));
                _goalsList.Add(checklistGoal);
            break;
        }
         }
         Console.WriteLine("\nGoals loaded successfully");

    }

}