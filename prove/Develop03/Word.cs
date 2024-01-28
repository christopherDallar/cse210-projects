using System;

class Word
{
  string _text;
  bool _isHidden = false;

  public Word(string text)
  {
    _text = text;
  }

  public void Hide() {
    _isHidden = true;
  }

  public void Show() {
    _isHidden = false;
  }

  public bool IsHidden() {
    return _isHidden;  
  }

  public string GetDisplayText()
  {
    if (_isHidden) {
      return string.Join("", _text.Select(text => "_").ToArray());
    }
    return _text;
  }
}