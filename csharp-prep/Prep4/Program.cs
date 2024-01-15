using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> entryNumbers = new List<int>();
        int entryNumber;

        do
        {
            Console.Write("Enter number: ");
            entryNumber = int.Parse(Console.ReadLine());

            if (entryNumber != 0) {
                entryNumbers.Add(entryNumber);
            }

        } while (entryNumber != 0);

        int sumNumbers = entryNumbers.Sum();
        double avgNumbers = entryNumbers.Average();
        int largestNumber = entryNumbers.Max();

        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {avgNumbers}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}