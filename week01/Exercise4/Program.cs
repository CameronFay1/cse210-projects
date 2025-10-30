using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];
        int input = -1;
        int sum = 0;
        int largestNumber = 0;
        int smallNumber = 999999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (input != 0)
        {
            Console.Write("enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
                sum = input + sum;
            }
        }
        Console.WriteLine($"The sun is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            if (number < smallNumber && number > 0)
            {
                smallNumber = number;
            }
        }
        Console.WriteLine($"the largest number is: {largestNumber}");
        Console.WriteLine($"the smallest positive nuvmer is {smallNumber}");
        numbers.Sort();
        Console.Write($"The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}