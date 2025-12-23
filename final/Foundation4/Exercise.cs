public abstract class Exercise
{
    private string _date;
    private double _length;

    public Exercise(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public double GetLength()
    {
        return _length;
    }
    public string GetSummary()
    {
        string summary = $"{_date} {GetType().Name} ({_length} min)- Distance {GetDistance():F2} miles,  Speed {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
        return summary;
    }
}