using System;

class Scripture
{
  Reference _reference;
  List<Word> _words = new List<Word>();


  public Scripture(
    Reference reference,
    string text
  )
  {
    _reference = reference;
    SetWords(text);
  }

  void SetWords(string text)
  {
    string[] textList = text.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

    foreach (var wordText in textList)
    {
      _words.Add(new Word(wordText));
    }

  }

  string GetWordsText() {

    string[] listTexts = _words.Select(word => word.GetDisplayText()).ToArray();

    return string.Join(" ", listTexts);
  }

  public void HideRandomWords(int numberToHide)
  {
    Random randomGenerator = new Random();
    List<Word> words = _words;

    numberToHide = numberToHide > words.Count() ? words.Count() : numberToHide;
  
    for (int i = 0; i < numberToHide; i++)
    {
      int inx = randomGenerator.Next(0, words.Count());
      if (words[inx].IsHidden() && !IsCompletelyHidden()) // Exceed requirement, just hide word available to hide.
      {
        i=i-1;
        continue;
      }

      words[inx].Hide();
    }
  }

  public string GetDisplayText()
  {
    string reference = _reference.GetDisplayText();
    string text = GetWordsText();
    return $"{reference} {text}";
  }

  public bool IsCompletelyHidden()
  {
    return _words.Where(w => w.IsHidden() == false).ToArray().Length == 0;
  }
}