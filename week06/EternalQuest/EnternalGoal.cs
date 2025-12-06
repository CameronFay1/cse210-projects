public class EnternalGoal : Goals
{
    public EnternalGoal(string name,string description,int points,bool isComplete) :base(name,description,points,isComplete){}
        public override string GetStringRepresentaion()
    {
        return $"EnternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
    public override void Completed(){}
}