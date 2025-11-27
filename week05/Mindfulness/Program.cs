using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        while (input != "4")
        {
       Console.WriteLine("Menu Options:\n   1. Start breathing activity\n   2. Start reflection activity\n   3. Start listing activity\n   4. Quit"); 
       Console.Write("Select a choice from the menu: ");
       input = Console.ReadLine();
       if (input == "1")
        {
            Breathingactivity B = new Breathingactivity("breathing activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }
       else if (input == "2")
        {
            ReflectingActivity R = new ReflectingActivity("reflection activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }
       else if (input == "3")
        {
            ListingActivity L = new ListingActivity("listing activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }
        else if (input == "4")
        {
            Console.WriteLine("\nGoodbye.\n");
            break;
        }
        else
        {
            Console.WriteLine("\nThat is not a valid input\n");
            Thread.Sleep(1000);
        }

        }
    }
}