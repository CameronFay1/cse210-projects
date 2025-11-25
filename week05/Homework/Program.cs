using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssigments M = new MathAssigments("Roberto Rodriguez","Fractions","7.3","8-19");
        M.GetSummary();
        M.GetHoeWorkList();
        Console.WriteLine("-------------------------------");
        WritingAssignments W = new WritingAssignments("Mary Waters","European History","The Causes of World War II by Mary Waters");
        W.GetSummary();
        W.GetWritingINformation();
    }
}