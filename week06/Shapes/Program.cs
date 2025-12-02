using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> list = new List<Shapes>{};
        Square S1 = new Square("Green",4);
        list.Add(S1);
        Square S2 = new Square("red",7);
        list.Add(S2);
        Rectangle R1 = new Rectangle("black", 2,5);
        list.Add(R1);
        Rectangle R2 = new Rectangle("yellow", 6,9);
        list.Add(R2);
        Circle C1 = new Circle("gray",10);
        list.Add(C1);
        Circle C2 = new Circle("blue",3);
        list.Add(C2);
        foreach (Shapes i in list)
        {
            Console.WriteLine($"color: {i.GetColor()} Area: {i.GetArea()}");
        }

    }
}