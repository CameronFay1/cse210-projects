using System;

class Program
{
    static void Main(string[] args)
    {
        int one = 0;
        int two = 1;
        List<TestClass> numbers = new List<TestClass>();
        for (int i = 0; i < 3; i++)
        {
        TestClass test = new TestClass(one++,two++,"WoW");
        numbers.Add(test);
        }
        foreach (TestClass N in numbers)
        {
        Console.WriteLine($"{N._one} {N._word} {N._two}");
        Console.WriteLine($"{N}\n");

            
        }
        
        Console.WriteLine($"\n{numbers[2]}\n");
        Console.WriteLine(string.Join(" ", numbers));
        Console.WriteLine("");
        Console.WriteLine(string.Join("\n", numbers));
        Console.WriteLine("");
        // this one dose not need a Tostring method to
        Console.WriteLine(string.Join("\n", numbers.Select(x => $"{x._one}, {x._two}")));
    }
}