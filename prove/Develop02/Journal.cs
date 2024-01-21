using System.IO;

class Journal
{
  List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {


    foreach (var entry in _entries)
    {
      Console.WriteLine("");
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("");
      entry.Display();
    }

  }

  public void SaveToFile(string file)
  {
    using (StreamWriter outputFile = new StreamWriter(file))
    {
      // You can add text to the file with the WriteLine method
      foreach (var entry in _entries)
      {
        outputFile.WriteLine($"{entry._promptText}|{entry._entryText}|{entry._date}");
      }

    }
  }

  public void LoadFromFile(string file)
  {
    _entries = new List<Entry>();

    using (StreamReader reader = new StreamReader(file))
    {
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        string[] linesData = line.Split("|");
        string promptText = linesData[0];
        string entryText = linesData[1];
        string date = linesData[2];

        Entry entry = new Entry();

        entry._promptText = linesData[0];
        entry._entryText = linesData[1];
        entry._date = linesData[2];

        _entries.Add(entry);
      }
    }
  }
}