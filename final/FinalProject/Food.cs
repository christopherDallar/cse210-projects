using System;

class Food : Product
{

  DateTime _expirationDate;

  public Food(
    string name,
    double cost,
    string brand,
    int barCode,
    int qtyAvailable,
    DateTime expirationDate
  ) : base(name, cost, brand, barCode, qtyAvailable)
  {
    _expirationDate = expirationDate;
  }

  override public string GetDetailsString()
  {
    return base.GetDetailsString() + ", Category: Food";
  }

  override public string GetStringRepresentation()
  {
    return "";
  }

}