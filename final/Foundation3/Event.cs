using System.Runtime.InteropServices;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)   
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"Event Type: {GetType().Name}, Title: {_eventTitle}, Date: {_date}");
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Title: {_eventTitle} | Description: {_description} | Date: {_date} | Time: {_time}");
        Console.WriteLine(_address.DisplayAddress());
    }
}