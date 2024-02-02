using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Christopher", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Maria", "Multiplication", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        WritingAssignment writingAssignment = new WritingAssignment("Jose", "Multiplication", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}