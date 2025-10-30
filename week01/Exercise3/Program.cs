using System;

class Program
{
    static void Main(string[] args)
    {
        string keepGoing = "yes";
        while (keepGoing == "yes")
        {
            int response = -1;
            int guesses = 0;
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 101);
            while (response != randomNumber)
            {
                Console.Write("guess the number: ");
                response = int.Parse(Console.ReadLine());
                guesses += 1;
                if (randomNumber > response)
                {
                    Console.WriteLine("Higher");
                }
                else if (randomNumber < response)
                {
                    Console.WriteLine("Lower");
                }
            }
            Console.WriteLine($"You guessed it! took you {guesses} guesses");
            Console.Write("do you whant to continue: ");
            keepGoing = Console.ReadLine();
        }
    }
}