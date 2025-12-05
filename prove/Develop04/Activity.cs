public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine("");
        
        Console.WriteLine(_description);
        Console.WriteLine("");
        
        Console.Write("How long, in seconds, would you like for session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
    }
    public void DisplayGetReady()
    {
        Console.Write("Get Ready");
    }
    public void DipslaySpinner()
    {
        string[] characters = {"—", """\""", """/""", "|", "—"};
        for(int i = 0; i < 5; i++ )
        {
            Console.Write(characters[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}