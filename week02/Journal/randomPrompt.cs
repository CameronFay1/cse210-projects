using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

public class RandomPrompt
{
    public List<string> _prompt = new List<string>{"one", "two", "three"};
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompt.Count);
        string RandomPrompt = _prompt[index];
        return RandomPrompt;
    }

}