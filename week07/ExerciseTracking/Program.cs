using System;

class Program
{
    static void Main(string[] args)
    {
        Running R = new Running(3.0,30);
        R.GetSummary();
        Swinmming S = new Swinmming(5,20);
        S.GetSummary();
        Cycling C = new Cycling(6.0,9.7,20);
        C.GetSummary();
    }
}