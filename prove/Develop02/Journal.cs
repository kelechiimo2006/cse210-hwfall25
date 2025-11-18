using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    List <Entry> entries = new List<Entry>();
    public void AddEntry()
    {
        Entry entry = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._time = theCurrentTime.ToLongTimeString();
        entry._prompt = prompt.GetRandomPrompt();
        Console.WriteLine(entry._prompt);
        Console.Write("Enter your response: ");
        entry._response = Console.ReadLine();
        entries.Add(entry);
    }
    public void DisplayEntries()
    {
       foreach (Entry entry in entries)
        {
           entry.Display();
        }

    }
    public void SaveEntry()
    {
        Console.Write("Please enter a filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._time}, {entry._prompt}, {entry._response}");
            }
        }
    }
    public void LoadEntry()
    {
        Console.Write("What is the name of the file?: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        List <Entry> _loadedentries = new List<Entry>();
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            

            string[] parts = line.Split(", ");

            entry._date = parts[0];
            entry._time = parts[1];
            entry._prompt = parts[2];
            entry._response = parts[3];
            _loadedentries.Add(entry);
        }
        entries = _loadedentries;

    }
}