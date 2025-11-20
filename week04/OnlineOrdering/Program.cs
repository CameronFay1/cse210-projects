using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("________________________________________________________________________________________");
        Console.WriteLine("");
        Address A = new Address("speed ave","Salt Lake city","Utah","USA");
        Customer C = new Customer("jack", A);
        C.Display();
        Order O = new Order(); 
        Console.WriteLine("\n_____________________________________________");
        O.PackingLabel();
        bool inUSA = A.IsInUSA();
        Console.WriteLine("_____________________________________________");
        O.TotalCost(inUSA);
    }
}