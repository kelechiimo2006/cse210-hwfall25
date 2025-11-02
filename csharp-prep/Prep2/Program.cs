using System;

class Program
{
    static void Main(string[] args)
    {
        int grade = 0;
        string letter = "";
        Console.Write("What is your grade? ");
        grade = int.Parse(Console.ReadLine());

        if (grade > 90)
        {
            letter = "A";
        }
        else if (grade > 80)
        {
            letter = "B";
        }
        else if (grade > 70)
        {
            letter = "C";
        }
        else if (grade > 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");
        Console.WriteLine("");
        if (grade < 70)
        {
            Console.WriteLine("Try Again, Ya Failed");
        }
        else
        {
            Console.WriteLine("congratS, Ya passed");
        }
    }
}