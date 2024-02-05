using System;

class ListingActivity : Activity
{
  int _count;

  List<string> _prompts = new List<string>();

  public ListingActivity(string name, string description) : base(name, description)
  {

    _prompts.Add("Who are people that you appreciate?");
    _prompts.Add("What are personal strengths of yours?");
    _prompts.Add("Who are people that you have helped this week?");
    _prompts.Add("When have you felt the Holy Ghost this month?");
    _prompts.Add("Who are some of your personal heroes?");

  }

  void GetRandomPrompt()
  {

    Random randomGenerator = new Random();
    int idx = randomGenerator.Next(0, _prompts.Count());
    string prompt = _prompts[idx];

    Console.WriteLine($"--- {prompt} ---");

  }
  List<string> GetListFromUser()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    List<string> answers = new List<string>();

    while (DateTime.Now < endTime)
    {
      Console.Write(">");
      string answer = Console.ReadLine();

      answers.Add(answer);

    }

    return answers;
  }

  public void Run()
  {
    DisplayStartingMessage();


    Console.WriteLine();
    Console.WriteLine("List as many responses you can to the following prompt:");

    GetRandomPrompt();

    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.WriteLine();

    List<string> answers = GetListFromUser();
    _count = answers.Count();

    Console.WriteLine($"You listed {_count} items!");
    Console.WriteLine();

    DisplayEndingMessage();

  }
}
