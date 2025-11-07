using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

public class RandomPrompt
{
    public List<string> _prompt = new List<string>
    {"What was one win today?", "Whats one thing I learned today?",
    "What are three things Im grateful for right now?", "How can I be 1% better tomorrow?",
    "What can I forgive myself for?",
    "Whats something that always makes me smile?",
    "Whats one small moment I want to remember forever?"} ;
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompt.Count);
        string RandomPrompt = _prompt[index];
        return RandomPrompt;
    }

}