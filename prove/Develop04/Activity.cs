using System;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = seconds;

        while (DateTime.Now < endTime)
        {
            int stepsToErase = (int)Math.Floor(Math.Log10(i) + 1);
            string eraseChar = string.Concat(Enumerable.Repeat("\b \b", stepsToErase)); // Exceed requirement, i take into account that whatever second can be given by argument and i'm repeat the eraser string as much will be necessary to erase each digits

            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write(eraseChar);

            i--;
        }

    }

    protected void ShowSpinner(int seconds)
    {
        string[] animationStrings = {
            "|",
            "/",
            "-",
            "\\",
        };

        int idxAnimationString = 0;

        for (int i = 0; i < seconds; i++)
        {
            string s = animationStrings[idxAnimationString];

            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            idxAnimationString = idxAnimationString == animationStrings.Length - 1 ? 0 : idxAnimationString + 1;

        }

    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(10);
    }
}