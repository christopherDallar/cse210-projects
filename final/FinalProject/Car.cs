using System;

class Car : Product
{

  double _mileage;
  int _horsePower;
  string _color;

  public Car(
    string name,
    double cost,
    string brand,
    int barCode,
    int qtyAvailable,
    double mileage,
    int horsePower,
    string color
  ) : base(name, cost, brand, barCode, qtyAvailable)
  {
    _mileage = mileage;
    _horsePower = horsePower;
    _color = color;
  }

  override public string GetDetailsString()
  {
    return base.GetDetailsString() + ", Category: Car";
  }
  override public string GetStringRepresentation()
  {
    return "";
  }

}