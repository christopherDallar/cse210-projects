using System;

class ChecklistGoal : Goal
{
  int _amountCompleted;
  int _target;
  int _bonus;

  public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
    _amountCompleted = amountCompleted;

  }

  public override int getPoints()
  {
    if (_amountCompleted == _target)
    {
      return base.getPoints() + _bonus;
    }

    return base.getPoints();
  }

  public override void RecordEvent()
  {
    if (_amountCompleted >= _target) return;

    _amountCompleted++;
  }

  public override bool IsComplete()
  {
    return _amountCompleted == _target;
  }

  public override string GetDetailsString()
  {
    return base.GetDetailsString() + $" -- Currently completed: {_amountCompleted}/{_target}";
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
  }
}