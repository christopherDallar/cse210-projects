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
    string needShade = _needShade ? "Yes" : "No";
    return $"{base.GetDetailsString()}, Does it need shade?: {needShade}, Category: Plant.";
  }

  override public string GetStringRepresentation()
  {
    return $"plant|{base.GetStringRepresentation()}|{_needShade}";
  }

}