using System;

class Plant : Product
{
  bool _needShade = true;

  public Plant(
    string name,
    double cost,
    string brand,
    int barCode,
    int qtyAvailable,
    bool needShade
  ) : base(name, cost, brand, barCode, qtyAvailable)
  {
    _needShade = needShade;
  }

  override public string GetDetailsString()
  {
    return base.GetDetailsString() + ", Category: Plant";
  }

  override public string GetStringRepresentation()
  {
    return "";
  }

}