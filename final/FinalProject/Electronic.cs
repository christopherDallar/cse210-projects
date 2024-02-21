using System;

class Electronic : Product
{
  string _warrantyPeriod;

  public Electronic(
    string name,
    double cost,
    string brand,
    int barCode,
    int qtyAvailable,
    string warrantyPeriod
  ) : base(name, cost, brand, barCode, qtyAvailable)
  {
    _warrantyPeriod = warrantyPeriod;
  }

  override public string GetDetailsString()
  {
    return $"{base.GetDetailsString()}, Warranty for: {_warrantyPeriod}, Category: Electronic.";
  }

  override public string GetStringRepresentation()
  {
    return $"electronic|{base.GetStringRepresentation()}|{_warrantyPeriod}";
  }

}