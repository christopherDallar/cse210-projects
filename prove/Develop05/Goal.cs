using System;

abstract class Goal
{
  protected string _shortName;
  protected string _description;
  protected string _points;

  public Goal(string name, string description, string points)
  {
    _shortName = name;
    _description = description;
    _points = points;
  }

  public virtual void RecordEvent()
  {

  }

  public virtual bool IsComplete()
  {
    return true;
  }

  public virtual string GetDetailsString()
  {
    return $"[ ] {_shortName} ({_description})";
  }

  public virtual string GetStringRepresentation()
  {
    return "";
  }
}