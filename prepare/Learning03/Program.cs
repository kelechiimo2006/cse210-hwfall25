using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.SetTop(1);
        fraction1.SetBottom(2);
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());

        Fraction fraction2 = new Fraction();
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());

        Fraction fraction3 = new Fraction(5);
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());

        Fraction fraction4 = new Fraction(1,8);
        Console.WriteLine(fraction4.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
    }
}