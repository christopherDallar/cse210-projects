using System;

class Fabrics : Product
{

  double _width;
  double _height;
  string _material;


  public Fabrics(
    string name,
    double cost,
    string brand,
    int barCode,
    int qtyAvailable,
    double width,
    double height,
    string material
  ) : base(name, cost, brand, barCode, qtyAvailable)
  {
    _width = width;
    _height = height;
    _material = material;
  }

  override public string GetDetailsString()
  {
    return $"{base.GetDetailsString()}, Width: {_width}, Height: {_height}, Material: {_material}, Category: Fabrics.";
  }

  override public string GetStringRepresentation()
  {
    return "";
  }

}