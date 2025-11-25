public class Assignmets
{
    private string _studnetName;
    private string _topic;
    public Assignmets(string studnetName, string topic)
    {
        _studnetName = studnetName;
        _topic = topic;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_studnetName} - {_topic}");
    }
}