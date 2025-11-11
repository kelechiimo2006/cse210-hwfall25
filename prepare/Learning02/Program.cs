using System;

public class Program
{
    static void Main(string[] args)
    {
        Resume myresume = new Resume();
        Job job1 = new Job();
        Job job2 = new Job();
        myresume._name = "Samuel";
        job1._company = "Amazon";
        job1._endYear = 2006;
        job1._startYear = 2001;
        job1._jobTitle = "Officer";

        job2._company = "Finance";
        job2._endYear = 2003;
        job2._startYear = 2005;
        job2._jobTitle = "icer";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();

    }
}