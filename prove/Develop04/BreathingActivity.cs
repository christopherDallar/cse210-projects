using System;

class BreathingActivity : Activity
{

  public BreathingActivity(string name, string description) : base(name, description)
  {
  }

  public void Run()
  {
    DisplayStartingMessage();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    int totalBreathIn = _duration;
    int initialJumps = 10;

    while (DateTime.Now < endTime)
    {

      int breatheIn = 4;
      int breatheOut = 6;

      if (totalBreathIn <= 1) break;

      if (totalBreathIn % initialJumps > 0)
      {
        int diffTimeJumps = totalBreathIn % initialJumps;
        breatheIn += (diffTimeJumps / 2);
        breatheOut += (diffTimeJumps / 2) + 1;
      }

      Console.WriteLine();
      Console.WriteLine();

      Console.Write("Breathe in...");
      ShowCountDown(breatheIn);

      Console.WriteLine();

      Console.Write("Now breathe out...");
      ShowCountDown(breatheOut);

      totalBreathIn -= breatheIn + breatheOut;
    }

    DisplayEndingMessage();

  }
}
