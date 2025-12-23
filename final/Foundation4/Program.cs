using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling = new Cycling("03 Nov 2022", 20, 5);
        Running running = new Running("05 Dec 2025", 30, 3);
        Swimming swimming = new Swimming("06 Jan 2026", 10, 4);

        List<Exercise> exercises = [cycling, running, swimming];

        foreach(Exercise excerise in exercises)
        {
            Console.WriteLine(excerise.GetSummary());
        }

    }
}