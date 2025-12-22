public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration): base(activityName, description, duration)
    {
     
    }
    public void RunActivity()
    {
        DisplayGetReady();
        DipslaySpinner();
        Console.WriteLine("");
        
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime;
       
        do{
            Console.Write($"Breathe in...");
            DisplayCountdown(); 
            Console.WriteLine();           
            Console.Write($"Breathe out...");
            DisplayCountdown();
            Console.WriteLine("");
            Console.WriteLine("");
            currentTime = DateTime.Now;

        }while (currentTime < futureTime);
        Console.WriteLine("");
    }
}