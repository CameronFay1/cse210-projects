public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"};
    public ReflectingActivity(string name,string descripion) : base(name,descripion)
    { 
        Run();
    }
    public void Run()
    {
        DispalyStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience. ");
        Console.Write("you may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (startTime <= futureTime)
        {
            startTime = DateTime.Now;
            GetRandomQuestion();
        }
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random R = new Random();
        int index = R.Next(_prompts.Count);
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.Write("When you have someting in mind, press enter to contunue. ");
        Console.ReadLine();
    }
    public void GetRandomQuestion()
    {
        Random R = new Random();
        int index = R.Next(_questions.Count);
        Console.Write($"> {_questions[index]}");
        ShowSpinner(10);
        Console.WriteLine("");
    }

}