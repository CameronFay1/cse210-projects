public class Running : Activity
{
    public Running(double distance,int length)
    {
        _distance = distance;
        _length = length;
        Speed();
        Pace();
        _name = "Running";
    }

}