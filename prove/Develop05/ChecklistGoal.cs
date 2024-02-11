using System;

class ChecklistGoal : Goal
{
  int _amountCompleted;
  int _target;
  int _bonus;

  public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;

  }

  public override void RecordEvent()
  {

  }

  public override bool IsComplete()
  {
    return true;
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