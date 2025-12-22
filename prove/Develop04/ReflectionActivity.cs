public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int number = random.Next(_questions.Count);
        string question = _questions[number];
        _questions.Remove(_questions[number]);
        return question;
    }
    
    public void RunActivity()
    {
        DisplayGetReady();
        DipslaySpinner();
        Console.WriteLine("");

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.WriteLine("");

        string action = Console.ReadLine();
        if(action == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        }
        Console.WriteLine("You may begin in: ");
        DisplayCountdown();
        Console.Clear();
        
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime;
       
        do{
            Console.Write($"> {GetRandomQuestion()} ");
            DipslaySpinner(); 
            Console.WriteLine();           
            currentTime = DateTime.Now;

        }while (currentTime < futureTime);
        Console.WriteLine("");
    }
}