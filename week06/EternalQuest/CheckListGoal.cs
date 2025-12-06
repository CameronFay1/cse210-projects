public class CheckListGoal : Goals
{
    private int _anmountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name,string description,int points,bool isComplete,int target,int bonus,int anmountCompleted = 0) :base(name,description,points,isComplete)
    {
        _target = target;
        _bonus = bonus;
        _anmountCompleted = anmountCompleted;
    }
        public override void GetDisplay()
    {
        Console.WriteLine($" {GetName()} ({GetDescription()}) -- Currently completed: {_anmountCompleted}/{_target}");
    }
        public override string GetStringRepresentaion()
    {
        return $"CheckListGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}|{_bonus}|{_target}|{_anmountCompleted}";
    }
    public override void Completed()
    {
        _anmountCompleted += 1;
        if (_anmountCompleted == _target)
        {
            base.Completed();
        }
    }
    
}