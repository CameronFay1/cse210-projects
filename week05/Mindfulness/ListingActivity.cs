using System.Dynamic;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"};
        public ListingActivity(string name,string descripion) : base(name,descripion)
    { 
      Run();  
    }
    public void Run()
    {
        DispalyStartingMessage();
        Console.WriteLine("List as many responses you can to teh following prompt: ");
        GetRandomPromt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(7);
        DateTime startdate = DateTime.Now;
        DateTime enddate = startdate.AddSeconds(_duration);
        while (startdate <= enddate)
        {
            startdate = DateTime.Now;
            GetListFromUser();
        }
        Console.WriteLine($"You listed {_count} items");
        DisplayEndingMessage();

    }
    public void GetRandomPromt()
    {
        Random R = new Random();
        int index = R.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }
    public void GetListFromUser()
    {
        Console.Write("> ");
        Console.ReadLine();
        _count += 1;
    }
}