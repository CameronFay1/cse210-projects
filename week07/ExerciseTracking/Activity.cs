public abstract class Activity
{
    DateTime timeNow = DateTime.Now;
    protected int _length;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _name;

    public virtual void GetDestance(){}
    public virtual void Speed()
    {
        _speed = (_distance / _length) * 60;
    }
    public virtual void Pace()
    {
        _pace = 60 / _speed;
    }
    public virtual void GetSummary()
    {
        Console.WriteLine($"{timeNow} {_name} ({_length} min)-Distance {_distance} miles, Speed {_speed} mph, Pace:{_pace} min per mile\n");
    }
}