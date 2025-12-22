public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;
    public LectureEvent(string eventTitle, string description, string date, string time, Address address, string speakerName, int capacity) : base(eventTitle,description,date,time,address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Speaker name: {_speakerName} | Capacity : {_capacity}");
    }
}