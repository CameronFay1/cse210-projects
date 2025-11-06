using System;

class Program
{
    static void Main(string[] args)
    {
        
        int input = 0;
        Journal journal = new Journal();
        while (input != 5)
        {
            RandomPrompt RandomPrompt = new RandomPrompt();
            Entry entry = new Entry();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load\n4. Save\n5. Quit ");
            Console.Write("What would you like to do? ");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                string Prompt = RandomPrompt.GetRandomPrompt();
                entry._promptText = Prompt;
                Console.WriteLine(Prompt);
                string promptAnuswer = Console.ReadLine();
                entry._entryText = promptAnuswer;
                
                journal.AddEntry(entry);
            }
            else if (input == 2)
            {
                journal.DisplayAll();
            }
            else if (input == 3)
            {
                Console.Write("Enter the file name: ");
                string loadfileInput = Console.ReadLine();
                journal.LoadFile(loadfileInput);
                journal.DisplayAll();
            }
            else if (input == 4)
            {
                Console.Write("Enter the file name: ");
                string savefileInput = Console.ReadLine();
                journal.SaveToFile(savefileInput);
            }
        }

    }
}