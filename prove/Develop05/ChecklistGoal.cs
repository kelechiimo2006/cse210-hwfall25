class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _numberOfTimesCompleted;
    public ChecklistGoal(string name, string description, int pointsToBeAwarded, int bonusPoints, int numberOfTimesCompleted) : base (name, description, pointsToBeAwarded)
    {
        
    }
    
}