public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
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
        Console.WriteLine("Get Ready");
    }
    public void DipslaySpinner()
    {
        string[] characters = {"—", """\""", """|""", "/", "—", """\""","""|""", "/", "—", """\""","""|""", "/", "—", """\"""};
        for(int i = 0; i < 14; i++ )
        {
            Console.Write(characters[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void DisplayCountdown()
    {
        for(int i = 5; i > 0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        DipslaySpinner();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        DipslaySpinner();
        Console.Clear();
    }
}