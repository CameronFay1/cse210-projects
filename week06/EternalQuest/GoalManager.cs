using System.IO.Compression;

public class GoalManager
{
    private int _score;
    private List<Goals> _goals = new List<Goals>();
    public void AddList(Goals goal)
    {
        _goals.Add(goal);
    }
    public void DisplayGoals()
    {
        Console.WriteLine("");
        int number = 0;
        foreach (Goals goal in _goals)
        {
            number++;
            Console.Write($"{number}.");
            if (goal.IsComplete() == true)
            {
                Console.Write(" [X] ");
            }
            else
            {
                Console.Write(" [ ] ");
            }
            goal.GetDisplay();
        }
            Console.WriteLine("");
            Thread.Sleep(1500);
        
    }
    public void RecordEvent()
    {
        int number = 0;
        Console.WriteLine("The goals are:");
        foreach (Goals goal in _goals)
        {
            number++;
            Console.WriteLine($"{number}. {goal.GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int input = int.Parse(Console.ReadLine());
        _goals[input - 1].Completed();
        _score += _goals[input - 1].GetPoints();
        Console.WriteLine($"Congratulations! You have earned {_goals[input - 1].GetPoints()} points!");
        Console.WriteLine($"You now have {_score} points.");
        Thread.Sleep(1500);
    }
    public void RemoveGoal()
    {
        int number = 0;
        Console.WriteLine("The goals are:");
        foreach (Goals goal in _goals)
        {
            number++;
            Console.WriteLine($"{number}. {goal.GetName()}");
        }
        Console.Write("Which goal do you whant to remove? ");
        int input = int.Parse(Console.ReadLine());
        _goals.RemoveAt(input - 1);
    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goals goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentaion());
            }
        }
    }


    public void LoadGoals(string fileName)
    {
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            
                string[] parts = line.Split("|");
            if (parts[0] == "CheckListGoal")
            {
                string nameOfGoalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bounus = int.Parse(parts[6]);
                int anmountCompleted =  int.Parse(parts[7]);
                CheckListGoal CL =new CheckListGoal(name,description,points,isComplete,target,bounus,anmountCompleted);
                AddList(CL);
            }
            else if (parts[0] == "SimpleGoal")
            {
            string nameOfGoalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            SimpleGoal SG =new SimpleGoal(name,description,points,isComplete);
            AddList(SG);
            }
            else if (parts[0] == "EnternalGoal")
            {
            string nameOfGoalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            EnternalGoal EG = new EnternalGoal(name,description,points,isComplete);
            AddList(EG);
            }
            else
            {
                _score = int.Parse(parts[0]);
            }

        }
    }
    public int GetScore()
    {
        return _score;
    }


}