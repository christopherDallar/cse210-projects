using System;

class Clothing : Product
{

  string _size;
  string _color;

  public Clothing(
    string name,
    double cost,
    string brand,
    int barCode,
    int qtyAvailable,
    string size,
    string color
  ) : base(name, cost, brand, barCode, qtyAvailable)
  {
    _size = size;
    _color = color;
  }

  override public string GetDetailsString()
  {
    return $"{base.GetDetailsString()}, Size: {_size}, Color: {_color}, Category: Clothing.";
  }


  override public string GetStringRepresentation()
  {
    return $"clothing|{base.GetStringRepresentation()}|{_size}|{_color}";
  }

}