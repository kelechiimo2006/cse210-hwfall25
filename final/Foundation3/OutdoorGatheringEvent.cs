public class OutdoorGatheringEvent : Event
{
   private string _weatherForcast;
    public OutdoorGatheringEvent(string eventTitle, string description, string date, string time, Address address,string weatherForcast):base( eventTitle,description,date,time,address)
    {
       _weatherForcast = weatherForcast;
    }
    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Weather Forecast: {_weatherForcast}");
    }
}