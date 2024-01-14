using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";

        }
        else if (gradePercentage >= 80)
        {

            letter = "B";

        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Letter Grade: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulate you passed.");
        } else {
            Console.WriteLine("Try again the next time, you can do it!");
        }
    }
}