public class SimpleGoal : Goals
{
    public SimpleGoal(string name,string description,int points,bool isComplete) :base(name,description,points,isComplete){}
    public override string GetStringRepresentaion()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }

}