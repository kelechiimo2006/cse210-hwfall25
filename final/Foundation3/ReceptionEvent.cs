public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string eventTitle, string description, string date, string time, Address address, string rsvpEmail) : base(eventTitle,description,date,time,address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"RSVP Email: {_rsvpEmail}");
    }
}