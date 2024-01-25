using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction[] fractions = {
            new Fraction(),
            new Fraction(5),
            new Fraction(3,4),
            new Fraction(1,3),
        };

        for (int i = 0; i < fractions.Length; i++)
        {
            Fraction item = fractions[i];

            Console.WriteLine($"Fraction {i+1}");
            Console.WriteLine($"top: {item.GetTop()}");
            Console.WriteLine($"bottom: {item.GetBottom()}");
            Console.WriteLine(item.GetFractionString());
            Console.WriteLine(item.GetDecimalValue());
            Console.WriteLine("");
        }

    }
}