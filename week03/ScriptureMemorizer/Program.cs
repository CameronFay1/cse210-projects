using System;
using System.Buffers;
using System.Security.Cryptography.X509Certificates;
// i added the option to add your own verse/veres.
class Program
{
    static void Main(string[] args)
    {
        Reference R;
        Scripture S;
        Console.Write("do you what to enter your own scripture yes/no: ");
        string ownScripture = Console.ReadLine().ToLower();
        if (ownScripture == "yes")
        {
            Console.Write("enter book name: ");
            string book = Console.ReadLine();
            Console.Write("chapter: ");
            int chapter = int.Parse(Console.ReadLine());
            Console.Write("star verse: ");
            int startverse = int.Parse(Console.ReadLine());
            Console.Write("end verse if none enter (0): ");
            int endverse = int.Parse(Console.ReadLine());
            Console.Write("enter the verses: ");
            string verses = Console.ReadLine();
            R = new Reference(book, chapter, startverse, endverse);
            S = new Scripture(verses);
        }
        else
        {
            R = new Reference("mosiah", 2, 12, 14);
            S = new Scripture("Neither have I suffered that ye should be confined in dungeons, nor that ye should make slaves one of another, nor that ye should murder, or plunder, or steal, or commit adultery; nor even have I suffered that ye should commit any manner of wickedness, and have taught you that ye should keep the commandments of the Lord, in all things which he hath commanded you And even I, myself, have labored with mine own hands that I might serve you, and that ye should not be laden with taxes, and that there should nothing come upon you which was grievous to be borne and of all these things which I have spoken, ye yourselves are witnesses this day.");
        }
        string input = "";
        while (input != "quit")
        {
            Console.Clear();
            string text = R.GetDisplayText();
            Console.Write(text);
            S.GetDisplayText();
            if (S.GetFullClearAmount() == true)
            {
                break;
            }
            Console.Write("Press enter to continue or type quit to finish: ");
            input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                break;
            }
            S.HideRandomWords();
        }
    }
}