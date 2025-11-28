using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Peter", "Love");
        MathAssignment mathAssignment = new MathAssignment("Samuel", "Fractions", "4.2", "7-9");
        WritingAssignment writingAssignment = new WritingAssignment("Paul", "Letters", "How to Write Comfortably");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");
        
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine("");

        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine("");
    }
}