public class MathAssigments : Assignmets
{
    private string _textBookSection;
    private string _probles;
    public MathAssigments(string studnetName, string topic, string textBookSection, string probles) : base(studnetName,topic)
    {
        _textBookSection = textBookSection;
        _probles = probles;
    }
    public void GetHoeWorkList()
    {
        Console.WriteLine($"Section: {_textBookSection} Problems: {_probles}");
    }
}