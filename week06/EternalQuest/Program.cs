using System;
using System.Diagnostics;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        GoalManager GM = new GoalManager();
        string input = "";
        while (input != "6")
        {
            Console.WriteLine($"\nYou have {GM.GetScore()} Points \n");
            Console.Write("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ");
            input = Console.ReadLine();
            

            if (input == "1")
            {
                Console.Write("The types of Goals are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\nWich type of goal would you like to create?  ");
                string input2 = Console.ReadLine();
                if (input2 == "1" ||input2 == "2" ||input2 == "3" )
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("Give a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("WHat is the amount of points associated with this goal? ");

                    int points = int.Parse(Console.ReadLine());
                    if (input2 == "1")
                    {
                        SimpleGoal SG = new SimpleGoal(name,description,points,false);
                        GM.AddList(SG);
                        GM.DisplayGoals();
                        
                    }
                    else if (input2 == "2")
                    {
                        EnternalGoal EG = new EnternalGoal(name,description,points,false);
                        GM.AddList(EG);
                        GM.DisplayGoals();
                    }
                    else if (input2 == "3")
                    {
                        Console.Write("How many times dose this goal need to be accomnplished for a bonus? ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("what is the bonus for accomplishing it that many times? ");
                        int bounus = int.Parse(Console.ReadLine());
                        CheckListGoal LG = new CheckListGoal(name,description,points,false,target,bounus);
                        GM.AddList(LG);
                        GM.DisplayGoals();
                    }
                }
                else
                {
                    Console.WriteLine("\nThat is not a vaild input.\n");
                    Thread.Sleep(1000);
                }
            }
                    
            else if (input == "2")
            {
                GM.DisplayGoals();
            }
            else if (input == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                GM.SaveGoals(fileName);
                GM.DisplayGoals();
            }
            else if (input == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                GM.LoadGoals(fileName);
                GM.DisplayGoals();
            }
            else if (input == "5")
            {
               GM.RecordEvent(); 
               GM.DisplayGoals();
            }
            else if (input == "6")
            {
                Console.WriteLine("\nGoodbye.\n");
                break;
            }
            else
            {
                Console.WriteLine("\nThat is not a vaild input.\n");
                Thread.Sleep(1000);
            }
        }
    }
}