using System.IO.Compression;

public class Breathingactivity : Activity
{
    public Breathingactivity(string name,string descripion) : base(name,descripion)
    { 
        Run();
    }
    public void Run()
    {
        DispalyStartingMessage();
        Console.Write("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("\n");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (startTime <= futureTime)
        {
        startTime = DateTime.Now;
        Console.Write("Breathe in...");
        ShowCountDown(4);
        Console.WriteLine("");
        Console.Write("Breathe out...");
        ShowCountDown(4);
        Console.WriteLine("\n");
        }
        DisplayEndingMessage();
        ShowSpinner(7);
    }
}
