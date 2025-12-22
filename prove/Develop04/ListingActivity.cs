public class ListingActivity : Activity
{
    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
    
    }
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _responses = new List<string>();
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }
    public void RunActivity()
    {
        DisplayGetReady();
        DipslaySpinner();
        Console.WriteLine("");

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        
        Console.WriteLine("You may begin in: ");
        DisplayCountdown();
        Console.Clear();
        
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime;

        do{
            Console.Write($">  ");
            string response = Console.ReadLine();
            _responses.Add(response);           
            currentTime = DateTime.Now;

        }while (currentTime < futureTime);
        Console.WriteLine($"You listed {_responses.Count} items!");
        Console.WriteLine("");
    }
}
