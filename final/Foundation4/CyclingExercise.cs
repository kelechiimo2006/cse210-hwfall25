public class Cycling : Exercise
{
    private int _speed;
    public Cycling(string date, int length, int speed) : base(date,length)
    {
       _speed = speed;
    }
    public override double GetPace()
    {
        return 60/_speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return _speed * GetLength()/60;
    }
}