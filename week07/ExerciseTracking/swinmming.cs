public class Swinmming : Activity
{
    private int _laps;

    public override void GetDestance()
    {
        _distance = _laps * 50.0 / 1000.0 * 0.62;
    }
        public Swinmming(int laps, int length)
    {
        _laps = laps;
        _length = length;
        GetDestance();
        Speed();
        Pace();
        _name = "Swinmming";
    }
}