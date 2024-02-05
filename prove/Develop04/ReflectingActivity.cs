using System;

class ReflectingActivity : Activity
{
  List<string> _prompts = new List<string>();
  List<string> _questions = new List<string>();

  public ReflectingActivity(string name, string description) : base(name, description)
  {
    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");

    _questions.Add("Why was this experience meaningful to you? ");
    _questions.Add("Have you ever done anything like this before? ");
    _questions.Add("How did you get started? ");
    _questions.Add("How did you feel when it was complete? ");
    _questions.Add("What made this time different than other times when you were not as successful? ");
    _questions.Add("What is your favorite thing about this experience? ");
    _questions.Add("What could you learn from this experience that applies to other situations? ");
    _questions.Add("What did you learn about yourself through this experience? ");
    _questions.Add("How can you keep this experience in mind in the future? ");
  }
  string GetRandomPrompt()
  {
    Random randomGenerator = new Random();
    int idx = randomGenerator.Next(0, _prompts.Count());

    return _prompts[idx];
  }
  string GetRandomQuestion()
  {
    Random randomGenerator = new Random();
    int idx = randomGenerator.Next(0, _questions.Count());

    return _questions[idx];
  }
  void DisplayPrompt()
  {
    string prompt = GetRandomPrompt();

    Console.WriteLine();
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine();

    Console.WriteLine($"--- {prompt} ---");
    Console.WriteLine();

  }
  void DisplayQuestions()
  {
    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);


    while (DateTime.Now < endTime)
    {
      string question = GetRandomQuestion();
      Console.WriteLine();
      Console.Write(question);
      ShowSpinner(10);
    }
  }

  public void Run()
  {
    DisplayStartingMessage();

    DisplayPrompt();

    Console.Write("When you have something in mind, press enter to continue.");
    string enter = Console.ReadLine();

    Console.WriteLine();
    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);

    DisplayQuestions();

    Console.WriteLine();
    DisplayEndingMessage();

  }
}
