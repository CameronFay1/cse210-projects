public class WritingAssignments : Assignmets
{
    private string _title;
    public WritingAssignments(string studnetName, string topic,string title) : base(studnetName, topic)
    {
        _title = title;
    }
    public void GetWritingINformation()
    {
        Console.WriteLine(_title);
    }
}