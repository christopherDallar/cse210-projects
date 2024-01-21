using System.IO; 

class PromptGenerator
{
  List<string> _prompts = new List<string>();

  // Exceed requirement i separate the prompts loading from file
  void LoadPrompts()
  {
    string filename = "prompts.txt";

    using (StreamReader reader = new StreamReader(filename))
    {
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        _prompts.Add(line);
      }
    }
    
  }

  public string GetRandomPrompt()
  {
    LoadPrompts();

    Random r = new Random();
    string randomPrompt = _prompts.OrderBy(s => r.Next()).First();

    return randomPrompt;
  }


}