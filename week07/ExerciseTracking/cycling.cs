public class Cycling : Activity
{
    public Cycling(double speed,double distance, int length)
    {
        _distance = distance;
        _length = length;
        _speed = speed;
        Pace();
        _name = "Cycling";
    }
}