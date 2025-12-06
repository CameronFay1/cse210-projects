public abstract class Goals
{
    private bool _isComplete;
    private string _shortName;
    private string _description;
    private int _points;
    public Goals(int points)
    {
        _points = points;
    }
    public Goals(string name, string description, int points,bool isComplete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    public virtual void GetDisplay()
    {
        Console.WriteLine($" {GetName()} ({GetDescription()})");
    }
    public string GetName()
    {
       return _shortName;
    }
    public string GetDescription()
    {
        return _description; 
    }
    public int GetPoints()
    {
        return _points; 
    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public virtual void Completed()
    {
        _isComplete = true;
    }
    public abstract string GetStringRepresentaion();
   
}