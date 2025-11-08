using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    static void DisplayResult(string name, int squaredNumber, int year)

    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        Console.WriteLine($"{name}, you will turn {2025 - year} this year.");
    }
    
        static void Main(string[] args)
    {
        int year;
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromptUserBirthYear(out year);
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber, year);

    }
}