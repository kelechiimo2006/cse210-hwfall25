public class Swimming : Exercise
{
    private double _numberOfLaps;
    public Swimming(string date, int length, int numberOfLaps) : base(date,length)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override double GetDistance()
    {
        return _numberOfLaps * 50/1000 * 0.62;
    }
    public override double GetPace()
    {
        return GetLength()/GetDistance();
    }
    public override double GetSpeed()
    {
        return GetDistance()/GetLength() * 60;
    }
}