using System;

class BreathingActivity : Activity
{

  public BreathingActivity(string name, string description) : base(name, description)
  {
  }

  public void Run()
  {
    DisplayStartingMessage();



    DisplayEndingMessage();

  }
}
