using System.Diagnostics;
using System.IO.Compression;

public class Activity
{
    private string _name;
    private string _descrtipion;
    protected int _duration;
    public Activity(string name,string descripion)
    {
     _name = name;
     _descrtipion = descripion;
    }
    public void DispalyStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_descrtipion}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed anoter {_duration} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds)
    {
        int i = 0;
        List<string> spinner = new List<string>{"|","/","-","\\","|","/","-","\\"};
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (startTime <= futureTime)
        {
            string S = spinner[i];
            startTime = DateTime.Now;
            Console.Write(S);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
       for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
    }
    
}