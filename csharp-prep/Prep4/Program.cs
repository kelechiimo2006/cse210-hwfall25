using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        do
        {
            Console.Write("What is your number? ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);
        //foreach (int number in numbers)
        {
            //Console.Write($"{number},");
        }
        Console.WriteLine($"The sum is {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
    }
}