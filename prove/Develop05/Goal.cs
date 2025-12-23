abstract class Goal
{
    private string _name;
    private string _description;
    private int _totalPoints;
    private int _pointsToBeAwarded;

    public Goal(string name, string description, int pointsToBeAwarded)
    {
        _name = name;
        _description = description;
        _totalPoints = pointsToBeAwarded;
    }
    
}