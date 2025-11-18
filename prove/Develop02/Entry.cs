
public class Entry

{
    public string _prompt;
    public string _date;
    public string _time;
    public string _response;

    public void  Display()
    {
        Console.WriteLine($"Date: {_date}, Time: {_time} - Prompt: {_prompt} \n{_response}");
        Console.WriteLine("");
    }
}