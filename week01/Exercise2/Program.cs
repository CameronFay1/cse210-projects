using System;

class Program
{
    static void Main(string[] args)
    {
        string score = "";
        string sign = "";
        Console.Write("enter grade precentage: ");
        string grade = Console.ReadLine();
        int int_grade = int.Parse(grade);
        if (int_grade >= 90)
        {
            score = "A";
        }
        else if (int_grade >= 80)
        {
            score = "B";
        }
        else if (int_grade >= 70)
        {
            score = "C";
        }
        else if (int_grade >= 60)
        {
            score = "D";
        }
        else if (int_grade < 60)
        {
            score = "F";
        }
        int last_didgit = int_grade % 10;
        if (last_didgit >= 7)
        {
            sign = "+";
        }
        else if (last_didgit <= 3)
        {
            sign = "-";
        }
        
        if (score == "A" && sign == "+" || int_grade >= 100 || score == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is a ({score}{sign})");

        if (int_grade >= 70)
        {
            Console.WriteLine("you have passed the class.");
        }
        else
        {
            Console.WriteLine("you have failed the class.");
        }
    }
}