using System;

class SimpleGoal : Goal
{
  bool _isComplete;

  public SimpleGoal(string name, string description, string points, bool isComplete = false) : base(name, description, points)
  {
    _isComplete = isComplete;
  }

  public override void RecordEvent()
  {
    _isComplete = true;
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
  }
}